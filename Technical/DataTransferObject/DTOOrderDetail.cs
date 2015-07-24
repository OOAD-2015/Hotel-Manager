using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOOrderDetail
    {
        public string orderDetailID;
        public string orderID;
        public string roomID;
        public DateTime startDate;
        public DateTime endDate;
        public int estimate;
        public string orderStatus;
    }
}
