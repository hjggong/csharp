using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatServer
{
    // 델리게이트 생성
    delegate void SetTextCallback(string str);

    public partial class Form1 : Form
    {
        TcpListener lit_Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 5001);
        public static ArrayList socketArr = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        public void SetText(string text)
        {
            if (this.txt_Chat.InvokeRequired)
            {
                // 델리게이트 선언
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txt_Chat.AppendText(text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            lit_Listener.Stop();
        }

        private void cmd_Start_Click(object sender, EventArgs e)
        {
            //if (lbl_Message.Tag.ToString() == "Stop")
            if ("Stop".Equals(lbl_Message.Tag.ToString()))
            {
                lit_Listener.Start();
                Thread thd_WaitSocket = new Thread(new ThreadStart(Wait_Socket));
                thd_WaitSocket.Start();
                lbl_Message.Text = "Server Start 상태입니다.";
                lbl_Message.Tag = "Start";
                cmd_Start.Text = "Server Stop";
            }
            else
            {
                lit_Listener.Stop();
                foreach(Socket socket in Form1.socketArr)
                {
                    socket.Close();
                }
                Form1.socketArr.Clear();
                lbl_Message.Text = "Server Stop 상태입니다.";
                lbl_Message.Tag = "Stop";
                cmd_Start.Text = "Server Start";
            }
        }

        private void Wait_Socket()
        {
            Socket sktClient = null;
            while (true)
            {
                try
                {
                    sktClient = lit_Listener.AcceptSocket();
                    Chat_Class cht_Class = new Chat_Class();
                    cht_Class.Chat_Class_Setup(this, sktClient, this.txt_Chat);

                    Thread thd_ChatProcess = new Thread(new ThreadStart(cht_Class.Chat_Process));
                    thd_ChatProcess.Start();
                }
                catch(Exception e)
                {
                    Form1.socketArr.Remove(sktClient);
                    break;
                }
            }
        }
    }

    public class Chat_Class
    {
        private Encoding ecd_Encode = Encoding.GetEncoding("KS_C_5601-1987");

        private TextBox txt_Chat;
        private Socket sktClient;
        private NetworkStream netStream;
        private StreamReader strReader;
        private Form1 form1;

        public void Chat_Class_Setup(Form1 form1, Socket sktClient, TextBox txt_Chat)
        {
            this.txt_Chat = txt_Chat;
            this.sktClient = sktClient;
            this.netStream = new NetworkStream(sktClient);
            Form1.socketArr.Add(sktClient);
            this.strReader = new StreamReader(netStream, ecd_Encode);
            this.form1 = form1;
        }

        public void Chat_Process()
        {
            while (true)
            {
                try
                {
                    string lstMessage = strReader.ReadLine();
                    if(lstMessage != null && lstMessage != "")
                    {
                        form1.SetText(lstMessage + "\r\n");

                        byte[] bytSend_Data = Encoding.Default.GetBytes(lstMessage + "\r\n");
                        ArrayList remove_socketArr = new ArrayList();
                        lock (Form1.socketArr)
                        {
                            foreach(Socket socket in Form1.socketArr)
                            {
                                NetworkStream stream = new NetworkStream(socket);
                                stream.Write(bytSend_Data, 0, bytSend_Data.Length);
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Form1.socketArr.Remove(sktClient);
                    break;
                }
            }
        }
    }
}
