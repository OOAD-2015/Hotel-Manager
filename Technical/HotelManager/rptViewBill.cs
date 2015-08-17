using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BookStoreManager.BusinessLogicLayer;
using BookStoreManager.DataTranferObject.Utils;

namespace BookStoreManager.Presentation.ReportForm
{
    public partial class rptViewBill : DevExpress.XtraReports.UI.XtraReport
    {
        private BUSRegulations systemBUS = new BUSRegulations();
        public rptViewBill()
        {
            InitializeComponent();
        }

        public void LoadDataToReport(string strCustomerName,
            String strCustomerAddress,
            String strTotalQuantity,
            String strTotalMoneyCommodity,
            String strTotalMoneyVAT,
            String strTotalMoney,
            String strMoneyProceed,
            String strMoneyReturn,
            string strBillId)
        {
            //
            xlblCompanyName.Text = systemBUS.GetRegulationsByLabel("TenCuaHang").ToUpper();
            xlblAddress.Text = Utils.standardNamePerson(systemBUS.GetRegulationsByLabel("DiaChiCH"));
            xrlblTaxIdValue.Text = systemBUS.GetRegulationsByLabel("MaSoThue");
            //
            //
            xrlbBillIdValue.Text = strBillId;
            xrLblStaffName.Text = frmMain.staffLogin.StaffId + "-" + frmMain.staffLogin.Name;
            xrlbCustomerNameValue.Text = strCustomerName;
            xrlbAddressValue.Text = strCustomerAddress;
            //
            xrlbTotalQuantityValue.Text = strTotalQuantity;
            xrlbTotalAmountValue.Text = strTotalMoneyCommodity;
            xrlblTaxVATValue.Text = strTotalMoneyVAT;
            xrlblTotalMoneyValue.Text = strTotalMoney;
            xrlblProceedsValue.Text = strMoneyProceed;
            xrlblRefundsValue.Text = strMoneyReturn;
            xrLblDateCreateValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            xrlbDateTimePrintValue.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() +
               " " + DateTime.Now.ToShortTimeString();
            //
            xrtbSnoValue.DataBindings.Add("Text", DataSource, "STT");
            xrtbCommodityIdValue.DataBindings.Add("Text", DataSource, "MaHangHoa");
            xrtbCommodityNameValue.DataBindings.Add("Text", DataSource, "TenHangHoa");
            xrtbCountValue.DataBindings.Add("Text", DataSource, "SoLuong");
            xrtbOutputPriceValue.DataBindings.Add("Text", DataSource, "DonGia");
            xrtbVATValue.DataBindings.Add("Text", DataSource, "TiLeVAT");
            xrtbAmountValue.DataBindings.Add("Text", DataSource, "ThanhTien");
            
        }
    }
}
