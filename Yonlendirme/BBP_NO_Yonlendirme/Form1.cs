using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBP_NO_Yonlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void yukariGit(PictureBox nesne)
        {
            nesne.Top -= nesne.Height;
        }
        public void solaGit(PictureBox nesne)
        {
            nesne.Left -= nesne.Width;
        }
        public void asagiGit(PictureBox nesne)
        {
            nesne.Top += nesne.Height;
        }
        public void sagaGit(PictureBox nesne)
        {
            nesne.Left += nesne.Width;
        }

        public void yukariGit(Button nesne)
        {
            nesne.Top -= nesne.Height;
        }
        public void solaGit(Button nesne)
        {
            nesne.Left -= nesne.Width;
        }
        public void asagiGit(Button nesne)
        {
            nesne.Top += nesne.Height;
        }
        public void sagaGit(Button nesne)
        {
            nesne.Left += nesne.Width;
        }

        string karakter = "";
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                case 'W':
                    if (karakter == "şovalye")
                    { if(pb_sovalye.Top != btn_okcu.Bottom || pb_sovalye.Left != btn_okcu.Left)
                        yukariGit(pb_sovalye);
                      else
                        MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    if (karakter == "okçu")
                    {
                        if (btn_okcu.Top != pb_sovalye.Bottom || pb_sovalye.Left != btn_okcu.Left)
                        yukariGit(btn_okcu);
                    else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    break;
                case 'a':
                case 'A':
                    if (karakter == "şovalye")
                    {
                        if (pb_sovalye.Left != btn_okcu.Right || pb_sovalye.Top != btn_okcu.Top)
                            solaGit(pb_sovalye);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    if (karakter == "okçu")
                    {
                        if (btn_okcu.Left!= pb_sovalye.Right || pb_sovalye.Top != btn_okcu.Top)
                            solaGit(btn_okcu);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    break;
                case 's':
                case 'S':
                    if (karakter == "şovalye")
                    {
                        if (pb_sovalye.Bottom != btn_okcu.Top || pb_sovalye.Left != btn_okcu.Left)
                            asagiGit(pb_sovalye);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    if (karakter == "okçu")
                    {
                        if (btn_okcu.Bottom != pb_sovalye.Top || pb_sovalye.Left != btn_okcu.Left)
                            asagiGit(btn_okcu);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    break;
                case 'd':
                case 'D':
                    if (karakter == "şovalye")
                    {
                        if (pb_sovalye.Right != btn_okcu.Left || pb_sovalye.Top != btn_okcu.Top)
                            sagaGit(pb_sovalye);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    if (karakter == "okçu")
                    {
                        if (btn_okcu.Right != pb_sovalye.Left || pb_sovalye.Top != btn_okcu.Top)
                            sagaGit(btn_okcu);
                        else
                            MessageBox.Show("iki karakter arası çarpışma var");
                    }
                    break;  
            }

            if (e.KeyChar==Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("Space tuşuna basıldı");
            }


            if (pb_sovalye.Bounds.IntersectsWith(btn_okcu.Bounds))
            {
                MessageBox.Show("karakter sınırları çakışıyor");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.W)
            {
                //yukarı gitme kodları
            }
            if (e.KeyCode == Keys.A)
            {
                //sola gitme kodları
            }
            if (e.KeyCode == Keys.S)
            {
                //aşağı gitme kodları
            }
            if (e.KeyCode == Keys.D)
            {
                //sağa gitme kodları
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                karakter = "şovalye";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                karakter = "okçu";
            }
        }

        private void pb_sovalye_Click(object sender, EventArgs e)
        {
            karakter = "şovalye";
            comboBox1.SelectedIndex = 0;
        }

        private void btn_okcu_Click(object sender, EventArgs e)
        {
            karakter = "okçu";
            comboBox1.SelectedIndex = 1;
            pb_sovalye.Focus();
        }

        private void btn_okcu_KeyDown(object sender, KeyEventArgs e)
        {
            //yalnızca button odaklıyken çalışır
            if (e.KeyCode==Keys.Escape)
            {
                MessageBox.Show("esc tuşuna basıldı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
