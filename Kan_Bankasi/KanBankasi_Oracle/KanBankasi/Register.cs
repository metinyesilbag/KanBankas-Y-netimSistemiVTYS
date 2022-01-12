using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBankasi
{
    public partial class Register : Form
    {
        DBFunctions islem = new DBFunctions();
        ErrorProvider error = new ErrorProvider();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtTcNo.MaxLength = 11;
            txtCepNo.MaxLength = 10;
            txtSifre.PasswordChar = '*';
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtTcNo.Text == "" || txtTcNo.Text.Length != 11 || txtCepNo.Text.Length != 10 || txtKullaniciAd.Text == "" || txtKullaniciSoyad.Text == "" || txtDogumTarih.Text == "" || comboCinsiyet.Text == "" ||
                txtCepNo.Text == "" || txtPosta.Text == "" || txtSifre.Text == "" || txtIsyeri.Text == "" || txtSehir.Text == "" || txtIlce.Text == "" || 
                txtAdres.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sorgu = "insert into Kullanicilar (tcNo, ad, soyad, dogumTarihi, cinsiyet, cepNo, ePosta, sifre, isyeriAdi, sehir, ilce, adres)" +
                    "values ('" + txtTcNo.Text + "', '" + txtKullaniciAd.Text + "', '" + txtKullaniciSoyad.Text + "', '" +txtDogumTarih.Text+ "', '" +comboCinsiyet.Text+ "'" +
                    " ,'" + txtCepNo.Text + "', '" + txtPosta.Text + "', '" + txtSifre.Text + "', '" + txtIsyeri.Text + "', '" + txtSehir.Text + "', '" + txtIlce.Text + "', '" + txtAdres.Text + "')";

                Boolean control = islem.veriAyarla(sorgu);

                if (control == true)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Veri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAdres.Clear();
                    txtCepNo.Clear();
                    txtDogumTarih.ResetText();
                    txtKullaniciAd.Clear();
                    txtKullaniciSoyad.Clear();
                    txtIlce.Clear();
                    txtPosta.Clear();
                    txtSehir.Clear();
                    txtTcNo.Clear();
                    txtSifre.Clear();
                    txtIsyeri.Clear();
                    comboCinsiyet.SelectedItem = null;
                }
            }

        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTcNo.TextLength < 11 && txtTcNo.TextLength > 0)
            {
                error.SetError(txtTcNo, "TC Kimlik Numarası 11 haneli olmalı!!");
            }
            else
                error.Clear();
        }

        private void txtCepNo_TextChanged(object sender, EventArgs e)
        {
            if (txtCepNo.TextLength < 10 && txtCepNo.TextLength > 0)
            {
                error.SetError(txtCepNo, "Başında 0 olmadan giriniz.");
            }
            else
                error.Clear();
        }


        private void sadeceHarf(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void sadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
