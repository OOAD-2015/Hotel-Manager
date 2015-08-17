namespace HotelManager.Report
{
    partial class rptRevenueReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrtbValue = new DevExpress.XtraReports.UI.XRTable();
            this.xrtbRValue = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtbSnoValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbRoomIdValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbRoomNameValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbCountValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbPriceValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbAmountValue = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrtbTitles = new DevExpress.XtraReports.UI.XRTable();
            this.xrtRTitles = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtbSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbRoomId = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbRoomName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbCount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLblDateReport = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblNameDocumnet = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblDatePrint = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblTaxId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTaxIdValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblTotalValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblDateWrite = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblUser = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbValue});
            this.Detail.HeightF = 27.08333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrtbValue
            // 
            this.xrtbValue.BorderColor = System.Drawing.Color.Black;
            this.xrtbValue.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbValue.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.xrtbValue.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrtbValue.Name = "xrtbValue";
            this.xrtbValue.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtbRValue});
            this.xrtbValue.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrtbValue.StylePriority.UseBorderColor = false;
            this.xrtbValue.StylePriority.UseBorders = false;
            this.xrtbValue.StylePriority.UseFont = false;
            // 
            // xrtbRValue
            // 
            this.xrtbRValue.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtbSnoValue,
            this.xrtbRoomIdValue,
            this.xrtbRoomNameValue,
            this.xrtbCountValue,
            this.xrtbPriceValue,
            this.xrtbAmountValue});
            this.xrtbRValue.Name = "xrtbRValue";
            this.xrtbRValue.Weight = 1D;
            // 
            // xrtbSnoValue
            // 
            this.xrtbSnoValue.Name = "xrtbSnoValue";
            this.xrtbSnoValue.StylePriority.UseTextAlignment = false;
            this.xrtbSnoValue.Text = "STT";
            this.xrtbSnoValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSnoValue.Weight = 0.29230365396422109D;
            // 
            // xrtbRoomIdValue
            // 
            this.xrtbRoomIdValue.Name = "xrtbRoomIdValue";
            this.xrtbRoomIdValue.StylePriority.UseTextAlignment = false;
            this.xrtbRoomIdValue.Text = "Mã phòng";
            this.xrtbRoomIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomIdValue.Weight = 0.84470342581934343D;
            // 
            // xrtbRoomNameValue
            // 
            this.xrtbRoomNameValue.Name = "xrtbRoomNameValue";
            this.xrtbRoomNameValue.StylePriority.UseTextAlignment = false;
            this.xrtbRoomNameValue.Text = "Tên phòng";
            this.xrtbRoomNameValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomNameValue.Weight = 1.2232026152068574D;
            // 
            // xrtbCountValue
            // 
            this.xrtbCountValue.Name = "xrtbCountValue";
            this.xrtbCountValue.StylePriority.UseTextAlignment = false;
            this.xrtbCountValue.Text = "Số ngày thuê";
            this.xrtbCountValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbCountValue.Weight = 0.96228841603057647D;
            // 
            // xrtbPriceValue
            // 
            this.xrtbPriceValue.Name = "xrtbPriceValue";
            this.xrtbPriceValue.StylePriority.UseTextAlignment = false;
            this.xrtbPriceValue.Text = "Giá thuê";
            this.xrtbPriceValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbPriceValue.Weight = 1.2793245311902846D;
            // 
            // xrtbAmountValue
            // 
            this.xrtbAmountValue.Name = "xrtbAmountValue";
            this.xrtbAmountValue.StylePriority.UseTextAlignment = false;
            this.xrtbAmountValue.Text = "Thành tiền";
            this.xrtbAmountValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbAmountValue.Weight = 1.387761503500639D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbTitles,
            this.xrLine1,
            this.xrLblDateReport,
            this.xrLblNameDocumnet,
            this.xrLblDatePrint,
            this.xrLblTaxId,
            this.xrlblAddress,
            this.xrlblTaxIdValue,
            this.xrlblCompanyName});
            this.ReportHeader.HeightF = 262.5F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrtbTitles
            // 
            this.xrtbTitles.BorderColor = System.Drawing.Color.Black;
            this.xrtbTitles.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbTitles.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrtbTitles.LocationFloat = new DevExpress.Utils.PointFloat(0F, 237.5F);
            this.xrtbTitles.Name = "xrtbTitles";
            this.xrtbTitles.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtRTitles});
            this.xrtbTitles.SizeF = new System.Drawing.SizeF(650F, 25F);
            this.xrtbTitles.StylePriority.UseBorderColor = false;
            this.xrtbTitles.StylePriority.UseBorders = false;
            this.xrtbTitles.StylePriority.UseFont = false;
            // 
            // xrtRTitles
            // 
            this.xrtRTitles.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtbSTT,
            this.xrtbRoomId,
            this.xrtbRoomName,
            this.xrtbCount,
            this.xrtbPrice,
            this.xrtbAmount});
            this.xrtRTitles.Name = "xrtRTitles";
            this.xrtRTitles.Weight = 1D;
            // 
            // xrtbSTT
            // 
            this.xrtbSTT.Name = "xrtbSTT";
            this.xrtbSTT.StylePriority.UseTextAlignment = false;
            this.xrtbSTT.Text = "STT";
            this.xrtbSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbSTT.Weight = 0.29230368911568239D;
            // 
            // xrtbRoomId
            // 
            this.xrtbRoomId.Name = "xrtbRoomId";
            this.xrtbRoomId.StylePriority.UseTextAlignment = false;
            this.xrtbRoomId.Text = "Mã phòng";
            this.xrtbRoomId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomId.Weight = 0.84470346097080484D;
            // 
            // xrtbRoomName
            // 
            this.xrtbRoomName.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtbRoomName.Name = "xrtbRoomName";
            this.xrtbRoomName.StylePriority.UseBorders = false;
            this.xrtbRoomName.StylePriority.UseTextAlignment = false;
            this.xrtbRoomName.Text = "Tên phòng";
            this.xrtbRoomName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomName.Weight = 1.2232014552086328D;
            // 
            // xrtbCount
            // 
            this.xrtbCount.Name = "xrtbCount";
            this.xrtbCount.StylePriority.UseTextAlignment = false;
            this.xrtbCount.Text = "Số ngày thuê";
            this.xrtbCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbCount.Weight = 0.9622895418107057D;
            // 
            // xrtbPrice
            // 
            this.xrtbPrice.Name = "xrtbPrice";
            this.xrtbPrice.StylePriority.UseTextAlignment = false;
            this.xrtbPrice.Text = "Giá thuê";
            this.xrtbPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbPrice.Weight = 1.2793253656130483D;
            // 
            // xrtbAmount
            // 
            this.xrtbAmount.Name = "xrtbAmount";
            this.xrtbAmount.StylePriority.UseTextAlignment = false;
            this.xrtbAmount.Text = "Thành tiền";
            this.xrtbAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbAmount.Weight = 1.3877605852564634D;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(189.1438F, 181.6667F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(286.2957F, 23F);
            // 
            // xrLblDateReport
            // 
            this.xrLblDateReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblDateReport.LocationFloat = new DevExpress.Utils.PointFloat(256.134F, 158.6667F);
            this.xrLblDateReport.Name = "xrLblDateReport";
            this.xrLblDateReport.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblDateReport.SizeF = new System.Drawing.SizeF(182.2917F, 22.99999F);
            this.xrLblDateReport.StylePriority.UseFont = false;
            this.xrLblDateReport.Text = "Date";
            // 
            // xrLblNameDocumnet
            // 
            this.xrLblNameDocumnet.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblNameDocumnet.LocationFloat = new DevExpress.Utils.PointFloat(169.3521F, 113.5417F);
            this.xrLblNameDocumnet.Name = "xrLblNameDocumnet";
            this.xrLblNameDocumnet.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblNameDocumnet.SizeF = new System.Drawing.SizeF(330.0457F, 34.83334F);
            this.xrLblNameDocumnet.StylePriority.UseFont = false;
            this.xrLblNameDocumnet.StylePriority.UseTextAlignment = false;
            this.xrLblNameDocumnet.Text = "BÁO CÁO DOANH THU ";
            this.xrLblNameDocumnet.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLblDatePrint
            // 
            this.xrLblDatePrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblDatePrint.LocationFloat = new DevExpress.Utils.PointFloat(451.9526F, 0F);
            this.xrLblDatePrint.Name = "xrLblDatePrint";
            this.xrLblDatePrint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblDatePrint.SizeF = new System.Drawing.SizeF(198.0474F, 23F);
            this.xrLblDatePrint.StylePriority.UseFont = false;
            // 
            // xrLblTaxId
            // 
            this.xrLblTaxId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblTaxId.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46F);
            this.xrLblTaxId.Name = "xrLblTaxId";
            this.xrLblTaxId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblTaxId.SizeF = new System.Drawing.SizeF(88.54166F, 23F);
            this.xrLblTaxId.StylePriority.UseFont = false;
            this.xrLblTaxId.Text = "Mã số thuế:";
            // 
            // xrlblAddress
            // 
            this.xrlblAddress.AutoWidth = true;
            this.xrlblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblAddress.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.xrlblAddress.Name = "xrlblAddress";
            this.xrlblAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblAddress.SizeF = new System.Drawing.SizeF(415.4622F, 23F);
            this.xrlblAddress.StylePriority.UseFont = false;
            this.xrlblAddress.Text = "Địa chỉ:";
            // 
            // xrlblTaxIdValue
            // 
            this.xrlblTaxIdValue.AutoWidth = true;
            this.xrlblTaxIdValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblTaxIdValue.LocationFloat = new DevExpress.Utils.PointFloat(88.54166F, 46F);
            this.xrlblTaxIdValue.Name = "xrlblTaxIdValue";
            this.xrlblTaxIdValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTaxIdValue.SizeF = new System.Drawing.SizeF(326.9206F, 23F);
            this.xrlblTaxIdValue.StylePriority.UseFont = false;
            // 
            // xrlblCompanyName
            // 
            this.xrlblCompanyName.AutoWidth = true;
            this.xrlblCompanyName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrlblCompanyName.Name = "xrlblCompanyName";
            this.xrlblCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblCompanyName.SizeF = new System.Drawing.SizeF(415.4622F, 23F);
            this.xrlblCompanyName.StylePriority.UseFont = false;
            this.xrlblCompanyName.Text = "Khách sạn:";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLblTotal,
            this.xrLblTotalValue,
            this.xrLblDateWrite,
            this.xrLblUser});
            this.ReportFooter.HeightF = 175F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLblTotal
            // 
            this.xrLblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblTotal.LocationFloat = new DevExpress.Utils.PointFloat(417.5455F, 10.00001F);
            this.xrLblTotal.Name = "xrLblTotal";
            this.xrLblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblTotal.SizeF = new System.Drawing.SizeF(96.43567F, 23F);
            this.xrLblTotal.StylePriority.UseFont = false;
            this.xrLblTotal.Text = "Tổng cộng:";
            // 
            // xrLblTotalValue
            // 
            this.xrLblTotalValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblTotalValue.LocationFloat = new DevExpress.Utils.PointFloat(513.9813F, 10.00001F);
            this.xrLblTotalValue.Name = "xrLblTotalValue";
            this.xrLblTotalValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblTotalValue.SizeF = new System.Drawing.SizeF(138.1021F, 23F);
            this.xrLblTotalValue.StylePriority.UseFont = false;
            this.xrLblTotalValue.StylePriority.UseTextAlignment = false;
            this.xrLblTotalValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLblDateWrite
            // 
            this.xrLblDateWrite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblDateWrite.LocationFloat = new DevExpress.Utils.PointFloat(417.5455F, 48.54167F);
            this.xrLblDateWrite.Name = "xrLblDateWrite";
            this.xrLblDateWrite.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblDateWrite.SizeF = new System.Drawing.SizeF(234.5378F, 24.04167F);
            this.xrLblDateWrite.StylePriority.UseFont = false;
            this.xrLblDateWrite.Text = "Ngày.........Tháng........năm...........";
            // 
            // xrLblUser
            // 
            this.xrLblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblUser.LocationFloat = new DevExpress.Utils.PointFloat(478.1333F, 72.58336F);
            this.xrLblUser.Name = "xrLblUser";
            this.xrLblUser.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblUser.SizeF = new System.Drawing.SizeF(115.3158F, 24.04166F);
            this.xrLblUser.StylePriority.UseFont = false;
            this.xrLblUser.Text = "Người lập phiếu";
            // 
            // rptRevenueReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter});
            this.Version = "15.1";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptRevenueReport_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLblDateReport;
        private DevExpress.XtraReports.UI.XRLabel xrLblNameDocumnet;
        private DevExpress.XtraReports.UI.XRLabel xrLblDatePrint;
        private DevExpress.XtraReports.UI.XRLabel xrLblTaxId;
        private DevExpress.XtraReports.UI.XRLabel xrlblAddress;
        private DevExpress.XtraReports.UI.XRLabel xrlblTaxIdValue;
        private DevExpress.XtraReports.UI.XRLabel xrlblCompanyName;
        private DevExpress.XtraReports.UI.XRTable xrtbTitles;
        private DevExpress.XtraReports.UI.XRTableRow xrtRTitles;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSTT;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomId;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomName;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCount;
        private DevExpress.XtraReports.UI.XRTableCell xrtbPrice;
        private DevExpress.XtraReports.UI.XRTableCell xrtbAmount;
        private DevExpress.XtraReports.UI.XRTable xrtbValue;
        private DevExpress.XtraReports.UI.XRTableRow xrtbRValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSnoValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomIdValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomNameValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCountValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbPriceValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbAmountValue;
        private DevExpress.XtraReports.UI.XRLabel xrLblTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLblTotalValue;
        private DevExpress.XtraReports.UI.XRLabel xrLblDateWrite;
        private DevExpress.XtraReports.UI.XRLabel xrLblUser;
    }
}
