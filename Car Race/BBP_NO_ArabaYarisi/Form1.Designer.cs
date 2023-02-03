namespace BBP_NO_ArabaYarisi
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_bayrak = new System.Windows.Forms.PictureBox();
            this.pb_araba1 = new System.Windows.Forms.PictureBox();
            this.pb_araba2 = new System.Windows.Forms.PictureBox();
            this.pb_araba3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bayrak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pb_bayrak
            // 
            this.pb_bayrak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_bayrak.Image = global::BBP_NO_ArabaYarisi.Properties.Resources._1200px_F1_chequered_flag_svg;
            this.pb_bayrak.Location = new System.Drawing.Point(624, 1);
            this.pb_bayrak.Name = "pb_bayrak";
            this.pb_bayrak.Size = new System.Drawing.Size(50, 205);
            this.pb_bayrak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bayrak.TabIndex = 1;
            this.pb_bayrak.TabStop = false;
            // 
            // pb_araba1
            // 
            this.pb_araba1.Image = global::BBP_NO_ArabaYarisi.Properties.Resources.Concept_Car;
            this.pb_araba1.Location = new System.Drawing.Point(12, 12);
            this.pb_araba1.Name = "pb_araba1";
            this.pb_araba1.Size = new System.Drawing.Size(100, 50);
            this.pb_araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_araba1.TabIndex = 2;
            this.pb_araba1.TabStop = false;
            this.pb_araba1.Tag = "Araba 1";
            // 
            // pb_araba2
            // 
            this.pb_araba2.Image = global::BBP_NO_ArabaYarisi.Properties.Resources.Concept_Car_Free_Download_PNG;
            this.pb_araba2.Location = new System.Drawing.Point(12, 79);
            this.pb_araba2.Name = "pb_araba2";
            this.pb_araba2.Size = new System.Drawing.Size(100, 50);
            this.pb_araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_araba2.TabIndex = 3;
            this.pb_araba2.TabStop = false;
            this.pb_araba2.Tag = "Araba 2";
            // 
            // pb_araba3
            // 
            this.pb_araba3.Image = global::BBP_NO_ArabaYarisi.Properties.Resources.Concept_Car_PNG_Image;
            this.pb_araba3.Location = new System.Drawing.Point(12, 146);
            this.pb_araba3.Name = "pb_araba3";
            this.pb_araba3.Size = new System.Drawing.Size(100, 50);
            this.pb_araba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_araba3.TabIndex = 4;
            this.pb_araba3.TabStop = false;
            this.pb_araba3.Tag = "Araba 3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(680, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 204);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pb_araba3);
            this.Controls.Add(this.pb_araba2);
            this.Controls.Add(this.pb_araba1);
            this.Controls.Add(this.pb_bayrak);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_bayrak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_araba3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_bayrak;
        private System.Windows.Forms.PictureBox pb_araba1;
        private System.Windows.Forms.PictureBox pb_araba2;
        private System.Windows.Forms.PictureBox pb_araba3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

