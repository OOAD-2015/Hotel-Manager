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
        #region "Varaibles FormObject"
        private frmStaff staffFormObject;
        private frmCustomer customerFormObject;
        private frmSearchStaff searchStaffFormObject;
        private frmStaffInfor staffInforFormObject;
        private frmRule ruleFormObject;
        private frmRoomType roomTypeFormObject;
        private frmServiceType servicesTypeFormObject;
        private frmStatus statusFormObject;
        private frmUnit unitFormObject;
        #endregion

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

        private void bbtnStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(staffFormObject))
            {
                staffFormObject = new frmStaff();
                xtraTabbedMdiManagerMenu.FloatForms.Add(staffFormObject);
                staffFormObject.MdiParent = this;
                staffFormObject.Show();
            }
            else
                staffFormObject.Activate();
        }

        private void bbtnInformation_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(staffInforFormObject))
            {
                staffInforFormObject = new frmStaffInfor();
                xtraTabbedMdiManagerMenu.FloatForms.Add(staffInforFormObject);
                staffInforFormObject.MdiParent = this;
                staffInforFormObject.Show();
            }
            else
                staffInforFormObject.Activate();
        }

        private void bbtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtraTabbedMdiManagerMenu.FloatForms.Count != 0)
            {
                XtraCustomMessageBox.Show("Vui lòng đóng tất cả các của sổ trước khi đăng xuất!", "Thông báo", false, 1);
            }
            else
            {
                DialogResult rs = XtraCustomMessageBox.Show("Bạn có muốn đăng xuất khỏi hệ thông?", "Thông báo", false, 2);
                if (rs == DialogResult.Yes)
                {
                    new frmLogin().Show();
                    staffLogin = null;
                    rolePermissionObj = null;
                    //
                    this.Dispose();
                    this.Close();
                }
                else
                    return;
            }
        }

        private void bbtnCustomerManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(customerFormObject))
            {
                customerFormObject = new frmCustomer();
                xtraTabbedMdiManagerMenu.FloatForms.Add(customerFormObject);
                customerFormObject.MdiParent = this;
                customerFormObject.Show();
            }
            else
                customerFormObject.Activate();
        }

        private void bbtnRule_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(ruleFormObject))
            {
                ruleFormObject = new frmRule();
                xtraTabbedMdiManagerMenu.FloatForms.Add(ruleFormObject);
                ruleFormObject.MdiParent = this;
                ruleFormObject.Show();
            }
            else
                ruleFormObject.Activate();
        }

        private void bbtnRoomTypeCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(roomTypeFormObject))
            {
                roomTypeFormObject = new frmRoomType();
                xtraTabbedMdiManagerMenu.FloatForms.Add(roomTypeFormObject);
                roomTypeFormObject.MdiParent = this;
                roomTypeFormObject.Show();
            }
            else
                roomTypeFormObject.Activate();
        }

        private void bbtnServicesType_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(servicesTypeFormObject))
            {
                servicesTypeFormObject = new frmServiceType();
                xtraTabbedMdiManagerMenu.FloatForms.Add(servicesTypeFormObject);
                servicesTypeFormObject.MdiParent = this;
                servicesTypeFormObject.Show();
            }
            else
                servicesTypeFormObject.Activate();
        }

        private void bbtnStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(statusFormObject))
            {
                statusFormObject = new frmStatus();
                xtraTabbedMdiManagerMenu.FloatForms.Add(statusFormObject);
                statusFormObject.MdiParent = this;
                statusFormObject.Show();
            }
            else
                statusFormObject.Activate();
        }

        private void bbtnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!xtraTabbedMdiManagerMenu.FloatForms.Contains(unitFormObject))
            {
                unitFormObject = new frmUnit();
                xtraTabbedMdiManagerMenu.FloatForms.Add(unitFormObject);
                unitFormObject.MdiParent = this;
                unitFormObject.Show();
            }
            else
                unitFormObject.Activate();
        }
    }
}