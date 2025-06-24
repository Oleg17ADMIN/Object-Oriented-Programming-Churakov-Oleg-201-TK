using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer
{
    public class ServerObject
    {
        static TcpListener tcpListener;
        List<ClientObject> clients = new List<ClientObject>();//список клієнтів
        private Action<string> logAction; //метод для логування подій

        public ServerObject(Action<string> logMethod)
        {
            logAction = logMethod;
        }

        //метод для додавання нового підключення (клієнта) до сервера
        protected internal void AddConnection(ClientObject clientObject)
        {
            clients.Add(clientObject);
        }
        //метод для видалення підключення за його унікальним ID
        protected internal void RemoveConnection(string id)
        {
            ClientObject client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
                clients.Remove(client);
        }
        //метод для прослуховування нових підключень
        protected internal void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                logAction("Сервер запущено. Очікування підключень...");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    ClientObject clientObject = new ClientObject(tcpClient, this, logAction);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                logAction($"Помилка: {ex.Message}");
                Disconnect();
            }
        }
        //метод для трансляції повідомлення всім підключеним клієнтам, окрім відправника
        protected internal void BroadcastMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            foreach (var client in clients)
            {
                if (client.Id != id)
                    client.Stream.Write(data, 0, data.Length);
            }
        }
        //метод для завершення роботи сервера та закриття всіх підключень
        protected internal void Disconnect()
        {
            tcpListener?.Stop();
            foreach (var client in clients)
            {
                client.Close();
            }
        }
    }

}
