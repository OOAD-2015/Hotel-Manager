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
        
    }
}