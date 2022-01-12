using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace KanBankasi
{
    public partial class Login : Form
    {

        DBFunctions islem = new DBFunctions();


        public Login()
        {
            InitializeComponent();
            
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
            txtSifre.PasswordChar = '*';

        }

        private void lblKapat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKapat_MouseEnter(object sender, EventArgs e)
        {
            lblKapat.ForeColor = System.Drawing.Color.FromArgb(75, 31, 62);
        }

        private void lblKapat_MouseLeave(object sender, EventArgs e)
        {
            lblKapat.ForeColor = Color.White;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblUyari.Visible = false;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (radioBtnYonetici.Checked == true)
            {

                String sorgu = "select * from Yoneticiler where kullaniciAdi = :p1 and sifre = :p2 ";

                OracleConnection con = islem.baglantiyiAl();

                con.Open();
                OracleCommand command = new OracleCommand(sorgu, con);

                command.Parameters.Add(":p1", txtKullaniciAdi.Text);
                command.Parameters.Add(":p2", txtSifre.Text);

                OracleDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    Global.unvan = "Yonetici";
                    Main main = new Main();
                    main.talepteBulunToolStripMenuItem.Visible = false;
                    con.Close();
                    main.Show();
                    this.Hide();
                    
                }
                else
                    lblUyari.Show();
                
            }
            if (radioBtnKullanici.Checked == true)
            {
                String sorgu = "select * from Kullanicilar where ePosta = :p1 and sifre = :p2 ";

                OracleConnection con = islem.baglantiyiAl();

                con.Open();
                OracleCommand command = new OracleCommand(sorgu, con);

                command.Parameters.Add(":p1", txtKullaniciAdi.Text);
                command.Parameters.Add(":p2", txtSifre.Text);

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Main main = new Main();
                    main.sağlıkÇalışanıDetaylarıToolStripMenuItem.Visible = false;
                    main.donorToolStripMenuItem.Visible = false;
                    main.seachToolStripMenuItem.Visible = false;
                    main.deleteToolStripMenuItem.Visible = false;
                    main.talepleriGörüntüleToolStripMenuItem.Visible = false;
                    Global.unvan = "Kullanici";
                    Global.tcAl = reader["tcNo"].ToString();
                    //tcAl = reader.GetString(0);
                    con.Close();
                    main.Show();
                    this.Hide();
                }
                else
                    lblUyari.Show();
            }
 
            
        }

        private void lblKayit_MouseEnter(object sender, EventArgs e)
        {
            lblKayit.ForeColor = System.Drawing.Color.FromArgb(75, 31, 62);
        }

        private void lblKayit_MouseLeave(object sender, EventArgs e)
        {
            lblKayit.ForeColor = Color.White;
        }

        private void lblKayit_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
            
        }
    }

    public static class Global
    {
        public static String tcAl = "";
        public static String unvan = "";
    }
}
