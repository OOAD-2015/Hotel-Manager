using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTOPerson
    {
        #region "Variable"
        protected String name;
        protected String gender;
        protected DateTime birthday;
        protected String address;
        protected String phone;
        protected String email;
        #endregion

        #region "Properties"
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region "Methods"
        public DTOPerson()
        { }
        public DTOPerson(String strName, String strGender, DateTime dBirthday,
            String strAddress, String strPhone, String strEmail)
        {
            this.name = strName;
            this.gender = strGender;
            this.birthday = dBirthday;
            this.address = strAddress;
            this.phone = strPhone;
            this.email = strPhone;
        }
        #endregion
    }
}
