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
    public partial class frmRoom : DevExpress.XtraEditors.XtraForm
    {
        #region "variable"
        private GridCheckMarksSelection roomMulitiSelect;
        private BUSRoom roomBUS;
        private DataTable roomDataTable;
        private DTORoom roomObject;
        private bool m_IsAdd;
        private DataTable statusDataTable;
        private BUSStatus statusBUS;
        private BUSRoomType roomTypeBUS;
        private DataTable roomTypeDataTable;
        #endregion
        public frmRoom()
        {
            InitializeComponent();

            statusDataTable = new DataTable();
            roomTypeDataTable = new DataTable();
            roomMulitiSelect = new GridCheckMarksSelection(grdvListRoom);
            roomBUS = new BUSRoom();
            statusBUS = new BUSStatus();
            roomTypeBUS = new BUSRoomType();
            roomDataTable = new DataTable();
            RoomSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            //
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            lkRoomType.Properties.DataSource = roomTypeDataTable;
            lkRoomType.Properties.DisplayMember = "RoomTypeName";
            lkRoomType.Properties.ValueMember = "RoomTypeID";
            //
            statusDataTable = statusBUS.GetAllStatus();
            lkStatus.Properties.DataSource = statusDataTable;
            lkStatus.Properties.DisplayMember = "StatusName";
            lkStatus.Properties.ValueMember = "StatusID";
            //
            roomDataTable = roomBUS.GetAllRoom();
            grdListRoom.DataSource = roomDataTable;
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
                        txtRoomId.Text = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, grdvListRoom.Columns["RoomID"]).ToString();
                        txtRoomName.Text = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, grdvListRoom.Columns["RoomName"]).ToString();
                        lkStatus.EditValue = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, "StatusID");
                        lkRoomType.EditValue = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, "RoomTypeID");
                        spNumberOfBeds.EditValue = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, grdvListRoom.Columns["NumberOfBeds"]);
                        rtxtDecription.Text = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, "Description").ToString();
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
            if (roomMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _listroomObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in roomMulitiSelect.Selection)
                {
                    grdvListRoom.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    roomObject = new DTORoom(_rowObjectDetail.Row["RoomID"].ToString(), _rowObjectDetail.Row["RoomName"].ToString(), _rowObjectDetail.Row["RoomTypeID"].ToString(), Int32.Parse(_rowObjectDetail.Row["NumberOfBeds"].ToString()), _rowObjectDetail.Row["Description"].ToString(), _rowObjectDetail.Row["StatusID"].ToString());
                    if (!roomBUS.DeleteRoom(roomObject.RoomID))
                    {
                        _listroomObjectInDelibility.Add(_rowObjectDetail.Row["RoomID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các thế loại sách có mã số: \n";
                if (_listroomObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listroomObjectInDelibility)
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

        //private void txtRoomNameLA_TextChanged(object sender, EventArgs e)
        //{
        //    grdvListRoom.FocusedRowHandle = 0;
        //    roomDataTable = roomBUS.LookAtRoom(txtRoomNameLA.Text);
        //    grdListRoom.DataSource = roomDataTable;
        //}

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        roomMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtRoomId.Text = "PH0000**";
                        txtRoomName.Text = null;
                        txtRoomName.Focus();
                        txtRoomName.Properties.ReadOnly = false;
                        spNumberOfBeds.EditValue = 0;
                        spNumberOfBeds.ReadOnly = false;
                        lkStatus.Properties.ReadOnly = false;
                        lkRoomType.Properties.ReadOnly = false;
                        rtxtDecription.Text = null;
                        rtxtDecription.ReadOnly = false;
                        //
                        grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtRoomName.Properties.ReadOnly = true;
                        spNumberOfBeds.ReadOnly = true;
                        lkStatus.Properties.ReadOnly = true;
                        lkRoomType.Properties.ReadOnly = true;
                        rtxtDecription.ReadOnly = true;
                        //
                        grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomDataTable = roomBUS.GetAllRoom();
                        grdListRoom.DataSource = roomDataTable;
                        grdvListRoom.FocusedRowHandle = -1;
                        grdvListRoom.FocusedRowHandle = 0;
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
                        txtRoomName.Properties.ReadOnly = true;
                        spNumberOfBeds.ReadOnly = true;
                        lkStatus.Properties.ReadOnly = true;
                        lkRoomType.Properties.ReadOnly = true;
                        rtxtDecription.ReadOnly = true;
                        //
                        grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomDataTable = roomBUS.GetAllRoom();
                        grdListRoom.DataSource = roomDataTable;
                        grdvListRoom.FocusedRowHandle = -1;
                        grdvListRoom.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtRoomName.Properties.ReadOnly = true; ;
                        roomDataTable = new DataTable();
                        roomDataTable = roomBUS.GetAllRoom();
                        grdListRoom.DataSource = roomDataTable;
                        grdvListRoom.FocusedRowHandle = 0;
                        roomMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        roomMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtRoomName.Focus();
                        txtRoomName.Properties.ReadOnly = false;
                        //
                        spNumberOfBeds.ReadOnly = false;
                        lkStatus.Properties.ReadOnly = false;
                        lkRoomType.Properties.ReadOnly = false;
                        rtxtDecription.ReadOnly = false;
                        //
                        grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtRoomName.Properties.ReadOnly = true;
                        //
                        spNumberOfBeds.ReadOnly = true;
                        lkStatus.Properties.ReadOnly = true;
                        lkRoomType.Properties.ReadOnly = true;
                        rtxtDecription.ReadOnly = true;
                        //
                        grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        roomDataTable = roomBUS.GetAllRoom();
                        grdListRoom.DataSource = roomDataTable;
                        grdvListRoom.FocusedRowHandle = grdvListRoom.DataRowCount - 1;
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
                    String roomName = Utils.standardNamePerson(txtRoomName.Text);
                    String roomType = lkRoomType.EditValue.ToString();
                    int numberOfBeds = Int32.Parse(spNumberOfBeds.Value.ToString());
                    String Description = rtxtDecription.Text;
                    String status = lkStatus.EditValue.ToString();

                    roomObject = new DTORoom("PH00000000", roomName, roomType, numberOfBeds, Description, status);

                    if (roomBUS.InsertRoom(roomObject))
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
                    String roomName = Utils.standardNamePerson(txtRoomName.Text);
                    String roomType = lkRoomType.EditValue.ToString();
                    int numberOfBeds = Int32.Parse(spNumberOfBeds.Value.ToString());
                    String Description = rtxtDecription.Text;
                    String status = lkStatus.EditValue.ToString();

                    roomObject = new DTORoom(txtRoomId.Text, roomName, roomType, numberOfBeds, Description, status);

                    if (roomBUS.UpdateRoom(roomObject))
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

        private void txtroomName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtRoomName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmRoom_FormClosing(object sender, FormClosingEventArgs e)
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
            if (roomDataTable.Rows.Count <= 0)
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

        private void txtRoomName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmRoom_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAddRoomType_Click(object sender, EventArgs e)
        {
            frmDialogAddNewRoomType dialogRoomType = new frmDialogAddNewRoomType();
            dialogRoomType.ShowDialog();
            dialogRoomType.ShowInTaskbar = false;
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            frmDialogAddNewStatus dialogStatus = new frmDialogAddNewStatus();
            dialogStatus.ShowDialog();
            dialogStatus.ShowInTaskbar = false;
        }

        private void lkStatus_QueryPopUp(object sender, CancelEventArgs e)
        {
            statusDataTable = statusBUS.GetAllStatus();
            lkStatus.Properties.DataSource = statusDataTable;
        }

        private void lkRoomType_QueryPopUp(object sender, CancelEventArgs e)
        {
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            lkRoomType.Properties.DataSource = roomTypeDataTable;
        }

        private void txtRoomNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}