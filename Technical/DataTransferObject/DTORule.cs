using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * trungpv
 **/
namespace DataAccessLayer
{
    public class DTORule
    {
        #region "Variables"
        private String id;
        private String label;
        private String value;
        #endregion

        #region "Properties"
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Label
        {
            get { return label; }
            set { label = value; }
        }
        public String Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        #endregion

        #region "Methods"
        public DTORule()
        {
        }
        public DTORule(String strId, String strLabel, String strValue)
        {
            this.id = strId;
            this.label = strLabel;
            this.value = strValue;
        }
        #endregion
    }
}
