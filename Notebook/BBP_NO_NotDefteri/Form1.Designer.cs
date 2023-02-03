namespace BBP_NO_NotDefteri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lbl_CapsLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_NumLock = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_yeni = new System.Windows.Forms.ToolStripButton();
            this.btn_ac = new System.Windows.Forms.ToolStripButton();
            this.btn_solaHizala = new System.Windows.Forms.ToolStripButton();
            this.btn_ortayaHizala = new System.Windows.Forms.ToolStripButton();
            this.btn_sagaHizala = new System.Windows.Forms.ToolStripButton();
            this.btn_geri = new System.Windows.Forms.ToolStripButton();
            this.btn_ileri = new System.Windows.Forms.ToolStripButton();
            this.btn_renk = new System.Windows.Forms.ToolStripButton();
            this.btn_font = new System.Windows.Forms.ToolStripButton();
            this.btn_kalin = new System.Windows.Forms.ToolStripButton();
            this.btn_italik = new System.Windows.Forms.ToolStripButton();
            this.btn_altiCizili = new System.Windows.Forms.ToolStripButton();
            this.btn_kes = new System.Windows.Forms.ToolStripButton();
            this.btn_kopyala = new System.Windows.Forms.ToolStripButton();
            this.btn_yapistir = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farklıKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.richTextBox1.Location = new System.Drawing.Point(0, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(799, 395);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_CapsLock,
            this.lbl_NumLock,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(798, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_yeni,
            this.btn_ac,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.btn_solaHizala,
            this.btn_ortayaHizala,
            this.btn_sagaHizala,
            this.toolStripSeparator2,
            this.btn_geri,
            this.btn_ileri,
            this.toolStripSeparator3,
            this.btn_renk,
            this.btn_font,
            this.toolStripSeparator4,
            this.btn_kalin,
            this.btn_italik,
            this.btn_altiCizili,
            this.toolStripSeparator5,
            this.btn_kes,
            this.btn_kopyala,
            this.btn_yapistir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // lbl_CapsLock
            // 
            this.lbl_CapsLock.Name = "lbl_CapsLock";
            this.lbl_CapsLock.Size = new System.Drawing.Size(151, 20);
            this.lbl_CapsLock.Text = "toolStripStatusLabel1";
            // 
            // lbl_NumLock
            // 
            this.lbl_NumLock.Name = "lbl_NumLock";
            this.lbl_NumLock.Size = new System.Drawing.Size(151, 20);
            this.lbl_NumLock.Text = "toolStripStatusLabel2";
            // 
            // btn_yeni
            // 
            this.btn_yeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_yeni.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Flatastic_10_New_file1;
            this.btn_yeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(29, 24);
            this.btn_yeni.Text = "toolStripButton1";
            // 
            // btn_ac
            // 
            this.btn_ac.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ac.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_9_Open_file;
            this.btn_ac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(29, 24);
            this.btn_ac.Text = "toolStripButton2";
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_solaHizala
            // 
            this.btn_solaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_solaHizala.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Text_align_left;
            this.btn_solaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_solaHizala.Name = "btn_solaHizala";
            this.btn_solaHizala.Size = new System.Drawing.Size(29, 24);
            this.btn_solaHizala.Text = "toolStripButton4";
            this.btn_solaHizala.Click += new System.EventHandler(this.btn_solaHizala_Click);
            // 
            // btn_ortayaHizala
            // 
            this.btn_ortayaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ortayaHizala.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Text_align_center;
            this.btn_ortayaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ortayaHizala.Name = "btn_ortayaHizala";
            this.btn_ortayaHizala.Size = new System.Drawing.Size(29, 24);
            this.btn_ortayaHizala.Text = "toolStripButton5";
            this.btn_ortayaHizala.Click += new System.EventHandler(this.btn_ortayaHizala_Click);
            // 
            // btn_sagaHizala
            // 
            this.btn_sagaHizala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sagaHizala.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Text_align_right;
            this.btn_sagaHizala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sagaHizala.Name = "btn_sagaHizala";
            this.btn_sagaHizala.Size = new System.Drawing.Size(29, 24);
            this.btn_sagaHizala.Text = "toolStripButton6";
            this.btn_sagaHizala.Click += new System.EventHandler(this.btn_sagaHizala_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_geri.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Flatastic_9_Undo;
            this.btn_geri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(29, 24);
            this.btn_geri.Text = "toolStripButton7";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_ileri
            // 
            this.btn_ileri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ileri.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Flatastic_9_Undo___Kopya;
            this.btn_ileri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ileri.Name = "btn_ileri";
            this.btn_ileri.Size = new System.Drawing.Size(29, 24);
            this.btn_ileri.Text = "toolStripButton8";
            this.btn_ileri.Click += new System.EventHandler(this.btn_ileri_Click);
            // 
            // btn_renk
            // 
            this.btn_renk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_renk.Image = global::BBP_NO_NotDefteri.Properties.Resources.Itzikgur_My_Seven_Graphics_Painting;
            this.btn_renk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(29, 24);
            this.btn_renk.Text = "toolStripButton9";
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // btn_font
            // 
            this.btn_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_font.Image = global::BBP_NO_NotDefteri.Properties.Resources.Arkangl300_Methodic_Folders_Remix_Fonts;
            this.btn_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(29, 24);
            this.btn_font.Text = "toolStripButton10";
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // btn_kalin
            // 
            this.btn_kalin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_kalin.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_Text_bold;
            this.btn_kalin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_kalin.Name = "btn_kalin";
            this.btn_kalin.Size = new System.Drawing.Size(29, 24);
            this.btn_kalin.Text = "toolStripButton11";
            this.btn_kalin.Click += new System.EventHandler(this.btn_kalin_Click);
            // 
            // btn_italik
            // 
            this.btn_italik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_italik.Image = global::BBP_NO_NotDefteri.Properties.Resources.Icons8_Windows_8_Editing_Italic;
            this.btn_italik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_italik.Name = "btn_italik";
            this.btn_italik.Size = new System.Drawing.Size(29, 24);
            this.btn_italik.Text = "toolStripButton12";
            this.btn_italik.Click += new System.EventHandler(this.btn_italik_Click);
            // 
            // btn_altiCizili
            // 
            this.btn_altiCizili.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_altiCizili.Image = global::BBP_NO_NotDefteri.Properties.Resources.Icons8_Ios7_Editing_Underline;
            this.btn_altiCizili.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_altiCizili.Name = "btn_altiCizili";
            this.btn_altiCizili.Size = new System.Drawing.Size(29, 24);
            this.btn_altiCizili.Text = "toolStripButton13";
            this.btn_altiCizili.Click += new System.EventHandler(this.btn_altiCizili_Click);
            // 
            // btn_kes
            // 
            this.btn_kes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_kes.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Flatastic_1_Cut;
            this.btn_kes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_kes.Name = "btn_kes";
            this.btn_kes.Size = new System.Drawing.Size(29, 24);
            this.btn_kes.Text = "toolStripButton14";
            this.btn_kes.Click += new System.EventHandler(this.btn_kes_Click);
            // 
            // btn_kopyala
            // 
            this.btn_kopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_kopyala.Image = global::BBP_NO_NotDefteri.Properties.Resources.Hopstarter_Soft_Scraps_Document_Copy;
            this.btn_kopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_kopyala.Name = "btn_kopyala";
            this.btn_kopyala.Size = new System.Drawing.Size(29, 24);
            this.btn_kopyala.Text = "toolStripButton15";
            this.btn_kopyala.Click += new System.EventHandler(this.btn_kopyala_Click);
            // 
            // btn_yapistir
            // 
            this.btn_yapistir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_yapistir.Image = global::BBP_NO_NotDefteri.Properties.Resources.Hopstarter_Soft_Scraps_Clipboard_Paste;
            this.btn_yapistir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_yapistir.Name = "btn_yapistir";
            this.btn_yapistir.Size = new System.Drawing.Size(29, 24);
            this.btn_yapistir.Text = "toolStripButton16";
            this.btn_yapistir.Click += new System.EventHandler(this.btn_yapistir_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.fontDialog1.MaxSize = 40;
            this.fontDialog1.MinSize = 20;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowColor = true;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Metin Dosyaları\" | *.txt| \"Zengin Metin Dosyası\" | *.rtf";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Metin Dosyaları\" | *.txt| \"Zengin Metin Dosyası\" | *.rtf";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.farklıKaydetToolStripMenuItem});
            this.toolStripButton3.Image = global::BBP_NO_NotDefteri.Properties.Resources.Custom_Icon_Design_Pretty_Office_7_Save_as;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // farklıKaydetToolStripMenuItem
            // 
            this.farklıKaydetToolStripMenuItem.Name = "farklıKaydetToolStripMenuItem";
            this.farklıKaydetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.farklıKaydetToolStripMenuItem.Text = "Farklı Kaydet";
            this.farklıKaydetToolStripMenuItem.Click += new System.EventHandler(this.farklıKaydetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_CapsLock;
        private System.Windows.Forms.ToolStripStatusLabel lbl_NumLock;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_yeni;
        private System.Windows.Forms.ToolStripButton btn_ac;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_solaHizala;
        private System.Windows.Forms.ToolStripButton btn_ortayaHizala;
        private System.Windows.Forms.ToolStripButton btn_sagaHizala;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_geri;
        private System.Windows.Forms.ToolStripButton btn_ileri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_renk;
        private System.Windows.Forms.ToolStripButton btn_font;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btn_kalin;
        private System.Windows.Forms.ToolStripButton btn_italik;
        private System.Windows.Forms.ToolStripButton btn_altiCizili;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btn_kes;
        private System.Windows.Forms.ToolStripButton btn_kopyala;
        private System.Windows.Forms.ToolStripButton btn_yapistir;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farklıKaydetToolStripMenuItem;
    }
}

