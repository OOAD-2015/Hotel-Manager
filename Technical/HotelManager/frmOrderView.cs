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
using BookStoreManager.Presentation.ReportForm;

namespace HotelManager
{
    public partial class frmOrderView : DevExpress.XtraEditors.XtraForm
    {
        private string orderID = "";
        private BUSOrder orderBUS;
        private BUSOrderDetail orderDetailBUS;
        private DataTable orderDetailTable;
        private DataTable orderTable;
        private DataRow orderRow;
        public frmOrderView()
        {
            InitializeComponent();
        }

        public frmOrderView(string _orderID)
        {
            InitializeComponent();
            this.orderID = _orderID;
            this.orderBUS = new BUSOrder();
            this.orderDetailBUS = new BUSOrderDetail();

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
            spinTotalRoom.Text = orderDetailTable.Rows.Count.ToString();
            if (grdCol1NumberOfPeople.SummaryItem.SummaryValue != null)
                spinTotalPeople.Text = grdCol1NumberOfPeople.SummaryItem.SummaryValue.ToString();
            else
                spinTotalPeople.Text = "0";
            if (grdCol1Monetized.SummaryItem.SummaryValue != null)
                spintotalEstimate.Text = grdCol1Monetized.SummaryItem.SummaryValue.ToString();
            else
                spintotalEstimate.Text = "0";
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
                _rowValue["ID"] = _row.ItemArray[1];
                _rowValue["Name"] = _row.ItemArray[2];
                _rowValue["Quantity"] = _row.ItemArray[9];
                _rowValue["Price"] = _row.ItemArray[7];
                _rowValue["Monetized"] = _row.ItemArray[10];
                QTY += int.Parse(_row.ItemArray[9].ToString());
                reportData.Rows.Add(_rowValue);
            }
            //
            frmViewBill billReportView = new frmViewBill(reportData, nameCustomer, address, QTY.ToString(),
                spintotalEstimate.Text, orderID);
            billReportView.ShowDialog();
            billReportView.ShowInTaskbar = false;

        }

    }
}