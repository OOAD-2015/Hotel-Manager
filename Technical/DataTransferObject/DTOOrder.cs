using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOOrder
    {
        public string orderID;
        public string customerID;
        public string staffID;
        public DateTime orderOfDate;
        public int numberOfPeople;
        public int estimate;
        public int deposit;
        public int total;
        public string orderStatus;

        public DTOOrder()
        {

        }

        public DTOOrder(string orderID, string customerID, string staffID, DateTime orderOfDate, 
            int numberOfPeople, int estimate, int deposit, int total, string orderStatus)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.staffID = staffID;
            this.orderOfDate = orderOfDate;
            this.numberOfPeople = numberOfPeople;
            this.estimate = estimate;
            this.deposit = deposit;
            this.total = total;
            this.orderStatus = orderStatus;
        }
    }

    public enum ORDERSTATUS
    {
        UNPAID = 0,
        PAID = 1,
        CANCEL = -1
    }
}
