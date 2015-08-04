using BusinessLayer;
using DataTransferObject;
using DataTransferObject.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class frmStaffInfor : DevExpress.XtraEditors.XtraForm
    {
        #region "Valiable"
        private DTOStaff staffDTO;
        private BUSStaff staffBUS;
        private BUSRolePermission rolePermissionBUS;
        private DTORolePermission rolePermissionDTO;
        private DataTable rolePermissionDataTable;
        #endregion

        public frmStaffInfor()
        {
            InitializeComponent();
            InitStaffObj();
        }

        private void InitDisplay(bool _update)
        {
            if (_update)
            {
                this.txtStaffName.Properties.ReadOnly = false;
                this.txtStaffPhone.Properties.ReadOnly = false;
                this.txtStaffEmail.Properties.ReadOnly = false;
                this.txtStaffAddress.Properties.ReadOnly = false;
                this.dateBirthDay.Properties.ReadOnly = false;
                this.cmbStaffGender.Properties.ReadOnly = false;
            }
            else
            {
                this.txtStaffName.Properties.ReadOnly = true;
                this.txtStaffPhone.Properties.ReadOnly = true;
                this.txtStaffEmail.Properties.ReadOnly = true;
                this.txtStaffAddress.Properties.ReadOnly = true;

                this.dateBirthDay.Properties.ReadOnly = true;

                this.cmbStaffGender.Properties.ReadOnly = true;
            }
            this.txtUser.Properties.ReadOnly = true;
            this.txtPass.Properties.ReadOnly = true;
            this.dateToWork.Properties.ReadOnly = true;
            //
            this.grpChangePassword.Enabled = false;
        }

        private void InitStaffObj()
        {
            staffBUS = new BUSStaff();
            rolePermissionDataTable = new DataTable();
            rolePermissionBUS = new BUSRolePermission();
            rolePermissionDTO = new DTORolePermission();
            rolePermissionDTO.RolePermissionID = frmHomePage.staffLogin.RolePermissionId;
            rolePermissionDTO.RolePermissionName = rolePermissionBUS.GetRolePermissionNameById(rolePermissionDTO.RolePermissionID);
        }

        private void InitfrmInfoStaff()
        {
            this.txtStaffId.Text = frmHomePage.staffLogin.StaffID;
            this.txtStaffName.Text = frmHomePage.staffLogin.Name;
            this.txtStaffPhone.Text = frmHomePage.staffLogin.Phone;
            this.txtStaffEmail.Text = frmHomePage.staffLogin.Email;
            this.txtStaffAddress.Text = frmHomePage.staffLogin.Address;
            this.txtUser.Text = frmHomePage.staffLogin.UserName;
            this.txtPass.Text = frmHomePage.staffLogin.Password;
            this.dateBirthDay.Text = frmHomePage.staffLogin.Birthday.ToShortDateString();
            this.dateToWork.Text = frmHomePage.staffLogin.DateCreated.ToShortDateString();
            this.cmbStaffGender.Text = frmHomePage.staffLogin.Gender;
            this.txtStaffCharge.Text = rolePermissionDTO.RolePermissionName;
        }

        private void frmStaffInfor_Load(object sender, EventArgs e)
        {
            InitfrmInfoStaff();
            InitDisplay(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InitDisplay(true);
            btnDetroyUpdate.Visible = true;
            btnSave.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void sbtnDetroyUpdate_Click(object sender, EventArgs e)
        {
            InitDisplay(false);
            btnDetroyUpdate.Visible = false;
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            this.grpChangePassword.Enabled = true;
            txtPassNew.Text = txtPassOld.Text = txtPassReplay.Text = null;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            this.grpChangePassword.Enabled = false;
            ChangePassWord();
        }

        //Ham thay doi mat khau
        private void ChangePassWord()
        {
            if (Utils.GetMD5(txtPassOld.Text.Trim()).Equals(frmHomePage.staffLogin.Password))
            {
                if (txtPassReplay.Text.Equals(txtPassNew.Text.Trim()))
                {
                    //thục hiện Update mật khẩu
                    frmHomePage.staffLogin.Password = Utils.GetMD5(txtPassReplay.Text.Trim());
                    //
                    if (staffBUS.UpdateStaffForPassword(frmHomePage.staffLogin.StaffID, frmHomePage.staffLogin.Password))
                    {
                        XtraCustomMessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", true, 1);
                        this.Close();
                    }
                    else
                    {
                        txtPassNew.Text = txtPassOld.Text = txtPassReplay.Text = "";
                        XtraCustomMessageBox.Show("Đổi mậu khẩu thất bại!", "Lỗi", true, 4);
                    }
                }
                else
                {
                    txtPassNew.Text = txtPassReplay.Text = "";
                    XtraCustomMessageBox.Show("Mật khẩu mới và xác nhận không hợp lệ. Vui lòng nhập lại!", "Cảnh báo", true, 3);
                }
            }
            else
            {
                XtraCustomMessageBox.Show("Sai mật khẩu. Vui lòng nhập lại!", "Cảnh báo", true, 3);
            }
        }

        private void frmStaffInfor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnSave_Click(null, null);
            else
                if (e.KeyCode == Keys.F4)
                    btnUpdate_Click(null, null);
                else
                    if (e.KeyCode == Keys.Escape)
                        sbtnDetroyUpdate_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            staffDTO = frmHomePage.staffLogin;
            staffDTO.Name = Utils.standardNamePerson(txtStaffName.Text.Trim());
            staffDTO.Phone = txtStaffPhone.Text.Trim();
            staffDTO.Email = txtStaffEmail.Text.Trim();
            staffDTO.Birthday = dateBirthDay.DateTime;
            staffDTO.Address = Utils.standardNamePerson(txtStaffAddress.Text.Trim());
            staffDTO.Gender = cmbStaffGender.Text.Trim();

            if (staffBUS.UpdateStaffNoUsernamePassword(staffDTO))
            {
                XtraCustomMessageBox.Show("Cập nhật thành công!", "Thông báo", false, 1);
                frmHomePage.staffLogin = staffDTO;
                InitDisplay(false);
                InitfrmInfoStaff();
            }
            else
                XtraCustomMessageBox.Show("Cập nhật thất bại!", "Lỗi", false, 4);

        }
    }
}
