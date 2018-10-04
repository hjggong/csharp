using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;

namespace Chat
{
    class ClientHandler
    {
        Socket socket = null;
        NetworkStream stream = null;
        StreamReader reader = null;
        StreamWriter writer = null;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            Server.list.Add(socket);
        }

        public void Chat()
        {
            Encoding encode = Encoding.GetEncoding("utf-8");
            stream = new NetworkStream(socket);

            reader = new StreamReader(stream, encode);

            try
            {
                while (true)
                {
                    string str = reader.ReadLine();
                    Console.WriteLine(str);

                    foreach (Socket s in Server.list)
                    {
                        stream = new NetworkStream(s);
                        writer = new StreamWriter(stream) { AutoFlush = true };

                        writer.WriteLine(str);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Server.list.Remove(socket);
                socket.Close();
                socket = null;
            }
        }
    }

    class Server
    {
        public static List<Socket> list = new List<Socket>();

        public static void Main()
        {
            TcpListener tcpListener = null;
            Socket clientsocket = null;

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                tcpListener = new TcpListener(ipAd, 5001);
                tcpListener.Start();

                while (true)
                {
                    clientsocket = tcpListener.AcceptSocket();

                    ClientHandler cHandler = new ClientHandler(clientsocket);
                    Thread t = new Thread(new ThreadStart(cHandler.Chat));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                clientsocket.Close();
            }
        }
    }
}