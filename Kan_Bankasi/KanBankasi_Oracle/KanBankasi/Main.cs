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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniDonörEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor newDoner = new AddNewDonor();
            newDoner.Show();
        }

        private void donörSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDonor deleteDonor = new DeleteDonor();
            deleteDonor.Show();
        }

        private void donörBilgileriniGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonor updateDonor = new UpdateDonor();
            updateDonor.Show();
        }

        private void bütünDonörBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorDetails donorDetails = new DonorDetails();
            donorDetails.Show();
        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorAdress donorAdress = new SearchDonorAdress();
            donorAdress.Show();
        }

        private void kanGrubuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorBlood donorBlood = new SearchDonorBlood();
            donorBlood.Show();
        }

        private void arttırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease stockIncrease = new StockIncrease();
            stockIncrease.Show();
        }

        private void azaltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockReduce stockReduce = new StockReduce();
            stockReduce.Show();
        }

        private void bütünStokBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails stockDetails = new StockDetails();
            stockDetails.Show();
        }

        private void talepteBulunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
        }

        private void talepleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeeRequests seeRequests = new SeeRequests();
            seeRequests.Show();
        }

        private void talepDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestDetails requestDetails = new RequestDetails();
            requestDetails.Show();
        }

        private void sağlıkÇalışanıDetaylarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicalWorkerDetails medicalWorkerDetails = new MedicalWorkerDetails();
            medicalWorkerDetails.Show();
        }
    }
}
