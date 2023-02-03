using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BBP_NO_NotDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaadi="";
        FontStyle yaziStili;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_CapsLock.Text = Console.CapsLock == true ? "CAPS LOCK" : "";
          

            lbl_NumLock.Text = Console.NumberLock ? "NUM LOCK" : "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_CapsLock.Text = Console.CapsLock == true ? "CAPS LOCK" : "";

            lbl_NumLock.Text = Console.NumberLock ? "NUM LOCK" : "";
        }

        public void yaziDegis()
        {
            if(richTextBox1.SelectionLength==0) 
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
            else
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }


        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            yaziDegis();
        }

 
        private void btn_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyaadi = openFileDialog1.FileName;
                StreamReader okuma = new StreamReader(dosyaadi);
                richTextBox1.Text = okuma.ReadToEnd();
                okuma.Dispose();

            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dosyaadi=="")
            {
                farklıKaydetToolStripMenuItem_Click(null, null);
            }

            StreamWriter yazma = new StreamWriter(dosyaadi);
            yazma.Write(richTextBox1.Text);
            yazma.Dispose();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyaadi = saveFileDialog1.FileName;
                kaydetToolStripMenuItem_Click(null,null);
            }
        }

        private void btn_kalin_Click(object sender, EventArgs e)
        {
            yaziStili = yaziStili ^ FontStyle.Bold;

           
            if (richTextBox1.SelectionLength==0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
            

        }

        private void btn_italik_Click(object sender, EventArgs e)
        {
            yaziStili = yaziStili ^ FontStyle.Italic;
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
        }

        private void btn_altiCizili_Click(object sender, EventArgs e)
        {
            yaziStili = yaziStili ^ FontStyle.Underline;
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, yaziStili);
            }
        }

        private void btn_solaHizala_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                richTextBox1.DeselectAll();
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void btn_ortayaHizala_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                richTextBox1.DeselectAll();
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void btn_sagaHizala_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                richTextBox1.DeselectAll();
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void btn_kes_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void btn_kopyala_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btn_yapistir_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btn_renk_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectedText.Length == 0) 
                {
                    richTextBox1.ForeColor = colorDialog1.Color;
                }
                else
                {
                    richTextBox1.SelectionColor = colorDialog1.Color;
                }

            }
        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                yaziDegis();
            }
        }


    }
}
