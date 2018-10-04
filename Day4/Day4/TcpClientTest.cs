using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Day4
{
    class ServerHandler
    {
        StreamReader reader = null;

        public ServerHandler(StreamReader reader)
        {
            this.reader = reader;
        }

        public void Chat()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    class TcpClientTest
    {
        static void Main(string[] args)
        {
            TcpClient client = null;

            try
            {
                client = new TcpClient();
                client.Connect("localhost", 5001);
                //client.Connect("192.168.0.73", 5001);

                Encoding encode = Encoding.GetEncoding("utf-8");
                NetworkStream stream = client.GetStream();
                StreamReader reader = new StreamReader(stream, encode);
                StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

                ServerHandler serverHandler = new ServerHandler(reader);
                Thread t = new Thread(new ThreadStart(serverHandler.Chat));
                t.Start();

                string dataToSend = Console.ReadLine();
                while (true)
                {
                    writer.WriteLine(dataToSend);
                    if (dataToSend.IndexOf("<EOF>") > -1)
                        break;
                    dataToSend = Console.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                client.Close();
                client = null;
            }
        }
    }
}
