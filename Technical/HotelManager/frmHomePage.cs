using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BusinessLayer;
using DataTransferObject;

namespace HotelManager
{
    public partial class frmHomePage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region "Varaibles"
        public static DTOStaff staffLogin;
        public static DTORolePermission rolePermissionObj;
        private BUSStaff staffBUS;
        private BUSRolePermission rolePermissionBUS;
        #endregion

        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffLogin = null;
            rolePermissionObj = null;
            //
            this.Dispose();
            this.Close();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            rolePermissionBUS = new BUSRolePermission();
            staffBUS = new BUSStaff();

            barSiInfo.Caption = "Đăng nhập với quyền: " + rolePermissionBUS.GetRolePermissionNameById(staffLogin.RolePermissionId) + " - NV: " + staffLogin.Name + ".";

            barHiDateLogin.Caption = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmHomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            new frmLogin().Show();
            staffLogin = null;
            rolePermissionObj = null;
            //
            this.Dispose();
            this.Close();
        }
    }
}