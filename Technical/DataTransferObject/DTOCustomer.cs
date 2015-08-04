using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOCustomer : DTOPerson
    {
        #region "Variable"
        public string customerID; // Ma khach hang
        public string numberID; // CMND
        #endregion

        #region "Properties"
        public String CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public String NumberID
        {
            get { return numberID; }
            set { numberID = value; }
        }
        #endregion

           #region "Method"
        public DTOCustomer()
        {

        }
        public DTOCustomer(String customerID, String strStaffName, String strGender, DateTime dBirthday,
            String strAddress, String strPhone, String strEmail, String numberID)
        {
            this.customerID = customerID;
            this.name = strStaffName;
            this.gender = strGender;
            this.birthday = dBirthday;
            this.phone = strPhone;
            this.address = strAddress;
            this.email = strEmail;
            this.numberID = numberID;
        }
        #endregion

    }
}
