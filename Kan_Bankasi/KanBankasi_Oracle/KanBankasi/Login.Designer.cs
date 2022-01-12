
namespace KanBankasi
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKayit = new System.Windows.Forms.Label();
            this.radioBtnKullanici = new System.Windows.Forms.RadioButton();
            this.radioBtnYonetici = new System.Windows.Forms.RadioButton();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblKapat = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(143)))));
            this.panel1.Controls.Add(this.lblKayit);
            this.panel1.Controls.Add(this.radioBtnKullanici);
            this.panel1.Controls.Add(this.radioBtnYonetici);
            this.panel1.Controls.Add(this.lblUyari);
            this.panel1.Controls.Add(this.lblKapat);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 537);
            this.panel1.TabIndex = 1;
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.ForeColor = System.Drawing.Color.White;
            this.lblKayit.Location = new System.Drawing.Point(215, 431);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(82, 22);
            this.lblKayit.TabIndex = 14;
            this.lblKayit.Text = "Kayıt Ol";
            this.lblKayit.Click += new System.EventHandler(this.lblKayit_Click);
            this.lblKayit.MouseEnter += new System.EventHandler(this.lblKayit_MouseEnter);
            this.lblKayit.MouseLeave += new System.EventHandler(this.lblKayit_MouseLeave);
            // 
            // radioBtnKullanici
            // 
            this.radioBtnKullanici.AutoSize = true;
            this.radioBtnKullanici.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnKullanici.Location = new System.Drawing.Point(385, 55);
            this.radioBtnKullanici.Name = "radioBtnKullanici";
            this.radioBtnKullanici.Size = new System.Drawing.Size(109, 28);
            this.radioBtnKullanici.TabIndex = 13;
            this.radioBtnKullanici.Text = "Kullanıcı";
            this.radioBtnKullanici.UseVisualStyleBackColor = true;
            // 
            // radioBtnYonetici
            // 
            this.radioBtnYonetici.AutoSize = true;
            this.radioBtnYonetici.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnYonetici.Location = new System.Drawing.Point(385, 21);
            this.radioBtnYonetici.Name = "radioBtnYonetici";
            this.radioBtnYonetici.Size = new System.Drawing.Size(100, 28);
            this.radioBtnYonetici.TabIndex = 12;
            this.radioBtnYonetici.TabStop = true;
            this.radioBtnYonetici.Text = "Yönetici";
            this.radioBtnYonetici.UseVisualStyleBackColor = true;
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUyari.Location = new System.Drawing.Point(128, 325);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(273, 23);
            this.lblUyari.TabIndex = 11;
            this.lblUyari.Text = "Kullanıcı Adı veya Şifre Yanlış";
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.White;
            this.lblKapat.Location = new System.Drawing.Point(228, 474);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(56, 22);
            this.lblKapat.TabIndex = 10;
            this.lblKapat.Text = "Çıkış";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click_1);
            this.lblKapat.MouseEnter += new System.EventHandler(this.lblKapat_MouseEnter);
            this.lblKapat.MouseLeave += new System.EventHandler(this.lblKapat_MouseLeave);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(143)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.HideSelection = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(143, 174);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(273, 23);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.TabStop = false;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KanBankasi.Properties.Resources.customer_32px;
            this.pictureBox3.Location = new System.Drawing.Point(92, 165);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(92, 203);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 2);
            this.panel3.TabIndex = 8;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(143)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.HideSelection = false;
            this.txtSifre.Location = new System.Drawing.Point(143, 276);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(273, 23);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.TabStop = false;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Click += new System.EventHandler(this.txtSifre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KanBankasi.Properties.Resources.password_32px;
            this.pictureBox2.Location = new System.Drawing.Point(92, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(92, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 2);
            this.panel2.TabIndex = 5;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(143)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(164, 365);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(185, 48);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.TabStop = false;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KanBankasi.Properties.Resources.blood_bank;
            this.pictureBox1.Location = new System.Drawing.Point(191, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(213)))), ((int)(((byte)(216)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 537);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.RadioButton radioBtnKullanici;
        private System.Windows.Forms.RadioButton radioBtnYonetici;
        private System.Windows.Forms.Label lblKayit;
    }
}

