using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class ChatServer : Form
    {
        public ChatServer()
        {
            InitializeComponent();
            txtOutput.ReadOnly = true; //поле вводутільки для читання 
        }

        static ServerObject server; // сервер
        static Thread listenThread; // потік для прослуховування

        //обробник для кнопки запуску серверу
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                server = new ServerObject(AppendLog); //передаємо метод логування
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.IsBackground = true; //не блокує вихід із програми
                listenThread.Start();
                AppendLog("Сервер стартував.");
                btnStart.Enabled = false;
            }
            catch (Exception ex)
            {
                //виняток, якщо виникла якась помилка
                server?.Disconnect();
                AppendLog("Помилка: " + ex.Message);
            }
        }

        //метод для логування повідомлень
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
    }
}
