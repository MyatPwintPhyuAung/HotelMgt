using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelMgt.DBA;
using HotelMgt.DBA.MasterDSTableAdapters;

namespace HotelMgt.DAL
{
    class CustomerDAL
    {
        CustomerTableAdapter CusAdpt = new CustomerTableAdapter();

        public bool SaveRoom(MasterDS.CustomerDataTable rooms)
        {
            int res = CusAdpt.Update(rooms);
            return res > 0;
        }

    }
}
