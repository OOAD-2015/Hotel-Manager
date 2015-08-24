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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace HotelManager
{
    public partial class frmOrderSearch : DevExpress.XtraEditors.XtraForm
    {
        private DataTable customerDataTable;
        private BUSCustomer customerBUS;
        private BUSOrder orderBUS;
        private DataTable orderDataTable;
        public frmOrderSearch()
        {
            InitializeComponent();
            rdgSearchOption.SelectedIndex = 0;
            customerBUS = new BUSCustomer();
            orderBUS = new BUSOrder();
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void rdgSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdgSearchOption.SelectedIndex == 0)
            {
                lkCustomer.Visible = true;
                txtIDNumber.Visible = false;
            }
            else
            {
                lkCustomer.Visible = false;
                txtIDNumber.Visible = true;
            }
        }

        private void frmOrderSearch_Load(object sender, EventArgs e)
        {
            customerDataTable = customerBUS.GetAllCustomer();
            lkCustomer.Properties.DataSource = customerDataTable;
            lkCustomer.Properties.DisplayMember = "CustomerName";
            lkCustomer.Properties.ValueMember = "CustomerID";
        }

        private void txtIDNumber_TextChanged(object sender, EventArgs e)
        {
            orderDataTable = orderBUS.GetAllOrderByNumberID("", "%"+txtIDNumber.Text+"%");
            grdListOrder.DataSource = orderDataTable;
        }

        private void lkCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if (lkCustomer.EditValue != null)
            {
                orderDataTable = orderBUS.GetAllOrderByNumberID(lkCustomer.EditValue.ToString(), "A");
                grdListOrder.DataSource = orderDataTable;
            }
        }

        private void grdvListOrder_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow row = orderDataTable.Rows[info.RowHandle];
                new frmOrderView(row["OrderID"].ToString()).ShowDialog();
            }
        }
    }
}