using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtOutput.ReadOnly = true;
        }
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        //обробник натискання кнопки підключення
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 8888);
                stream = client.GetStream();

                string name = txtName.Text;
                byte[] data = Encoding.Unicode.GetBytes(name);
                stream.Write(data, 0, data.Length);

                receiveThread = new Thread(ReceiveMessage);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                AppendLog($"Підключено як {name}");
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                AppendLog("Помилка підключення: " + ex.Message);
            }
        }
        //обробник натискання кнопки відправлення повідомлення
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string message = txtMessage.Text;
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                AppendLog("Помилка надсилання: " + ex.Message);
            }
        }
        //потік для отримання повідомлень від сервера
        private void ReceiveMessage()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    AppendLog(builder.ToString());
                }
            }
            catch
            {
                AppendLog("З'єднання розірвано.");
                Disconnect();
            }
        }
        //метод для додавання повідомлення в поле txtOutput
        private void AppendLog(string message)
        {
            if (txtOutput.InvokeRequired)
            {
                txtOutput.Invoke(new Action<string>(AppendLog), message);
            }
            else
            {
                txtOutput.AppendText(message + Environment.NewLine);
            }
        }
        //метод для закриття з'єднання
        private void Disconnect()
        {
            stream?.Close();
            client?.Close();
        }
    }
}
