using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson_02_09_21_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8005;
            string address = "127.0.0.1";

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(address), port);

            using Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                socket.Connect(endPoint);
                Console.WriteLine("Input your text to send: ");
                string message = Console.ReadLine();
                byte[] data = Encoding.UTF8.GetBytes(message);
                socket.Send(data);

                StringBuilder builder = new StringBuilder();
                int bytes = 0;
                byte[] dataBuffer = new byte[256];

                do
                {
                    bytes = socket.Receive(dataBuffer);
                    builder.Append(Encoding.UTF8.GetString(dataBuffer, 0, bytes));

                } while (socket.Available > 0);

                Console.WriteLine($"Server response: {builder.ToString()}");

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
