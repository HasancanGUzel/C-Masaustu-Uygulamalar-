namespace katılımcıekle
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secilensıra = new System.Windows.Forms.Button();
            this.secilengeri = new System.Windows.Forms.Button();
            this.hepsisıra = new System.Windows.Forms.Button();
            this.hepsigeri = new System.Windows.Forms.Button();
            this.katılımincele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Ahmet ",
            "Mehmet",
            "Aydın",
            "Can",
            "Mert",
            "Kürşat",
            "Fatma",
            "Ayşe",
            "Selda",
            "Neşe",
            "Muzaffer",
            "Murat",
            "Nazlı",
            "Mahmut",
            "Hasan"});
            this.listBox1.Location = new System.Drawing.Point(74, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 244);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(456, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(120, 244);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(452, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Katılımcı Listesi";
            // 
            // secilensıra
            // 
            this.secilensıra.Location = new System.Drawing.Point(286, 72);
            this.secilensıra.Name = "secilensıra";
            this.secilensıra.Size = new System.Drawing.Size(75, 23);
            this.secilensıra.TabIndex = 4;
            this.secilensıra.Text = ">";
            this.secilensıra.UseVisualStyleBackColor = false;
            this.secilensıra.Click += new System.EventHandler(this.secilensıra_Click);
            // 
            // secilengeri
            // 
            this.secilengeri.Location = new System.Drawing.Point(286, 139);
            this.secilengeri.Name = "secilengeri";
            this.secilengeri.Size = new System.Drawing.Size(75, 23);
            this.secilengeri.TabIndex = 5;
            this.secilengeri.Text = "<";
            this.secilengeri.UseVisualStyleBackColor = false;
            this.secilengeri.Click += new System.EventHandler(this.secilengeri_Click);
            // 
            // hepsisıra
            // 
            this.hepsisıra.Location = new System.Drawing.Point(286, 206);
            this.hepsisıra.Name = "hepsisıra";
            this.hepsisıra.Size = new System.Drawing.Size(75, 23);
            this.hepsisıra.TabIndex = 6;
            this.hepsisıra.Text = ">>";
            this.hepsisıra.UseVisualStyleBackColor = false;
            this.hepsisıra.Click += new System.EventHandler(this.hepsisıra_Click);
            // 
            // hepsigeri
            // 
            this.hepsigeri.Location = new System.Drawing.Point(286, 273);
            this.hepsigeri.Name = "hepsigeri";
            this.hepsigeri.Size = new System.Drawing.Size(75, 23);
            this.hepsigeri.TabIndex = 7;
            this.hepsigeri.Text = "<<";
            this.hepsigeri.UseVisualStyleBackColor = false;
            this.hepsigeri.Click += new System.EventHandler(this.hepsigeri_Click);
            // 
            // katılımincele
            // 
            this.katılımincele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katılımincele.Location = new System.Drawing.Point(270, 363);
            this.katılımincele.Name = "katılımincele";
            this.katılımincele.Size = new System.Drawing.Size(113, 60);
            this.katılımincele.TabIndex = 8;
            this.katılımincele.Text = "Katılımcıları İncele";
            this.katılımincele.UseVisualStyleBackColor = false;
            this.katılımincele.Click += new System.EventHandler(this.katılımincele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.katılımincele);
            this.Controls.Add(this.hepsigeri);
            this.Controls.Add(this.hepsisıra);
            this.Controls.Add(this.secilengeri);
            this.Controls.Add(this.secilensıra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button secilensıra;
        private System.Windows.Forms.Button secilengeri;
        private System.Windows.Forms.Button hepsisıra;
        private System.Windows.Forms.Button hepsigeri;
        private System.Windows.Forms.Button katılımincele;
        private System.Windows.Forms.ListBox listBox2;
    }
}

