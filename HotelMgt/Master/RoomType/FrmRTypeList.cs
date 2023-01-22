using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgt.Master.RoomType
{
    public partial class FrmRTypeList : Form
    {
        public FrmRTypeList()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmRTypeEntry frm = new FrmRTypeEntry();
            frm.ShowDialog();
        }
    }
}
