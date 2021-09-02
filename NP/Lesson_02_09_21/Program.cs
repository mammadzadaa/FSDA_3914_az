using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson_02_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8005;

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),port);

            using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);

            try
            {
                socket.Bind(endPoint);
                socket.Listen(10);

                Console.WriteLine("Server is up, waiting for connections");

                while (true)
                {
                    Socket handler = socket.Accept();

                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] dataBuffer = new byte[256];

                    do
                    {
                        bytes = handler.Receive(dataBuffer);
                        builder.Append(Encoding.UTF8.GetString(dataBuffer, 0,bytes));

                    } while (handler.Available > 0);

                    Console.WriteLine(DateTime.Now.ToShortTimeString() + " : " + builder.ToString());

                    string message = "Your message was delivered!";
                    dataBuffer = Encoding.UTF8.GetBytes(message);

                    handler.Send(dataBuffer);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
