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
    public partial class StockReduce : Form
    {
        DBFunctions islem = new DBFunctions();
        public StockReduce()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockReduce_Load(object sender, EventArgs e)
        {
            tabloyuGöster();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            String sorgu = "update stok set unite = unite + '" + int.Parse(comboUnite.Text) + "' where kanGrubu = '" + comboKanGrubu.Text + "'";
            Boolean control = islem.veriAyarla(sorgu);
            if (control)
            {
                MessageBox.Show("İşlem Başarıyla gerçekleşti.", "Veri Ekleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabloyuGöster();
                comboKanGrubu.SelectedItem = null;
                comboUnite.SelectedItem = null;
            }

        }

        private void tabloyuGöster()
        {
            String sorgu = "select kanGrubu AS \"Kan Grubu\", unite AS \"Ünite\" from Stok";
            DataSet ds = islem.veriyiAl(sorgu);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;

        }
    }
}
