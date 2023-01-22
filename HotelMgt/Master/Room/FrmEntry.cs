using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelMgt.DBA;
using HotelMgt.DAL;
using HotelMgt.DBA.MasterDSTableAdapters;
namespace HotelMgt.Master.Room
{
    public partial class FrmEntry : Form
    {
        public bool IsEdit = false;
        RoomTableAdapter RoomAdpt = new RoomTableAdapter();
        RoomDAL roomDAL = new RoomDAL();
        public FrmEntry()
        {
            InitializeComponent();
        }

        private void FrmEntry_Load(object sender, EventArgs e)
        {
            if (!IsEdit)
            {
                TxtId.Text = roomDAL.AutoID().ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
         
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
