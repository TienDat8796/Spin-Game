using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace SpinGamePlay
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        int SpinPlay = 2000;
        int Score = 0;
        int diem = 0;
        Random random = new Random();
        Music nhac = new Music();

        public Form1()
        {
            InitializeComponent();
        }
        int MucCuoc(int mc)
        {
            var selected = comboBox1.SelectedItem.ToString();
            switch (selected)
            {
                default:
                    return int.Parse(selected);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nhac.NhacHieuUng2.URL = "positive-orchestral-jingle-21444.wav";
            nhac.NhacHieuUng2.controls.play();
            lblSpin.Text = SpinPlay.ToString();
            btnStop.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblKQ1.Text = random.Next(1, 8).ToString();
            lblKQ2.Text = random.Next(1, 8).ToString();
            lblKQ3.Text = random.Next(1, 8).ToString();
        }
        private void btnSpin_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            btnStop.Enabled = true;
            if (timer1.Enabled)
            {
                MessageBox.Show("Đang quay vui lòng dừng lại !");
            }
            if (SpinPlay == 0)
            {
                MessageBox.Show("Bạn Hết Tiền Rồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn mức cược !");
                btnStop.Enabled = false;
                return;
            }
            if (!timer1.Enabled)
            {
                if (SpinPlay < MucCuoc(0))
                    MessageBox.Show("Tiền còn lại không đủ cược ở mức này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    SpinPlay -= MucCuoc(0);
                    lblSpin.Text = SpinPlay.ToString();
                    timer1.Start();
                }
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            timer1.Stop();
            btnStop.Enabled = false;
            if (lblSpin.Text == "0")
            {
                btnStop.Enabled = false;
                btnSpin.Enabled = false;
            }

            if (lblKQ1.Text == "7" && lblKQ2.Text == "7" && lblKQ3.Text == "7")
            {
                MessageBox.Show("JackPort", "Chúc Mừng Bạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                diem += Score + MucCuoc(0) + 10000;
            }
            else if (lblKQ1.Text == "7" && lblKQ2.Text == "7" || lblKQ1.Text == "7" && lblKQ3.Text == "7" || lblKQ2.Text == "7" && lblKQ3.Text == "7")
            {
                diem += Score + MucCuoc(0) + 2000;
            }
            else if (lblKQ1.Text == "7" || lblKQ2.Text == "7" || lblKQ3.Text == "7")
            {
                diem += Score + MucCuoc(0) + 1000;
            }
            lblScore.Text = diem.ToString();
            if (SpinPlay == 0)
            {
                MessageBox.Show("Bạn đã hết spin hãy đổi điểm để chơi tiếp hoặc chơi mới.");
                return;
            }
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                MessageBox.Show("Đang quay vui lòng dừng lại !");
                return;
            }
            nhac.NhacHieuUng3.Play();
            btnSpin.Enabled = true;
            SpinPlay = 2000;
            diem = 0;
            Score = 0;
            lblKQ1.Text = "7";
            lblKQ2.Text = "7";
            lblKQ3.Text = "7";
            lblSpin.Text = "2000";
            lblScore.Text = "0";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        static bool checkHD = false;
        static fHuongDan fhd;
        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (checkHD == true)
                fhd.Close();
            fhd = new fHuongDan();
            fhd.Show();
            checkHD = true;
        }
        private void mnuNhacOn_Click(object sender, EventArgs e)
        {
            nhac.NhacNen.URL = "Tình yêu màu nắng.wav";
            nhac.NhacNen.controls.play();
        }
        private void mnuNhacOff_Click(object sender, EventArgs e)
        {
            nhac.NhacNen.controls.stop();
        }
        private void mnuDoiSpin100Score_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (int.Parse(lblScore.Text) >= 100)
            {
                int tru = int.Parse(lblScore.Text) - 100;
                SpinPlay += 150;
                lblSpin.Text = SpinPlay.ToString();
                diem = tru;
                lblScore.Text = diem.ToString();
            }
            else
                MessageBox.Show("Không đủ điểm để đổi !");
            if (lblSpin.Text != "0")
            {
                btnSpin.Enabled = true;
            }
        }
        private void mnuDoiSpin200Score_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (int.Parse(lblScore.Text) >= 200)
            {
                int tru = int.Parse(lblScore.Text) - 200;
                SpinPlay += 300;
                lblSpin.Text = SpinPlay.ToString();
                diem = tru;
                lblScore.Text = diem.ToString();
            }
            else
                MessageBox.Show("Không đủ điểm để đổi !");
            if (lblSpin.Text != "0")
            {
                btnSpin.Enabled = true;
            }
        }
        private void mnuDoiSpin300Score_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (int.Parse(lblScore.Text) >= 300)
            {
                int tru = int.Parse(lblScore.Text) - 300;
                SpinPlay += 500;
                lblSpin.Text = SpinPlay.ToString();
                diem = tru;
                lblScore.Text = diem.ToString();
            }
            else
                MessageBox.Show("Không đủ điểm để đổi !");
            if (lblSpin.Text != "0")
            {
                btnSpin.Enabled = true;
            }
        }
        private void mnuDoiSpin500Score_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (int.Parse(lblScore.Text) >= 500)
            {
                int tru = int.Parse(lblScore.Text) - 500;
                SpinPlay += 1100;
                lblSpin.Text = SpinPlay.ToString();
                diem = tru;
                lblScore.Text = diem.ToString();
            }
            else
                MessageBox.Show("Không đủ điểm để đổi !");
            if (lblSpin.Text != "0")
            {
                btnSpin.Enabled = true;
            }
        }
        private void mnuDoiSpin1000Score_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
            if (int.Parse(lblScore.Text) >= 1000)
            {
                int tru = int.Parse(lblScore.Text) - 1000;
                SpinPlay += 10000;
                lblSpin.Text = SpinPlay.ToString();
                diem = tru;
                lblScore.Text = diem.ToString();
            }
            else
                MessageBox.Show("Không đủ điểm để đổi !");
            if (lblSpin.Text != "0")
            {
                btnSpin.Enabled = true;
            }
        }

        private void mnuDoiSpin_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            nhac.NhacHieuUng1.Play();
        }
    }
}
