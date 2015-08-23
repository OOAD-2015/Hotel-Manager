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
            xrLblDateCreateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            xrlbDateTimePrintValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() +
               " " + DateTime.Now.ToShortTimeString();
            //
            //xrtbSnoValue.DataBindings.Add("Text", DataSource, "STT");
            xrtbRoomIdValue.DataBindings.Add("Text", DataSource, "ServicesID");
            xrtbRoomNameValue.DataBindings.Add("Text", DataSource, "ServicesName");
            xrtbCountValue.DataBindings.Add("Text", DataSource, "Quantity");
            xrtbPriceValue.DataBindings.Add("Text", DataSource, "Price");
            xrtbAmountValue.DataBindings.Add("Text", DataSource, "Monetized");

        }

    }
}
