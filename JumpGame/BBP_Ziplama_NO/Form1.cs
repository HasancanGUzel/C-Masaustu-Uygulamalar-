using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBP_Ziplama_NO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool artis=true;
        int sinir=1,ilkX,ilkY;

        private void ziplama_Tick(object sender, EventArgs e)
        {
            if (sinir==5)
            {
                artis = false;
                pb_oyuncu.Top -= pb_oyuncu.Height / 2;
            }

            if (artis)
            {
                pb_oyuncu.Top -= pb_oyuncu.Height / 2;
                sinir++;
            }
            else
            {
                pb_oyuncu.Top += pb_oyuncu.Height / 2;
                sinir--;
            }

            if (sinir == 0)
            {
                ziplama.Stop();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 22472)
            {
                pb_oyuncu.Focus();
            }
            if ((e.KeyCode==Keys.W || e.KeyCode==Keys.Space || e.KeyCode==Keys.Up) && ziplama.Enabled==false)
            {
                artis = true;
                sinir = 1;
                ziplama.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ilkX = pb_oyuncu.Left;
            ilkY = pb_oyuncu.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_oyuncu.Location = new Point(ilkX, ilkY);
            pb_oyuncu.Focus();
            ilerleme.Start();
            button1.Enabled = false;
        }


        private void ilerleme_Tick(object sender, EventArgs e)
        {
            if (pb_oyuncu.Left > 775)
            {
                button1.Enabled = true;
                ilerleme.Stop();
                ziplama.Stop();
            }
            else
                pb_oyuncu.Left += pb_oyuncu.Width / 2;



            foreach (Control nesne in this.Controls)
            {
                if (nesne is PictureBox && nesne.Tag.ToString()=="engel")
                {
                    if (nesne.Bounds.IntersectsWith(pb_oyuncu.Bounds))
                    {
                        button1.Enabled = true;
                        ilerleme.Stop();
                        ziplama.Stop();
                    }
                }
            }
        }
    }
}
