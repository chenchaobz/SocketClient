using System;
using System.Collections;
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


            #region  

            Task task_newSocket1 = new Task(()=> {
                Socket clientSocket1 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket1.Connect(new IPEndPoint(ip, 8099));

                clientSocket1.Send(Encoding.UTF8.GetBytes("连接1来了"));
            });
            Task task_newSocket2 = new Task(() => {
                Socket clientSocket2 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket2.Connect(new IPEndPoint(ip, 8099));
                clientSocket2.Send(Encoding.UTF8.GetBytes("连接2来了"));
            });
            Task task_newSocket3 = new Task(() => {
                Socket clientSocket3 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket3.Connect(new IPEndPoint(ip, 8099));

                clientSocket3.Send(Encoding.UTF8.GetBytes("连接3来了"));
            });
            Task task_newSocket4 = new Task(() => {
                Socket clientSocket4 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket4.Connect(new IPEndPoint(ip, 8099));

                clientSocket4.Send(Encoding.UTF8.GetBytes("连接4来了"));
            });
            Task task_newSocket5 = new Task(() => {
                Socket clientSocket5 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket5.Connect(new IPEndPoint(ip, 8099));

                clientSocket5.Send(Encoding.UTF8.GetBytes("连接5来了"));
            });
            Task task_newSocket6 = new Task(() => {
                Socket clientSocket6 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket6.Connect(new IPEndPoint(ip, 8099));


                clientSocket6.Send(Encoding.UTF8.GetBytes("连接6来了"));
            });
            Task task_newSocket7 = new Task(() => {
                Socket clientSocket7 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket7.Connect(new IPEndPoint(ip, 8099));

                clientSocket7.Send(Encoding.UTF8.GetBytes("连接7来了"));
            });
            Task task_newSocket8 = new Task(() => {
                Socket clientSocket8 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket8.Connect(new IPEndPoint(ip, 8099));

                clientSocket8.Send(Encoding.UTF8.GetBytes("连接8来了"));
            });
            Task task_newSocket9 = new Task(() => {
                Socket clientSocket9 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket9.Connect(new IPEndPoint(ip, 8099));


                clientSocket9.Send(Encoding.UTF8.GetBytes("连接9来了"));
            });
            Task task_newSocket10 = new Task(() => {
                Socket clientSocket10 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket10.Connect(new IPEndPoint(ip, 8099));


                clientSocket10.Send(Encoding.UTF8.GetBytes("连接10来了"));
            });

            Task[] tasks = new Task[] { task_newSocket1, task_newSocket2, task_newSocket3, task_newSocket4, task_newSocket5, task_newSocket6, task_newSocket7, task_newSocket8, task_newSocket9, task_newSocket10 };
            task_newSocket1.Start();
            task_newSocket2.Start();
            task_newSocket3.Start();
            task_newSocket4.Start();
            task_newSocket5.Start();
            task_newSocket6.Start();
            task_newSocket7.Start();
            task_newSocket8.Start();
            task_newSocket9.Start();
            task_newSocket10.Start();


            Task.WaitAll(tasks);

            #endregion


            Console.ReadLine();
        }
    }
}





   
