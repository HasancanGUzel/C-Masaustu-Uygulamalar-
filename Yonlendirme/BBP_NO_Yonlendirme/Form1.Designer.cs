namespace BBP_NO_Yonlendirme
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_okcu = new System.Windows.Forms.Button();
            this.pb_sovalye = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sovalye)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Şovalyeyi Yönet",
            "Okçuyu Yönet"});
            this.comboBox1.Location = new System.Drawing.Point(667, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_okcu
            // 
            this.btn_okcu.BackColor = System.Drawing.Color.Transparent;
            this.btn_okcu.FlatAppearance.BorderSize = 0;
            this.btn_okcu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_okcu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_okcu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okcu.Image = global::BBP_NO_Yonlendirme.Properties.Resources.okcu;
            this.btn_okcu.Location = new System.Drawing.Point(0, 60);
            this.btn_okcu.Name = "btn_okcu";
            this.btn_okcu.Size = new System.Drawing.Size(50, 60);
            this.btn_okcu.TabIndex = 1;
            this.btn_okcu.TabStop = false;
            this.btn_okcu.UseVisualStyleBackColor = false;
            this.btn_okcu.Click += new System.EventHandler(this.btn_okcu_Click);
            this.btn_okcu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_okcu_KeyDown);
            // 
            // pb_sovalye
            // 
            this.pb_sovalye.BackColor = System.Drawing.Color.Transparent;
            this.pb_sovalye.Image = global::BBP_NO_Yonlendirme.Properties.Resources.birim;
            this.pb_sovalye.Location = new System.Drawing.Point(0, 0);
            this.pb_sovalye.Name = "pb_sovalye";
            this.pb_sovalye.Size = new System.Drawing.Size(50, 60);
            this.pb_sovalye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_sovalye.TabIndex = 0;
            this.pb_sovalye.TabStop = false;
            this.pb_sovalye.Click += new System.EventHandler(this.pb_sovalye_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BBP_NO_Yonlendirme.Properties.Resources.çimen;
            this.ClientSize = new System.Drawing.Size(839, 306);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_okcu);
            this.Controls.Add(this.pb_sovalye);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_sovalye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_sovalye;
        private System.Windows.Forms.Button btn_okcu;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

