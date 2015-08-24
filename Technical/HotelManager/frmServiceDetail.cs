using BookStoreManager.Presentation.ReportForm;
using BusinessLayer;
using DataTransferObject;
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
    public partial class frmServiceDetail : Form
    {
        #region "Variable"

        private BUSServices servicesBUS;
        private DataTable serviceDataTable;
        private DataTable serviceDetailDataTable;
        private BUSServiceDetail serviceDetailBUS;
        private List<DTOServiceDetail> listServiceDetailObject;
        private BUSOrderDetail orderDetailBUS;
        private DataTable orderDetailDataTable;
        private GridCheckMarksSelection serviceDetailMultiselect;
        private BUSCustomer customerBUS;


        Dictionary<String, Object> m_listServiceObject = new Dictionary<String, Object>();
        #endregion

        public frmServiceDetail()
        {
            InitializeComponent();
            serviceDataTable = new DataTable();
            servicesBUS = new BUSServices();
            serviceDetailDataTable = new DataTable();
            serviceDetailBUS = new BUSServiceDetail();
            listServiceDetailObject = new List<DTOServiceDetail>();
            orderDetailDataTable = new DataTable();
            orderDetailBUS = new BUSOrderDetail();
            serviceDetailMultiselect = new GridCheckMarksSelection(grdvServiceDetail);
            customerBUS = new BUSCustomer();
        }

        private void frmServiceDetail_Load(object sender, EventArgs e)
        {
            //
            serviceDetailDataTable = serviceDetailBUS.GetAllServiceDetail();
            serviceDetailDataTable.Clear();
            DataColumn[] keys = new DataColumn[1];
            keys[0] = serviceDetailDataTable.Columns["ServiceID"];
            serviceDetailDataTable.PrimaryKey = keys;
            listServiceDetailObject.Clear();
            foreach (DataRow row in serviceDetailDataTable.Rows) // Loop over the rows.
            {
                listServiceDetailObject.Add(new DTOServiceDetail(row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), Int32.Parse(row.ItemArray[4].ToString()), Int32.Parse(row.ItemArray[5].ToString())));
            }
            //
            orderDetailDataTable = orderDetailBUS.GetAllOrderDetailFromNow();
            gvRoomOrder.DataSource = orderDetailDataTable;

            txtTotalMoney.Text = grdvServiceDetail.Columns["Monetized"].SummaryItem.SummaryValue == null ? "0" : grdvServiceDetail.Columns["Monetized"].SummaryItem.SummaryValue.ToString();
        }

        private void drbtnServiceChose_Click(object sender, EventArgs e)
        {
            //do du lieu len danh sach dich vu
            serviceDataTable.Clear();
            serviceDataTable = servicesBUS.GetAllServices();
            grdListServicePopup.DataSource = serviceDataTable;

            drbtnServiceChose.ShowDropDown();
        }

        private void drbtnServiceChose_ArrowButtonClick(object sender, EventArgs e)
        {
            //do du lieu len danh sach mat hang
            serviceDataTable.Clear();
            serviceDataTable = servicesBUS.GetAllServices();
            grdListServicePopup.DataSource = serviceDataTable;
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            drbtnServiceChose.HideDropDown();
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            choseServiceAddServiceDetail();
        }

        private void choseServiceAddServiceDetail()
        {
            try
            {
                if (m_listServiceObject.Count != 0)
                {
                    txtServiceId.Text = m_listServiceObject["ServicesID"].ToString();
                    txtServiceName.Text = m_listServiceObject["ServicesName"].ToString();
                    txtServiceTypeName.Text = m_listServiceObject["ServicesTypeName"].ToString();
                    spQuantity.EditValue = decimal.Parse(m_listServiceObject["Quantity"].ToString()); ;
                    spPrices.EditValue = decimal.Parse(m_listServiceObject["Price"].ToString());
                    ppControlService.HidePopup();
                }
            }
            catch (System.Exception) { }
            finally
            {
                updateEnableButtonAndResetValueOfControl(ref btnChose);
            }
        }

        private void grdvListServicePopup_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            choseServiceAddServiceDetail();
        }

        private void grdvListServicePopup_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                m_listServiceObject.Clear();
                m_listServiceObject.Add("ServicesID", grdvListServicePopup.GetRowCellValue(e.FocusedRowHandle, "ServicesID"));
                m_listServiceObject.Add("ServicesName", grdvListServicePopup.GetRowCellValue(e.FocusedRowHandle, "ServicesName"));
                m_listServiceObject.Add("ServicesTypeName", grdvListServicePopup.GetRowCellValue(e.FocusedRowHandle, "ServicesTypeName"));
                m_listServiceObject.Add("Price", grdvListServicePopup.GetRowCellValue(e.FocusedRowHandle, "Price"));
                m_listServiceObject.Add("Quantity", 1);
            }
        }

        private void spQuantity_EditValueChanged(object sender, EventArgs e)
        {
            if (spQuantity.Value.Equals(0) && spPrices.Value.Equals(0))
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
        }

        private void spQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
            catch (System.Exception)
            {

            }
        }

        private void spPrices_TextChanged(object sender, EventArgs e)
        {
            try
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
            catch (System.Exception)
            {

            }
        }

        private void spPrices_EditValueChanged(object sender, EventArgs e)
        {
            if (spQuantity.Value.Equals(0) && spPrices.Value.Equals(0))
            {
                spAmount.EditValue = spPrices.Value * spQuantity.Value;
            }
        }

        private void spQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void updateEnableButtonAndResetValueOfControl(ref SimpleButton _btnControl)
        {
            switch (_btnControl.Name)
            {
                case "btnChose":
                    {
                        spQuantity.Properties.ReadOnly = false;
                        btnAddInListServiceDetail.Enabled = true;
                        break;
                    }
                case "btnUpdate":
                    {
                        spQuantity.Properties.ReadOnly = false;
                        txtServiceId.Enabled = true;
                        //
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnAddInListServiceDetail.Enabled = true;
                        drbtnServiceChose.Enabled = true;
                        //
                        btnCancel.Enabled = true;
                        break;
                    }
                case "btnCancel":
                    {
                        spQuantity.Properties.ReadOnly = true;
                        txtServiceId.Enabled = false;
                        //
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnAddInListServiceDetail.Enabled = false;
                        drbtnServiceChose.Enabled = false;
                        btnCancel.Enabled = false;
                        //

                        break;
                    }
                case "btnSave":
                    {
                        spQuantity.Properties.ReadOnly = true;
                        txtServiceId.Enabled = false;
                        //
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = true;
                        btnAddInListServiceDetail.Enabled = false;
                        drbtnServiceChose.Enabled = false;
                        btnCancel.Enabled = false;
                        break;
                    }
            }
        }

        private void txtServiceId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String serviceId = txtServiceId.Text.Trim().ToUpper();
                //Kiểm tra xem service nhập vào đúng hay ko?
                if (servicesBUS.CheckServiceIsExistInDatabase(serviceId))
                {
                    btnAddInListServiceDetail.Enabled = true;
                    //
                    spPrices.Properties.ReadOnly = true;
                    spQuantity.Properties.ReadOnly = false;
                    spQuantity.EditValue = 0;
                    //
                    //du de ban
                    DataTable tb = servicesBUS.GetDataServicesById(serviceId);
                    txtServiceId.Text = serviceId;
                    txtServiceName.Text = tb.Rows[0][2].ToString();
                    txtServiceTypeName.Text = tb.Rows[0][4].ToString();
                    spPrices.EditValue = decimal.Parse(tb.Rows[0][5].ToString());
                    spQuantity.EditValue = decimal.Parse("1"); ;
                }
                else
                {
                    XtraCustomMessageBox.Show("Mã dịch vụ không đúng. Vui lòng nhập lại!", "Cảnh báo", true, 3);
                    txtServiceId.Text = null;
                    txtServiceName.Text = null;
                    txtServiceTypeName.Text = null;
                    spQuantity.EditValue = 0;
                    spPrices.EditValue = 0;
                    spAmount.EditValue = 0;
                }
            }
        }

        private void btnAddInListServiceDetail_Click(object sender, EventArgs e)
        {
            if (spQuantity.Value == 0)
            {
                XtraCustomMessageBox.Show("Số lượng dịch vụ phải lớn hơn 0", "Lỗi", true, 4);
                spQuantity.Focus();
                return;
            }
            //try
            //{
            DataRow _rowValue = serviceDetailDataTable.NewRow();
            _rowValue["ServicesID"] = txtServiceId.Text.Trim();
            _rowValue["ServicesName"] = txtServiceName.Text;
            _rowValue["OrderDetailID"] = lblOrderValue.Text;
            _rowValue["Quantity"] = spQuantity.Value;
            _rowValue["Price"] = spPrices.Value;
            _rowValue["Monetized"] = Math.Round(spAmount.Value);
            if (serviceDetailDataTable.Rows.Count != 0)
            {
                if (serviceDetailDataTable.Rows.Contains(txtServiceId.Text.Trim()))
                {
                    if (XtraMessageBox.Show("Dịch vụ này đã tồn tại trong danh sách!\nBạn có muốn cập nhật thông tin hay không?",
                                            "Thông báo",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning).Equals(DialogResult.Yes))
                    {
                        for (int i = 0; i < listServiceDetailObject.Count; i++)
                        {
                            if (listServiceDetailObject[i].ServicesID == txtServiceId.Text.Trim())
                            {
                                listServiceDetailObject.Remove(listServiceDetailObject[i]);
                            }
                        }
                        serviceDetailDataTable.Rows.Remove(serviceDetailDataTable.Rows.Find(txtServiceId.Text.Trim()));

                    }
                    else
                        return;
                }
            }
            serviceDetailDataTable.Rows.Add(_rowValue);
            gvServiceDetail.DataSource = serviceDetailDataTable;
            listServiceDetailObject.Add(new DTOServiceDetail(_rowValue["OrderDetailID"].ToString().Trim(), _rowValue["ServicesID"].ToString().Trim(), Int32.Parse(_rowValue["Quantity"].ToString()), Int32.Parse(_rowValue["Monetized"].ToString())));

            updateEnableButtonAndResetValueOfControl(ref btnAddInListServiceDetail);

            //Chỗ này lỗi ko sum dc
            txtTotalMoney.Text = grdvServiceDetail.Columns["Monetized"].SummaryItem.SummaryValue.ToString();
            //}//
            //catch (System.Exception)
            //{

            //}
        }

        private void grdvListOrder_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                if (e.FocusedRowHandle >= 0)
                {
                    lblOrderValue.Text = grdvListOrder.GetRowCellValue(e.FocusedRowHandle, grdvListOrder.Columns["OrderDetailID"]).ToString();

                    //
                    serviceDetailDataTable = serviceDetailBUS.GetAllServiceDetailByOrderID(lblOrderValue.Text.Trim());
                    DataColumn[] keys = new DataColumn[1];
                    keys[0] = serviceDetailDataTable.Columns["ServicesID"];
                    serviceDetailDataTable.PrimaryKey = keys;
                    gvServiceDetail.DataSource = serviceDetailDataTable;
                    listServiceDetailObject.Clear();
                    foreach (DataRow row in serviceDetailDataTable.Rows) // Loop over the rows.
                    {
                        listServiceDetailObject.Add(new DTOServiceDetail(row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), Int32.Parse(row.ItemArray[4].ToString()), Int32.Parse(row.ItemArray[5].ToString())));
                    }
                    txtTotalMoney.Text = grdvServiceDetail.Columns["Monetized"].SummaryItem.SummaryValue.ToString();
                }
            }
            catch (System.Exception)
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnUpdate);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRowView _rowView in serviceDetailMultiselect.Selection)
            {
                listServiceDetailObject.Remove(new DTOServiceDetail(_rowView.Row.ItemArray[2].ToString(), _rowView.Row.ItemArray[3].ToString(), Int32.Parse(_rowView.Row.ItemArray[4].ToString()), Int32.Parse(_rowView.Row.ItemArray[5].ToString())));
                serviceDetailDataTable.Rows.Remove(_rowView.Row);
            }
            serviceDetailMultiselect.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            updateEnableButtonAndResetValueOfControl(ref btnSave);
            try
            {

                serviceDetailBUS.DeleteAllServiceDetailByOrderID(lblOrderValue.Text.Trim());
                int Total = 0;
                for (int i = 0; i < listServiceDetailObject.Count; i++)
                {
                    listServiceDetailObject[i].ServicesDetailID = "DVC0000000";
                    listServiceDetailObject[i].OrderDetailID = lblOrderValue.Text.Trim();
                    if (!serviceDetailBUS.InsertServiceDetail(listServiceDetailObject[i]))
                        XtraCustomMessageBox.Show("Thêm thất bại dịch vụ có mã: " + listServiceDetailObject[i].ServicesID, "Lỗi", true, 1);
                    else
                    {
                        Total += listServiceDetailObject[i].Total;
                    }
                }

                orderDetailBUS.UpdateServiceMoneyOrderDetailById(lblOrderValue.Text.Trim(), Total);
                orderDetailDataTable = orderDetailBUS.GetAllOrderDetailFromNow();
                gvRoomOrder.DataSource = orderDetailDataTable;
                //Cập nhật controls của form
                updateEnableButtonAndResetValueOfControl(ref btnSave);

                XtraCustomMessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", true, 1);
                listServiceDetailObject.Clear();

            }
            catch (System.Exception)
            {
                XtraCustomMessageBox.Show("Không thể ghi dữ liệu!", "Lỗi", true, 4);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            updateEnableButtonAndResetValueOfControl(ref btnCancel);

            //
            serviceDetailDataTable = serviceDetailBUS.GetAllServiceDetailByOrderID(lblOrderValue.Text);
            DataColumn[] keys = new DataColumn[1];
            keys[0] = serviceDetailDataTable.Columns["ServicesID"];
            serviceDetailDataTable.PrimaryKey = keys;
            gvServiceDetail.DataSource = serviceDetailDataTable;
            listServiceDetailObject.Clear();
            foreach (DataRow row in serviceDetailDataTable.Rows) // Loop over the rows.
            {
                listServiceDetailObject.Add(new DTOServiceDetail(row.ItemArray[2].ToString(), row.ItemArray[3].ToString(), Int32.Parse(row.ItemArray[4].ToString()), Int32.Parse(row.ItemArray[5].ToString())));
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //try
            //{
                String customerID = customerBUS.GetCustomerByOrderDetailId(lblOrderValue.Text.Trim());
                DataTable customer = customerBUS.GetCustomerById(customerID);
                if (customer.Rows.Count > 0)
                {
                    String nameCustomer = customer.Rows[0].ItemArray[2].ToString();
                    String address = customer.Rows[0].ItemArray[5].ToString();
                    String orderID = orderDetailBUS.GetOrderIDByOrderDetailID(lblOrderValue.Text.Trim());
                    //
                    DataTable reportData = new DataTable();
                    DataColumn newColumn = new DataColumn();
                    newColumn.ColumnName = "ID";
                    newColumn.DataType = System.Type.GetType("System.String");
                    reportData.Columns.Add(newColumn);

                    DataColumn newColumn1 = new DataColumn();
                    newColumn1.ColumnName = "Name";
                    newColumn1.DataType = System.Type.GetType("System.String");
                    reportData.Columns.Add(newColumn1);

                    DataColumn newColumn2 = new DataColumn();
                    newColumn2.ColumnName = "Quantity";
                    newColumn2.DataType = System.Type.GetType("System.String");
                    reportData.Columns.Add(newColumn2);

                    DataColumn newColumn3 = new DataColumn();
                    newColumn3.ColumnName = "Price";
                    newColumn3.DataType = System.Type.GetType("System.String");
                    reportData.Columns.Add(newColumn3);

                    DataColumn newColumn4 = new DataColumn();
                    newColumn4.ColumnName = "Monetized";
                    newColumn4.DataType = System.Type.GetType("System.String");
                    reportData.Columns.Add(newColumn4);

                    serviceDetailDataTable = serviceDetailBUS.GetAllServiceDetailByOrderID(lblOrderValue.Text.Trim());
                    DataColumn[] keys = new DataColumn[1];
                    keys[0] = serviceDetailDataTable.Columns["ServicesID"];
                    serviceDetailDataTable.PrimaryKey = keys;
                    gvServiceDetail.DataSource = serviceDetailDataTable;

                    foreach(DataRow _row in serviceDetailDataTable.Rows){
                        DataRow _rowValue = reportData.NewRow();
                        _rowValue["ID"] = _row.ItemArray[3];
                        _rowValue["Name"] = _row.ItemArray[8];
                        _rowValue["Quantity"] = _row.ItemArray[4];
                        _rowValue["Price"] = _row.ItemArray[10];
                        _rowValue["Monetized"] = _row.ItemArray[5];
                        reportData.Rows.Add(_rowValue);
                    }
                    //
                    frmViewBill billReportView = new frmViewBill(reportData, nameCustomer, address, grdvServiceDetail.Columns["Quantity"].SummaryItem.SummaryValue.ToString(),
                        txtTotalMoney.Text, orderID);
                    billReportView.ShowDialog();
                    billReportView.ShowInTaskbar = false;
                }
            //}
            //catch (System.Exception)
            //{

            //}
        }


    }
}
