using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Client
{
    class Program
    {


        //创建一个数据缓冲区
        private static byte[] m_DataBuffer = new byte[1024];
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Loopback;
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);



            #region 基础连接



            //try
            //{
            //    clientSocket.Connect(new IPEndPoint(ip, 8099));
            //    Console.WriteLine("连接服务器成功");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("连接服务器失败，按回车键退出");
            //    Console.WriteLine(ex.Message);
            //    return;
            //}
            ////通过clientSocket接收数据
            //int receiveLength = clientSocket.Receive(m_DataBuffer);
            //Console.WriteLine("接受服务器消息：{0}", Encoding.UTF8.GetString(m_DataBuffer, 0, receiveLength));
            ////通过clientSocket发送数据
            //for (int i = 0; i < 10; i++)
            //{
            //    try
            //    {
            //        Thread.Sleep(1000);
            //        string sendMessage = string.Format("{0} {1}", "Server 你好！", DateTime.Now.ToString());
            //        clientSocket.Send(Encoding.UTF8.GetBytes(sendMessage));
            //        Console.WriteLine("向服务器发送消息：{0}", sendMessage);
            //    }
            //    catch
            //    {
            //        clientSocket.Shutdown(SocketShutdown.Both);
            //        clientSocket.Close();
            //        break;
            //    }
            //}
            //Console.WriteLine("发送完毕，按回车键退出");

            #endregion


           // #region  连接测试

            Dictionary<int, Socket> socketList = new Dictionary<int, Socket>();


            for (var i = 0; i < 50; i++)
            {
                var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(new IPEndPoint(ip, 8099));

                socketList.Add(i,socket);

                socket.Send(Encoding.UTF8.GetBytes("连接" + i + "来了"));
            }
            try
            {
                Random r = new Random();
                int id;

                for (var j = 0; j < 50; j++)
                {
                    Task task = new Task(() =>
                    {
                        id = r.Next(1, 49);
                        Socket socket;
                        socketList.TryGetValue(id, out socket);
                        while (true)
                        {
                            socket.Send(Encoding.UTF8.GetBytes("连接" + id + "发送消息了"));
                            Thread.Sleep(r.Next(500, 1500));
                        }


                    });
                    task.Start();
                }
            }
            catch (Exception ex)
            {
                int x = 0;
            }


            Console.ReadLine();
           


        }
    }
}





   
