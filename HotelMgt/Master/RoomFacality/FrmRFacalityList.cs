using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgt.Master.RoomFacality
{
    public partial class FrmRFacalityList : Form
    {
        public FrmRFacalityList()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmRFacalityEntry frm = new FrmRFacalityEntry();
            frm.ShowDialog();
        }
    }
}
