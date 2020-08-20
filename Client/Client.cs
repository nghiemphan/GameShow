using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class frmClient : Form
    {
        //khơi tạo biến gửi đi kết quả đúng or sai
        string _Yes = "1";
        string _NO = "0";
        // khởi tọa biến kiểm tra câu hỏi thứ mấy
        int Intcount = 0;
        //khởi tạo đỉa chỉ tên
        string fileName;
        // khởi tạo biến kt kết nối
        public int KtConnect = 0;
        // khởi tạo chứa kết quả đáp án
        public string DA = null;
        // khởi tạo biến kiểm tra thời gian
        public bool Time = false;
        //khởi tọa biến kiểm tra thời gian của trợ giúp 50/50
        public bool b50 = true;
        // khởi tọa biến kiểm tra thời gian của trợ  giúp hỏi ý kiến khán giả trường quay
        public bool bkhangia = true;
        public frmClient()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
            SoundPlayer chaomung = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\nhacnen\nhacbatdau.wav");
            chaomung.Play();
            tmThoiGianTraLoi.Start();
            EnabledFalsebtn();
        }
        // khởi tọa socket client
        IPEndPoint IP;
        Socket client;       
        //
        // khởi tạo biến kt đăng nhập thành công hay không
        /// <summary>
        /// kết nối tới sever
        /// </summary>
        void Connect(string s)
        {
            // IP là đỉa chỉ của server
            try
            {
                IP = new IPEndPoint(IPAddress.Parse(s), 5000);
            }
            catch
            {
            }
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
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
            client.Close();
        }
        /// <summary>
        /// Gửi tin
        /// </summary>
        void Send(string s)
        {
            if (s != "")
            {
                client.Send(Serialize(s));
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
                    btnA.Visible = true;
                    btnB.Visible = true;
                    btnC.Visible = true;
                    btnD.Visible = true;
                    byte[] message = new byte[1024 * 5000];
                    client.Receive(message);
                    string data = (string)Deserialize(message);
                    DA = data.Substring(0, data.IndexOf("@"));

                    data = data.Remove(0, data.IndexOf("@") + 1);
                    lbQuestion.Text = data.Substring(0, data.IndexOf("@"));


                    data = data.Remove(0, data.IndexOf("@") + 1);
                    btnA.Text = data.Substring(0, data.IndexOf("@"));

                    data = data.Remove(0, data.IndexOf("@") + 1);
                    btnB.Text = data.Substring(0, data.IndexOf("@"));

                    data = data.Remove(0, data.IndexOf("@") + 1);
                    btnC.Text = data.Substring(0, data.IndexOf("@"));

                    data = data.Remove(0, data.IndexOf("@") + 1);
                    btnD.Text = data.Substring(0, data.IndexOf("@"));
                    data = data.Remove(0, data.IndexOf("@") + 1);
                    Intcount = int.Parse(data);
                    scores(Intcount);
                    BackColorbtnScores(Intcount);
                    EnabledTruebtn();
                    ResetColorbtn();
                    Time = true;
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
        public int STEP = 1000;
        public int TimeDown = 10000;
        public int Interval = 1000;
        #region

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            _Close();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
        }
        #endregion
        SoundPlayer NhacChon = null;
        int DemTG = 0;
        string chon = "";

        /// <summary>
        /// tắt thao tác trên các btn
        /// </summary>
        private void EnabledFalsebtn()
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        /// <summary>
        /// mở thao tác trên các btn
        /// </summary>
        private void EnabledTruebtn()
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
        }
        /// <summary>
        /// trả về màu mặc định của btn các đáp án
        /// </summary>
        private void ResetColorbtn()
        {
            btnA.BackColor = Color.PaleGreen;
            btnB.BackColor = Color.PaleGreen;
            btnC.BackColor = Color.PaleGreen;
            btnD.BackColor = Color.PaleGreen;
            
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có chắc chắn chọn đáp án A ?", "Thông Báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\chon\TGChoDA.wav");
                NhacChon.Play();
                chon = "A";
                tmDemTG.Start();
                EnabledFalsebtn();
                btnA.BackColor = Color.Blue ;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có chắc chắn chọn đáp án B ?", "Thông Báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\chon\TGChoDA.wav");
                NhacChon.Play();
                chon = "B";
                tmDemTG.Start();
                EnabledFalsebtn();
                btnB.BackColor = Color.Blue;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có chắc chắn chọn đáp án C ?", "Thông Báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\chon\TGChoDA.wav");
                NhacChon.Play();
                chon = "C";
                tmDemTG.Start();
                EnabledFalsebtn();
                btnC.BackColor = Color.Blue;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có chắc chắn chọn đáp án D ?", "Thông Báo",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\chon\TGChoDA.wav");
                NhacChon.Play();
                chon = "D";
                tmDemTG.Start();
                EnabledFalsebtn();
                btnD.BackColor = Color.Blue;
            }
        }
        static int SLDAD = 0;
        void CheckDA()
        {
            if (chon == DA)
            {
                NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\dap\victory.wav");
                NhacChon.Play();
                chon = "";
                Send(_Yes);
                if (chon == "A")
                {
                    btnA.BackColor = Color.LightGray;
                }
                else if (chon == "B")
                {
                    btnB.BackColor = Color.LightGray;
                }
                else if (chon == "C")
                {
                    btnC.BackColor = Color.LightGray;
                }
                else if (chon == "D")
                {
                    btnD.BackColor = Color.LightGray;
                }
                SLDAD++;

            }
            else
            {
                if (DA == "A")
                {
                    NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\dap\traloisai.wav");
                    btnA.BackColor = Color.Green;
                }

                else
                {
                    if (DA == "B")
                    {
                        NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\dap\traloisai.wav");
                        btnB.BackColor = Color.Green;
                    }
                    else
                    {
                        if (DA == "C")
                        {
                           NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\dap\traloisai.wav");
                            btnC.BackColor = Color.Green;
                        }
                        else
                        {
                            NhacChon = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\dap\traloisai.wav");
                            btnD.BackColor = Color.Green;
                            this.Opacity = 10;
                        }
                    }
                }
                chon = "";
                Send(_NO);
               NhacChon.Play();

                /*SAi  lam o day*/
                DialogResult _KQ = MessageBox.Show("Bạn Đã Thua Cuộc, Kết thúc lượt chơi tại đây, hẹn gặp bạn ở số tiếp theo!!!!", "Thong bao", MessageBoxButtons.OK);
                if (_KQ == DialogResult.OK)
                {
                    Close();
                    _Close();
                }
            }

            Time = false;
            lbTG.Text = "60";
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            lbTG.Visible = false;

            gbHoiYKien.Visible = false;
            gbScore.Visible = false;
            gbhelp.Visible = false;
            //btnChat.Visible = false;
            gbDungchoi.Visible = false;
            label6.Visible = false;
        }
        public void scores(int cau)
        {
            switch (cau)
            {
                case 1: btnDiem.Text = "100.000"; break;
                case 2: btnDiem.Text = "200.000"; break;
                case 3: btnDiem.Text = "300.000"; break;
                case 4: btnDiem.Text = "500.000"; break;
                case 5: btnDiem.Text = "800.000"; break;
                case 6: btnDiem.Text = "1.500.000"; break;
                case 7: btnDiem.Text = "2.000.000"; break;
                case 8: btnDiem.Text = "3.000.000"; break;
                case 9: btnDiem.Text = "5.000.000"; break;
                case 10: btnDiem.Text = "10.000.000"; break;
            }
        }

        /// <summary>
        /// thay dổi màu nền bảng hiện thỉ điểm
        /// </summary>
        /// <param name="cau"></param>
        public void BackColorbtnScores(int cau)
        {
            switch (cau)
            {
                case 1:
                    btn1.BackColor = Color.Yellow;
                    break;
                case 2:
                    btn2.BackColor = Color.Yellow;
                    btn1.BackColor = Color.Gainsboro;
                    break;
                case 3:
                    btn3.BackColor = Color.Yellow;
                    btn2.BackColor = Color.Gainsboro;

                    break;
                case 4:
                    btn4.BackColor = Color.Yellow;
                    btn3.BackColor = Color.Gainsboro;

                    break;
                case 5:
                    btn5.BackColor = Color.Yellow;
                    btn4.BackColor = Color.Gainsboro;

                    break;
                case 6:
                    btn6.BackColor = Color.Yellow;
                    btn5.BackColor = Color.Gainsboro;

                    break;
                case 7:
                    btn7.BackColor = Color.Yellow;
                    btn6.BackColor = Color.Gainsboro;

                    break;
                case 8:
                    btn8.BackColor = Color.Yellow;
                    btn7.BackColor = Color.Gainsboro;

                    break;
                case 9:
                    btn9.BackColor = Color.Yellow;
                    btn8.BackColor = Color.Gainsboro;

                    break;
                case 10:
                    btn10.BackColor = Color.Yellow;
                    btn9.BackColor = Color.Gainsboro;

                    break;
            }
        }

        private void tmDemTG_Tick(object sender, EventArgs e)
        {
            if (DemTG >= 7)
            {
                tmDemTG.Stop();
                DemTG = 0;
                CheckDA();
            }
            else DemTG++;
        }

        private void tmThoiGianTraLoi_Tick(object sender, EventArgs e)
        {
            if (Time == true)
            {
                if (int.Parse(lbTG.Text) <= 0)
                {
                    lbTG.Text = "60";
                    Time = false;
                    CheckDA();
                }
                else
                {
                    lbTG.Text = (int.Parse(lbTG.Text) - 1).ToString();
                }
            }
        }

        private void btnKhanGia_Click(object sender, EventArgs e)
        {
            btnKhanGia.Enabled = false;
            bkhangia = true;
            btnKhanGia.BackColor = Color.SlateGray;
            gbHoiYKien.Visible = true;
            tmThoiGianTraLoi.Stop();
            tmKhanGia.Start();
            tmRangBuoc.Stop();
            btnKhanGia.Visible = false;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            b50 = true;
            btn50.Enabled = false;
            btn50.BackColor = Color.SlateGray;
            SoundPlayer nam = new SoundPlayer(@Application.StartupPath + @"\resource\Sounds\trogiup\50\trogiup50.wav");

            nam.Play();
            tm50.Start();
            tmThoiGianTraLoi.Stop();
            btn50.Visible = false;
        }

        int B = 5;

        private void tm50_Tick(object sender, EventArgs e)
        {
            if (B == 0)
            {
                if (DA == "A")
                {
                    btnB.Visible = false;
                    btnC.Visible = false;

                }

                if (DA == "B")
                {
                    btnA.Visible = false;
                    btnD.Visible = false;

                }

                if (DA == "C")
                {
                    btnA.Visible = false;
                    btnD.Visible = false;
                }

                if (DA == "D")
                {
                    btnB.Visible = false;
                    btnA.Visible = false;
                }

                tm50.Stop();
                tmThoiGianTraLoi.Start();
            }
            B--;
        }

        private void btnHoiYKien_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            if (btnA.Visible = true && btnB.Visible == true && btnC.Visible == true && btnD.Visible == true)
            {
                int A = rd.Next(1, 100);
                int B = rd.Next(1, 100 - A);
                int C = rd.Next(1, 100 - A - B);
                int D = 100 - A - B - C;
                this.chart1.Series["Age"].Points.AddXY("A", A);
                this.chart1.Series["Age"].Points.AddXY("B", B);
                this.chart1.Series["Age"].Points.AddXY("C", C);
                this.chart1.Series["Age"].Points.AddXY("D", D);
            }
            else
            {
                if (DA == "A")
                {
                    int a = rd.Next(1, 100);
                    int d = 100 - a;
                    this.chart1.Series["Age"].Points.AddXY("A", a);
                    this.chart1.Series["Age"].Points.AddXY("D", d);
                }
                if (DA == "B")
                {
                    int b = rd.Next(1, 100);
                    int c = 100 - b;
                    this.chart1.Series["Age"].Points.AddXY("B", b);
                    this.chart1.Series["Age"].Points.AddXY("C", c);
                }
                if (DA == "C")
                {
                    int c = rd.Next(1, 100);
                    int b = 100 - c;
                    this.chart1.Series["Age"].Points.AddXY("C", c);
                    this.chart1.Series["Age"].Points.AddXY("B", b);
                }
                if (DA == "D")
                {
                    int d = rd.Next(1, 100);
                    int c = 100 - d;
                    this.chart1.Series["Age"].Points.AddXY("D", d);
                    this.chart1.Series["Age"].Points.AddXY("C", c);
                }
            }
        }

        private void btnXemxong_Click(object sender, EventArgs e)
        {
            gbHoiYKien.Visible = false;
            tmThoiGianTraLoi.Start();
        }

        
        private void btnDungChoi_Click(object sender, EventArgs e)
        {

            gbDungchoi.Visible = true;
            tmThoiGianTraLoi.Stop();
            switch (SLDAD)
            {
                case 1: btnTien.Text = "100.000"; break;
                case 2: btnTien.Text = "200.000"; break;
                case 3: btnTien.Text = "300.000"; break;
                case 4: btnTien.Text = "500.000"; break;
                case 5: btnTien.Text = "800.000"; break;
                case 6: btnTien.Text = "1.500.000"; break;
                case 7: btnTien.Text = "2.000.000"; break;
                case 8: btnTien.Text = "3.000.000"; break;
                case 9: btnTien.Text = "5.000.000"; break;
                case 10: btnTien.Text = "10.000.000"; break;
            }
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            gbDungchoi.Visible = false;
            tmThoiGianTraLoi.Start();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn đã dừng cuộc chơi tại đây nhấn OK để thoát", "Thông báo dừng chơi",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Connect(txtIp.Text);
            if (KtConnect == 1 && txthoten.Text != "" && txtIp.Text != "")
            {
                lbName.Text = txthoten.Text;
                if (fileName != null)
                {
                    ptrProfile.Image = Bitmap.FromFile(fileName);
                }
                panel1.Visible = false;
                gbhelp.Visible = true;
                gbScore.Visible = true;
                gbmain.Visible = true;
                gbDA.Visible = true;
                //btnChat.Visible = true;
                lbTG.Visible = true;
                ptrProfile.Visible = true;
                lbQuestion.Visible = true;
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show("Bạn đã điền thiếu thông tin hoặc sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnchat_Click(object sender, EventArgs e)
        {
            frmChat frm = new frmChat(this);

            frm.Show();
        }
    }
}
