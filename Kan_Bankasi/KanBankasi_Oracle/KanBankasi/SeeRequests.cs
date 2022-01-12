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
    public partial class SeeRequests : Form
    {
        DBFunctions islem = new DBFunctions();
        Boolean control2;
        Boolean control3;
        Boolean control4;
        Boolean control5;
        Boolean control6;
        Boolean control7;
        Boolean control8;
        Boolean control9;

        public SeeRequests()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeeRequests_Load(object sender, EventArgs e)
        {
            tabloYukle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                temizle();
                lblTalepNo.Text = dataGridView1.Rows[e.RowIndex].Cells["TALEPNO"].Value.ToString();
                txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells["AD"].Value.ToString();
                txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["SOYAD"].Value.ToString();
                txtIsyeri.Text = dataGridView1.Rows[e.RowIndex].Cells["ISYERIADI"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["TARIH"].Value.ToString();
                comboTalep.Text = dataGridView1.Rows[e.RowIndex].Cells["DURUM"].Value.ToString();
                txtAciklama.Text = dataGridView1.Rows[e.RowIndex].Cells["ACIKLAMA"].Value.ToString();
                txtTcNo.Text = dataGridView1.Rows[e.RowIndex].Cells["TCNO"].Value.ToString();
                String sorgu = "select * from Talepler where talepNo =  '" + lblTalepNo.Text + "'";

                DataSet ds = islem.veriyiAl(sorgu);

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("A+"))
                    {
                        checkA_Arti.Checked = true;
                        txtA_Arti.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("B+"))
                    {
                        checkB_Arti.Checked = true;
                        txtB_Arti.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("AB+"))
                    {
                        checkAB_Arti.Checked = true;
                        txtAB_Arti.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("O+"))
                    {
                        checkO_Arti.Checked = true;
                        txtO_Arti.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("A-"))
                    {
                        checkA_Eksi.Checked = true;
                        txtA_Eksi.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("B-"))
                    {
                        checkB_Eksi.Checked = true;
                        txtB_Eksi.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("AB-"))
                    {
                        checkAB_Eksi.Checked = true;
                        txtAB_Eksi.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }

                    if (ds.Tables[0].Rows[i]["KANGRUBU"].ToString().Equals("O-"))
                    {
                        checkO_Eksi.Checked = true;
                        txtO_Eksi.Text = ds.Tables[0].Rows[i]["STOK"].ToString();
                    }
                }



            }
        }

        private void temizle()
        {
            txtTcNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtIsyeri.Clear();
            dateTimePicker1.ResetText();
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
            txtA_Arti.Clear();
            txtB_Arti.Clear();
            txtAB_Arti.Clear();
            txtO_Arti.Clear();
            txtA_Eksi.Clear();
            txtB_Eksi.Clear();
            txtAB_Eksi.Clear();
            txtO_Eksi.Clear();

        }

        private void btnRet_Click(object sender, EventArgs e)
        {

            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "" || txtIsyeri.Text == "" || dateTimePicker1.Text == "" || txtIsyeri.Text == "" || txtAciklama.Text == "" || comboTalep.Text == "" ||
                txtA_Arti.Text == "" && txtB_Arti.Text == "" && txtAB_Arti.Text == "" && txtO_Arti.Text == "" && txtA_Eksi.Text == "" && txtB_Eksi.Text == "" &&
                txtAB_Eksi.Text == "" && txtO_Eksi.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                String sorgu = "update TalepBilgi set onay = 'Reddedildi', cevapTarihi = '" + dateTimePicker1.Text + "' where talepNo = '" + int.Parse(lblTalepNo.Text.Trim()) + "' ";
                Boolean control = islem.veriAyarla(sorgu);

                if (control)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Veri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabloYukle();
                    temizle();
                }

            }

        }

        private void btnKabul_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtTcNo.Text == "" || txtIsyeri.Text == "" || dateTimePicker1.Text == "" || txtIsyeri.Text == "" || txtAciklama.Text == "" || comboTalep.Text == "" ||
    txtA_Arti.Text == "" && txtB_Arti.Text == "" && txtAB_Arti.Text == "" && txtO_Arti.Text == "" && txtA_Eksi.Text == "" && txtB_Eksi.Text == "" &&
    txtAB_Eksi.Text == "" && txtO_Eksi.Text == "")
            {
                MessageBox.Show("Bütün Alanlar Doldurulmalıdır!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                String sorgu = "update TalepBilgi set onay = 'Onaylandı', cevapTarihi = '" + dateTimePicker1.Text + "' where talepNo = '" + int.Parse(lblTalepNo.Text.Trim()) + "' ";
                Boolean control = islem.veriAyarla(sorgu);

                if (checkA_Arti.Checked == true && txtA_Arti.Text != "")
                {

                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtA_Arti.Text) + "' where kanGrubu = 'A+' ";
                    control2 = islem.veriAyarla(sorgu2);
                }

                if (checkB_Arti.Checked == true && txtB_Arti.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtB_Arti.Text) + "' where kanGrubu = 'B+' "; 
                    control3 = islem.veriAyarla(sorgu2);
                }

                if (checkAB_Arti.Checked == true && txtAB_Arti.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtAB_Arti.Text) + "' where kanGrubu = 'AB+' ";
                    control4 = islem.veriAyarla(sorgu2);
                }

                if (checkO_Arti.Checked == true && txtO_Arti.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtO_Arti.Text) + "' where kanGrubu = 'O+' ";
                    control5 = islem.veriAyarla(sorgu2);
                }

                if (checkA_Eksi.Checked == true && txtA_Eksi.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtA_Eksi.Text) + "' where kanGrubu = 'A-' ";
                    control6 = islem.veriAyarla(sorgu2);
                }

                if (checkB_Eksi.Checked == true && txtB_Eksi.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtB_Eksi.Text) + "' where kanGrubu = 'B-' ";
                    control7 = islem.veriAyarla(sorgu2);
                }

                if (checkAB_Eksi.Checked == true && txtAB_Eksi.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtAB_Eksi.Text) + "' where kanGrubu = 'AB-' ";
                    control8 = islem.veriAyarla(sorgu2);
                }

                if (checkO_Eksi.Checked == true && txtO_Eksi.Text != "")
                {
                    String sorgu2 = "update Stok set unite = unite - '" + int.Parse(txtO_Eksi.Text) + "' where kanGrubu = 'O-' ";
                    control9 = islem.veriAyarla(sorgu2);
                }

                if (control == true || control2 == true || control3 == true || control4 == true || control5 == true || control6 == true
                    || control7 == true || control8 == true || control9 == true)
                {
                    MessageBox.Show("İşlem Başarıyla Gerçekleşti.", "Veri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabloYukle();
                    temizle();
                }
            }
        }

        private void tabloYukle()
        {
            String sorgu = "select distinct t1.talepNo, k.tcNo , k.ad, k.soyad, k.isyeriAdi, t2.durum, t2.aciklama, t2.tarih from Talepler t1 inner join TalepBilgi t2 on t1.talepNo = t2.talepNo inner join Kullanicilar k on k.tcNo = t2.tcNo  where t2.onay = 'Onay Bekliyor' order by t1.talepNo";
            DataSet ds = islem.veriyiAl(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ReadOnly = true;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
        }
    }
}
