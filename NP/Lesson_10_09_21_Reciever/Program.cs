using Lesson_10_09_21_lib;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson_10_09_21_Reciever
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

            Console.WriteLine(udpMessanger.RecieveMessage());

            //UdpClient udpClient = new UdpClient(8888);
            //IPEndPoint endPoint = null;
            //byte[] data = udpClient.Receive(ref endPoint);
            //string msg = Encoding.UTF8.GetString(data);
            //udpClient.Close();
        }
    }
}
