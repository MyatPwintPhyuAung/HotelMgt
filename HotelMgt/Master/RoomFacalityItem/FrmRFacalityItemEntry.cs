using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgt.Master.RoomFacalityItem
{
    public partial class FrmRFacalityItemEntry : Form
    {
        public FrmRFacalityItemEntry()
        {
            InitializeComponent();
        }

        

        private void FrmRFacalityItemEntry_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
