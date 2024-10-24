using MasterFloor.Forms;
using MasterFloor.Models;
using MasterFloor.Models.Repositories;
using MasterFloor.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MasterFloor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            DisplayPartnerInfo();

        }
        private async void DisplayPartnerInfo()
        {
            var dbPartners = new PartnersRepository(new MasterFloorDbContext());
            var allPartners = await dbPartners.GetPartners();
            flowLayoutPanel1.Controls.Clear();

            foreach (var partner in allPartners)
            {
                var partnerInfoControl = new PartnersControls();
                partnerInfoControl.DisplayPartnerInfo(partner);
                flowLayoutPanel1.Controls.Add(partnerInfoControl);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            var historySales = new HistorySales();
            //historySales.FormClosed += (s, args) => this.Close();
            //historySales.Show();
            //this.Hide();
            historySales.ShowDialog();
        }
    }
}
