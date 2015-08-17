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
using DevExpress.XtraReports.UI;
using HotelManager.Report;
using HotelManager;

namespace HotelManager
{
    public partial class frmRevenueReport : DevExpress.XtraEditors.XtraForm
    {
        private rptRevenueReport revenueReport;
        private DataTable revenueDataTable;
        
        public frmRevenueReport()
        {
            InitializeComponent();
        }

        private void frmRevenueReport_Load(object sender, EventArgs e)
        {
            revenueReport = new rptRevenueReport();
            revenueDataTable = new DataTable();
            //
            //
            dateMonthYear.Enabled = true;
            dateMonthYear.Text = null;
            //
            lblThisYear.Text = null;
            dateFrom.Enabled = false;
            dateFrom.Text = null;
            dateTo.Enabled = false;
            dateTo.Text = null;
            //
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (!CheckData())
            {
                XtraCustomMessageBox.Show("Vui lòng chọn thời gian lập báo cáo!", "Thông báo", true, 2);
            }
            else
            {
                //
                ReportByDate();
                //
                revenueReport.DataSource = revenueDataTable;
                docRevenueView.PrintingSystem = revenueReport.PrintingSystem;
                revenueReport.CreateDocument();
            }
        }


        private void dateRevenueValue_EditValueChanged(object sender, EventArgs e)
        {
            if (dateMonthYear.DateTime > DateTime.Now)
            {
                XtraCustomMessageBox.Show("Ngày báo cáo không được lớn hơn ngày hiện tại!", "Thông báo", true, 2);
                dateMonthYear.EditValue = null;
            }
        }

        private void dateFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (dateFrom.DateTime > DateTime.Now)
            {
                XtraCustomMessageBox.Show("Ngày bắt đầu không được lớn hơn ngày hiện tại!", "Thông báo", true, 2);
                dateFrom.EditValue = null;
            }
            if (!dateTo.Text.Equals(""))
            {
                if (dateFrom.DateTime > dateTo.DateTime)
                {
                    XtraCustomMessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo", true, 2);
                    dateTo.EditValue = null;
                }
            }
        }

        private void dateTo_EditValueChanged(object sender, EventArgs e)
        {
            if (dateTo.DateTime > DateTime.Now)
            {
                XtraCustomMessageBox.Show("Ngày kết thúc không được lớn hơn ngày hiện tại!", "Thông báo", true, 2);
                dateTo.EditValue = null;
            }
            if (!dateFrom.Text.Equals(""))
            {
                if (dateFrom.DateTime > dateTo.DateTime)
                {
                    XtraCustomMessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Thông báo", true, 2);
                    dateFrom.EditValue = null;
                }
            }
        }

        private void rdoTime_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (revenueDataTable != null)
            {
                revenueDataTable.Clear();
                revenueReport = null;
                docRevenueView.PrintingSystem = null;
                docRevenueView.UpdatePageView();
            }
            //
            switch (rdoTime.SelectedIndex)
            {
                case 0:
                    {
                        dateMonthYear.Enabled = true;
                        dateMonthYear.Text = null;
                        //
                        lblThisYear.Text = null;
                        dateFrom.Enabled = false;
                        dateFrom.Text = null;
                        dateTo.Enabled = false;
                        dateTo.Text = null;
                        break;
                    }
                case 1:
                    {
                        lblThisYear.Text = DateTime.Now.Year.ToString();
                        //
                        dateMonthYear.Enabled = false;
                        dateMonthYear.Text = null;
                        dateFrom.Enabled = false;
                        dateFrom.Text = null;
                        dateTo.Enabled = false;
                        dateTo.Text = null;
                        break;
                    }
                case 2:
                    {
                        dateFrom.Enabled = true;
                        dateFrom.Text = null;
                        dateTo.Enabled = true;
                        dateTo.Text = null;
                        //
                        dateMonthYear.Enabled = false;
                        dateMonthYear.Text = null;
                        lblThisYear.Text = null;
                        break;
                    }
                default:
                    break;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (revenueReport != null)
            {
                revenueReport.PrintDialog();
            }
        }

        private void frmRevenueReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPrint_Click(null, null);
            }
            else
            {
                if (e.KeyCode == Keys.F4)
                {
                    btnView_Click(null, null);
                }
            }
        }

        //My Methods
        private bool CheckData()
        {
            bool result = true;
            switch (rdoTime.SelectedIndex)
            {
                case 0://theo thang/nam
                    {
                        if (dateMonthYear.EditValue == null)
                            result = false;
                        break;
                    }
                case 2://trong khoang
                    {
                        if (dateFrom.EditValue == null || dateTo.EditValue == null)
                            result = false;
                        break;
                    }
                default:
                    break;
            }
            return result;
        }

        private void ReportByDate()
        {
            if (revenueDataTable != null)
            {
                revenueDataTable.Clear();
            }
            switch (rdoTime.SelectedIndex)
            {
                case 0://theo thang/nam
                    {
                        DateTime reportDate = dateMonthYear.DateTime;
                        revenueReport = new rptRevenueReport(reportDate);
                        revenueDataTable = null;
                        break;
                    }
                case 1://theo nam
                    {
                        int thisYear = DateTime.Now.Year;
                        revenueReport = new rptRevenueReport(thisYear);
                        revenueDataTable = null;
                        break;
                    }
                case 2://trong khoang
                    {
                        DateTime reportDateFrom = dateFrom.DateTime;
                        DateTime reportDateTo = dateTo.DateTime;
                        revenueReport = new rptRevenueReport(reportDateFrom, reportDateTo);
                        revenueDataTable = null;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
