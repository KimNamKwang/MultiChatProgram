using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MultiChatProgram2
{
    public partial class MultiChat2 : Form
    {
        delegate void AppendTextDelegate(Control ctrl, string s);
        AppendTextDelegate _textAppender;
        Socket mainSock;
        IPAddress thisAddress;

        public MultiChat2()
        {
            InitializeComponent();
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            _textAppender = new AppendTextDelegate(AppendText);
        }

        private void GetIPAddress()
        {
            // 현재 IP 주소를 가져옴.
            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());

            // IP 주소를 문자열로 변환해 boxForIPAddr에 출력.
            foreach (IPAddress ipAddress in localIPs)
            {
                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    boxForIPAddr.Text = ipAddress.ToString();
                }
            }
        }

        void AppendText(Control ctrl, string s)
        {
            if (ctrl.InvokeRequired) ctrl.Invoke(_textAppender, ctrl, s);
            else
            {
                string source = ctrl.Text;
                ctrl.Text = source + Environment.NewLine + s;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            // 처음으로 발견되는 ipv4 주소를 사용한다.
            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }

            // 주소가 없다면..
            if (thisAddress == null)
                // 로컬호스트 주소를 사용한다.
                thisAddress = IPAddress.Loopback;

            boxForIPAddr.Text = thisAddress.ToString();
        }

        private void serverBtn_CheckedChanged(object sender, EventArgs e)
        {
            GetIPAddress();
            boxForPort.Text = "8080";
        }

        private void clientBtn_CheckedChanged(object sender, EventArgs e)
        {
            boxForIPAddr.Text = "";
            boxForIPAddr.Enabled = true;
            boxForPort.Text = "";
            boxForPort.Enabled = true;
        }

        private void oneToOneBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void multiToMultiBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boxForIPAddr_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxForPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Server로 시작하는 경우
            if (serverBtn.Checked)
            {
                int port;
                if (!int.TryParse(boxForPort.Text, out port))
                {
                    MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                    boxForPort.Focus();
                    boxForPort.SelectAll();
                    return;
                }

                // 서버에서 클라이언트의 연결 요청을 대기하기 위해
                // 소켓을 열어둔다.
                IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
                mainSock.Bind(serverEP);
                mainSock.Listen(10);

                MessageBox.Show("서버를 시작합니다. . .람쥐");

                // 비동기적으로 클라이언트의 연결 요청을 받는다.
                mainSock.BeginAccept(AcceptCallback, null);
            }

            // Client로 시작하는 경우
            else
            {
                if (mainSock.Connected)
                {
                    MsgBoxHelper.Error("이미 연결되어 있습니다!");
                    return;
                }

                int port;
                if (!int.TryParse(boxForPort.Text, out port))
                {
                    MsgBoxHelper.Error("포트 번호가 잘못 입력되었거나 입력되지 않았습니다.");
                    boxForPort.Focus();
                    boxForPort.SelectAll();
                    return;
                }

                try { mainSock.Connect(boxForIPAddr.Text, port); }
                catch (Exception ex)
                {
                    MsgBoxHelper.Error("연결에 실패했습니다!\n오류 내용: {0}", MessageBoxButtons.OK, ex.Message);
                    return;
                }

                // 연결 완료되었다는 메세지를 띄워준다.
                MessageBox.Show("서버와 연결되었습니다. . .람쥐");

                AppendText(textBoxForChatView, "서버와 연결되었습니다.");

                // 연결 완료, 서버에서 데이터가 올 수 있으므로 수신 대기한다.
                AsyncObject obj = new AsyncObject(4096);
                obj.WorkingSocket = mainSock;
                mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
            }
        }


        List<Socket> connectedClients = new List<Socket>();

        void AcceptCallback(IAsyncResult ar)
        {
            // 클라이언트의 연결 요청을 수락한다.
            Socket client = mainSock.EndAccept(ar);

            // 또 다른 클라이언트의 연결을 대기한다.
            mainSock.BeginAccept(AcceptCallback, null);

            AsyncObject obj = new AsyncObject(4096);
            obj.WorkingSocket = client;

            // 연결된 클라이언트 리스트에 추가해준다.
            connectedClients.Add(client);

            // 텍스트박스에 클라이언트가 연결되었다고 써준다.
            AppendText(textBoxForChatView, string.Format("클라이언트 (@ {0})가 연결되었습니다.", client.RemoteEndPoint));

            // 클라이언트의 데이터를 받는다.
            client.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }

        void DataReceived(IAsyncResult ar)
        {
            // BeginReceive에서 추가적으로 넘어온 데이터를 AsyncObject 형식으로 변환한다.
            AsyncObject obj = (AsyncObject)ar.AsyncState;

            // 데이터 수신을 끝낸다.
            int received = obj.WorkingSocket.EndReceive(ar);

            // 받은 데이터가 없으면(연결끊어짐) 끝낸다.
            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                return;
            }



            // 텍스트로 변환한다.
            string text = Encoding.UTF8.GetString(obj.Buffer);

            // 0x01 기준으로 자른다.
            // tokens[0] - 보낸 사람 IP
            // tokens[1] - 보낸 메세지            
            string[] tokens = text.Split('\x01');

            // 메시지인 경우
            if (!tokens[0].Equals("file_ready"))
            {

                string ip = tokens[0];
                string msg = tokens[1];

                // 텍스트박스에 추가해준다.
                // 비동기식으로 작업하기 때문에 폼의 UI 스레드에서 작업을 해줘야 한다.
                // 따라서 대리자를 통해 처리한다.
                AppendText(textBoxForChatView, string.Format("[받음]{0}: {1}", ip, msg));

                // for을 통해 "역순"으로 클라이언트에게 데이터를 보낸다.
                for (int i = connectedClients.Count - 1; i >= 0; i--)
                {
                    Socket socket = connectedClients[i];
                    if (socket != obj.WorkingSocket)
                    {
                        try { socket.Send(obj.Buffer); }
                        catch
                        {
                            // 오류 발생하면 전송 취소하고 리스트에서 삭제한다.
                            try { socket.Dispose(); } catch { }
                            connectedClients.RemoveAt(i);
                        }
                    }
                }

            }
            // 파일인 경우
            else if (tokens[0].Equals("file_ready"))
            {
                string fileName = tokens[1];
                ReceiveFile(mainSock, fileName);
                return;

            }

            // 데이터를 받은 후엔 다시 버퍼를 비워주고 같은 방법으로 수신을 대기한다.
            obj.ClearBuffer();

            // 수신 대기
            obj.WorkingSocket.BeginReceive(obj.Buffer, 0, 4096, 0, DataReceived, obj);
        }


        // 파일을 받는 메소드
        private void ReceiveFile(Socket serverSocket, string fileName)
        {

            // 파일 전송 준비 완료 메시지를 서버로부터 받습니다.
            byte[] readyMessage = new byte[8192];
            int bytesReceived = serverSocket.Receive(readyMessage);
            string message = Encoding.UTF8.GetString(readyMessage, 0, bytesReceived);
            string[] tokens = message.Split('\x01');
            //if (/*tokens.Length != 2 ||*/ tokens[0] != "file_ready")
            //{
            //    // 파일 전송 준비 완료 메시지가 아니면 메소드를 종료합니다.
            //    return;
            //}
             //fileName = tokens[1];

            // 파일을 수신합니다.
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[8192];
                int bytesRead;
                long totalBytes = fileStream.Length;
                 bytesReceived = 0;
                while ((bytesRead = serverSocket.Receive(buffer)) > 0)
                    //while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                    fileStream.Write(buffer, 0, bytesRead);
                    bytesReceived += bytesRead;
                    int progress = (int)(bytesReceived * 100 / totalBytes);
                    // ProgressBar 업데이트
                    progressBarForFile.Invoke((MethodInvoker)delegate { progressBarForFile.Value = progress; });
                    AppendText(richTextBoxForReceiveFile, fileName);


                }

            }

            // 파일 전송 완료 메시지를 서버로부터 받습니다.
            byte[] doneMessage = new byte[4096];
            bytesReceived = serverSocket.Receive(doneMessage);
            message = Encoding.UTF8.GetString(doneMessage, 0, bytesReceived);
            if (message != "file_done")
            {
                // 파일 전송 완료 메시지가 아니면 메소드를 종료합니다.
                return;
            }

        }



        private void btnSameIP_Click(object sender, EventArgs e)
        {
            GetIPAddress();
            boxForPort.Text = "8080";
        }

        private void textBoxForChatView_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForSendChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            // 서버가 대기중인지 확인한다.
            if (!mainSock.IsBound)
            {
                MsgBoxHelper.Warn("서버가 실행되고 있지 않습니다!");
                return;
            }

            // 보낼 텍스트
            string tts = textBoxForSendChat.Text.Trim();
            if (string.IsNullOrEmpty(tts))
            {
                MsgBoxHelper.Warn("텍스트가 입력되지 않았습니다!");
                textBoxForSendChat.Focus();
                return;
            }

            //Server인 경우
            if (serverBtn.Checked)
            {
                // 문자열을 utf8 형식의 바이트로 변환한다.
                byte[] bDts = Encoding.UTF8.GetBytes(thisAddress.ToString() + '\x01' + tts);

                // 연결된 모든 클라이언트에게 전송한다.
                for (int i = connectedClients.Count - 1; i >= 0; i--)
                {
                    Socket socket = connectedClients[i];
                    try { socket.Send(bDts); }
                    catch (Exception exception)
                    {
                        Console.Write(exception);
                        // 오류 발생하면 전송 취소하고 리스트에서 삭제한다.
                        try { socket.Dispose(); } catch { }
                        connectedClients.RemoveAt(i);
                    }
                }

                // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
                AppendText(textBoxForChatView, string.Format("[보냄]{0}: {1}", thisAddress.ToString(), tts));
                textBoxForSendChat.Clear();
            }
            // Client인 경우
            else if (clientBtn.Checked)
            {
                // 서버 ip 주소와 메세지를 담도록 만든다.
                IPEndPoint ip = (IPEndPoint)mainSock.LocalEndPoint;
                string addr = ip.Address.ToString();

                // 문자열을 utf8 형식의 바이트로 변환한다.
                byte[] bDts = Encoding.UTF8.GetBytes(addr + '\x01' + tts);

                // 서버에 전송한다.
                mainSock.Send(bDts);

                // 전송 완료 후 텍스트박스에 추가하고, 원래의 내용은 지운다.
                AppendText(textBoxForChatView, string.Format("[보냄]{0}: {1}", addr, tts));
                textBoxForSendChat.Clear();
            }
        }

        private void btnClearChat_Click(object sender, EventArgs e)
        {
            if (serverBtn.Checked)
            {
                MessageBox.Show("서버를 종료합니다.");
            }
            else
            {
                MessageBox.Show("접속을 종료합니다.");

            }
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
