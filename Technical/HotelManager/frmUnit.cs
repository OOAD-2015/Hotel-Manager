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
    public partial class frmUnit : Form
    {
          #region "variable"
        private GridCheckMarksSelection unitMulitiSelect;
        private BUSUnit unitBUS;
        private DataTable unitDataTable;
        private DTOUnit unitObject;
        private bool m_IsAdd;
        #endregion
        public frmUnit()
        {
            InitializeComponent();

            unitMulitiSelect = new GridCheckMarksSelection(grdvListUnit);
            unitBUS = new BUSUnit();
            unitDataTable = new DataTable();
            UnitSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {
            unitDataTable = unitBUS.GetAllUnit();
            grdListUnit.DataSource = unitDataTable;
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
                        txtUnitId.Text = grdvListUnit.GetRowCellValue(e.FocusedRowHandle, grdvListUnit.Columns["UnitID"]).ToString();
                        txtUnitName.Text = grdvListUnit.GetRowCellValue(e.FocusedRowHandle, grdvListUnit.Columns["UnitName"]).ToString();
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
            if (unitMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _listunitObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in unitMulitiSelect.Selection)
                {
                    grdvListUnit.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    unitObject = new DTOUnit(_rowObjectDetail.Row["UnitID"].ToString(), _rowObjectDetail.Row["UnitName"].ToString());
                    if (!unitBUS.DeleteUnit(unitObject.UnitID))
                    {
                        _listunitObjectInDelibility.Add(_rowObjectDetail.Row["UnitID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các thế loại sách có mã số: \n";
                if (_listunitObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listunitObjectInDelibility)
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

        private void txtunitNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListUnit.FocusedRowHandle = 0;
            unitDataTable = unitBUS.LookAtUnit(txtUnitNameLA.Text);
            grdListUnit.DataSource = unitDataTable;
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        unitMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtUnitId.Text = "DOV0000**";
                        txtUnitName.Text = null;
                        txtUnitName.Focus();
                        txtUnitName.Properties.ReadOnly = false;
                        //
                        grdvListUnit.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListUnit.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtUnitName.Properties.ReadOnly = true;
                        //
                        grdvListUnit.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListUnit.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        unitDataTable = unitBUS.GetAllUnit();
                        grdListUnit.DataSource = unitDataTable;
                        grdvListUnit.FocusedRowHandle = -1;
                        grdvListUnit.FocusedRowHandle = 0;
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
                        txtUnitName.Properties.ReadOnly = true;
                        //
                        grdvListUnit.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListUnit.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        unitDataTable = unitBUS.GetAllUnit();
                        grdListUnit.DataSource = unitDataTable;
                        grdvListUnit.FocusedRowHandle = -1;
                        grdvListUnit.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtUnitName.Properties.ReadOnly = true;;
                        unitDataTable = new DataTable();
                        unitDataTable = unitBUS.GetAllUnit();
                        grdListUnit.DataSource = unitDataTable;
                        grdvListUnit.FocusedRowHandle = 0;
                        unitMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        unitMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtUnitName.Focus();
                        txtUnitName.Properties.ReadOnly = false;
                        //
                        grdvListUnit.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListUnit.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtUnitName.Properties.ReadOnly = true;
                        //
                        grdvListUnit.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListUnit.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        unitDataTable = unitBUS.GetAllUnit();
                        grdListUnit.DataSource = unitDataTable;
                        grdvListUnit.FocusedRowHandle = grdvListUnit.DataRowCount - 1;
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
                    String unitName = Utils.standardNamePerson(txtUnitName.Text);
                    unitObject = new DTOUnit("DOV0000000", unitName);

                    if (unitBUS.InsertUnit(unitObject))
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
                    String unitName = Utils.standardNamePerson(txtUnitName.Text);
                    unitObject = new DTOUnit(txtUnitId.Text, unitName);

                    if (unitBUS.UpdateUnit(unitObject))
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

        private void txtunitName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtUnitName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmUnit_FormClosing(object sender, FormClosingEventArgs e)
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
            if (unitDataTable.Rows.Count <= 0)
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

        private void txtUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmUnit_KeyDown(object sender, KeyEventArgs e)
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
