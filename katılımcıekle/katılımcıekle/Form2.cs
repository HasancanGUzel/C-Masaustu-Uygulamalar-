using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katılımcıekle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int gelenkisisayisi = lst_katılımcı.Items.Count;
            lbl_kisisayısı.Text = gelenkisisayisi.ToString();       
            if (gelenkisisayisi < 5)
            {
                pictureBox1.BackColor = Color.Red;
            }

            else if (gelenkisisayisi >= 5 && gelenkisisayisi <= 10)
            {
                pictureBox1.BackColor = Color.Orange;
            }

           else if (gelenkisisayisi > 10)
            {
                pictureBox1.BackColor = Color.Green;
            }
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gelenkisisayisi = lst_katılımcı.Items.Count;
            if (gelenkisisayisi < 5)
            {
                MessageBox.Show("Katılım oranı çok azdır");
            }

            else if (gelenkisisayisi >= 5 && gelenkisisayisi <= 10)
            { 
                MessageBox.Show("Katılım oranı orta düzeydedir");
            }

            else if (gelenkisisayisi > 10)
            {
                MessageBox.Show("Katılımcı oranı yeterlidir");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
