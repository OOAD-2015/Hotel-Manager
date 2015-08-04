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
using BusinessLayer;
using DataTransferObject;
using HotelManager.General;
using System.Text.RegularExpressions;
using System.Collections;

namespace HotelManager
{
    public partial class frmCustomer : Form
    {
        #region "Variable"
        private DTORolePermission rolePermissionObject;
        private DataTable rolePermissionDataTable;
        private BUSRolePermission rolePermissionBUS;
        private DTOCustomer customerObject;
        private BUSCustomer customerBUS;
        private DataTable customerDataTable;
        private GridCheckMarksSelection customerMultiSelect;
        private BUSRule ruleBUS;
        private int maxAge, minAge;
        #endregion

        public frmCustomer()
        {
            InitializeComponent();
            rolePermissionDataTable = new DataTable();
            rolePermissionBUS = new BUSRolePermission();
            rolePermissionObject = new DTORolePermission();
            customerDataTable = new DataTable();
            customerBUS = new BUSCustomer();
            customerObject = new DTOCustomer();
            customerMultiSelect = new GridCheckMarksSelection(grdvListCustomer);
            ruleBUS = new BUSRule();
            CustomerSno.VisibleIndex = 1;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            customerDataTable = customerBUS.GetAllCustomer();
            grdListCustomer.DataSource = customerDataTable;
            //
            minAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiThieu"));
            maxAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiDa"));

            LoadSerach();
        }

        private void grdvListCustomer_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                txtCustomerId.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "CustomerID").ToString();
                txtCustomerName.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "CustomerName").ToString();
                txtCustomerAddress.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "Address").ToString();
                dateBirthDay.DateTime = Convert.ToDateTime(grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "DateOfBirth").ToString());
                txtCustomerEmail.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "Email").ToString();
                cmbCustomerGender.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "Gender").ToString();
                txtCustomerPhone.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "PhoneNumber").ToString();
                txtCMND.Text = grdvListCustomer.GetRowCellValue(e.FocusedRowHandle, "IDNumber").ToString();
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
            if (customerMultiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Cảnh báo", true, 3);
                return;
            }
            try
            {
                ArrayList _listCustomerId = new ArrayList();
                grdvListCustomer.FocusedRowHandle -= 1;
                foreach (DataRowView _rowData in customerMultiSelect.Selection)
                {
                    customerObject = new DTOCustomer();
                    customerObject.CustomerID = _rowData["CustomerID"].ToString();
                    if (!customerBUS.DeleteCustomer(customerObject.CustomerID))
                    {
                        _listCustomerId.Add(_rowData["CustomerID"]);
                    }
                }
                if (_listCustomerId.Count != 0)
                {
                    String _erroContent = "Không thể xóa các khách hàng có mã: \n";
                    foreach (var item in _listCustomerId)
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
                    customerObject = new DTOCustomer("KH000000", txtCustomerName.Text, cmbCustomerGender.Text, dateBirthDay.DateTime,
                        txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerEmail.Text, txtCMND.Text);

                    if (customerBUS.InsertCustomer(customerObject))
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
                    customerObject = new DTOCustomer(txtCustomerId.Text, txtCustomerName.Text, cmbCustomerGender.Text, dateBirthDay.DateTime,
                        txtCustomerAddress.Text, txtCustomerPhone.Text, txtCustomerEmail.Text, txtCMND.Text);

                    if (customerBUS.UpdateCustomer(customerObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true, 1);
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
                        customerMultiSelect.ClearSelection();
                        //
                        txtCustomerId.Text = "KH00000**";
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtCustomerName.Properties.ReadOnly = false;
                        txtCustomerName.Focus();
                        txtCustomerAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtCustomerEmail.Properties.ReadOnly = false;
                        cmbCustomerGender.Properties.ReadOnly = false;
                        txtCustomerPhone.Properties.ReadOnly = false;
                        txtCMND.Properties.ReadOnly = false;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        txtCustomerName.EditValue = null;
                        txtCustomerAddress.EditValue = null;
                        dateBirthDay.EditValue = null;
                        txtCustomerEmail.EditValue = null;
                        cmbCustomerGender.EditValue = null;
                        txtCustomerPhone.EditValue = null;
                        txtCMND.EditValue = null;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        txtCMND.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        customerDataTable = customerBUS.GetAllCustomer();
                        grdListCustomer.DataSource = customerDataTable;
                        grdvListCustomer.FocusedRowHandle = -1;
                        grdvListCustomer.FocusedRowHandle = 0;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        txtCMND.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        customerDataTable = customerBUS.GetAllCustomer();
                        grdListCustomer.DataSource = customerDataTable;
                        grdvListCustomer.FocusedRowHandle = -1;
                        grdvListCustomer.FocusedRowHandle = 0;
                        break;
                    }
                case "btnDelete":
                    {
                        customerDataTable = customerBUS.GetAllCustomer();
                        grdListCustomer.DataSource = customerDataTable;
                        grdvListCustomer.FocusedRowHandle = grdvListCustomer.DataRowCount - 1;
                        customerMultiSelect.ClearSelection();
                        break;
                    }
                case "btnUpdate":
                    {
                        m_IsAdd = false;
                        //
                        customerMultiSelect.ClearSelection();
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        btnAdd.Enabled = false;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtCustomerName.Properties.ReadOnly = false;
                        txtCustomerName.Focus();
                        txtCustomerAddress.Properties.ReadOnly = false;
                        dateBirthDay.Properties.ReadOnly = false;
                        txtCustomerEmail.Properties.ReadOnly = false;
                        cmbCustomerGender.Properties.ReadOnly = false;
                        txtCustomerPhone.Properties.ReadOnly = false;
                        txtCMND.Properties.ReadOnly = false;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtCustomerName.Properties.ReadOnly = true;
                        txtCustomerAddress.Properties.ReadOnly = true;
                        dateBirthDay.Properties.ReadOnly = true;
                        txtCustomerEmail.Properties.ReadOnly = true;
                        cmbCustomerGender.Properties.ReadOnly = true;
                        txtCustomerPhone.Properties.ReadOnly = true;
                        txtCMND.Properties.ReadOnly = true;
                        //
                        grdvListCustomer.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListCustomer.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        customerDataTable = customerBUS.GetAllCustomer();
                        grdListCustomer.DataSource = customerDataTable;
                        grdvListCustomer.FocusedRowHandle = grdvListCustomer.DataRowCount - 1;
                        customerMultiSelect.ClearSelection();
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
            if (CheckInformationEntered.checkDataInput(txtCustomerName, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerAddress, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerEmail, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCustomerPhone, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(dateBirthDay, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(txtCMND, "Dữ liệu không thể để trống", ref dxErrorProvider) &&
                CheckInformationEntered.checkDataInput(cmbCustomerGender, "Dữ liệu không thể để trống", ref dxErrorProvider))
            {
                return true;
            }
            return false;
        }

        private void lkCustomerCharge_QueryPopUp(object sender, CancelEventArgs e)
        {
            rolePermissionDataTable = rolePermissionBUS.GetAllRolePermission();
        }

        private void txtCustomerNameLA_KeyPress(object sender, KeyPressEventArgs e)
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
                else
                {
                    btnSave.Enabled = true;
                    dxErrorProvider.ClearErrors();
                }
            }
        }

        private void txtCustomerEmail_Leave(object sender, EventArgs e)
        {
            if (!CheckInformationEntered.isEmail(txtCustomerEmail.Text.Trim()))
            {
                txtCustomerEmail.Focus();
                dxErrorProvider.SetError(txtCustomerEmail, "Email không đúng định dạng!");
            }
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

    }
}