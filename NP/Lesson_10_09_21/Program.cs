using Lesson_10_09_21_lib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson_10_09_21
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpMessanger udpMessanger = new UdpMessanger
            {
                localPort = 8888,
                remoteAddress = "127.0.0.1",
                remotePort = 8888
            };

            udpMessanger.SendMessage("Hello there!");

            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback,8888);
            //UdpClient udpClient = new UdpClient();
            //udpClient.Connect(endPoint);

            //string msg = "Hello from Sumqayit!";
            //byte[] data = Encoding.UTF8.GetBytes(msg);
            //int numberOfSentBytes =  udpClient.Send(data, data.Length);
            //udpClient.Close();
        }
    }
}
