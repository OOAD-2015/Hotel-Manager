using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BusinessLayer;
using DataTransferObject.Utils;

namespace HotelManager.Report
{
    public partial class rptViewBill : DevExpress.XtraReports.UI.XtraReport
    {
        private BUSRule systemBUS = new BUSRule();
        public rptViewBill()
        {
            InitializeComponent();
        }

        public void LoadDataToReport(string strCustomerName,
            String strCustomerAddress,
            String strTotalQuantity,
            String strTotalMoney,
            String strMoneyProceed,
            String strMoneyReturn,
            string strBillId)
        {
            //
            xlblCompanyName.Text = systemBUS.GetRuleByLabel("TenKhachSan").ToUpper();
            xlblAddress.Text = Utils.standardNamePerson(systemBUS.GetRuleByLabel("DiaChi"));
            xrlblTaxIdValue.Text = systemBUS.GetRuleByLabel("MaSoThue");
            //
            //
            xrlbBillIdValue.Text = strBillId;
            xrLblStaffName.Text = frmHomePage.staffLogin.StaffID + "-" + frmHomePage.staffLogin.Name;
            xrlbCustomerNameValue.Text = strCustomerName;
            xrlbAddressValue.Text = strCustomerAddress;
            //
            
            xrlblTotalMoneyValue.Text = strTotalMoney;
            xrlblProceedsValue.Text = strMoneyProceed;
            xrlblRefundsValue.Text = strMoneyReturn;
            xrLblDateCreateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            xrlbDateTimePrintValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() +
               " " + DateTime.Now.ToShortTimeString();
            //
            //xrtbSnoValue.DataBindings.Add("Text", DataSource, "STT");
            //xrtbCommodityIdValue.DataBindings.Add("Text", DataSource, "MaHangHoa");
            //xrtbCommodityNameValue.DataBindings.Add("Text", DataSource, "TenHangHoa");
            //xrtbCountValue.DataBindings.Add("Text", DataSource, "SoLuong");
            //xrtbOutputPriceValue.DataBindings.Add("Text", DataSource, "DonGia");
            //xrtbVATValue.DataBindings.Add("Text", DataSource, "TiLeVAT");
            //xrtbAmountValue.DataBindings.Add("Text", DataSource, "ThanhTien");

        }

    }
}
