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


    public partial class RequestDetails : Form
    {

        DBFunctions islem = new DBFunctions();
        public RequestDetails()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
           
            tabloYukle();
        }

        String sorgu;

        private void tabloYukle()
        {
            
            if (Global.unvan.Equals("Yonetici"))
            {
                sorgu = "select distinct t1.talepNo, k.tcNo , k.ad, k.soyad, k.isyeriAdi, t2.durum, t2.aciklama, t2.tarih, t2.onay, t2.cevapTarihi from Talepler t1 inner join TalepBilgi t2 on t1.talepNo = t2.talepNo inner join Kullanicilar k on k.tcNo = t2.tcNo order by t1.talepNo";

            }
            if (Global.unvan.Equals("Kullanici"))
            {
                sorgu = "select distinct t1.talepNo, k.tcNo , k.ad, k.soyad, k.isyeriAdi, t2.durum, t2.aciklama, t2.tarih, t2.onay, t2.cevapTarihi from Talepler t1 inner join TalepBilgi t2 on t1.talepNo = t2.talepNo inner join Kullanicilar k on k.tcNo = t2.tcNo where k.tcNo = '" + Global.tcAl + "' order by t1.talepNo";

            }
            else
            sorgu = "select distinct t1.talepNo, k.tcNo , k.ad, k.soyad, k.isyeriAdi, t2.durum, t2.aciklama, t2.tarih, t2.onay, t2.cevapTarihi from Talepler t1 inner join TalepBilgi t2 on t1.talepNo = t2.talepNo inner join Kullanicilar k on k.tcNo = t2.tcNo order by t1.talepNo";
            
            DataSet ds = islem.veriyiAl(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ReadOnly = true;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
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
            txtOnay.Clear();

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
                txtCevapTarihi.Text = dataGridView1.Rows[e.RowIndex].Cells["CEVAPTARIHI"].Value.ToString();
                txtOnay.Text = dataGridView1.Rows[e.RowIndex].Cells["ONAY"].Value.ToString();
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
    }


}
