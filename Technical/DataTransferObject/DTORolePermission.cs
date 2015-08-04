using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DTORolePermission
    {
         #region "Variables"
        private String rolePermissionID;
        private String rolePermissionName;
        private Boolean systemManager;
        private Boolean changeRule;
        #endregion

        #region "Prop"
        public String RolePermissionID
        {
            get { return rolePermissionID; }
            set { rolePermissionID = value; }
        }
        public String RolePermissionName
        {
            get { return rolePermissionName; }
            set { rolePermissionName = value; }
        }
        public Boolean SystemManager
        {
            get { return systemManager; }
            set { systemManager = value; }
        }
        public Boolean ChangeRule
        {
            get { return changeRule; }
            set { changeRule = value; }
        }
        #endregion

        #region "Methods"
        public DTORolePermission()
        { 
        }

        public DTORolePermission(String strRolePermissionID, String strRolePermissionName)
        {
            this.rolePermissionID = strRolePermissionID;
            this.rolePermissionName = strRolePermissionName;
        }

        public DTORolePermission(String strRolePermissionID, String strRolePermissionName, Boolean bSystem, Boolean bChange)
        {
            this.rolePermissionID = strRolePermissionID;
            this.rolePermissionName = strRolePermissionName;
            this.systemManager = bSystem;
            this.changeRule = bChange;
        }
        #endregion
    }
}
