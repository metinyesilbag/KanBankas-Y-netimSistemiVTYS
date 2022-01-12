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
    public partial class SearchDonorAdress : Form
    {
        DBFunctions islem = new DBFunctions();
        public SearchDonorAdress()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDonorAdress_Load(object sender, EventArgs e)
        {
            tabloyuGöster();
            

        }

        private void txtAdresArama_TextChanged(object sender, EventArgs e)
        {
            if (txtAdresArama.Text != "")
            {
                String sorgu = "select donorNo AS \"Donor No\", tcNo AS \"TC Kimlik No\", ad AS \"Ad\", soyad AS \"Soyad\"," +
                " dogumTarihi AS \"Doğum Tarihi\", cinsiyet AS \"Cinsiyet\", cepNo AS \"Cep Telefonu\", kanGrubu AS \"Kan Grubu\"," +
                    " ePosta AS \"E-Posta\", sehir AS \"Şehir\", ilce AS \"İlçe\", adres AS \"Adres\" from Donorler" +
                    " where sehir Like '%"+txtAdresArama.Text+"%' or ilce Like '%"+txtAdresArama.Text+"%' or adres like '%"+txtAdresArama.Text+"%' ";
                DataSet ds = islem.veriyiAl(sorgu);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                tabloyuGöster();
            }
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
    }
}
