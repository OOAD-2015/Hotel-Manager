using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BusinessLayer;
using DataTransferObject.Utils;

namespace HotelManager.Report
{
    public partial class rptRevenueReport : DevExpress.XtraReports.UI.XtraReport
    {
        private BUSRule systemBUS = new BUSRule();
        public rptRevenueReport()
        {
            InitializeComponent();
        }
        public rptRevenueReport(DateTime dMonthYear)
        {
            InitializeComponent();
            xrLblDateReport.Text = "Tháng " + dMonthYear.Month.ToString() + " năm " + dMonthYear.Year.ToString();
        }
        public rptRevenueReport(int iYear)
        {
            InitializeComponent();
            xrLblDateReport.Text = "Năm " + iYear.ToString();
        }
        public rptRevenueReport(DateTime dDateFrom, DateTime dDateTo)
        {
            InitializeComponent();
            xrLblDateReport.Text = "Từ ngày " + dDateFrom.ToShortDateString() + " đến " + dDateTo.ToShortDateString();
        }

        private void rptRevenueReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //
            xrlblCompanyName.Text = systemBUS.GetRuleByLabel("TenKhachSan").ToUpper();
            xrlblAddress.Text = Utils.standardNamePerson(systemBUS.GetRuleByLabel("DiaChi"));
            xrlblTaxIdValue.Text = systemBUS.GetRuleByLabel("MaSoThue");
            //
            xrLblDatePrint.Text = "Ngày " + DateTime.Now.Day.ToString() + " tháng " + DateTime.Now.Month.ToString() + " năm " + DateTime.Now.Year.ToString();
            //
            //xrtbSnoValue.DataBindings.Add("Text", DataSource, "STT");
            //xrtbCommodityIdValue.DataBindings.Add("Text", DataSource, "MaHangHoa");
            //xrtbCommodityNameValue.DataBindings.Add("Text", DataSource, "TenHangHoa");
            //xrtbCountValue.DataBindings.Add("Text", DataSource, "SoLuong");
            //xrtbInputPriceValue.DataBindings.Add("Text", DataSource, "GiaNhapVAT");
            //xrtbOutPriceValue.DataBindings.Add("Text", DataSource, "DonGia");
            //xrtbAmountValue.DataBindings.Add("Text", DataSource, "ThanhTien");
            //xrtbProfitValue.DataBindings.Add("Text", DataSource, "Lai");

            //xrLblSumValue.DataBindings.Add("Text", DataSource, "TongSoLuong");
            //xrLblTotalValue.DataBindings.Add("Text", DataSource, "TongLai");
        }
    }
}
