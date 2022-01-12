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
    public partial class MedicalWorkerDetails : Form
    {

        DBFunctions islem = new DBFunctions();

        public MedicalWorkerDetails()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MedicalWorkerDetails_Load(object sender, EventArgs e)
        {
            String sorgu = "select  tcNo, ad, soyad, dogumTarihi, cinsiyet, cepNo, ePosta, isyeriAdi, sehir, ilce, adres from kullanicilar";
            DataSet ds = islem.veriyiAl(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
    }
}
