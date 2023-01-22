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
        private readonly RoomTableAdapter RoomAdpt = new RoomTableAdapter();

        public MasterDS.RoomDataTable GetList() => RoomAdpt.GetData();

        public MasterDS.RoomDataTable GetDataById(int RoomId) => RoomAdpt.GetDataById(RoomId);

        public int? AutoID() => RoomAdpt.GetAutoId();

        public bool SaveRoom(MasterDS.RoomDataTable rooms) => RoomAdpt.Update(rooms) > 0;
    }
}
