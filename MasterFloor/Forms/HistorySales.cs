using MasterFloor.Models.Repositories;
using MasterFloor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFloor.Forms
{
    public partial class HistorySales : Form
    {
        public HistorySales()
        {
            InitializeComponent();
        }

        private async void HistorySales_Activated(object sender, EventArgs e)
        {
            var dbPartners = new HistorySalesRepository(new MasterFloorDbContext());
            var partners = await dbPartners.GetHistorySale();
            dgwPartners.DataSource = partners.Select(c => new
            {
                c.product_name,
                c.Partner.PartnerType.partner_type,
                c.Partner.partner_name,
                c.quantity_product,
                c.date_sales
            }).ToList();
        }
    }
}
