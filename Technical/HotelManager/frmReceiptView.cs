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
        
    }
}