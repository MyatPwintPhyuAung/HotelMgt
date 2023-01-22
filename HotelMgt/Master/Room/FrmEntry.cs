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
        RoomTableAdapter RoomAdpt = new RoomTableAdapter();
        RoomDAL roomDAL = new RoomDAL();
        public FrmEntry()
        {
            InitializeComponent();
        }

        private void FrmEntry_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MasterDS.RoomDataTable roomTbl = new MasterDS.RoomDataTable();
            MasterDS.RoomRow roomRow = roomTbl.NewRoomRow();
            roomRow.RoomId = int.Parse(TxtId.Text);
            roomRow.RoomName = TxtName.Text;
            roomRow.Fees = double.Parse(TxtFees.Text);
            roomRow.Capacity = int.Parse(TxtCapacity.Text);
            roomTbl.AddRoomRow(roomRow);
            if (roomDAL.SaveRoom(roomTbl))
                MessageBox.Show("Successfully Save");
            else MessageBox.Show("Error in save data!!");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
