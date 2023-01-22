using HotelMgt.DAL;
using HotelMgt.DBA;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMgt.Master.Room
{
    public partial class FrmList : Form
    {
        RoomDAL roomDAL = new RoomDAL();
        public FrmList()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            FrmEntry frm = new FrmEntry();
            frm.IsEdit = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MasterDS.RoomDataTable roomTbl = new MasterDS.RoomDataTable();
                MasterDS.RoomRow roomRow = roomTbl.NewRoomRow();
                roomRow.RoomId = int.Parse(frm.TxtId.Text);
                roomRow.RoomName = frm.TxtName.Text;
                roomRow.Fees = double.Parse(frm.TxtFees.Text);
                roomRow.Capacity = int.Parse(frm.TxtCapacity.Text);
                roomTbl.AddRoomRow(roomRow);
                if (roomDAL.SaveRoom(roomTbl))
                {
                    MessageBox.Show("Successfully Save");
                    RefreshData();
                }
                else MessageBox.Show("Error in save data!!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            radGridView1.DataSource = roomDAL.GetList();
            radGridView1.Refresh();
        }
    }
}
