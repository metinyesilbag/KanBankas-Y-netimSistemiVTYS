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
    public partial class DeleteDonor : Form
    {
        DBFunctions islem = new DBFunctions();
        
        public DeleteDonor()
        {
            InitializeComponent();
        }


        private void DeleteDonor_Load(object sender, EventArgs e)
        {
            txtAdres.ReadOnly = true;
            txtCepNo.ReadOnly = true;
            txtDonorAd.ReadOnly = true;
            txtDonorSoyad.ReadOnly = true;
            txtIlce.ReadOnly = true;
            txtPosta.ReadOnly = true;
            txtSehir.ReadOnly = true;
            txtTcNo.ReadOnly = true;
            txtCinsiyet.ReadOnly = true;
            txtKanGrubu.ReadOnly = true;
            txtDogumTarih.Enabled = false;

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
                    txtCinsiyet.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtCepNo.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtKanGrubu.Text = ds.Tables[0].Rows[0][7].ToString();
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAdres.Text == "" || txtCepNo.Text == "" || txtDogumTarih.Text == "" || txtDonorAd.Text == "" ||
            txtDonorNo.Text == "" || txtDonorSoyad.Text == "" || txtIlce.Text == "" || txtPosta.Text == "" ||
            txtSehir.Text == "" || txtTcNo.Text == "" || txtCinsiyet.Text == "" || txtKanGrubu.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Donörü silmek istediğinizden emin misiniz?", "Donör Silme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String sorgu = "delete from Donorler where donorNo = " + txtDonorNo.Text + " ";
                    Boolean control = islem.veriAyarla(sorgu);
                    if (control)
                    {
                        MessageBox.Show("İşlem Başarılıyla gerçekleşti.", "Veri Kaydı Silinmesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        temizle();
                    }
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
            txtCinsiyet.Clear();
            txtKanGrubu.Clear();
        }

        private void txtDonorNo_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorNo.Text == "")
            {
                temizle();
            }
        }

        private void txtDonorNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
