using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOStatus
    {
        #region "Variable"
        public string statusID;
        public string statusName;
        #endregion

        #region "properties"
        public String StatusID
        {
            get { return statusID; }
            set { statusID = value; }
        }
        public System.String StatusName
        {
            get { return statusName; }
            set { statusName = value; }
        }
        #endregion

        #region  "method"
        public DTOStatus(String statusID, String statusName)
        {
            this.statusID = statusID;
            this.statusName = statusName;
        }
        public DTOStatus(String statusName)
        {
            this.statusName = statusName;
        }
        public DTOStatus()
        {

        }
        #endregion
    }
}
