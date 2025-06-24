using System;
using System.Net.Sockets;
using System.Text;

namespace ChatServer
{
    public class ClientObject
    {
        //властивості, ID клієнта та його потік
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }

        private string userName; //ім'я 
        private TcpClient client; //TcpClient для з'єднання
        private ServerObject server; //сервер
        private Action<string> logAction; //метод для ведення журналу повідомлень

        public ClientObject(TcpClient tcpClient, ServerObject serverObject, Action<string> logMethod)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            logAction = logMethod;

            serverObject.AddConnection(this);
        }

        //метод для обробки повідомлень клієнта
        public void Process()
        {
            try
            {
                Stream = client.GetStream();

                // отримуємо ім’я користувача
                string message = GetMessage();
                userName = message;

                message = $"{userName} увійшов до чату";
                logAction(message);

                server.BroadcastMessage(message, this.Id);

                // нескінченний цикл прийому повідомлень
                while (true)
                {
                    try
                    {
                        message = GetMessage();
                        message = $"{userName}: {message}";
                        logAction(message);
                        server.BroadcastMessage(message, this.Id);
                    }
                    catch
                    {
                        message = $"{userName} покинув чат";
                        logAction(message);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                logAction("Помилка: " + e.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
        }
        //метод для отримання повідомлення від клієнта
        private string GetMessage()
        {
            byte[] data = new byte[64];
            StringBuilder builder = new StringBuilder();
            int bytes = 0;

            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

            return builder.ToString();
        }

        //метод для закриття з'єднання з клієнтом
        protected internal void Close()
        {
            Stream?.Close();
            client?.Close();
        }
    }
}
