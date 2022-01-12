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
    public partial class UpdateDonor : Form
    {
        DBFunctions islem = new DBFunctions();
        ErrorProvider error = new ErrorProvider();
        public UpdateDonor()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDonorAra_Click(object sender, EventArgs e)
        {
            if (txtDonorNo.Text != "")
            {
                String sorgu = "select * from Donorler where donorNo = " + txtDonorNo.Text + " ";
                DataSet ds = islem.veriyiAl(sorgu);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtTcNo.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDonorAd.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtDonorSoyad.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDogumTarih.Text = ds.Tables[0].Rows[0][4].ToString();
                    comboCinsiyet.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCepNo.Text = ds.Tables[0].Rows[0][6].ToString();
                    comboKanGrubu.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtPosta.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtSehir.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtIlce.Text = ds.Tables[0].Rows[0][10].ToString();
                    txtAdres.Text = ds.Tables[0].Rows[0][11].ToString();
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanıcı kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void btnDonorGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtCepNo.Text == "" || txtDogumTarih.Text == "" || txtDonorAd.Text == "" ||
                txtDonorNo.Text == "" || txtDonorSoyad.Text == "" || txtIlce.Text == "" || txtPosta.Text == "" ||
                txtSehir.Text == "" || txtTcNo.Text == "" || comboCinsiyet.Text == "" || comboKanGrubu.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sorgu = "update Donorler set tcNo = '" + txtTcNo.Text + "', ad = '" + txtDonorAd.Text + "', soyad = '" + txtDonorSoyad.Text + "', dogumTarihi = '" + txtDogumTarih.Text + "'," +
                " cinsiyet = '" + comboCinsiyet.Text + "', cepNo = '" + txtCepNo.Text + "', kanGrubu = '" + comboKanGrubu.Text + "', ePosta = '" + txtPosta.Text + "', sehir = '" + txtSehir.Text + "', ilce = '" + txtIlce.Text + "'," +
                " adres = '" + txtAdres.Text + "' where donorNo = " + txtDonorNo.Text + " ";
                Boolean control = islem.veriAyarla(sorgu);
                if (control)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Veri Kaydı Güncellemesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }


        }


        private void temizle()
        {
            txtAdres.Clear();
            txtCepNo.Clear();
            txtDogumTarih.ResetText();
            txtDonorAd.Clear();
            txtDonorNo.Clear();
            txtDonorSoyad.Clear();
            txtIlce.Clear();
            txtPosta.Clear();
            txtSehir.Clear();
            txtTcNo.Clear();
            comboCinsiyet.SelectedItem = null;
            comboKanGrubu.SelectedItem = null;
        }
        private void txtDonorNo_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorNo.Text == "")
            {
                temizle();
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

        private void UpdateDonor_Load(object sender, EventArgs e)
        {
            txtTcNo.MaxLength = 11;
            txtCepNo.MaxLength = 10;
           
        }
    }
}
