using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOConditions
    {
        public string conditionsID;
        public string conditionsName;
        public string actionName;
        public string actionValue;
        public bool isChargeByTheHour;
        public float hourMin;
        public float hourMax;
        public float hourLate;
    }
}
