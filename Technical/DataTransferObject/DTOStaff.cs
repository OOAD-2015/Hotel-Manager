using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * trungpv
**/
namespace DataTransferObject
{
    public class DTOStaff : DTOPerson
    {
        #region "Variable"
        public string staffID;
        private DateTime dateCreated;
        private String rolePermissionId;
        private String userName;
        private String password;
        #endregion

        #region "Properties"
        public System.String StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }
        public System.DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public System.String RolePermissionId
        {
            get { return rolePermissionId; }
            set { rolePermissionId = value; }
        }

        public System.String UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public System.String Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region "Method"
        public DTOStaff()
        {

        }
        public DTOStaff(String strStaffId, String strStaffName, String strGender, DateTime dBirthday,
            String strAddress, String strPhone, String strEmail, DateTime dDateCreated, String strRolePermissionId, String strUserName, String strPassword)
        {
            this.staffID = strStaffId;
            this.name = strStaffName;
            this.gender = strGender;
            this.birthday = dBirthday;
            this.phone = strPhone;
            this.address = strAddress;
            this.email = strEmail;
            this.dateCreated = dDateCreated;
            this.rolePermissionId = strRolePermissionId;
            this.userName = strUserName;
            this.password = strPassword;
        }
        public DTOStaff(String strStaffId, String strStaffName, String strGender, DateTime dBirthday,
            String strAddress, String strPhone, String strEmail, String strRolePermissionId)
        {
            this.staffID = strStaffId;
            this.name = strStaffName;
            this.gender = strGender;
            this.birthday = dBirthday;
            this.phone = strPhone;
            this.address = strAddress;
            this.email = strEmail;
            this.rolePermissionId = strRolePermissionId;
        }
        #endregion
    }
}
