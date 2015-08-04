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
using HotelManager.General;
using BusinessLayer;
using DataTransferObject;
using DataTransferObject.Utils;

namespace HotelManager
{
    public partial class frmServiceType : DevExpress.XtraEditors.XtraForm
    {
       #region "variable"
        private GridCheckMarksSelection servicesTypeMulitiSelect;
        private BUSServicesType servicesTypeBUS;
        private DataTable servicesTypeDataTable;
        private DTOServicesType servicesTypeObject;
        private bool m_IsAdd;
        #endregion
        public frmServiceType()
        {
            InitializeComponent();

            servicesTypeMulitiSelect = new GridCheckMarksSelection(grdvListServicesType);
            servicesTypeBUS = new BUSServicesType();
            servicesTypeDataTable = new DataTable();
            ServicesTypeSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmServicesType_Load(object sender, EventArgs e)
        {
            servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
            grdListServicesType.DataSource = servicesTypeDataTable;
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
                        txtServicesTypeId.Text = grdvListServicesType.GetRowCellValue(e.FocusedRowHandle, grdvListServicesType.Columns["ServicesTypeID"]).ToString();
                        txtServicesTypeName.Text = grdvListServicesType.GetRowCellValue(e.FocusedRowHandle, grdvListServicesType.Columns["ServicesTypeName"]).ToString();
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
            if (servicesTypeMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _listservicesTypeObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in servicesTypeMulitiSelect.Selection)
                {
                    grdvListServicesType.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    servicesTypeObject = new DTOServicesType(_rowObjectDetail.Row["ServicesTypeID"].ToString(), _rowObjectDetail.Row["ServicesTypeName"].ToString());
                    if (!servicesTypeBUS.DeleteServicesType(servicesTypeObject.ServicesTypeID))
                    {
                        _listservicesTypeObjectInDelibility.Add(_rowObjectDetail.Row["ServicesTypeID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các thế loại sách có mã số: \n";
                if (_listservicesTypeObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listservicesTypeObjectInDelibility)
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

        private void txtservicesTypeNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListServicesType.FocusedRowHandle = 0;
            servicesTypeDataTable = servicesTypeBUS.LookAtServicesType(txtServicesTypeNameLA.Text);
            grdListServicesType.DataSource = servicesTypeDataTable;
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        servicesTypeMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtServicesTypeId.Text = "LDV0000**";
                        txtServicesTypeName.Text = null;
                        txtServicesTypeName.Focus();
                        txtServicesTypeName.Properties.ReadOnly = false;
                        //
                        grdvListServicesType.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListServicesType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtServicesTypeName.Properties.ReadOnly = true;
                        //
                        grdvListServicesType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServicesType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
                        grdListServicesType.DataSource = servicesTypeDataTable;
                        grdvListServicesType.FocusedRowHandle = -1;
                        grdvListServicesType.FocusedRowHandle = 0;
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
                        txtServicesTypeName.Properties.ReadOnly = true;
                        //
                        grdvListServicesType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServicesType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
                        grdListServicesType.DataSource = servicesTypeDataTable;
                        grdvListServicesType.FocusedRowHandle = -1;
                        grdvListServicesType.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtServicesTypeName.Properties.ReadOnly = true;;
                        servicesTypeDataTable = new DataTable();
                        servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
                        grdListServicesType.DataSource = servicesTypeDataTable;
                        grdvListServicesType.FocusedRowHandle = 0;
                        servicesTypeMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        servicesTypeMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtServicesTypeName.Focus();
                        txtServicesTypeName.Properties.ReadOnly = false;
                        //
                        grdvListServicesType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServicesType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtServicesTypeName.Properties.ReadOnly = true;
                        //
                        grdvListServicesType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServicesType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
                        grdListServicesType.DataSource = servicesTypeDataTable;
                        grdvListServicesType.FocusedRowHandle = grdvListServicesType.DataRowCount - 1;
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
                    String servicesTypeName = Utils.standardNamePerson(txtServicesTypeName.Text);
                    servicesTypeObject = new DTOServicesType("LDV0000000", servicesTypeName);

                    if (servicesTypeBUS.InsertServicesType(servicesTypeObject))
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
                    String servicesTypeName = Utils.standardNamePerson(txtServicesTypeName.Text);
                    servicesTypeObject = new DTOServicesType(txtServicesTypeId.Text, servicesTypeName);

                    if (servicesTypeBUS.UpdateServicesType(servicesTypeObject))
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

        private void txtservicesTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtServicesTypeName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmServicesType_FormClosing(object sender, FormClosingEventArgs e)
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
            if (servicesTypeDataTable.Rows.Count <= 0)
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

        private void txtServicesTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmServicesType_KeyDown(object sender, KeyEventArgs e)
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