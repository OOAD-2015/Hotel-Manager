namespace HotelManager
{
    partial class frmOrderSearch
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderSearch));
            this.panelRoomsT = new DevExpress.XtraEditors.PanelControl();
            this.labOrders = new DevExpress.XtraEditors.LabelControl();
            this.grpSearchInfo = new DevExpress.XtraEditors.GroupControl();
            this.lkCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.grpResult = new DevExpress.XtraEditors.GroupControl();
            this.grdListOrder = new DevExpress.XtraGrid.GridControl();
            this.grdvListOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColOrderOfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColStaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColNumberOfPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdgSearchOption = new DevExpress.XtraEditors.RadioGroup();
            this.picSearch = new DevExpress.XtraEditors.PictureEdit();
            this.txtIDNumber = new DevExpress.XtraEditors.TextEdit();
            this.grdColOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdIDNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColCutomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelRoomsT)).BeginInit();
            this.panelRoomsT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchInfo)).BeginInit();
            this.grpSearchInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).BeginInit();
            this.grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSearchOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoomsT
            // 
            this.panelRoomsT.Controls.Add(this.labOrders);
            this.panelRoomsT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomsT.Location = new System.Drawing.Point(0, 0);
            this.panelRoomsT.Name = "panelRoomsT";
            this.panelRoomsT.Size = new System.Drawing.Size(719, 69);
            this.panelRoomsT.TabIndex = 8;
            // 
            // labOrders
            // 
            this.labOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOrders.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labOrders.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labOrders.Location = new System.Drawing.Point(205, 21);
            this.labOrders.Name = "labOrders";
            this.labOrders.Size = new System.Drawing.Size(370, 32);
            this.labOrders.TabIndex = 0;
            this.labOrders.Text = "DANH SÁCH PHIẾU ĐẶT PHÒNG";
            // 
            // grpSearchInfo
            // 
            this.grpSearchInfo.Controls.Add(this.txtIDNumber);
            this.grpSearchInfo.Controls.Add(this.picSearch);
            this.grpSearchInfo.Controls.Add(this.rdgSearchOption);
            this.grpSearchInfo.Controls.Add(this.lkCustomer);
            this.grpSearchInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchInfo.Location = new System.Drawing.Point(0, 69);
            this.grpSearchInfo.Name = "grpSearchInfo";
            this.grpSearchInfo.Size = new System.Drawing.Size(719, 92);
            this.grpSearchInfo.TabIndex = 9;
            this.grpSearchInfo.Text = "Thông tin ";
            // 
            // lkCustomer
            // 
            this.lkCustomer.Location = new System.Drawing.Point(65, 36);
            this.lkCustomer.Name = "lkCustomer";
            this.lkCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Tên khách hàng")});
            this.lkCustomer.Properties.NullText = "";
            this.lkCustomer.Size = new System.Drawing.Size(197, 20);
            this.lkCustomer.TabIndex = 24;
            this.lkCustomer.EditValueChanged += new System.EventHandler(this.lkCustomer_EditValueChanged);
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.grdListOrder);
            this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResult.Location = new System.Drawing.Point(0, 161);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(719, 336);
            this.grpResult.TabIndex = 10;
            this.grpResult.Text = "Kết quả tìm kiếm";
            // 
            // grdListOrder
            // 
            this.grdListOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListOrder.Location = new System.Drawing.Point(2, 20);
            this.grdListOrder.MainView = this.grdvListOrder;
            this.grdListOrder.Name = "grdListOrder";
            this.grdListOrder.Size = new System.Drawing.Size(715, 314);
            this.grdListOrder.TabIndex = 0;
            this.grdListOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListOrder});
            // 
            // grdvListOrder
            // 
            this.grdvListOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColOrderID,
            this.grdColCutomerName,
            this.grdIDNumber,
            this.grdColStaffName,
            this.grdColOrderOfDate,
            this.grdColNumberOfPeople,
            this.grdColTotal,
            this.grdColOrderStatus});
            this.grdvListOrder.GridControl = this.grdListOrder;
            this.grdvListOrder.Name = "grdvListOrder";
            this.grdvListOrder.OptionsView.ShowGroupPanel = false;
            this.grdvListOrder.DoubleClick += new System.EventHandler(this.grdvListOrder_DoubleClick);
            // 
            // grdColOrderOfDate
            // 
            this.grdColOrderOfDate.Caption = "Ngày lập";
            this.grdColOrderOfDate.FieldName = "OrderOfDate";
            this.grdColOrderOfDate.Name = "grdColOrderOfDate";
            this.grdColOrderOfDate.Visible = true;
            this.grdColOrderOfDate.VisibleIndex = 3;
            // 
            // grdColStaffName
            // 
            this.grdColStaffName.Caption = "Nhân viên";
            this.grdColStaffName.FieldName = "StaffName";
            this.grdColStaffName.Name = "grdColStaffName";
            this.grdColStaffName.Visible = true;
            this.grdColStaffName.VisibleIndex = 4;
            // 
            // grdColNumberOfPeople
            // 
            this.grdColNumberOfPeople.Caption = "Số người ở";
            this.grdColNumberOfPeople.FieldName = "NumberOfPeople";
            this.grdColNumberOfPeople.Name = "grdColNumberOfPeople";
            this.grdColNumberOfPeople.Visible = true;
            this.grdColNumberOfPeople.VisibleIndex = 5;
            // 
            // grdColTotal
            // 
            this.grdColTotal.Caption = "Tổng tiền";
            this.grdColTotal.FieldName = "Total";
            this.grdColTotal.Name = "grdColTotal";
            this.grdColTotal.Visible = true;
            this.grdColTotal.VisibleIndex = 6;
            // 
            // grdColOrderStatus
            // 
            this.grdColOrderStatus.Caption = "Trạng thái hóa đơn";
            this.grdColOrderStatus.FieldName = "OrderStatusName";
            this.grdColOrderStatus.Name = "grdColOrderStatus";
            this.grdColOrderStatus.Visible = true;
            this.grdColOrderStatus.VisibleIndex = 7;
            // 
            // rdgSearchOption
            // 
            this.rdgSearchOption.Location = new System.Drawing.Point(499, 32);
            this.rdgSearchOption.Name = "rdgSearchOption";
            this.rdgSearchOption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgSearchOption.Properties.Appearance.Options.UseBackColor = true;
            this.rdgSearchOption.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgSearchOption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tìm theo tên khách hàng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tìm theo số chứng minh nhân dân")});
            this.rdgSearchOption.Size = new System.Drawing.Size(208, 47);
            this.rdgSearchOption.TabIndex = 26;
            this.rdgSearchOption.SelectedIndexChanged += new System.EventHandler(this.rdgSearchOption_SelectedIndexChanged);
            // 
            // picSearch
            // 
            this.picSearch.EditValue = ((object)(resources.GetObject("picSearch.EditValue")));
            this.picSearch.Location = new System.Drawing.Point(22, 34);
            this.picSearch.Name = "picSearch";
            this.picSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Properties.Appearance.Options.UseBackColor = true;
            this.picSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picSearch.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picSearch.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picSearch.Size = new System.Drawing.Size(37, 38);
            this.picSearch.TabIndex = 28;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(65, 36);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(197, 20);
            this.txtIDNumber.TabIndex = 29;
            this.txtIDNumber.TextChanged += new System.EventHandler(this.txtIDNumber_TextChanged);
            // 
            // grdColOrderID
            // 
            this.grdColOrderID.Caption = "Mã hóa đơn";
            this.grdColOrderID.FieldName = "OrderID";
            this.grdColOrderID.Name = "grdColOrderID";
            this.grdColOrderID.Visible = true;
            this.grdColOrderID.VisibleIndex = 0;
            // 
            // grdIDNumber
            // 
            this.grdIDNumber.Caption = "CMND";
            this.grdIDNumber.FieldName = "IDNumber";
            this.grdIDNumber.Name = "grdIDNumber";
            this.grdIDNumber.Visible = true;
            this.grdIDNumber.VisibleIndex = 2;
            // 
            // grdColCutomerName
            // 
            this.grdColCutomerName.Caption = "Khách hàng";
            this.grdColCutomerName.FieldName = "CustomerName";
            this.grdColCutomerName.Name = "grdColCutomerName";
            this.grdColCutomerName.Visible = true;
            this.grdColCutomerName.VisibleIndex = 1;
            // 
            // frmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpSearchInfo);
            this.Controls.Add(this.panelRoomsT);
            this.Name = "frmOrderSearch";
            this.Text = "TÌM PHIẾU ĐẶT PHÒNG";
            this.Load += new System.EventHandler(this.frmOrderSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelRoomsT)).EndInit();
            this.panelRoomsT.ResumeLayout(false);
            this.panelRoomsT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchInfo)).EndInit();
            this.grpSearchInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).EndInit();
            this.grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSearchOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelRoomsT;
        private DevExpress.XtraEditors.LabelControl labOrders;
        private DevExpress.XtraEditors.GroupControl grpSearchInfo;
        private DevExpress.XtraEditors.LookUpEdit lkCustomer;
        private DevExpress.XtraEditors.GroupControl grpResult;
        private DevExpress.XtraGrid.GridControl grdListOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListOrder;
        private DevExpress.XtraGrid.Columns.GridColumn grdColOrderOfDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdColStaffName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColNumberOfPeople;
        private DevExpress.XtraGrid.Columns.GridColumn grdColTotal;
        private DevExpress.XtraGrid.Columns.GridColumn grdColOrderStatus;
        private DevExpress.XtraEditors.RadioGroup rdgSearchOption;
        private DevExpress.XtraEditors.TextEdit txtIDNumber;
        private DevExpress.XtraEditors.PictureEdit picSearch;
        private DevExpress.XtraGrid.Columns.GridColumn grdColOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn grdColCutomerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdIDNumber;
    }
}