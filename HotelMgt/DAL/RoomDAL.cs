using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMgt.DBA;
using HotelMgt.DBA.MasterDSTableAdapters;

namespace HotelMgt.DAL
{
    class RoomDAL
    {
        RoomTableAdapter RoomAdpt = new RoomTableAdapter();

        public bool SaveRoom(MasterDS.RoomDataTable rooms)
        {
            int res = RoomAdpt.Update(rooms);
            return res > 0;
        }
    }
}
