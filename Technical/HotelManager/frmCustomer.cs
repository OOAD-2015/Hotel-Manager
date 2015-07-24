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

namespace HotelManager
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public BUSCustomer busCustomer;
        public frmCustomer()
        {
            InitializeComponent();
            this.busCustomer = new BUSCustomer();
            FillDataToGridview();
        }

        public void FillDataToGridview()
        {
            DataTable customerData = busCustomer.getAllData();
            if (customerData != null)
            {
                grdListCustomer.DataSource = customerData;
            }
            else
            {
                XtraMessageBox.Show("Don't contain data");
            }
        }

    }
}