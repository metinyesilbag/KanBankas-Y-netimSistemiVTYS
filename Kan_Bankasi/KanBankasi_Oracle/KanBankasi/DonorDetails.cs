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
    
    public partial class DonorDetails : Form
    {
        DBFunctions islem = new DBFunctions();
        public DonorDetails()
        {
            InitializeComponent();
        }

        private void DonorDetails_Load(object sender, EventArgs e)
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
