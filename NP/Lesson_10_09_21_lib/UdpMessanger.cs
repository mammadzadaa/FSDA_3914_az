
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Lesson_10_09_21_lib
{
    public class UdpMessanger
    {
        public string remoteAddress { get; set; }
        public int remotePort { get; set; }
        public int localPort { get; set; }

        public void SendMessage(string message)
        {
            using UdpClient sender = new UdpClient();
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                sender.Send(data, data.Length, remoteAddress, remotePort);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sender.Close();
            }
        }

        public string RecieveMessage()
        {
            UdpClient reciever = new UdpClient(localPort);
            IPEndPoint remoteIp = null;
            string message = null;
            try
            {
                byte[] data = reciever.Receive(ref remoteIp);
                message = Encoding.UTF8.GetString(data);
                return message;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reciever.Close();
            }
            return message;
        }
    }
}
