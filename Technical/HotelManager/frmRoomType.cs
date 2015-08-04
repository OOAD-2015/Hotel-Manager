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
    public partial class frmRoomType : DevExpress.XtraEditors.XtraForm
    {
         #region "variable"
        private GridCheckMarksSelection roomTypeMulitiSelect;
        private BUSRoomType roomTypeBUS;
        private DataTable roomTypeDataTable;
        private DTORoomType roomTypeObject;
        private bool m_IsAdd;
        #endregion
        public frmRoomType()
        {
            InitializeComponent();

            roomTypeMulitiSelect = new GridCheckMarksSelection(grdvListRoomType);
            roomTypeBUS = new BUSRoomType();
            roomTypeDataTable = new DataTable();
            RoomTypeSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            grdListRoomType.DataSource = roomTypeDataTable;
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
                        txtRoomTypeId.Text = grdvListRoomType.GetRowCellValue(e.FocusedRowHandle, grdvListRoomType.Columns["RoomTypeID"]).ToString();
                        txtRoomTypeName.Text = grdvListRoomType.GetRowCellValue(e.FocusedRowHandle, grdvListRoomType.Columns["RoomTypeName"]).ToString();
                        spPrices.EditValue = grdvListRoomType.GetRowCellValue(e.FocusedRowHandle, grdvListRoomType.Columns["Price"]).ToString();
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
            if (roomTypeMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _listroomTypeObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in roomTypeMulitiSelect.Selection)
                {
                    grdvListRoomType.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    roomTypeObject = new DTORoomType(_rowObjectDetail.Row["RoomTypeID"].ToString(), _rowObjectDetail.Row["RoomTypeName"].ToString());
                    if (!roomTypeBUS.DeleteRoomType(roomTypeObject.RoomTypeID))
                    {
                        _listroomTypeObjectInDelibility.Add(_rowObjectDetail.Row["RoomTypeID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các thế loại sách có mã số: \n";
                if (_listroomTypeObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listroomTypeObjectInDelibility)
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

        private void txtroomTypeNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListRoomType.FocusedRowHandle = 0;
            roomTypeDataTable = roomTypeBUS.LookAtRoomType(txtRoomTypeNameLA.Text);
            grdListRoomType.DataSource = roomTypeDataTable;
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        roomTypeMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtRoomTypeId.Text = "LP0000**";
                        txtRoomTypeName.Text = null;
                        txtRoomTypeName.Focus();
                        txtRoomTypeName.Properties.ReadOnly = false;
                        spPrices.EditValue = 0;
                        spPrices.ReadOnly = false;
                        //
                        grdvListRoomType.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListRoomType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtRoomTypeName.Properties.ReadOnly = true;
                        spPrices.ReadOnly = true;
                        //
                        grdvListRoomType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoomType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomTypeDataTable = roomTypeBUS.GetAllRoomType();
                        grdListRoomType.DataSource = roomTypeDataTable;
                        grdvListRoomType.FocusedRowHandle = -1;
                        grdvListRoomType.FocusedRowHandle = 0;
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
                        txtRoomTypeName.Properties.ReadOnly = true;
                        spPrices.ReadOnly = true;
                        //
                        grdvListRoomType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoomType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomTypeDataTable = roomTypeBUS.GetAllRoomType();
                        grdListRoomType.DataSource = roomTypeDataTable;
                        grdvListRoomType.FocusedRowHandle = -1;
                        grdvListRoomType.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtRoomTypeName.Properties.ReadOnly = true; ;
                        roomTypeDataTable = new DataTable();
                        roomTypeDataTable = roomTypeBUS.GetAllRoomType();
                        grdListRoomType.DataSource = roomTypeDataTable;
                        grdvListRoomType.FocusedRowHandle = 0;
                        roomTypeMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        roomTypeMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtRoomTypeName.Focus();
                        txtRoomTypeName.Properties.ReadOnly = false;
                        //
                        spPrices.ReadOnly = false;
                        //
                        grdvListRoomType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoomType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtRoomTypeName.Properties.ReadOnly = true;
                        //
                        spPrices.ReadOnly = true;
                        //
                        grdvListRoomType.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoomType.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomTypeDataTable = roomTypeBUS.GetAllRoomType();
                        grdListRoomType.DataSource = roomTypeDataTable;
                        grdvListRoomType.FocusedRowHandle = grdvListRoomType.DataRowCount - 1;
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
                    String roomTypeName = Utils.standardNamePerson(txtRoomTypeName.Text);
                    decimal roomTypePrices = Math.Round(spPrices.Value);
                    roomTypeObject = new DTORoomType("LP00000000", roomTypeName, roomTypePrices);

                    if (roomTypeBUS.InsertRoomType(roomTypeObject))
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
                    String roomTypeName = Utils.standardNamePerson(txtRoomTypeName.Text);
                    decimal roomTypePrices = Math.Round(spPrices.Value);
                    roomTypeObject = new DTORoomType(txtRoomTypeId.Text, roomTypeName, roomTypePrices);

                    if (roomTypeBUS.UpdateRoomType(roomTypeObject))
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

        private void txtroomTypeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtRoomTypeName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmRoomType_FormClosing(object sender, FormClosingEventArgs e)
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
            if (roomTypeDataTable.Rows.Count <= 0)
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

        private void txtRoomTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmRoomType_KeyDown(object sender, KeyEventArgs e)
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