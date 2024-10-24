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
    public partial class EditPartner : Form
    {
        public EditPartner(string title)
        {
            InitializeComponent();
            txbPartnerType.Text = title;
            
        }
    }
}
