using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBP_NO_ArabaYarisi
{
    public partial class Form1 : Form
    {
        public class Yarisci
        {
            public Yarisci(string yarisci, double zaman)
            {
                YarisciAdi = yarisci;
                Zaman = zaman;
            }
            public string YarisciAdi { get; }
            public double Zaman { get; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        int ilkYer;
        double sure=0,sy1,sy2,sy3;
        bool y1=false, y2=false, y3=false;
        string[] siralama = new string[] { "Araba1", "Araba2", "Araba3" };
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_araba1.Right > pb_bayrak.Left && pb_araba2.Right > pb_bayrak.Left && pb_araba3.Right > pb_bayrak.Left)
            {
                timer1.Stop();
                button1.Enabled = true;
                var arabalar = new List<Yarisci>();
                arabalar.Add(new Yarisci(pb_araba1.Tag.ToString(), sy1));
                arabalar.Add(new Yarisci(pb_araba2.Tag.ToString(), sy2));
                arabalar.Add(new Yarisci(pb_araba3.Tag.ToString(), sy3));

                var siralama = arabalar.OrderBy(x => x.Zaman).ToList();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Yarış bitti, kazanan:" + siralama[0].YarisciAdi);
                sb.AppendLine("----Yarış Sıralaması----");
                foreach (var item in siralama)
                {
                    sb.AppendLine(String.Join("-", item.YarisciAdi, item.Zaman + " saniye"));
                    
                }

                MessageBox.Show(sb.ToString(),"Yarış Sonucu");

            }
            sure += 0.1;
            Random rastgele = new Random();

            pb_araba1.Left += rastgele.Next(3, 15);
            pb_araba2.Left += rastgele.Next(3, 15);
            pb_araba3.Left += rastgele.Next(3, 15);
            
            

            if (pb_araba1.Right > pb_bayrak.Left && y1==false)
            {
                sy1 = Math.Round(sure,3);
                y1 = true;
            }
            if (pb_araba2.Right > pb_bayrak.Left && y2 == false)
            {
                sy2 = Math.Round(sure, 3);
                y2 = true;
            }
            if (pb_araba3.Right > pb_bayrak.Left && y3 == false)
            {
                sy3 = Math.Round(sure, 3);
                y3 = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ilkYer = pb_araba1.Location.X;


         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_araba1.Left = ilkYer;
            pb_araba2.Left = ilkYer;
            pb_araba3.Left = ilkYer;

           
            timer1.Start();
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }
    }

}
