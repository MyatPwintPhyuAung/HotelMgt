using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgt.Master.Customer
{
    public partial class FrmCustomerEntry : Form
    {
        public FrmCustomerEntry()
        {
            InitializeComponent();
        }

        private void FrmCustomerEntry_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
