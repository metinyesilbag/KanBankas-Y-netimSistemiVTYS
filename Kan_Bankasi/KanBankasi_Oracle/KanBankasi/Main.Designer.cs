
namespace KanBankasi
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.donorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniDonörEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donörSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donörBilgileriniGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütünDonörBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanGrubuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütünStokBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepteBulunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepleriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talepDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Brown;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donorToolStripMenuItem,
            this.seachToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.talepİşlemleriToolStripMenuItem,
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1750, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // donorToolStripMenuItem
            // 
            this.donorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniDonörEkleToolStripMenuItem,
            this.donörSilToolStripMenuItem,
            this.donörBilgileriniGüncelleToolStripMenuItem,
            this.bütünDonörBilgileriToolStripMenuItem});
            this.donorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donorToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.donorToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.Donor;
            this.donorToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donorToolStripMenuItem.Name = "donorToolStripMenuItem";
            this.donorToolStripMenuItem.Size = new System.Drawing.Size(135, 54);
            this.donorToolStripMenuItem.Text = "Donör";
            // 
            // yeniDonörEkleToolStripMenuItem
            // 
            this.yeniDonörEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniDonörEkleToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.plus;
            this.yeniDonörEkleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.yeniDonörEkleToolStripMenuItem.Name = "yeniDonörEkleToolStripMenuItem";
            this.yeniDonörEkleToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.yeniDonörEkleToolStripMenuItem.Text = "Yeni Donör Ekle";
            this.yeniDonörEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniDonörEkleToolStripMenuItem_Click);
            // 
            // donörSilToolStripMenuItem
            // 
            this.donörSilToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donörSilToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.minus;
            this.donörSilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donörSilToolStripMenuItem.Name = "donörSilToolStripMenuItem";
            this.donörSilToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.donörSilToolStripMenuItem.Text = "Donör Sil";
            this.donörSilToolStripMenuItem.Click += new System.EventHandler(this.donörSilToolStripMenuItem_Click);
            // 
            // donörBilgileriniGüncelleToolStripMenuItem
            // 
            this.donörBilgileriniGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.donörBilgileriniGüncelleToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.update;
            this.donörBilgileriniGüncelleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.donörBilgileriniGüncelleToolStripMenuItem.Name = "donörBilgileriniGüncelleToolStripMenuItem";
            this.donörBilgileriniGüncelleToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.donörBilgileriniGüncelleToolStripMenuItem.Text = "Donör Bilgilerini Güncelle";
            this.donörBilgileriniGüncelleToolStripMenuItem.Click += new System.EventHandler(this.donörBilgileriniGüncelleToolStripMenuItem_Click);
            // 
            // bütünDonörBilgileriToolStripMenuItem
            // 
            this.bütünDonörBilgileriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bütünDonörBilgileriToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.blood_donor_card;
            this.bütünDonörBilgileriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bütünDonörBilgileriToolStripMenuItem.Name = "bütünDonörBilgileriToolStripMenuItem";
            this.bütünDonörBilgileriToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.bütünDonörBilgileriToolStripMenuItem.Text = "Bütün Donör Bilgileri";
            this.bütünDonörBilgileriToolStripMenuItem.Click += new System.EventHandler(this.bütünDonörBilgileriToolStripMenuItem_Click);
            // 
            // seachToolStripMenuItem
            // 
            this.seachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adresToolStripMenuItem,
            this.kanGrubuToolStripMenuItem});
            this.seachToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seachToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.seachToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.find;
            this.seachToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.seachToolStripMenuItem.Name = "seachToolStripMenuItem";
            this.seachToolStripMenuItem.Size = new System.Drawing.Size(203, 54);
            this.seachToolStripMenuItem.Text = "Donör Arama";
            // 
            // adresToolStripMenuItem
            // 
            this.adresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adresToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.location;
            this.adresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adresToolStripMenuItem.Name = "adresToolStripMenuItem";
            this.adresToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.adresToolStripMenuItem.Text = "Adres";
            this.adresToolStripMenuItem.Click += new System.EventHandler(this.adresToolStripMenuItem_Click);
            // 
            // kanGrubuToolStripMenuItem
            // 
            this.kanGrubuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kanGrubuToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.blood;
            this.kanGrubuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.kanGrubuToolStripMenuItem.Name = "kanGrubuToolStripMenuItem";
            this.kanGrubuToolStripMenuItem.Size = new System.Drawing.Size(190, 38);
            this.kanGrubuToolStripMenuItem.Text = "Kan Grubu";
            this.kanGrubuToolStripMenuItem.Click += new System.EventHandler(this.kanGrubuToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arttırToolStripMenuItem,
            this.azaltToolStripMenuItem,
            this.bütünStokBilgileriToolStripMenuItem});
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.deleteToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.refrigerator;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 54);
            this.deleteToolStripMenuItem.Text = "Stok";
            // 
            // arttırToolStripMenuItem
            // 
            this.arttırToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arttırToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.Up_Arrow_32px;
            this.arttırToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.arttırToolStripMenuItem.Name = "arttırToolStripMenuItem";
            this.arttırToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.arttırToolStripMenuItem.Text = "Arttır";
            this.arttırToolStripMenuItem.Click += new System.EventHandler(this.arttırToolStripMenuItem_Click);
            // 
            // azaltToolStripMenuItem
            // 
            this.azaltToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.azaltToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.Down_Arrow_32px;
            this.azaltToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.azaltToolStripMenuItem.Name = "azaltToolStripMenuItem";
            this.azaltToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.azaltToolStripMenuItem.Text = "Azalt";
            this.azaltToolStripMenuItem.Click += new System.EventHandler(this.azaltToolStripMenuItem_Click);
            // 
            // bütünStokBilgileriToolStripMenuItem
            // 
            this.bütünStokBilgileriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bütünStokBilgileriToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.blood_donor_card;
            this.bütünStokBilgileriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bütünStokBilgileriToolStripMenuItem.Name = "bütünStokBilgileriToolStripMenuItem";
            this.bütünStokBilgileriToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.bütünStokBilgileriToolStripMenuItem.Text = "Bütün Stok Bilgileri";
            this.bütünStokBilgileriToolStripMenuItem.Click += new System.EventHandler(this.bütünStokBilgileriToolStripMenuItem_Click);
            // 
            // talepİşlemleriToolStripMenuItem
            // 
            this.talepİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.talepteBulunToolStripMenuItem,
            this.talepleriGörüntüleToolStripMenuItem,
            this.talepDurumuToolStripMenuItem});
            this.talepİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepİşlemleriToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.hand_50;
            this.talepİşlemleriToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.talepİşlemleriToolStripMenuItem.Name = "talepİşlemleriToolStripMenuItem";
            this.talepİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(213, 54);
            this.talepİşlemleriToolStripMenuItem.Text = "Talep İşlemleri";
            // 
            // talepteBulunToolStripMenuItem
            // 
            this.talepteBulunToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepteBulunToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.hand_req_32px;
            this.talepteBulunToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.talepteBulunToolStripMenuItem.Name = "talepteBulunToolStripMenuItem";
            this.talepteBulunToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.talepteBulunToolStripMenuItem.Text = "Talepte Bulun";
            this.talepteBulunToolStripMenuItem.Click += new System.EventHandler(this.talepteBulunToolStripMenuItem_Click);
            // 
            // talepleriGörüntüleToolStripMenuItem
            // 
            this.talepleriGörüntüleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepleriGörüntüleToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.medical_folder_32px;
            this.talepleriGörüntüleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.talepleriGörüntüleToolStripMenuItem.Name = "talepleriGörüntüleToolStripMenuItem";
            this.talepleriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.talepleriGörüntüleToolStripMenuItem.Text = "Talepleri İncele";
            this.talepleriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.talepleriGörüntüleToolStripMenuItem_Click);
            // 
            // talepDurumuToolStripMenuItem
            // 
            this.talepDurumuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talepDurumuToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.blood_history_32px;
            this.talepDurumuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.talepDurumuToolStripMenuItem.Name = "talepDurumuToolStripMenuItem";
            this.talepDurumuToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.talepDurumuToolStripMenuItem.Text = "Talep Durumu ve Geçmişi";
            this.talepDurumuToolStripMenuItem.Click += new System.EventHandler(this.talepDurumuToolStripMenuItem_Click);
            // 
            // sağlıkÇalışanıDetaylarıToolStripMenuItem
            // 
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.blood_donor_card_50;
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Name = "sağlıkÇalışanıDetaylarıToolStripMenuItem";
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Size = new System.Drawing.Size(251, 54);
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Text = "Kullanıcı Detayları";
            this.sağlıkÇalışanıDetaylarıToolStripMenuItem.Click += new System.EventHandler(this.sağlıkÇalışanıDetaylarıToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.logoutToolStripMenuItem.Image = global::KanBankasi.Properties.Resources.logout_50;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(120, 54);
            this.logoutToolStripMenuItem.Text = "Çıkış";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KanBankasi.Properties.Resources.home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1750, 1024);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniDonörEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donörSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donörBilgileriniGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütünDonörBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanGrubuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütünStokBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talepİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talepDurumuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sağlıkÇalışanıDetaylarıToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem donorToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem seachToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem talepleriGörüntüleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem talepteBulunToolStripMenuItem;
    }
}