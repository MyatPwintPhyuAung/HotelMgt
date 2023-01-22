using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMgt.DBA;
using HotelMgt.DBA.MasterDSTableAdapters;

namespace HotelMgt.DAL
{
    class RoomFacalityDAL
    {
        RoomFacalityTableAdapter RFacAdpt = new RoomFacalityTableAdapter();

        public bool SaveRoom(MasterDS.RoomFacalityDataTable rooms)
        {
            int res = RFacAdpt.Update(rooms);
            return res > 0;
        }
    }
}
