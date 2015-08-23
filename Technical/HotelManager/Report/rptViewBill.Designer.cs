namespace HotelManager.Report
{
    partial class rptViewBill
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
            this.xrLblStaff = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblStaffName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblDateCreateBill = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblDateCreateValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLblTaxId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTaxIdValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbTitles = new DevExpress.XtraReports.UI.XRLabel();
            this.xlblAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xlblCompanyName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbBillIdValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbBillId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbAddressValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbCustomerNameValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbDateTimePrint = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlFirst = new DevExpress.XtraReports.UI.XRLine();
            this.xrlbDateTimePrintValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbCustomerAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbCustomerName = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrtbDeliveryNote = new DevExpress.XtraReports.UI.XRTable();
            this.xrtrDeliveryNote = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrtbcSno = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbrId = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbrName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbcQuantity = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbcPrices = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrtbAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTotalMoneyValue = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTotalMoney = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlbThanks = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlSecond = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbDeliveryNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbValue});
            this.Detail.HeightF = 25F;
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
            this.xrtbSnoValue.Weight = 0.36858979478846382D;
            // 
            // xrtbRoomIdValue
            // 
            this.xrtbRoomIdValue.Name = "xrtbRoomIdValue";
            this.xrtbRoomIdValue.StylePriority.UseTextAlignment = false;
            this.xrtbRoomIdValue.Text = "Mã phòng, DV";
            this.xrtbRoomIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomIdValue.Weight = 1.1235693016304555D;
            // 
            // xrtbRoomNameValue
            // 
            this.xrtbRoomNameValue.Name = "xrtbRoomNameValue";
            this.xrtbRoomNameValue.StylePriority.UseTextAlignment = false;
            this.xrtbRoomNameValue.Text = "Tên phòng, DV";
            this.xrtbRoomNameValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbRoomNameValue.Weight = 1.1193436733885624D;
            // 
            // xrtbCountValue
            // 
            this.xrtbCountValue.Name = "xrtbCountValue";
            this.xrtbCountValue.StylePriority.UseTextAlignment = false;
            this.xrtbCountValue.Text = "Số lượng";
            this.xrtbCountValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtbCountValue.Weight = 0.645032111381069D;
            // 
            // xrtbPriceValue
            // 
            this.xrtbPriceValue.Name = "xrtbPriceValue";
            this.xrtbPriceValue.StylePriority.UseTextAlignment = false;
            this.xrtbPriceValue.Text = "Đơn giá";
            this.xrtbPriceValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtbPriceValue.Weight = 1.2419351846427158D;
            // 
            // xrtbAmountValue
            // 
            this.xrtbAmountValue.Name = "xrtbAmountValue";
            this.xrtbAmountValue.StylePriority.UseTextAlignment = false;
            this.xrtbAmountValue.Text = "Thành tiền";
            this.xrtbAmountValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrtbAmountValue.Weight = 1.491113987975091D;
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
            this.xrLblStaff,
            this.xrLblStaffName,
            this.xrLblDateCreateBill,
            this.xrLblDateCreateValue,
            this.xrLblTaxId,
            this.xrlblTaxIdValue,
            this.xrlbTitles,
            this.xlblAddress,
            this.xlblCompanyName,
            this.xrlbBillIdValue,
            this.xrlbBillId,
            this.xrlbAddressValue,
            this.xrlbCustomerNameValue,
            this.xrlbDateTimePrint,
            this.xrlFirst,
            this.xrlbDateTimePrintValue,
            this.xrlbCustomerAddress,
            this.xrlbCustomerName});
            this.ReportHeader.HeightF = 261.5835F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLblStaff
            // 
            this.xrLblStaff.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLblStaff.ForeColor = System.Drawing.Color.Black;
            this.xrLblStaff.LocationFloat = new DevExpress.Utils.PointFloat(421.0417F, 47.0417F);
            this.xrLblStaff.Name = "xrLblStaff";
            this.xrLblStaff.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblStaff.SizeF = new System.Drawing.SizeF(87.5F, 21.95833F);
            this.xrLblStaff.StylePriority.UseFont = false;
            this.xrLblStaff.StylePriority.UseForeColor = false;
            this.xrLblStaff.StylePriority.UseTextAlignment = false;
            this.xrLblStaff.Text = "Nhân viên:";
            this.xrLblStaff.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLblStaffName
            // 
            this.xrLblStaffName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLblStaffName.ForeColor = System.Drawing.Color.Black;
            this.xrLblStaffName.LocationFloat = new DevExpress.Utils.PointFloat(514.7917F, 47.0417F);
            this.xrLblStaffName.Name = "xrLblStaffName";
            this.xrLblStaffName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblStaffName.SizeF = new System.Drawing.SizeF(135.2084F, 21.95833F);
            this.xrLblStaffName.StylePriority.UseFont = false;
            this.xrLblStaffName.StylePriority.UseForeColor = false;
            this.xrLblStaffName.StylePriority.UseTextAlignment = false;
            this.xrLblStaffName.Text = "Admin";
            this.xrLblStaffName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLblDateCreateBill
            // 
            this.xrLblDateCreateBill.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLblDateCreateBill.LocationFloat = new DevExpress.Utils.PointFloat(198.8542F, 147.4585F);
            this.xrLblDateCreateBill.Name = "xrLblDateCreateBill";
            this.xrLblDateCreateBill.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblDateCreateBill.SizeF = new System.Drawing.SizeF(122.9167F, 26.04166F);
            this.xrLblDateCreateBill.StylePriority.UseFont = false;
            this.xrLblDateCreateBill.Text = "Ngày lập phiếu:";
            // 
            // xrLblDateCreateValue
            // 
            this.xrLblDateCreateValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.xrLblDateCreateValue.LocationFloat = new DevExpress.Utils.PointFloat(321.7708F, 147.4585F);
            this.xrLblDateCreateValue.Name = "xrLblDateCreateValue";
            this.xrLblDateCreateValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblDateCreateValue.SizeF = new System.Drawing.SizeF(125.2083F, 26.04164F);
            this.xrLblDateCreateValue.StylePriority.UseFont = false;
            this.xrLblDateCreateValue.Text = "01/01/2014";
            // 
            // xrLblTaxId
            // 
            this.xrLblTaxId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLblTaxId.LocationFloat = new DevExpress.Utils.PointFloat(0.8333047F, 46.00003F);
            this.xrLblTaxId.Name = "xrLblTaxId";
            this.xrLblTaxId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLblTaxId.SizeF = new System.Drawing.SizeF(88.54166F, 23F);
            this.xrLblTaxId.StylePriority.UseFont = false;
            this.xrLblTaxId.StylePriority.UseTextAlignment = false;
            this.xrLblTaxId.Text = "Mã số thuế:";
            this.xrLblTaxId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlblTaxIdValue
            // 
            this.xrlblTaxIdValue.AutoWidth = true;
            this.xrlblTaxIdValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblTaxIdValue.LocationFloat = new DevExpress.Utils.PointFloat(89.37495F, 46.00003F);
            this.xrlblTaxIdValue.Name = "xrlblTaxIdValue";
            this.xrlblTaxIdValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTaxIdValue.SizeF = new System.Drawing.SizeF(307.7084F, 23F);
            this.xrlblTaxIdValue.StylePriority.UseFont = false;
            this.xrlblTaxIdValue.StylePriority.UseTextAlignment = false;
            this.xrlblTaxIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbTitles
            // 
            this.xrlbTitles.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrlbTitles.LocationFloat = new DevExpress.Utils.PointFloat(148.39F, 104.4584F);
            this.xrlbTitles.Name = "xrlbTitles";
            this.xrlbTitles.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbTitles.SizeF = new System.Drawing.SizeF(339.7917F, 36.54164F);
            this.xrlbTitles.StylePriority.UseFont = false;
            this.xrlbTitles.StylePriority.UseTextAlignment = false;
            this.xrlbTitles.Text = "HÓA ĐƠN";
            this.xrlbTitles.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xlblAddress
            // 
            this.xlblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.xlblAddress.LocationFloat = new DevExpress.Utils.PointFloat(0.8333047F, 24.04169F);
            this.xlblAddress.Name = "xlblAddress";
            this.xlblAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlblAddress.SizeF = new System.Drawing.SizeF(396.9795F, 21.95833F);
            this.xlblAddress.StylePriority.UseFont = false;
            this.xlblAddress.StylePriority.UseTextAlignment = false;
            this.xlblAddress.Text = "Khu phố 6 - P. Linh Trung - Thủ Đức - Tp HCM";
            this.xlblAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xlblCompanyName
            // 
            this.xlblCompanyName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xlblCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xlblCompanyName.Name = "xlblCompanyName";
            this.xlblCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlblCompanyName.SizeF = new System.Drawing.SizeF(397.8128F, 24.04167F);
            this.xlblCompanyName.StylePriority.UseFont = false;
            this.xlblCompanyName.StylePriority.UseTextAlignment = false;
            this.xlblCompanyName.Text = "CỬA HÀNG SÁCH 3T";
            this.xlblCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbBillIdValue
            // 
            this.xrlbBillIdValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrlbBillIdValue.ForeColor = System.Drawing.Color.Black;
            this.xrlbBillIdValue.LocationFloat = new DevExpress.Utils.PointFloat(514.7916F, 24.04169F);
            this.xrlbBillIdValue.Name = "xrlbBillIdValue";
            this.xrlbBillIdValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbBillIdValue.SizeF = new System.Drawing.SizeF(135.2084F, 21.95833F);
            this.xrlbBillIdValue.StylePriority.UseFont = false;
            this.xrlbBillIdValue.StylePriority.UseForeColor = false;
            this.xrlbBillIdValue.StylePriority.UseTextAlignment = false;
            this.xrlbBillIdValue.Text = "01";
            this.xrlbBillIdValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbBillId
            // 
            this.xrlbBillId.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrlbBillId.ForeColor = System.Drawing.Color.Black;
            this.xrlbBillId.LocationFloat = new DevExpress.Utils.PointFloat(421.0416F, 24.04169F);
            this.xrlbBillId.Name = "xrlbBillId";
            this.xrlbBillId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbBillId.SizeF = new System.Drawing.SizeF(87.5F, 21.95833F);
            this.xrlbBillId.StylePriority.UseFont = false;
            this.xrlbBillId.StylePriority.UseForeColor = false;
            this.xrlbBillId.StylePriority.UseTextAlignment = false;
            this.xrlbBillId.Text = "Số hóa đơn:";
            this.xrlbBillId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbAddressValue
            // 
            this.xrlbAddressValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.xrlbAddressValue.LocationFloat = new DevExpress.Utils.PointFloat(68.54166F, 227.2067F);
            this.xrlbAddressValue.Name = "xrlbAddressValue";
            this.xrlbAddressValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbAddressValue.SizeF = new System.Drawing.SizeF(449.9584F, 25.08336F);
            this.xrlbAddressValue.StylePriority.UseFont = false;
            this.xrlbAddressValue.Text = "aaaaaaaaa";
            // 
            // xrlbCustomerNameValue
            // 
            this.xrlbCustomerNameValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.xrlbCustomerNameValue.LocationFloat = new DevExpress.Utils.PointFloat(126.4533F, 201.1667F);
            this.xrlbCustomerNameValue.Name = "xrlbCustomerNameValue";
            this.xrlbCustomerNameValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbCustomerNameValue.SizeF = new System.Drawing.SizeF(255.05F, 26.04F);
            this.xrlbCustomerNameValue.StylePriority.UseFont = false;
            this.xrlbCustomerNameValue.Text = "Hạ Long";
            // 
            // xrlbDateTimePrint
            // 
            this.xrlbDateTimePrint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrlbDateTimePrint.LocationFloat = new DevExpress.Utils.PointFloat(382.5001F, 201.1667F);
            this.xrlbDateTimePrint.Name = "xrlbDateTimePrint";
            this.xrlbDateTimePrint.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateTimePrint.SizeF = new System.Drawing.SizeF(136F, 26.04F);
            this.xrlbDateTimePrint.StylePriority.UseFont = false;
            this.xrlbDateTimePrint.Text = "Ngày giờ in phiếu:";
            // 
            // xrlFirst
            // 
            this.xrlFirst.LocationFloat = new DevExpress.Utils.PointFloat(0.8333047F, 69.00003F);
            this.xrlFirst.Name = "xrlFirst";
            this.xrlFirst.SizeF = new System.Drawing.SizeF(649.1667F, 23F);
            // 
            // xrlbDateTimePrintValue
            // 
            this.xrlbDateTimePrintValue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
            this.xrlbDateTimePrintValue.LocationFloat = new DevExpress.Utils.PointFloat(520.0001F, 201.1667F);
            this.xrlbDateTimePrintValue.Name = "xrlbDateTimePrintValue";
            this.xrlbDateTimePrintValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbDateTimePrintValue.SizeF = new System.Drawing.SizeF(130F, 51.12169F);
            this.xrlbDateTimePrintValue.StylePriority.UseFont = false;
            this.xrlbDateTimePrintValue.Text = "01/12/1993";
            // 
            // xrlbCustomerAddress
            // 
            this.xrlbCustomerAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrlbCustomerAddress.LocationFloat = new DevExpress.Utils.PointFloat(0.8333047F, 227.205F);
            this.xrlbCustomerAddress.Name = "xrlbCustomerAddress";
            this.xrlbCustomerAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbCustomerAddress.SizeF = new System.Drawing.SizeF(67.70834F, 25.08333F);
            this.xrlbCustomerAddress.StylePriority.UseFont = false;
            this.xrlbCustomerAddress.Text = "Địa chỉ:";
            // 
            // xrlbCustomerName
            // 
            this.xrlbCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrlbCustomerName.LocationFloat = new DevExpress.Utils.PointFloat(0.8333047F, 201.165F);
            this.xrlbCustomerName.Name = "xrlbCustomerName";
            this.xrlbCustomerName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbCustomerName.SizeF = new System.Drawing.SizeF(125.62F, 26.04F);
            this.xrlbCustomerName.StylePriority.UseFont = false;
            this.xrlbCustomerName.Text = "Tên khách hàng:";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtbDeliveryNote});
            this.PageHeader.HeightF = 25F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrtbDeliveryNote
            // 
            this.xrtbDeliveryNote.BackColor = System.Drawing.Color.Empty;
            this.xrtbDeliveryNote.BorderColor = System.Drawing.Color.Black;
            this.xrtbDeliveryNote.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrtbDeliveryNote.ForeColor = System.Drawing.Color.Black;
            this.xrtbDeliveryNote.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrtbDeliveryNote.Name = "xrtbDeliveryNote";
            this.xrtbDeliveryNote.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrtrDeliveryNote});
            this.xrtbDeliveryNote.SizeF = new System.Drawing.SizeF(650.0001F, 25F);
            this.xrtbDeliveryNote.StylePriority.UseBackColor = false;
            this.xrtbDeliveryNote.StylePriority.UseBorderColor = false;
            this.xrtbDeliveryNote.StylePriority.UseFont = false;
            this.xrtbDeliveryNote.StylePriority.UseForeColor = false;
            this.xrtbDeliveryNote.StylePriority.UseTextAlignment = false;
            this.xrtbDeliveryNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrtrDeliveryNote
            // 
            this.xrtrDeliveryNote.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrtrDeliveryNote.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrtbcSno,
            this.xrtbrId,
            this.xrtbrName,
            this.xrtbcQuantity,
            this.xrtbcPrices,
            this.xrtbAmount});
            this.xrtrDeliveryNote.Name = "xrtrDeliveryNote";
            this.xrtrDeliveryNote.StylePriority.UseBorders = false;
            this.xrtrDeliveryNote.Weight = 1D;
            // 
            // xrtbcSno
            // 
            this.xrtbcSno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbcSno.Name = "xrtbcSno";
            this.xrtbcSno.StylePriority.UseFont = false;
            this.xrtbcSno.StylePriority.UseTextAlignment = false;
            this.xrtbcSno.Text = "STT";
            this.xrtbcSno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrtbcSno.Weight = 0.41788977880838962D;
            // 
            // xrtbrId
            // 
            this.xrtbrId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbrId.Name = "xrtbrId";
            this.xrtbrId.StylePriority.UseFont = false;
            this.xrtbrId.StylePriority.UseTextAlignment = false;
            this.xrtbrId.Text = "Mã phòng, DV";
            this.xrtbrId.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrtbrId.Weight = 1.2738495950169984D;
            // 
            // xrtbrName
            // 
            this.xrtbrName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbrName.Name = "xrtbrName";
            this.xrtbrName.StylePriority.UseFont = false;
            this.xrtbrName.StylePriority.UseTextAlignment = false;
            this.xrtbrName.Text = "Tên phòng, DV";
            this.xrtbrName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrtbrName.Weight = 1.2690596958549991D;
            // 
            // xrtbcQuantity
            // 
            this.xrtbcQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbcQuantity.Name = "xrtbcQuantity";
            this.xrtbcQuantity.StylePriority.UseFont = false;
            this.xrtbcQuantity.Text = "Số lượng";
            this.xrtbcQuantity.Weight = 0.73130708664269028D;
            // 
            // xrtbcPrices
            // 
            this.xrtbcPrices.BackColor = System.Drawing.Color.Empty;
            this.xrtbcPrices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbcPrices.Name = "xrtbcPrices";
            this.xrtbcPrices.StylePriority.UseBackColor = false;
            this.xrtbcPrices.StylePriority.UseFont = false;
            this.xrtbcPrices.StylePriority.UseTextAlignment = false;
            this.xrtbcPrices.Text = "Đơn giá";
            this.xrtbcPrices.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrtbcPrices.Weight = 1.4080475683088043D;
            // 
            // xrtbAmount
            // 
            this.xrtbAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrtbAmount.Name = "xrtbAmount";
            this.xrtbAmount.StylePriority.UseFont = false;
            this.xrtbAmount.StylePriority.UseTextAlignment = false;
            this.xrtbAmount.Text = "Thành tiền";
            this.xrtbAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrtbAmount.Weight = 1.6905550240132403D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel1,
            this.xrlblTotalMoneyValue,
            this.xrlblTotalMoney,
            this.xrlbThanks,
            this.xrlSecond});
            this.ReportFooter.HeightF = 528.8333F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(230.1469F, 95.83337F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(221.624F, 25.08333F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Hẹn gặp lại!";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.ForeColor = System.Drawing.Color.Black;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(603.5417F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(46.45837F, 25.08336F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "vnđ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlblTotalMoneyValue
            // 
            this.xrlblTotalMoneyValue.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrlblTotalMoneyValue.ForeColor = System.Drawing.Color.Black;
            this.xrlblTotalMoneyValue.LocationFloat = new DevExpress.Utils.PointFloat(468.3759F, 10.00007F);
            this.xrlblTotalMoneyValue.Name = "xrlblTotalMoneyValue";
            this.xrlblTotalMoneyValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTotalMoneyValue.SizeF = new System.Drawing.SizeF(135.1658F, 25.08331F);
            this.xrlblTotalMoneyValue.StylePriority.UseFont = false;
            this.xrlblTotalMoneyValue.StylePriority.UseForeColor = false;
            this.xrlblTotalMoneyValue.StylePriority.UseTextAlignment = false;
            this.xrlblTotalMoneyValue.Text = "0";
            this.xrlblTotalMoneyValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrlblTotalMoney
            // 
            this.xrlblTotalMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrlblTotalMoney.LocationFloat = new DevExpress.Utils.PointFloat(292.9167F, 10.00001F);
            this.xrlblTotalMoney.Name = "xrlblTotalMoney";
            this.xrlblTotalMoney.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTotalMoney.SizeF = new System.Drawing.SizeF(104.1667F, 25.08331F);
            this.xrlblTotalMoney.StylePriority.UseFont = false;
            this.xrlblTotalMoney.StylePriority.UseTextAlignment = false;
            this.xrlblTotalMoney.Text = "TỔNG TIỀN:";
            this.xrlblTotalMoney.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlbThanks
            // 
            this.xrlbThanks.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlbThanks.LocationFloat = new DevExpress.Utils.PointFloat(230.1468F, 70.75008F);
            this.xrlbThanks.Name = "xrlbThanks";
            this.xrlbThanks.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlbThanks.SizeF = new System.Drawing.SizeF(221.624F, 25.08333F);
            this.xrlbThanks.StylePriority.UseFont = false;
            this.xrlbThanks.StylePriority.UseTextAlignment = false;
            this.xrlbThanks.Text = "CẢM ƠN QUÝ KHÁCH!";
            this.xrlbThanks.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrlSecond
            // 
            this.xrlSecond.LocationFloat = new DevExpress.Utils.PointFloat(89.37495F, 35.08338F);
            this.xrlSecond.Name = "xrlSecond";
            this.xrlSecond.SizeF = new System.Drawing.SizeF(457.2917F, 23F);
            // 
            // rptViewBill
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter});
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrtbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrtbDeliveryNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrlbBillIdValue;
        private DevExpress.XtraReports.UI.XRLabel xrlbBillId;
        private DevExpress.XtraReports.UI.XRLabel xrlbAddressValue;
        private DevExpress.XtraReports.UI.XRLabel xrlbCustomerNameValue;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateTimePrint;
        private DevExpress.XtraReports.UI.XRLine xrlFirst;
        private DevExpress.XtraReports.UI.XRLabel xrlbDateTimePrintValue;
        private DevExpress.XtraReports.UI.XRLabel xrlbCustomerAddress;
        private DevExpress.XtraReports.UI.XRLabel xrlbCustomerName;
        private DevExpress.XtraReports.UI.XRTable xrtbDeliveryNote;
        private DevExpress.XtraReports.UI.XRTableRow xrtrDeliveryNote;
        private DevExpress.XtraReports.UI.XRTableCell xrtbcSno;
        private DevExpress.XtraReports.UI.XRTableCell xrtbrId;
        private DevExpress.XtraReports.UI.XRTableCell xrtbrName;
        private DevExpress.XtraReports.UI.XRTableCell xrtbcQuantity;
        private DevExpress.XtraReports.UI.XRTableCell xrtbcPrices;
        private DevExpress.XtraReports.UI.XRTableCell xrtbAmount;
        private DevExpress.XtraReports.UI.XRLine xrlSecond;
        private DevExpress.XtraReports.UI.XRLabel xlblAddress;
        private DevExpress.XtraReports.UI.XRLabel xlblCompanyName;
        private DevExpress.XtraReports.UI.XRLabel xrlbTitles;
        private DevExpress.XtraReports.UI.XRLabel xrLblTaxId;
        private DevExpress.XtraReports.UI.XRLabel xrlblTaxIdValue;
        private DevExpress.XtraReports.UI.XRLabel xrLblDateCreateBill;
        private DevExpress.XtraReports.UI.XRLabel xrLblDateCreateValue;
        private DevExpress.XtraReports.UI.XRLabel xrLblStaff;
        private DevExpress.XtraReports.UI.XRLabel xrLblStaffName;
        private DevExpress.XtraReports.UI.XRTable xrtbValue;
        private DevExpress.XtraReports.UI.XRTableRow xrtbRValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbSnoValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomIdValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbRoomNameValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbCountValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbPriceValue;
        private DevExpress.XtraReports.UI.XRTableCell xrtbAmountValue;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrlblTotalMoneyValue;
        private DevExpress.XtraReports.UI.XRLabel xrlblTotalMoney;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrlbThanks;
    }
}
