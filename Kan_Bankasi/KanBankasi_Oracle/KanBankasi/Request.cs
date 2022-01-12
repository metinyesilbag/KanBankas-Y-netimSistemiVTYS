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
    public partial class Request : Form
    {

        DBFunctions islem = new DBFunctions();
        public Request()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkA_Arti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkA_Arti.Checked == true)
            {
                txtA_Arti.Enabled = true;
            }
            else
            {
                txtA_Arti.Enabled = false;
                txtA_Arti.Text = "";
            }

        }

        private void checkB_Arti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Arti.Checked == true)
            {
                txtB_Arti.Enabled = true;
            }
            else
            {
                txtB_Arti.Enabled = false;
                txtB_Arti.Text = "";
            }
        }

        private void checkAB_Arti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAB_Arti.Checked == true)
            {
                txtAB_Arti.Enabled = true;
            }
            else
            {
                txtAB_Arti.Enabled = false;
                txtAB_Arti.Text = "";
            }
        }

        private void checkO_Arti_CheckedChanged(object sender, EventArgs e)
        {
            if (checkO_Arti.Checked == true)
            {
                txtO_Arti.Enabled = true;
            }
            else
            {
                txtO_Arti.Enabled = false;
                txtO_Arti.Text = "";
            }
        }

        private void checkA_Eksi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkA_Eksi.Checked == true)
            {
                txtA_Eksi.Enabled = true;
            }
            else
            {
                txtA_Eksi.Enabled = false;
                txtA_Eksi.Text = "";
            }
        }

        private void checkB_Eksi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Eksi.Checked == true)
            {
                txtB_Eksi.Enabled = true;
            }
            else
            {
                txtB_Eksi.Enabled = false;
                txtB_Eksi.Text = "";
            }
        }

        private void checkAB_Eksi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAB_Eksi.Checked == true)
            {
                txtAB_Eksi.Enabled = true;
            }
            else
            {
                txtAB_Eksi.Enabled = false;
                txtAB_Eksi.Text = "";
            }
        }

        private void checkO_Eksi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkO_Eksi.Checked == true)
            {
                txtO_Eksi.Enabled = true;
            }
            else
            {
                txtO_Eksi.Enabled = false;
                txtO_Eksi.Text = "";
            }
        }

        private void Request_Load(object sender, EventArgs e)
        {
            String sorgu = "SELECT MAX(talepNo) FROM TalepBilgi";
            DataSet ds = islem.veriyiAl(sorgu);
            int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            lbl_TalepNo.Text = (id + 1).ToString();
            txtTcNo.MaxLength = 11;
            txtAd.ReadOnly = true;
            txtSoyad.ReadOnly = true;
            txtIsyeri.ReadOnly = true;
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            if (txtTcNo.Text.Length == 11)
            {
                String sorgu = "select * from Kullanicilar where tcNo = " + txtTcNo.Text + "";

                DataSet ds = islem.veriyiAl(sorgu);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    txtAd.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtSoyad.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtIsyeri.Text = ds.Tables[0].Rows[0][8].ToString();

                }
            }
            else
            {
                txtAd.Clear();
                txtSoyad.Clear();
                txtIsyeri.Clear();
                txtTarih.ResetText();
            }
        }

        private void sadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        Boolean control2;
        Boolean control3;
        Boolean control4;
        Boolean control5;
        Boolean control6;
        Boolean control7;
        Boolean control8;
        Boolean control9;


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "" || txtIsyeri.Text == "" || txtTarih.Text == "" || txtIsyeri.Text == ""|| txtAciklama.Text == "" || comboTalep.Text == "" ||
                txtA_Arti.Text == "" && txtB_Arti.Text == "" && txtAB_Arti.Text == "" && txtO_Arti.Text == "" && txtA_Eksi.Text == "" && txtB_Eksi.Text == "" &&
                txtAB_Eksi.Text == "" && txtO_Eksi.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sorgu1 = "insert into TalepBilgi (talepNo, tcNo, aciklama, tarih, durum, onay , cevapTarihi) values ('" + lbl_TalepNo.Text + "', '" + txtTcNo.Text + "', '" + txtAciklama.Text + "'" +
                    "  ,'" + txtTarih.Text + "', '" + comboTalep.Text + "', 'Onay Bekliyor' , 'Tarih Belirlenmedi')";

                Boolean control1 = islem.veriAyarla(sorgu1);
                

                if (checkA_Arti.Checked == true && txtA_Arti.Text != "")
                {
    
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "' ,'" + checkA_Arti.Text.Trim() + "', '" + txtA_Arti.Text + "')";
                    control2 = islem.veriAyarla(sorgu2);
                }

                if (checkB_Arti.Checked == true && txtB_Arti.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkB_Arti.Text.Trim() + "', '" + txtB_Arti.Text + "')";
                    control3 = islem.veriAyarla(sorgu2);
                }

                if (checkAB_Arti.Checked == true && txtAB_Arti.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkAB_Arti.Text.Trim() + "', '" + txtAB_Arti.Text + "')";
                    control4 = islem.veriAyarla(sorgu2);
                }

                if (checkO_Arti.Checked == true && txtO_Arti.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkO_Arti.Text.Trim() + "', '" + txtO_Arti.Text + "')";
                    control5 = islem.veriAyarla(sorgu2);
                }

                if (checkA_Eksi.Checked == true && txtA_Eksi.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkA_Eksi.Text.Trim() + "', '" + txtA_Eksi.Text + "')";
                    control6 = islem.veriAyarla(sorgu2);
                }

                if (checkB_Eksi.Checked == true && txtB_Eksi.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkAB_Eksi.Text.Trim() + "', '" + txtB_Eksi.Text + "')";
                    control7 = islem.veriAyarla(sorgu2);
                }

                if (checkAB_Eksi.Checked == true && txtAB_Eksi.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkAB_Eksi.Text.Trim() + "', '" + txtAB_Eksi.Text + "')";
                    control8 = islem.veriAyarla(sorgu2);
                }

                if (checkO_Eksi.Checked == true && txtO_Eksi.Text != "")
                {
                    String sorgu2 = "insert into Talepler (talepNo, kanGrubu, stok) values ('" + lbl_TalepNo.Text + "',  '" + checkO_Eksi.Text.Trim() + "', '" + txtO_Eksi.Text + "')";
                    control9 = islem.veriAyarla(sorgu2);
                }

                if (control1 == true || control2 == true || control3 == true || control4 == true || control5 == true || control6 == true
                    || control7 == true || control8 == true || control9 == true)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Veri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTcNo.Clear();
                    txtTarih.ResetText();
                    comboTalep.SelectedItem = null;
                    txtAciklama.Clear();
                    checkA_Arti.Checked = false;
                    checkB_Arti.Checked = false;
                    checkAB_Arti.Checked = false;
                    checkO_Arti.Checked = false;
                    checkA_Eksi.Checked = false;
                    checkB_Eksi.Checked = false;
                    checkAB_Eksi.Checked = false;
                    checkO_Eksi.Checked = false;
                    String sorgu = "SELECT MAX(talepNo) FROM TalepBilgi";
                    DataSet ds = islem.veriyiAl(sorgu);
                    int id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                    lbl_TalepNo.Text = (id + 1).ToString();

                }


            }
        }
    }
}
