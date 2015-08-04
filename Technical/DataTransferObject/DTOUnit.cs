
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
namespace DataTransferObject
{
    public class DTOUnit
    {
          #region "Variable"
        public string unitID;
        public string unitName;
        #endregion

        #region "properties"
        public String UnitID
        {
            get { return unitID; }
            set { unitID = value; }
        }
        public System.String UnitName
        {
            get { return unitName; }
            set { unitName = value; }
        }
        #endregion

        #region  "method"
        public DTOUnit(String unitID, String unitName)
        {
            this.unitID = unitID;
            this.unitName = unitName;
        }
        public DTOUnit(String unitName)
        {
            this.unitName = unitName;
        }
        public DTOUnit()
        {

        }
        #endregion
    }
}
