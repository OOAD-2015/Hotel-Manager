using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOServicesType
    {
        #region "Variable"
        public string servicesTypeID;
        public string servicesTypeName;
        #endregion

        #region "properties"
        public String ServicesTypeID
        {
            get { return servicesTypeID; }
            set { servicesTypeID = value; }
        }
        public System.String ServicesTypeName
        {
            get { return servicesTypeName; }
            set { servicesTypeName = value; }
        }
        #endregion

        #region  "method"
        public DTOServicesType(String servicesTypeID, String servicesTypeName)
        {
            this.servicesTypeID = servicesTypeID;
            this.servicesTypeName = servicesTypeName;
        }
        public DTOServicesType(String servicesTypeName)
        {
            this.servicesTypeName = servicesTypeName;
        }
        public DTOServicesType()
        {

        }
        #endregion

    }
}
