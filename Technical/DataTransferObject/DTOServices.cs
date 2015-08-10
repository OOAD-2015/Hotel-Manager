using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOServices
    {
        #region "Variable"
        public string servicesID;
        public string servicesTypeID;
        public string servicesName;
        public string unitID;
        public int price;
        #endregion

        #region "properties"
        public String ServicesID
        {
            get { return servicesID; }
            set { servicesID = value; }
        }
        public String ServicesName
        {
            get { return servicesName; }
            set { servicesName = value; }
        }
        public String ServicesTypeID
        {
            get { return servicesTypeID; }
            set { servicesTypeID = value; }
        }
        public String UnitID
        {
            get { return unitID; }
            set { unitID = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region  "method"
        public DTOServices(String servicesID, String servicesName, String servicesTypeID, String unitID, int price)
        {
            this.servicesTypeID = servicesTypeID;
            this.servicesID = servicesID;
            this.servicesName = servicesName;
            this.unitID = unitID;
            this.price = price;
        }
        public DTOServices()
        {

        }
        #endregion
    }
}
