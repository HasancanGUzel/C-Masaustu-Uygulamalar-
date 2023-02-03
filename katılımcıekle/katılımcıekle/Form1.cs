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
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[15] { "Ahmet", "Mehmet", "Aydın", "Can", "Mert", "Kürşat", "Fatma", "Ayşe", "Selda", "Neşe", "Muzaffer", "Murat", "Nazlı", "Mahmut", "Hasan" };
        private void secilensıra_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            string[] sec=listBox1.SelectedItems.OfType<string>().ToArray();
            

            foreach (string ekle in sec )
            {
                listBox2.Items.Add(ekle);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            
           
        }

        private void hepsisıra_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Items.AddRange(isimler);        
        }

        private void hepsigeri_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(isimler);
        }

        private void secilengeri_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] sec = listBox2.SelectedItems.OfType<string>().ToArray();


            foreach (string ekle in sec)
            {
                listBox1.Items.Add(ekle);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void katılımincele_Click(object sender, EventArgs e)
        {
           
            Form2 frm = new Form2();
            frm.lst_katılımcı.Items.AddRange(listBox2.Items);
            frm.Show();
            this.Hide();
          

           

        }
    }
}
