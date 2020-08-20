using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mc
{
    public partial class Lichphatsong : Form
    {
        public Lichphatsong()
        {
            InitializeComponent();
        }
        Timer gameTimer = new Timer();
        private void LoadLich()
        {
            List<GameShow> lst = new List<GameShow>();
            lst.Add(
               new GameShow()
               {
                   Id = 1,
                   Name = "Ai là triệu phú",
                   StartDate = DateTime.Now.AddSeconds(10),
                   EndDate = DateTime.Now.AddMinutes(30)
               });
            lst.Add(
               new GameShow()
               {
                   Id = 2,
                   Name = "Hãy chọn giá đúng",
                   StartDate = DateTime.Now.AddDays(1),
                   EndDate = DateTime.Now.AddDays(1).AddMinutes(30)
               });

            grvGameShow.DataSource = lst;

            var nearestGameShow = lst[0];
            lblName.Text = nearestGameShow.Name;
            lblTime.Text = nearestGameShow.StartDate.ToString("dd/MM/yyyy hh:mm:ss");
            OrigTime = (int)Math.Round((nearestGameShow.StartDate - DateTime.Now).TotalSeconds, 0);
        }
        private void Lichphatsong_Load(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
            LoadLich();
            gameTimer.Enabled = true;
            gbAddgameshow.Visible = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            timeX_Tick(sender, e);
        }
        int OrigTime = 1800;
        private void timeX_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            txtCountDown.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            if (OrigTime <= 0)
            {
                gameTimer.Enabled = false;
                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMC frm = new frmMC();
            frm.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            gbAddgameshow.Visible = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            gbAddgameshow.Visible = false;
        }
        int index = 0;
        private void Laythongtingameshow(int index)
        {
            /* GameShow gs = new GameShow();
             gs.Id = int.Parse(txtid.Text);
             gs.Name = txtname.Text;
             gs.StartDate = DateTime.Parse(dtgStart.Text);
             gs.EndDate = DateTime.Parse(dtgend.Text);*/
            List<GameShow> lst = new List<GameShow>();
            lst.Add(
               new GameShow()
               {
                   Id = int.Parse(txtid.Text),
                   Name = txtname.Text,
                   StartDate = DateTime.Parse(dtgStart.Text),
                   EndDate = DateTime.Parse(dtgend.Text)
               });
            grvGameShow.DataSource = lst;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
             Laythongtingameshow(index);
             index++;
        }
    }
}
