using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mc
{
    public partial class frmMC : Form
    {
        // khởi tạo biến đếm gửi câu hỏi
        int IntCount = 0;
        // khởi tạo biến kiểm tra kết nối
        int KtConnect = 0;
        // khởi tạo đường dẫn hình ảnh
        public string fileName;
        // khởi tọa list chứa câu hỏi
        List<Questions> list = new List<Questions>();
        //
        bool kt = false;
        // khởi tạo giá trị kế tiếp
        int Value_NextQs = -1;
        public frmMC()
        {
            InitializeComponent();
        }
        IPEndPoint IP;
        Socket Client;
        /// <summary>
        /// kết nối tới sever
        /// </summary>
        void Connect(string s)
        {
            try
            {
                IP = new IPEndPoint(IPAddress.Parse(s), 5000);
            }
            catch
            {
            }
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                Client.Connect(IP);
                KtConnect = 1;
            }
            catch
            {

                return;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }
        /// <summary>
        /// đóng kết nối hiện thời lại
        /// </summary>
        void _Close()
        {
            Client.Close();
        }
        /// <summary>
        /// Gửi tin
        /// </summary>
        void Send(string s)
        {
            if (s != "")
            {
                Client.Send(Serialize(s));
            }
        }
        /// <summary>
        /// nhận tin
        /// </summary>
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    Client.Receive(data);
                    string message = (string)Deserialize(data);
                    if (message == "1")
                    {
                        btnSendQuestion.Enabled = true;
                        RemoveQsSend();
                    }
                    else if (message == "0")
                    {
                        btnSendQuestion.Enabled = true;
                    }
                }
            }
            catch
            {
                _Close();
            }
        }

        /// <summary>
        /// Phân mảnh
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }
        public void LoadQs()
        {
            // load de
            Questions temp = null;
            string[] lines = File.ReadAllLines("C:\\Users\\phant\\Desktop\\1760002-1760081-1760118\\game\\mc\\Question.txt");
            foreach (string s in lines)
            {
                if (s.StartsWith("@@"))
                {
                    temp = new Questions();
                    temp._TrueAnswer = s.Substring(2);
                }
                if (s.StartsWith("**"))
                {
                    list.Add(temp);
                }
                if (s.StartsWith("A."))
                {
                    temp._ListAnswer._answerA = s.Substring(2);
                }
                if (s.StartsWith("B."))
                {
                    temp._ListAnswer._answerB = s.Substring(2);
                }
                if (s.StartsWith("C."))
                {
                    temp._ListAnswer._answerC = s.Substring(2);
                }
                if (s.StartsWith("D."))
                {
                    temp._ListAnswer._answerD = s.Substring(2);
                }
                if (s.StartsWith("Q."))
                {
                    temp._Question = s.Substring(2);
                }
            }
            
        }
        //Ham xoa cau hoi ra khoi List cau hoi khi da gui
        public void RemoveQsSend()
        {
            if (kt == false)
            {
                list.RemoveAt(Value_NextQs);
                if (list.Count != 0)
                {
                    if (Value_NextQs != list.Count - 1)
                    {
                        txtQuestion.Text = list[Value_NextQs]._Question;
                        txtA.Text = list[Value_NextQs]._ListAnswer._answerA;
                        txtB.Text = list[Value_NextQs]._ListAnswer._answerB;
                        txtC.Text = list[Value_NextQs]._ListAnswer._answerC;
                        txtD.Text = list[Value_NextQs]._ListAnswer._answerD;
                        txtDA.Text = list[Value_NextQs]._TrueAnswer;
                    }
                    else
                    {
                        Value_NextQs = 0;
                        txtQuestion.Text = list[Value_NextQs]._Question;
                        txtA.Text = list[Value_NextQs]._ListAnswer._answerA;
                        txtB.Text = list[Value_NextQs]._ListAnswer._answerB;
                        txtC.Text = list[Value_NextQs]._ListAnswer._answerC;
                        txtD.Text = list[Value_NextQs]._ListAnswer._answerD;
                        txtDA.Text = list[Value_NextQs]._TrueAnswer;
                    }
                }
                else
                {
                    txtQuestion.Text = "";
                    txtA.Text = "";
                    txtB.Text = "";
                    txtC.Text = "";
                    txtD.Text = "";
                    txtDA.Text = "";
                    btnLoadQuestion.Enabled = false;
                }
            }
        }
        // kiểm tra thông tin đày đủ trước khi gửi đi
        public bool CheckBeforeSend()
        {
            if (string.IsNullOrEmpty(txtQuestion.Text) == true)
                return false;
            if (string.IsNullOrEmpty(txtA.Text) == true)
                return false;
            if (string.IsNullOrEmpty(txtB.Text) == true)
                return false;
            if (string.IsNullOrEmpty(txtC.Text) == true)
                return false;
            if (string.IsNullOrEmpty(txtD.Text) == true)
                return false;
            if (string.IsNullOrEmpty(txtDA.Text) == true)
                return false;
            return true;
        }
        
        private void frmMC_Load(object sender, EventArgs e)
        {
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            txtD.Visible = false;
            txtDA.Visible = false;
            ptrImageMc.Visible = false;
            lbname.Visible = false;
            lbD.Visible = false;
            lbA.Visible = false;
            lbB.Visible = false;
            lbC.Visible = false;
            lbda.Visible = false;
            lbinputda.Visible = false;
            lbinputQs.Visible = false;
            btnNextQuestion.Visible = false;
            btnNextQuestion.Visible = false;
            btnchat.Visible = false;
            btnSendQuestion.Visible = false;
            btnLoadQuestion.Visible = false;
            txtQuestion.Visible = false;
            //Load Câu hỏi lên List và list02
            LoadQs();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (Value_NextQs < list.Count)
            {
                txtQuestion.Text = list[Value_NextQs]._Question;
                txtA.Text = list[Value_NextQs]._ListAnswer._answerA;
                txtB.Text = list[Value_NextQs]._ListAnswer._answerB;
                txtC.Text = list[Value_NextQs]._ListAnswer._answerC;
                txtD.Text = list[Value_NextQs]._ListAnswer._answerD;
                txtDA.Text = list[Value_NextQs]._TrueAnswer;
                Value_NextQs++;
            }
            if (Value_NextQs >= list.Count)
            {
                Value_NextQs = 0;
            }
        }

        private void btnLoadQuestion_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                kt = false;
                Value_NextQs++;
                if (Value_NextQs <= list.Count - 1)
                {
                    txtQuestion.Text = list[Value_NextQs]._Question;
                    txtA.Text = list[Value_NextQs]._ListAnswer._answerA;
                    txtB.Text = list[Value_NextQs]._ListAnswer._answerB;
                    txtC.Text = list[Value_NextQs]._ListAnswer._answerC;
                    txtD.Text = list[Value_NextQs]._ListAnswer._answerD;
                    txtDA.Text = list[Value_NextQs]._TrueAnswer;
                }
                else
                {
                    Value_NextQs = 0;
                    txtQuestion.Text = list[Value_NextQs]._Question;
                    txtA.Text = list[Value_NextQs]._ListAnswer._answerA;
                    txtB.Text = list[Value_NextQs]._ListAnswer._answerB;
                    txtC.Text = list[Value_NextQs]._ListAnswer._answerC;
                    txtD.Text = list[Value_NextQs]._ListAnswer._answerD;
                    txtDA.Text = list[Value_NextQs]._TrueAnswer;
                }
            }
        }

        private void btnchat_Click(object sender, EventArgs e)
        {
            chatmc frm = new chatmc(this);

            frm.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Connect(txtIp.Text);
            if (KtConnect == 1 && txthoten.Text != "" && txtIp.Text != "")
            {
                lbname.Text = txthoten.Text;
                if (fileName != null)
                {
                    ptrImageMc.Image = Bitmap.FromFile(fileName);
                }
                panel1.Visible = false;
                //
                txtA.Visible = true;
                txtB.Visible = true;
                txtC.Visible = true;
                txtD.Visible = true;
                txtDA.Visible = true;
                ptrImageMc.Visible = true;
                lbname.Visible = true;
                lbD.Visible = true;
                lbA.Visible = true;
                lbB.Visible = true;
                lbC.Visible = true;
                lbda.Visible = true;
                lbinputda.Visible = true;
                lbinputQs.Visible = true;
                btnNextQuestion.Visible = true;
                btnchat.Visible = true;
                btnSendQuestion.Visible = true;
                btnLoadQuestion.Visible = true;
                txtQuestion.Visible = true;
                btnNewQuestion.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn đã điền thiếu thông tin hoặc sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendQuestion_Click(object sender, EventArgs e)
        {
            if (CheckBeforeSend() == true)
            {
                IntCount++;
                lbcount.Text = IntCount.ToString();
                string question = txtQuestion.Text;
                string a = txtA.Text;
                string b = txtB.Text;
                string c = txtC.Text;
                string d = txtD.Text;
                string da = txtDA.Text;
                string data = string.Format("{0}" + "@" + "{1}" + "@" + "{2}" + "@" + "{3}" + "@" + "{4}" + "@" + "{5}" + "@" + "{6}", da, question, a, b, c, d, IntCount);
                Send(data);
                RemoveQsSend();
                btnSendQuestion.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thiếu thông tin câu hỏi !", "Lỗi");
            }
        }

        private void btnChonanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                ptImage.Image = Bitmap.FromFile(fileName);
            }
        }

        private void btnNewQuestion_Click(object sender, EventArgs e)
        {
            IntCount = 0;
            lbcount.Text = IntCount.ToString();
        }
    }
}
