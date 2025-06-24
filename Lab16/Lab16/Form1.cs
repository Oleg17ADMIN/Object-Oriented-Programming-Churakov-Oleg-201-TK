using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.IO;

namespace Lab16
{
    public partial class Form1 : Form
    {
        bool alive = false; // чи буде працювати потік для приймання
        UdpClient client;
        private int localPort = 8001; // порт для приймання повідомлень
        private int remotePort = 8001; // порт для передавання повідомлень
        const int TTL = 20;
        private string host = "235.5.5.1"; // хост для групового розсилання
        IPAddress groupAddress; // адреса для групового розсилання
        string userName; // ім’я користувача в чаті

        private string logFilePath = "\"C:\\Users\\WORLD\\Downloads\\chatlog.txt\\"; //шляш до файлу збереження логів
        public Form1()
        {
            InitializeComponent();
            loginButton.Enabled = true; // кнопка входу
            logoutButton.Enabled = false; // кнопка виходу
            sendButton.Enabled = false; // кнопка отправки
            chatTextBox.ReadOnly = true; // поле для повідомлень
            groupAddress = IPAddress.Parse(host);
        }
        // обробник натискання кнопок loginButton
        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = userNameTextBox.Text;
            userNameTextBox.ReadOnly = true;
            try
            {
                client = new UdpClient(localPort);
                //підєднання до групового розсилання
                client.JoinMulticastGroup(groupAddress, TTL);

                // задача на приймання повідомлень
                Task receiveTask = new Task(ReceiveMessages);
                receiveTask.Start();
                // перше повідомлення про вхід нового користувача
                string message = userName + " зайшов в чат";
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, host, remotePort);
                loginButton.Enabled = false;
                logoutButton.Enabled = true;
                sendButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // метод приймання повідомлення
        private void ReceiveMessages()
        {
            alive = true;
            try
            {
                while (alive)
                {
                    IPEndPoint remoteIp = null;
                    byte[] data = client.Receive(ref remoteIp);
                    string message = Encoding.Unicode.GetString(data);
                    string time = DateTime.Now.ToShortTimeString();
                    string fullMessage = $"{time} {message}";
                    // добавляем полученное сообщение в текстовое поле
                    this.Invoke(new MethodInvoker(() =>
                    {
                        chatTextBox.Text = time + " " + message + "\r\n"
                        + chatTextBox.Text;
                    }));
                    File.AppendAllText(logFilePath, fullMessage + Environment.NewLine);
                }
            }
            catch (ObjectDisposedException)
            {
                if (!alive)
                    return;
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // обробник натискання кнопки sendButton
        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string message = String.Format("{0}: {1}", userName,
               messageTextBox.Text);
                byte[] data = Encoding.Unicode.GetBytes(message);
                client.Send(data, data.Length, host, remotePort);
                messageTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // обробник натискання кнопки logoutButton
        private void logoutButton_Click(object sender, EventArgs e)
        {
            ExitChat();
        }
        // вихід з чату
        private void ExitChat()
        {
            string message = userName + " виходить з чату";
            byte[] data = Encoding.Unicode.GetBytes(message);
            client.Send(data, data.Length, host, remotePort);
            client.DropMulticastGroup(groupAddress);
            alive = false;
            client.Close();
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
            sendButton.Enabled = false;
        }

        // обробник закриття форми
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (alive)
                ExitChat();
        }
        
        // обробник кнопки Налаштування
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(host, localPort, chatTextBox.Font);
            if (settings.ShowDialog() == DialogResult.OK)
            {
                host = settings.MulticastAddress;
                localPort = settings.Port;
                remotePort = settings.Port;
                groupAddress = IPAddress.Parse(host);
                chatTextBox.Font = settings.ChatFont;
            }
        }
    }
}
