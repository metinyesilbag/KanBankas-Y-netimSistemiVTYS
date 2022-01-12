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
    public partial class SearchDonorBlood : Form
    {
        DBFunctions islem = new DBFunctions();
        public SearchDonorBlood()
        {
            InitializeComponent();
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            comboKanGrubuArama.SelectedItem = null;
        }

        private void SearchDonorBlood_Load(object sender, EventArgs e)
        {
            tabloyuGöster();
        }

        private void tabloyuGöster()
        {
            String sorgu = "select donorNo AS \"Donor No\", tcNo AS \"TC Kimlik No\", ad AS \"Ad\", soyad AS \"Soyad\"," +
                " dogumTarihi AS \"Doğum Tarihi\", cinsiyet AS \"Cinsiyet\", cepNo AS \"Cep Telefonu\", kanGrubu AS \"Kan Grubu\"," +
                " ePosta AS \"E-Posta\", sehir AS \"Şehir\", ilce AS \"İlçe\", adres AS \"Adres\" from Donorler ";
            DataSet ds = islem.veriyiAl(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void comboKanGrubuArama_TextChanged(object sender, EventArgs e)
        {
            if (comboKanGrubuArama.Text != "")
            {
                String sorgu = "select donorNo AS \"Donor No\", tcNo AS \"TC Kimlik No\", ad AS \"Ad\", soyad AS \"Soyad\"," +
                " dogumTarihi AS \"Doğum Tarihi\", cinsiyet AS \"Cinsiyet\", cepNo AS \"Cep Telefonu\", kanGrubu AS \"Kan Grubu\"," +
                " ePosta AS \"E-Posta\", sehir AS \"Şehir\", ilce AS \"İlçe\", adres AS \"Adres\" from Donorler where kanGrubu = '" + comboKanGrubuArama.Text+"' ";
                DataSet ds = islem.veriyiAl(sorgu);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.ReadOnly = true;
            }
            else
            {
                tabloyuGöster();
            }
        }
    }
}
