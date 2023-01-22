using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMgt.Master;
namespace HotelMgt
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.Room.FrmList frm = new Master.Room.FrmList();
            frm.ShowDialog();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.RoomType.FrmRTypeList frm = new Master.RoomType.FrmRTypeList();
            frm.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master.Customer.FrmCustomerList frm = new Master.Customer.FrmCustomerList();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Master.RoomFacality.FrmRFacalityList frm = new Master.RoomFacality.FrmRFacalityList();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
