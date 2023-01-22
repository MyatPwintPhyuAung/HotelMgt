using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMgt.DBA;
using HotelMgt.DBA.MasterDSTableAdapters;



namespace HotelMgt.DAL
{
    class RoomTypeDAL
    {
        RoomTypeTableAdapter RTypeAdpt = new RoomTypeTableAdapter();

        public bool SaveRoom(MasterDS.RoomTypeDataTable rooms)
        {
            int res = RTypeAdpt.Update(rooms);
            return res > 0;
        }
    }
}
