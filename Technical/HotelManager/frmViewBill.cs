using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using HotelManager.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BookStoreManager.Presentation.ReportForm
{
    public partial class frmViewBill : Form
    {
        private rptViewBill billReportView;
        public frmViewBill()
        {
            InitializeComponent();
        }
        public frmViewBill(DataTable dListCommodity, string strCustomerName,
            String strCustomerAddress,
            String strTotalQuantity,
            String strTotalMoneyCommodity,
            String strTotalMoneyVAT,
            String strTotalMoney,
            String strMoneyProceed,
            String strMoneyReturn,
            string strBillId)
        {
            InitializeComponent();

            billReportView = new rptViewBill();

            billReportView.LoadDataToReport(strCustomerName, strCustomerAddress, strTotalQuantity, strTotalMoney, strMoneyProceed, strMoneyReturn, strBillId);

            billReportView.DataSource = dListCommodity;
            docDeliveryNoteView.PrintingSystem = billReportView.PrintingSystem;
            billReportView.CreateDocument();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportPrintTool pt = new ReportPrintTool(billReportView);
            pt.PrintingSystem.StartPrint +=
                new PrintDocumentEventHandler(printingSystem_StartPrint);
            pt.PrintDialog();
        }
        private void printingSystem_StartPrint(object sender, PrintDocumentEventArgs e)
        {
            for (int i = 0; i < e.PrintDocument.PrinterSettings.PaperSources.Count; i++)
                if (e.PrintDocument.PrinterSettings.PaperSources[i].Kind ==
                    PaperSourceKind.TractorFeed)
                {
                    e.PrintDocument.DefaultPageSettings.PaperSource =
                        e.PrintDocument.PrinterSettings.PaperSources[i];
                    break;
                }

            for (int i = 0; i < e.PrintDocument.PrinterSettings.PrinterResolutions.Count; i++)
                if (e.PrintDocument.PrinterSettings.PrinterResolutions[i].Kind ==
                    PrinterResolutionKind.High)
                {
                    e.PrintDocument.DefaultPageSettings.PrinterResolution =
                        e.PrintDocument.PrinterSettings.PrinterResolutions[i];
                    break;
                }
        }

        private void frmViewBillReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ReportPrintTool pt = new ReportPrintTool(billReportView);
                pt.PrintingSystem.StartPrint +=
                    new PrintDocumentEventHandler(printingSystem_StartPrint);
                pt.PrintDialog();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
            }
        }

    }
}
