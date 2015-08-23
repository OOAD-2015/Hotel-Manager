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
        private string orderDetailID;
        private string orderID;
        private string roomID;
        private DateTime startDate;
        private DateTime endDate;
        private int estimate;
        private int servicesMoney;
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
