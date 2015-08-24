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
using BookStoreManager.Presentation.ReportForm;

namespace HotelManager
{
    public partial class frmReceiptView : DevExpress.XtraEditors.XtraForm
    {
        private string orderID = "";
        private BUSOrder orderBUS;
        private BUSOrderDetail orderDetailBUS;
        private BUSServiceDetail serviceBUS;
        private DataTable orderDetailTable;
        private DataTable orderTable;
        private DataTable serviceDetailTable;
        private DataRow orderRow;
        public frmReceiptView()
        {
            InitializeComponent();
        }

        public frmReceiptView(string _orderID)
        {
            InitializeComponent();
            this.orderID = _orderID;
            this.orderBUS = new BUSOrder();
            this.orderDetailBUS = new BUSOrderDetail();
            this.serviceBUS = new BUSServiceDetail();
        }

        private void frmOrderView_Load(object sender, EventArgs e)
        {
            //

            //
            this.orderTable = orderBUS.GetOrderById(this.orderID);
            if (orderTable != null && orderTable.Rows.Count > 0)
            {
                this.orderRow = orderTable.Rows[0];
                labCustomerIDValue.Text = this.orderRow["CustomerID"].ToString();
                labCustomerNameValue.Text = this.orderRow["CustomerName"].ToString();
                labNumberIDValue.Text = this.orderRow["IDNumber"].ToString();
                labAddressValue.Text = this.orderRow["Address"].ToString();
                labStaffNameValue.Text = this.orderRow["StaffName"].ToString();
                labOrderOfDateValue.Text = this.orderRow["OrderOfDate"].ToString();
            }

            //
            this.orderDetailTable = orderDetailBUS.GetAllOrderDetailsByOderID(this.orderID);
            grdListRoom.DataSource = orderDetailTable;
            AutoRefreshData();
        }


        private void AutoRefreshData()
        {
            //reset gia tri o tinh
            spinTotalMoney.Text = orderDetailTable.Rows.Count.ToString();
            if (grdCol1NumberOfPeople.SummaryItem.SummaryValue != null)
                spinTotalServiceMoney.Text = grdCol1ServiceMoney.SummaryItem.SummaryValue.ToString();
            else
                spinTotalServiceMoney.Text = "0";
            if (grdCol1Monetized.SummaryItem.SummaryValue != null)
                spintotalEstimate.Text = grdCol1Monetized.SummaryItem.SummaryValue.ToString();
            else
                spintotalEstimate.Text = "0";
        }

        private void grdvListRoom_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string orderDetailID = "";
            if (e.FocusedRowHandle >= 0)
            {
                orderDetailID = grdvListRoom.GetRowCellValue(e.FocusedRowHandle, "OrderDetailID").ToString().Trim();
                this.serviceDetailTable = serviceBUS.GetAllServiceDetailByOrderID(orderDetailID);
                gvServiceDetail.DataSource = serviceDetailTable;
            }
        }

        private void spinTotalServiceMoney_EditValueChanged(object sender, EventArgs e)
        {
            spinTotalMoney.EditValue = spinTotalServiceMoney.Value + spintotalEstimate.Value;
        }

        private void spintotalEstimate_EditValueChanged(object sender, EventArgs e)
        {
            spinTotalMoney.EditValue = spinTotalServiceMoney.Value + spintotalEstimate.Value;
        }

        private void btnChangeToView_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            String customerID = labCustomerIDValue.Text.Trim();
            String nameCustomer = labCustomerNameValue.Text;
            String address = labAddressValue.Text;

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
            int QTY = 0;
            foreach (DataRow _row in orderDetailTable.Rows)
            {
                DataRow _rowValue = reportData.NewRow();
                _rowValue["ID"] = _row.ItemArray[2];
                _rowValue["Name"] = _row.ItemArray[3];
                _rowValue["Quantity"] = _row.ItemArray[7];
                _rowValue["Price"] = _row.ItemArray[8];
                _rowValue["Monetized"] = _row.ItemArray[12];
                QTY += int.Parse(_row.ItemArray[9].ToString());
                reportData.Rows.Add(_rowValue);
                //
                DataTable serviceDetailDataTable = serviceBUS.GetAllServiceDetailByOrderID(_row.ItemArray[1].ToString().Trim());

                foreach (DataRow __row in serviceDetailDataTable.Rows)
                {
                    DataRow __rowValue = reportData.NewRow();
                    __rowValue["ID"] = __row.ItemArray[3];
                    __rowValue["Name"] = __row.ItemArray[8];
                    __rowValue["Quantity"] = __row.ItemArray[4];
                    __rowValue["Price"] = __row.ItemArray[10];
                    __rowValue["Monetized"] = __row.ItemArray[5];
                    reportData.Rows.Add(__rowValue);
                }
            }
            //
            frmViewBill billReportView = new frmViewBill(reportData, nameCustomer, address, QTY.ToString(),
                spinTotalMoney.Text, orderID);
            billReportView.ShowDialog();
            billReportView.ShowInTaskbar = false;
        }
        
    }
}