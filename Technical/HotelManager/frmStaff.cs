using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using BusinessLayer;
using System.Text.RegularExpressions;
using System.Collections;
using DataTransferObject.Utils;
using HotelManager.General;

namespace HotelManager
{
    public partial class frmStaff : Form
    {
        #region "Variable"
        private DTORolePermission rolePermissionObject;
        private DataTable rolePermissionDataTable;
        private BUSRolePermission rolePermissionBUS;
        private DTOStaff staffObject;
        private BUSStaff staffBUS;
        private DataTable staffDataTable;
        private GridCheckMarksSelection staffMultiSelect;
        private BUSRule ruleBUS;
        private int maxAge, minAge;
        #endregion

        public frmStaff()
        {
            InitializeComponent();
            rolePermissionDataTable = new DataTable();
            rolePermissionBUS = new BUSRolePermission();
            rolePermissionObject = new DTORolePermission();
            staffDataTable = new DataTable();
            staffBUS = new BUSStaff();
            staffObject = new DTOStaff();
            staffMultiSelect = new GridCheckMarksSelection(grdvListStaff);
            ruleBUS = new BUSRule();
            StaffSno.VisibleIndex = 1;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //
            rolePermissionDataTable = rolePermissionBUS.GetAllRolePermission();
            lkStaffCharge.Properties.DataSource = rolePermissionDataTable;
            lkStaffCharge.Properties.DisplayMember = "RolePermissionName";
            lkStaffCharge.Properties.ValueMember = "RolePermissionID";
            //
            staffDataTable = staffBUS.GetAllStaff();
            grdListStaff.DataSource = staffDataTable;
            //
            minAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiThieu"));
            maxAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiDa"));

            LoadSerach();
        }

        private void grdvListStaff_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtStaffId.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "StaffID").ToString();
                txtStaffName.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "StaffName").ToString();
                txtStaffAddress.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "Address").ToString();
                dateBirthDay.DateTime = Convert.ToDateTime(grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "DateOfBirth").ToString());
                dateToWork.DateTime = Convert.ToDateTime(grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "DateCreated").ToString());
                txtStaffEmail.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
                cmbStaffGender.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "Sex").ToString();
                txtStaffPhone.Text = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "PhoneNumber").ToString();
                lkStaffCharge.EditValue = grdvListStaff.GetRowCellValue(e.FocusedRowHandle, "RolePermissionID");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        //Ham chuyen từ chuỗi có dấu sang không dấu
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        //Ham tao ten dang nhap
        private string createUserName(string str, string ngayS)
        {
            str = convertToUnSign3(str).Trim();
            str = str.Substring(str.LastIndexOf(" ") + 1);
            //lay so id cua nhan vien
            int lenght = ngayS.LastIndexOf("/");
            string temp = ngayS.Substring(lenght + 3, 2);
            return (str + temp).ToLower();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (staffMultiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Cảnh báo", true, 3);
                return;
            }
            try
            {
                ArrayList _listStaffId = new ArrayList();
                grdvListStaff.FocusedRowHandle -= 1;
                foreach (DataRowView _rowData in staffMultiSelect.Selection)
                {
                    staffObject = new DTOStaff();
                    staffObject.StaffID = _rowData["StaffID"].ToString();
                    if (!staffBUS.DeleteStaff(staffObject.StaffID))
                    {
                        _listStaffId.Add(_rowData["StaffID"]);
                    }
                }
                if (_listStaffId.Count != 0)
                {
                    String _erroContent = "Không thể xóa các nhân viên có mã: \n";
                    foreach (var item in _listStaffId)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraCustomMessageBox.Show(_erroContent, "Lỗi", true, 4);
                }
                else
                {
                    XtraCustomMessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", true, 1);
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Xóa dữ liệu thất bại", "Lỗi", true, 4);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnDelete);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
                return;
            try
            {
                if (m_IsAdd)
                {
                    String _user = createUserName(txtStaffName.Text, dateBirthDay.DateTime.ToString());
                    String _pass = Utils.GetMD5("123456789");

                    staffObject = new DTOStaff("NV000000", txtStaffName.Text, cmbStaffGender.Text, dateBirthDay.DateTime, txtStaffAddress.Text, txtStaffPhone.Text, txtStaffEmail.Text,
                        dateToWork.DateTime, lkStaffCharge.EditValue.ToString(), _user, _pass);

                    if (staffBUS.InsertStaff(staffObject))
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", true, 1);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true, 4);
                    }
                }
                else
                {
                    staffObject = new DTOStaff(txtStaffId.Text, txtStaffName.Text, cmbStaffGender.Text, dateBirthDay.DateTime,
                        txtStaffAddress.Text, txtStaffPhone.Text, txtStaffEmail.Text,
                        dateToWork.DateTime, lkStaffCharge.EditValue.ToString(), null, null);

                    if (staffBUS.UpdateStaffNoUsernamePassword(staffObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!\nVui lòng thiết lập quyền truy cập hệ thống cho nhân viên '" + staffObject.Name + "'!", "Thông báo", true, 1);

                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", true, 4);
                    }
                }
            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Lưu dữ liệu thất bại!", "Lỗi", true, 4);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }


        }
        private bool m_IsAdd = false;
        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        staffMultiSelect.ClearSelection();
                        //
                        txtStaffId.Text = "NV00000**";
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtStaffName.Properties.ReadOnly = false;
                        txtStaffName.Focus();
                        txtStaffAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtStaffEmail.Properties.ReadOnly = false;
                        cmbStaffGender.Properties.ReadOnly = false;
                        txtStaffPhone.Properties.ReadOnly = false;
                        dateToWork.Properties.ReadOnly = false;
                        lkStaffCharge.Properties.ReadOnly = false;
                        //
                        grdvListStaff.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListStaff.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        txtStaffName.EditValue = null;
                        txtStaffAddress.EditValue = null;
                        dateBirthDay.EditValue = null;
                        dateToWork.EditValue = null;
                        txtStaffEmail.EditValue = null;
                        cmbStaffGender.EditValue = null;
                        txtStaffPhone.EditValue = null;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        m_IsAdd = false;
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtStaffName.Properties.ReadOnly = true;
                        txtStaffAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtStaffEmail.Properties.ReadOnly = true;
                        cmbStaffGender.Properties.ReadOnly = true;
                        txtStaffPhone.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkStaffCharge.Properties.ReadOnly = true;
                        //
                        grdvListStaff.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStaff.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        staffDataTable = staffBUS.GetAllStaff();
                        grdListStaff.DataSource = staffDataTable;
                        grdvListStaff.FocusedRowHandle = -1;
                        grdvListStaff.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnCancelOfUpdate":
                    {
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        btnUpdate.Visible = true;
                        //
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnAdd.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        txtStaffName.Properties.ReadOnly = true;
                        txtStaffAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtStaffEmail.Properties.ReadOnly = true;
                        cmbStaffGender.Properties.ReadOnly = true;
                        txtStaffPhone.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkStaffCharge.Properties.ReadOnly = true;
                        //
                        grdvListStaff.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStaff.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        staffDataTable = staffBUS.GetAllStaff();
                        grdListStaff.DataSource = staffDataTable;
                        grdvListStaff.FocusedRowHandle = -1;
                        grdvListStaff.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        staffDataTable = staffBUS.GetAllStaff();
                        grdListStaff.DataSource = staffDataTable;
                        grdvListStaff.FocusedRowHandle = grdvListStaff.DataRowCount - 1;
                        staffMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        staffMultiSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        btnAdd.Enabled = false;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtStaffName.Properties.ReadOnly = false;
                        txtStaffName.Focus();
                        txtStaffAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtStaffEmail.Properties.ReadOnly = false;
                        cmbStaffGender.Properties.ReadOnly = false;
                        txtStaffPhone.Properties.ReadOnly = false;
                        dateToWork.Properties.ReadOnly = false;
                        lkStaffCharge.Properties.ReadOnly = false;
                        //
                        grdvListStaff.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListStaff.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        break;
                    }
                case "btnSave":
                    {
                        m_IsAdd = false;
                        btnUpdate.Visible = true;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnUpdate.Visible = true;
                        btnSave.Enabled = false;
                        //
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        //
                        txtStaffName.Properties.ReadOnly = true;
                        txtStaffAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        dateToWork.Properties.ReadOnly = true;
                        lkStaffCharge.Properties.ReadOnly = true;
                        txtStaffEmail.Properties.ReadOnly = true;
                        cmbStaffGender.Properties.ReadOnly = true;
                        txtStaffPhone.Properties.ReadOnly = true;
                        //
                        grdvListStaff.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStaff.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        staffDataTable = staffBUS.GetAllStaff();
                        grdListStaff.DataSource = staffDataTable;
                        grdvListStaff.FocusedRowHandle = grdvListStaff.DataRowCount - 1;
                        staffMultiSelect.ClearSelection();
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
            }
        }

        private void btnCancelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void btnAddCharge_Click(object sender, EventArgs e)
        {
            frmDialogAddNewRolePermission dialogRolePermission = new frmDialogAddNewRolePermission();
            dialogRolePermission.ShowDialog();
            dialogRolePermission.ShowInTaskbar = false;
        }

        private bool checkData()
        {
            //if (dateBirthDay.DateTime < DateTime.Now && dateToWork.DateTime <= DateTime.Now)
            //{
            //    if (!staffBUS.checkAge(dateBirthDay.DateTime, dateToWork.DateTime))
            //    {
            //        dateBirthDay.Focus();
            //        dateToWork.EditValue = null;
            //        dateBirthDay.EditValue = null;
            //        XtraCustomMessageBox.Show("Độ tuổi không phù hợp với quy định!\nXin vui lòng kiểm tra lại!", "Lỗi", true);
            //        return false;
            //    }

            //}
            //else
            //{
            //    XtraCustomMessageBox.Show("Ngày sinh hoặc ngày vào làm không thể lớn hơn ngày hiện tại", "Lỗi", true);
            //    return false;
            //}
            if (CheckInformationEntered.checkDataInput(txtStaffName, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtStaffAddress, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtStaffEmail, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtStaffPhone, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateBirthDay, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(cmbStaffGender, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateToWork, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(lkStaffCharge, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }

        private void lkStaffCharge_QueryPopUp(object sender, CancelEventArgs e)
        {
            rolePermissionDataTable = rolePermissionBUS.GetAllRolePermission();
            lkStaffCharge.Properties.DataSource = rolePermissionDataTable;
        }

        private void txtStaffNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }

        private void dateBirthDay_EditValueChanged(object sender, EventArgs e)
        {
            if (!btnAdd.Enabled || !btnUpdate.Enabled)
            {
                if (dateBirthDay.DateTime > DateTime.Now)
                {
                    dateBirthDay.Focus();
                    btnSave.Enabled = false;
                    dxErrorProvider.SetError(dateBirthDay, "Ngày sinh không thể lớn hơn ngày hiện tại!");
                }
                else if (dateBirthDay.DateTime.AddYears(minAge) > DateTime.Now && dateBirthDay.DateTime.AddYears(maxAge) > DateTime.Now)
                {
                    dateBirthDay.Focus();
                    btnSave.Enabled = false;
                    dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                    //dateBirthDay.EditValue = null;
                }
                else
                {
                    btnSave.Enabled = true;
                    dxErrorProvider.ClearErrors();
                }
            }
        }
        private void dateToWork_EditValueChanged(object sender, EventArgs e)
        {
            if (!btnAdd.Enabled || !btnUpdate.Enabled)
            {

                if (dateToWork.DateTime > DateTime.Now)
                {
                    dateToWork.Focus();
                    btnSave.Enabled = false;
                    dxErrorProvider.SetError(dateToWork, "Ngày vào làm không thể lớn hơn ngày hiện tại!");
                    return;
                }
                else
                {
                    if (dateBirthDay.DateTime.AddYears(minAge) > DateTime.Now && dateBirthDay.DateTime.AddYears(maxAge) > DateTime.Now)
                    {
                        dateBirthDay.Focus();
                        btnSave.Enabled = false;
                        dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                        return;
                    }
                }

                if (!String.IsNullOrEmpty(dateBirthDay.Text))
                {
                    if (!staffBUS.checkAge(dateBirthDay.DateTime, dateToWork.DateTime))
                    {
                        dateBirthDay.Focus();
                        btnSave.Enabled = false;
                        dateToWork.EditValue = null;
                        dateToWork.Focus();
                        dxErrorProvider.SetError(dateToWork, "Độ tuổi không đúng với quy định!");
                    }
                    else
                    {
                        btnSave.Enabled = true;
                        dxErrorProvider.ClearErrors();
                    }
                }
            }
        }

        private void txtStaffEmail_Leave(object sender, EventArgs e)
        {
            if (!CheckInformationEntered.isEmail(txtStaffEmail.Text.Trim()))
            {
                txtStaffEmail.Focus();
                dxErrorProvider.SetError(txtStaffEmail, "Email không đúng định dạng!");
            }
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void frmStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnSave_Click(null, null);
            else
                if (e.KeyCode == Keys.F4)
                    btnDelete_Click(null, null);
                else
                    if (e.KeyCode == Keys.F6)
                        btnUpdate_Click(null, null);
                    else
                        if (e.KeyCode == Keys.F8)
                            btnAdd_Click(null, null);
        }
      
    }
}