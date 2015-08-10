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
    public partial class frmServices : DevExpress.XtraEditors.XtraForm
    {
        #region "variable"
        private GridCheckMarksSelection servicesMulitiSelect;
        private BUSServices servicesBUS;
        private DataTable servicesDataTable;
        private DTOServices servicesObject;
        private bool m_IsAdd;
        private DataTable unitDataTable;
        private BUSUnit unitBUS;
        private BUSServicesType servicesTypeBUS;
        private DataTable servicesTypeDataTable;
        #endregion
        public frmServices()
        {
            InitializeComponent();

            unitDataTable = new DataTable();
            servicesTypeDataTable = new DataTable();
            servicesMulitiSelect = new GridCheckMarksSelection(grdvListServices);
            servicesBUS = new BUSServices();
            unitBUS = new BUSUnit();
            servicesTypeBUS = new BUSServicesType();
            servicesDataTable = new DataTable();
            ServicesSno.VisibleIndex = 1;
            m_IsAdd = false;
            btnSave.Enabled = false;
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            //
            servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
            lkServicesType.Properties.DataSource = servicesTypeDataTable;
            lkServicesType.Properties.DisplayMember = "ServicesTypeName";
            lkServicesType.Properties.ValueMember = "ServicesTypeID";
            //
            unitDataTable = unitBUS.GetAllUnit();
            lkUnit.Properties.DataSource = unitDataTable;
            lkUnit.Properties.DisplayMember = "UnitName";
            lkUnit.Properties.ValueMember = "UnitID";
            //
            servicesDataTable = servicesBUS.GetAllServices();
            grdListServices.DataSource = servicesDataTable;
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
                        txtServicesId.Text = grdvListServices.GetRowCellValue(e.FocusedRowHandle, grdvListServices.Columns["ServicesID"]).ToString();
                        txtServicesName.Text = grdvListServices.GetRowCellValue(e.FocusedRowHandle, grdvListServices.Columns["ServicesName"]).ToString();
                        lkUnit.EditValue = grdvListServices.GetRowCellValue(e.FocusedRowHandle, "UnitID");
                        lkServicesType.EditValue = grdvListServices.GetRowCellValue(e.FocusedRowHandle, "ServicesTypeID");
                        spPrice.EditValue = grdvListServices.GetRowCellValue(e.FocusedRowHandle, grdvListServices.Columns["Price"]);
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
            if (servicesMulitiSelect.Selection.Count == 0)
            {
                XtraCustomMessageBox.Show("Chưa có dòng dữ liệu nào được chọn!", "Thông báo", true, 1);
                return;
            }
            try
            {
                System.Collections.ArrayList _listservicesObjectInDelibility = new System.Collections.ArrayList();
                foreach (object _rowObjectItem in servicesMulitiSelect.Selection)
                {
                    grdvListServices.FocusedRowHandle -= 1;
                    DataRowView _rowObjectDetail = _rowObjectItem as DataRowView;
                    servicesObject = new DTOServices(_rowObjectDetail.Row["ServicesID"].ToString(), _rowObjectDetail.Row["ServicesName"].ToString(), _rowObjectDetail.Row["ServicesTypeID"].ToString(), _rowObjectDetail.Row["UnitID"].ToString(), Int32.Parse(_rowObjectDetail.Row["Price"].ToString()));
                    if (!servicesBUS.DeleteServices(servicesObject.ServicesID))
                    {
                        _listservicesObjectInDelibility.Add(_rowObjectDetail.Row["ServicesID"]);
                    }
                }
                String _erroContent = "Không thể xóa thông tin các thế loại sách có mã số: \n";
                if (_listservicesObjectInDelibility.Count != 0)
                {
                    foreach (var item in _listservicesObjectInDelibility)
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

        private void txtservicesNameLA_TextChanged(object sender, EventArgs e)
        {
            grdvListServices.FocusedRowHandle = 0;
            servicesDataTable = servicesBUS.LookAtServices(txtServicesNameLA.Text);
            grdListServices.DataSource = servicesDataTable;
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnAdd":
                    {
                        servicesMulitiSelect.ClearSelection();
                        //
                        btnAdd.Visible = false;
                        btnCancel.Visible = true;
                        //
                        btnSave.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        //
                        txtServicesId.Text = "DV0000**";
                        txtServicesName.Text = null;
                        txtServicesName.Focus();
                        txtServicesName.Properties.ReadOnly = false;
                        spPrice.EditValue = 0;
                        spPrice.ReadOnly = false;
                        lkUnit.Properties.ReadOnly = false;
                        lkServicesType.Properties.ReadOnly = false;
                        //
                        grdvListServices.OptionsSelection.EnableAppearanceFocusedRow = false;
                        grdvListServices.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtServicesName.Properties.ReadOnly = true;
                        spPrice.ReadOnly = true;
                        lkUnit.Properties.ReadOnly = true;
                        lkServicesType.Properties.ReadOnly = true;
                        //
                        grdvListServices.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServices.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesDataTable = servicesBUS.GetAllServices();
                        grdListServices.DataSource = servicesDataTable;
                        grdvListServices.FocusedRowHandle = -1;
                        grdvListServices.FocusedRowHandle = 0;
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
                        txtServicesName.Properties.ReadOnly = true;
                        spPrice.ReadOnly = true;
                        lkUnit.Properties.ReadOnly = true;
                        lkServicesType.Properties.ReadOnly = true;
                        //
                        grdvListServices.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServices.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesDataTable = servicesBUS.GetAllServices();
                        grdListServices.DataSource = servicesDataTable;
                        grdvListServices.FocusedRowHandle = -1;
                        grdvListServices.FocusedRowHandle = 0;
                        //
                        dxErrorProvider.ClearErrors();
                        break;
                    }
                case "btnDelete":
                    {
                        txtServicesName.Properties.ReadOnly = true; ;
                        servicesDataTable = new DataTable();
                        servicesDataTable = servicesBUS.GetAllServices();
                        grdListServices.DataSource = servicesDataTable;
                        grdvListServices.FocusedRowHandle = 0;
                        servicesMulitiSelect.ClearSelection();
                        InitControlByData();
                        break;
                    }
                case "btnUpdate":
                    {
                        servicesMulitiSelect.ClearSelection();
                        m_IsAdd = false;
                        //
                        btnUpdate.Visible = false;
                        btnCancelOfUpdate.Visible = true;
                        //
                        txtServicesName.Focus();
                        txtServicesName.Properties.ReadOnly = false;
                        //
                        spPrice.ReadOnly = false;
                        lkUnit.Properties.ReadOnly = false;
                        lkServicesType.Properties.ReadOnly = false;
                        //
                        grdvListServices.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServices.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = false;
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
                        txtServicesName.Properties.ReadOnly = true;
                        //
                        spPrice.ReadOnly = true;
                        lkUnit.Properties.ReadOnly = true;
                        lkServicesType.Properties.ReadOnly = true;
                        //
                        grdvListServices.OptionsSelection.EnableAppearanceFocusedRow = true;
                        grdvListServices.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;
                        //
                        servicesDataTable = servicesBUS.GetAllServices();
                        grdListServices.DataSource = servicesDataTable;
                        grdvListServices.FocusedRowHandle = grdvListServices.DataRowCount - 1;
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
                    String servicesName = Utils.standardNamePerson(txtServicesName.Text);
                    String servicesType = lkServicesType.EditValue.ToString();
                    String unit = lkUnit.EditValue.ToString();
                    int price = Int32.Parse(spPrice.Value.ToString());

                    servicesObject = new DTOServices("DV00000000", servicesName, servicesType, unit, price);

                    if (servicesBUS.InsertServices(servicesObject))
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
                    String servicesName = Utils.standardNamePerson(txtServicesName.Text);
                    String servicesType = lkServicesType.EditValue.ToString();
                    String unit = lkUnit.EditValue.ToString();
                    int price = Int32.Parse(spPrice.Value.ToString());

                    servicesObject = new DTOServices(txtServicesId.Text, servicesName, servicesType, unit, price);

                    if (servicesBUS.UpdateServices(servicesObject))
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

        private void txtservicesName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }
        private void txtAuthorAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 2);
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtServicesName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmServices_FormClosing(object sender, FormClosingEventArgs e)
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
            if (servicesDataTable.Rows.Count <= 0)
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

        private void txtServicesName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveDataToDatabase();
            }
        }

        private void frmServices_KeyDown(object sender, KeyEventArgs e)
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

        private void btnAddServicesType_Click(object sender, EventArgs e)
        {
            frmDialogAddNewServicesType dialogServicesType = new frmDialogAddNewServicesType();
            dialogServicesType.ShowDialog();
            dialogServicesType.ShowInTaskbar = false;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            frmDialogAddNewUnit dialogUnit = new frmDialogAddNewUnit();
            dialogUnit.ShowDialog();
            dialogUnit.ShowInTaskbar = false;
        }

        private void lkUnit_QueryPopUp(object sender, CancelEventArgs e)
        {
            unitDataTable = unitBUS.GetAllUnit();
            lkUnit.Properties.DataSource = unitDataTable;
        }

        private void lkServicesType_QueryPopUp(object sender, CancelEventArgs e)
        {
            servicesTypeDataTable = servicesTypeBUS.GetAllServicesType();
            lkServicesType.Properties.DataSource = servicesTypeDataTable;
        }

    }
}
