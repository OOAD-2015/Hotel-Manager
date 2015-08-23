using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOOrderDetail
    {
        #region "Variable"
        public string orderDetailID;
        public string orderID;
        public string roomID;
        public DateTime startDate;
        public DateTime endDate;
        public int estimate;
        public int servicesMoney;
        #endregion

        #region "Properties"
        public String OrderDetailID
        {
            get { return orderDetailID; }
            set { orderDetailID = value; }
        }
        public String OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public String RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public int Estimate
        {
            get { return estimate; }
            set { estimate = value; }
        }
        public int ServicesMoney
        {
            get { return servicesMoney; }
            set { servicesMoney = value; }
        }

        #endregion

        #region "Methods"
        public DTOOrderDetail()
        { }
        public DTOOrderDetail(String orderDetailID, String orderID, String roomID, DateTime startDate,
           DateTime endDate, int estimate, int servicesMoney)
        {
            this.orderDetailID = orderDetailID;
            this.orderID = orderID;
            this.roomID = roomID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.estimate = estimate;
            this.servicesMoney = servicesMoney;
        }
        public DTOOrderDetail(String orderID, String roomID, DateTime startDate,
            DateTime endDate, int estimate, int servicesMoney)
        {
            this.orderID = orderID;
            this.roomID = roomID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.estimate = estimate;
            this.servicesMoney = servicesMoney;
        }
        #endregion
    }
}
