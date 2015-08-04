using BusinessLayer;
using DataTransferObject;
using DataTransferObject.Utils;
using DevExpress.XtraEditors;
using HotelManager.General;
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
    public partial class frmStatus : Form
    {
           #region "variable"
        private GridCheckMarksSelection statusMulitiSelect;
        private BUSStatus statusBUS;
        private DataTable statusDataTable;
        private DTOStatus statusObject;
        private bool m_IsAdd;
        #endregion
        public frmStatus()
        {
            InitializeComponent();

            statusMulitiSelect = new GridCheckMarksSelection(grdvListStatus);
            statusBUS = new BUSStatus();
            statusDataTable = new DataTable();
            StatusSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            statusDataTable = statusBUS.GetAllStatus();
            grdListStatus.DataSource = statusDataTable;
            InitControlByData();
        }

        private void grdvListAuthor_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (!m_IsAdd)
                {

                    if (e.FocusedRowHandle >= 0)
                    {
                        txtStatusId.Text = grdvListStatus.GetRowCellValue(e.FocusedRowHandle, grdvListStatus.Columns["StatusID"]).ToString();
                        txtStatusName.Text = grdvListStatus.GetRowCellValue(e.FocusedRowHandle, grdvListStatus.Columns["StatusName"]).ToString();
                    }
                }
            }
            catch (System.Exception)
            {

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnAdd);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (statusMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _liststatusObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in statusMulitiSelect.Selection)
                {
                    grdvListStatus.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    statusObject = new DTOStatus(_rowObjectDetail.Row["StatusID"].ToString(), _rowObjectDetail.Row["StatusName"].ToString());
                    if (!statusBUS.DeleteStatus(statusObject.StatusID))
                    {
                        _liststatusObjectInDelibility.Add(_rowObjectDetail.Row["StatusID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin có mã số: \n";
                if (_liststatusObjectInDelibility.Count != 0)
                {
                    foreach (var item in _liststatusObjectInDelibility)
                    {
                        _erroContent += item.ToString() + "\n";
                    }
                    XtraCustomMessageBox.Show(_erroContent, "Lỗi", true, 4);
                }
                else
                    XtraCustomMessageBox.Show("Xóa dữ liệu thành công", "Thông báo", true, 1);
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
            SaveDataToDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);
        }

        private void txtstatusNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListStatus.FocusedRowHandle = 0;
            statusDataTable = statusBUS.LookAtStatus(txtStatusNameLA.Text);
            grdListStatus.DataSource = statusDataTable;
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        statusMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtStatusId.Text = "TT0000**";
                        txtStatusName.Text = null;
                        txtStatusName.Focus();
                        txtStatusName.Properties.ReadOnly = false;
                        //
                        grdvListStatus.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListStatus.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        m_IsAdd = true;
                        break;
                    }
                case "btnCancel":
                    {
                        //
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
                        txtStatusName.Properties.ReadOnly = true;
                        //
                        grdvListStatus.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStatus.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        statusDataTable = statusBUS.GetAllStatus();
                        grdListStatus.DataSource = statusDataTable;
                        grdvListStatus.FocusedRowHandle = -1;
                        grdvListStatus.FocusedRowHandle = 0;
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
                        txtStatusName.Properties.ReadOnly = true;
                        //
                        grdvListStatus.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStatus.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        statusDataTable = statusBUS.GetAllStatus();
                        grdListStatus.DataSource = statusDataTable;
                        grdvListStatus.FocusedRowHandle = -1;
                        grdvListStatus.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtStatusName.Properties.ReadOnly = true;;
                        statusDataTable = new DataTable();
                        statusDataTable = statusBUS.GetAllStatus();
                        grdListStatus.DataSource = statusDataTable;
                        grdvListStatus.FocusedRowHandle = 0;
                        statusMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        statusMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtStatusName.Focus();
                        txtStatusName.Properties.ReadOnly = false;
                        //
                        grdvListStatus.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStatus.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
                        //
                        btnDelete.Enabled = false;
                        btnAdd.Enabled = false;
                        btnSave.Enabled = true;
                        break;
                    }
                case "btnSave":
                    {
                        m_IsAdd = false;
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnSave.Enabled = false;
                        //
                        btnUpdate.Visible = true;
                        btnAdd.Visible = true;
                        btnCancel.Visible = false;
                        btnCancelOfUpdate.Visible = false;
                        //
                        txtStatusName.Properties.ReadOnly = true;
                        //
                        grdvListStatus.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListStatus.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        statusDataTable = statusBUS.GetAllStatus();
                        grdListStatus.DataSource = statusDataTable;
                        grdvListStatus.FocusedRowHandle = grdvListStatus.DataRowCount - 1;
                        break;
                    }
            }
        }

        private void SaveDataToDatabase()
        {
            if (!checkData())
            {
                return;
            }
            try
            {
                if (m_IsAdd)
                {
                    String statusName = Utils.standardNamePerson(txtStatusName.Text);
                    statusObject = new DTOStatus("TT0000000", statusName);

                    if (statusBUS.InsertStatus(statusObject))
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
                    String statusName = Utils.standardNamePerson(txtStatusName.Text);
                    statusObject = new DTOStatus(txtStatusId.Text, statusName);

                    if (statusBUS.UpdateStatus(statusObject))
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true, 1);
                    }
                    else
                    {
                        XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", true, 4);
                    }
                }

            }
            catch (System.Exception ex)
            {
                XtraCustomMessageBox.Show(ex.ToString(), "Lỗi", true, 3);
            }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnSave);
            }
        }
        private void btnCacelOfUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancelOfUpdate);
        }

        private void txtstatusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtStatusName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
             {
                 if (XtraCustomMessageBox.Show("Dữ liệu chưa được lưu!\nBạn có thực sự muốn thoát hay không?", "Cảnh báo", false, 3) == DialogResult.No)
                 {
                     e.Cancel = true;
                     return;
                 }
             }
        }

        private void InitControlByData()
        {
            if (statusDataTable.Rows.Count <= 0)
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtStatusName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmStatus_KeyDown(object sender, KeyEventArgs e)
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
