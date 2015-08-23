using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOServiceDetail
    {
        #region "Variable"
        public string servicesDetailID;
        public string orderDetailID;
        public string servicesID;
        public int quantity; // so luong
        public int total; // thanh tien
        #endregion

        #region "properties"
        public String ServicesDetailID
        {
            get { return servicesDetailID; }
            set { servicesDetailID = value; }
        }
        public String OrderDetailID
        {
            get { return orderDetailID; }
            set { orderDetailID = value; }
        }
        public String ServicesID
        {
            get { return servicesID; }
            set { servicesID = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        #endregion

        #region  "method"
        public DTOServiceDetail(String servicesDetailID, String orderDetailID, String servicesID, int quantity, int total)
        {
            this.servicesDetailID = servicesDetailID;
            this.orderDetailID = orderDetailID;
            this.servicesID = servicesID;
            this.quantity = quantity;
            this.total = total;
        }
        public DTOServiceDetail(String orderDetailID, String servicesID, int quantity, int total)
        {
            this.orderDetailID = orderDetailID;
            this.servicesID = servicesID;
            this.quantity = quantity;
            this.total = total;
        }
        public DTOServiceDetail()
        {

        }
        #endregion
    }
}
