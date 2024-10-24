using MasterFloor.Forms;
using MasterFloor.Models;
using MasterFloor.Models.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterFloor.UserControls
{
    public partial class PartnersControls : UserControl
    {
        
        
        public PartnersControls()
        {
            InitializeComponent();
           
        }

        public void DisplayPartnerInfo(Partner partner)
        {
            lblPartnerType.Text = partner.PartnerType.partner_type;
            lblPartnerName.Text = partner.partner_name;
            lblDirector.Text =  $"Директор {partner.director}";
            lblPhone.Text = $"Телефон {partner.phone}";
            lblRating.Text = $"Рейтинг {partner.rating}";
            lblDiscount.Text = $"Скидка {partner.DiscountPartner.discount} %";
        }

       

        private void PartnersControls_Load(object sender, EventArgs e)
        {
            

        }

        private void PartnersControls_Click(object sender, EventArgs e)
        {

            var PartnerType = lblPartnerType.Text;


            var formEditPartner = new EditPartner(title: PartnerType);
            formEditPartner.Show();
            
        }
    }
}
