namespace HotelManager
{
    partial class frmOrderView
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
            this.pnlTitle = new DevExpress.XtraEditors.PanelControl();
            this.labOrder = new DevExpress.XtraEditors.LabelControl();
            this.pnlExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnChangeToView = new DevExpress.XtraEditors.SimpleButton();
            this.pnlOrderView = new DevExpress.XtraEditors.PanelControl();
            this.grpListRoom = new DevExpress.XtraEditors.GroupControl();
            this.grdListRoom = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCol1RoomSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol1RoomID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol1RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol1RoomTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol1StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grdCol1EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.grdCol1NumberOfPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grpCol1Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCol1Monetized = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.spinDeposit = new DevExpress.XtraEditors.SpinEdit();
            this.labDeposit = new DevExpress.XtraEditors.LabelControl();
            this.spintotalEstimate = new DevExpress.XtraEditors.SpinEdit();
            this.labTotalEstimate = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalPeople = new DevExpress.XtraEditors.SpinEdit();
            this.labTotalPeople = new DevExpress.XtraEditors.LabelControl();
            this.spinTotalRoom = new DevExpress.XtraEditors.SpinEdit();
            this.labTotalRoom = new DevExpress.XtraEditors.LabelControl();
            this.grpOrderInfo = new DevExpress.XtraEditors.GroupControl();
            this.labOrderOfDateValue = new DevExpress.XtraEditors.LabelControl();
            this.labStaffNameValue = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labStaffName = new DevExpress.XtraEditors.LabelControl();
            this.labAddressValue = new DevExpress.XtraEditors.LabelControl();
            this.labAddress = new DevExpress.XtraEditors.LabelControl();
            this.labNumberIDValue = new DevExpress.XtraEditors.LabelControl();
            this.labNumberID = new DevExpress.XtraEditors.LabelControl();
            this.labCustomerNameValue = new DevExpress.XtraEditors.LabelControl();
            this.labCustomerIDValue = new DevExpress.XtraEditors.LabelControl();
            this.labCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labCustomerID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecute)).BeginInit();
            this.pnlExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrderView)).BeginInit();
            this.pnlOrderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoom)).BeginInit();
            this.grpListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeposit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spintotalEstimate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalPeople.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOrderInfo)).BeginInit();
            this.grpOrderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.labOrder);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(971, 70);
            this.pnlTitle.TabIndex = 1;
            // 
            // labOrder
            // 
            this.labOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOrder.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labOrder.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labOrder.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labOrder.Location = new System.Drawing.Point(335, 24);
            this.labOrder.Name = "labOrder";
            this.labOrder.Size = new System.Drawing.Size(246, 26);
            this.labOrder.TabIndex = 2;
            this.labOrder.Text = "PHIẾU NHẬN PHÒNG";
            // 
            // pnlExecute
            // 
            this.pnlExecute.Controls.Add(this.btnPreview);
            this.pnlExecute.Controls.Add(this.btnChangeToView);
            this.pnlExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlExecute.Location = new System.Drawing.Point(0, 474);
            this.pnlExecute.Name = "pnlExecute";
            this.pnlExecute.Size = new System.Drawing.Size(971, 49);
            this.pnlExecute.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(671, 8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 31);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "In phiếu";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnChangeToView
            // 
            this.btnChangeToView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeToView.Location = new System.Drawing.Point(772, 8);
            this.btnChangeToView.Name = "btnChangeToView";
            this.btnChangeToView.Size = new System.Drawing.Size(161, 31);
            this.btnChangeToView.TabIndex = 10;
            this.btnChangeToView.Text = "Thanh toán";
            this.btnChangeToView.Click += new System.EventHandler(this.btnChangeToView_Click);
            // 
            // pnlOrderView
            // 
            this.pnlOrderView.Controls.Add(this.grpListRoom);
            this.pnlOrderView.Controls.Add(this.panelControl1);
            this.pnlOrderView.Controls.Add(this.grpOrderInfo);
            this.pnlOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderView.Location = new System.Drawing.Point(0, 70);
            this.pnlOrderView.Name = "pnlOrderView";
            this.pnlOrderView.Size = new System.Drawing.Size(971, 404);
            this.pnlOrderView.TabIndex = 3;
            // 
            // grpListRoom
            // 
            this.grpListRoom.Controls.Add(this.grdListRoom);
            this.grpListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListRoom.Location = new System.Drawing.Point(2, 106);
            this.grpListRoom.Name = "grpListRoom";
            this.grpListRoom.Size = new System.Drawing.Size(967, 166);
            this.grpListRoom.TabIndex = 3;
            this.grpListRoom.Text = "Danh sách phòng";
            // 
            // grdListRoom
            // 
            this.grdListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoom.Location = new System.Drawing.Point(2, 20);
            this.grdListRoom.MainView = this.grdvListRoom;
            this.grdListRoom.Name = "grdListRoom";
            this.grdListRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2});
            this.grdListRoom.Size = new System.Drawing.Size(963, 144);
            this.grdListRoom.TabIndex = 4;
            this.grdListRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoom});
            // 
            // grdvListRoom
            // 
            this.grdvListRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdCol1RoomSno,
            this.grdCol1RoomID,
            this.grdCol1RoomName,
            this.grdCol1RoomTypeName,
            this.grdCol1StartDate,
            this.grdCol1EndDate,
            this.grdCol1NumberOfPeople,
            this.grpCol1Price,
            this.grdCol1Monetized});
            this.grdvListRoom.GridControl = this.grdListRoom;
            this.grdvListRoom.Name = "grdvListRoom";
            this.grdvListRoom.OptionsBehavior.ReadOnly = true;
            this.grdvListRoom.OptionsView.ShowGroupPanel = false;
            // 
            // grdCol1RoomSno
            // 
            this.grdCol1RoomSno.Caption = "STT";
            this.grdCol1RoomSno.FieldName = "STT";
            this.grdCol1RoomSno.Name = "grdCol1RoomSno";
            this.grdCol1RoomSno.OptionsColumn.ReadOnly = true;
            this.grdCol1RoomSno.Visible = true;
            this.grdCol1RoomSno.VisibleIndex = 0;
            this.grdCol1RoomSno.Width = 31;
            // 
            // grdCol1RoomID
            // 
            this.grdCol1RoomID.Caption = "Mã phòng";
            this.grdCol1RoomID.FieldName = "RoomID";
            this.grdCol1RoomID.Name = "grdCol1RoomID";
            this.grdCol1RoomID.OptionsColumn.ReadOnly = true;
            this.grdCol1RoomID.Visible = true;
            this.grdCol1RoomID.VisibleIndex = 1;
            this.grdCol1RoomID.Width = 68;
            // 
            // grdCol1RoomName
            // 
            this.grdCol1RoomName.Caption = "Tên phòng";
            this.grdCol1RoomName.FieldName = "RoomName";
            this.grdCol1RoomName.Name = "grdCol1RoomName";
            this.grdCol1RoomName.OptionsColumn.ReadOnly = true;
            this.grdCol1RoomName.Visible = true;
            this.grdCol1RoomName.VisibleIndex = 2;
            this.grdCol1RoomName.Width = 68;
            // 
            // grdCol1RoomTypeName
            // 
            this.grdCol1RoomTypeName.Caption = "Loại phòng";
            this.grdCol1RoomTypeName.FieldName = "RoomTypeName";
            this.grdCol1RoomTypeName.Name = "grdCol1RoomTypeName";
            this.grdCol1RoomTypeName.OptionsColumn.ReadOnly = true;
            this.grdCol1RoomTypeName.Visible = true;
            this.grdCol1RoomTypeName.VisibleIndex = 3;
            this.grdCol1RoomTypeName.Width = 88;
            // 
            // grdCol1StartDate
            // 
            this.grdCol1StartDate.Caption = "Ngày đến";
            this.grdCol1StartDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.grdCol1StartDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.grdCol1StartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdCol1StartDate.FieldName = "StartDate";
            this.grdCol1StartDate.GroupFormat.FormatString = "dd/MM/yyyy";
            this.grdCol1StartDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdCol1StartDate.Name = "grdCol1StartDate";
            this.grdCol1StartDate.OptionsColumn.ReadOnly = true;
            this.grdCol1StartDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.grdCol1StartDate.Visible = true;
            this.grdCol1StartDate.VisibleIndex = 4;
            this.grdCol1StartDate.Width = 62;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // grdCol1EndDate
            // 
            this.grdCol1EndDate.Caption = "Ngày đi";
            this.grdCol1EndDate.ColumnEdit = this.repositoryItemDateEdit2;
            this.grdCol1EndDate.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.grdCol1EndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.grdCol1EndDate.FieldName = "EndDate";
            this.grdCol1EndDate.Name = "grdCol1EndDate";
            this.grdCol1EndDate.OptionsColumn.ReadOnly = true;
            this.grdCol1EndDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.grdCol1EndDate.Visible = true;
            this.grdCol1EndDate.VisibleIndex = 5;
            this.grdCol1EndDate.Width = 62;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // grdCol1NumberOfPeople
            // 
            this.grdCol1NumberOfPeople.Caption = "Số người";
            this.grdCol1NumberOfPeople.FieldName = "NumberOfBeds";
            this.grdCol1NumberOfPeople.Name = "grdCol1NumberOfPeople";
            this.grdCol1NumberOfPeople.OptionsColumn.ReadOnly = true;
            this.grdCol1NumberOfPeople.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumberOfBeds", "SUM={0:0.##}")});
            this.grdCol1NumberOfPeople.Visible = true;
            this.grdCol1NumberOfPeople.VisibleIndex = 6;
            this.grdCol1NumberOfPeople.Width = 62;
            // 
            // grpCol1Price
            // 
            this.grpCol1Price.Caption = "Giá";
            this.grpCol1Price.FieldName = "Price";
            this.grpCol1Price.Name = "grpCol1Price";
            this.grpCol1Price.OptionsColumn.ReadOnly = true;
            this.grpCol1Price.Visible = true;
            this.grpCol1Price.VisibleIndex = 7;
            this.grpCol1Price.Width = 62;
            // 
            // grdCol1Monetized
            // 
            this.grdCol1Monetized.Caption = "Thành tiền";
            this.grdCol1Monetized.FieldName = "Monetized";
            this.grdCol1Monetized.Name = "grdCol1Monetized";
            this.grdCol1Monetized.OptionsColumn.ReadOnly = true;
            this.grdCol1Monetized.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monetized", "SUM={0:0.##}")});
            this.grdCol1Monetized.Visible = true;
            this.grdCol1Monetized.VisibleIndex = 8;
            this.grdCol1Monetized.Width = 81;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spinDeposit);
            this.panelControl1.Controls.Add(this.labDeposit);
            this.panelControl1.Controls.Add(this.spintotalEstimate);
            this.panelControl1.Controls.Add(this.labTotalEstimate);
            this.panelControl1.Controls.Add(this.spinTotalPeople);
            this.panelControl1.Controls.Add(this.labTotalPeople);
            this.panelControl1.Controls.Add(this.spinTotalRoom);
            this.panelControl1.Controls.Add(this.labTotalRoom);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 272);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(967, 130);
            this.panelControl1.TabIndex = 2;
            // 
            // spinDeposit
            // 
            this.spinDeposit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinDeposit.Location = new System.Drawing.Point(810, 88);
            this.spinDeposit.Name = "spinDeposit";
            this.spinDeposit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinDeposit.Properties.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.spinDeposit.Properties.Appearance.Options.UseBackColor = true;
            this.spinDeposit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDeposit.Properties.ReadOnly = true;
            this.spinDeposit.Size = new System.Drawing.Size(123, 20);
            this.spinDeposit.TabIndex = 29;
            // 
            // labDeposit
            // 
            this.labDeposit.Location = new System.Drawing.Point(681, 91);
            this.labDeposit.Name = "labDeposit";
            this.labDeposit.Size = new System.Drawing.Size(71, 13);
            this.labDeposit.TabIndex = 25;
            this.labDeposit.Text = "Số tiền đặt cọc";
            // 
            // spintotalEstimate
            // 
            this.spintotalEstimate.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spintotalEstimate.Location = new System.Drawing.Point(810, 57);
            this.spintotalEstimate.Name = "spintotalEstimate";
            this.spintotalEstimate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spintotalEstimate.Properties.Appearance.BackColor = System.Drawing.Color.Pink;
            this.spintotalEstimate.Properties.Appearance.Options.UseBackColor = true;
            this.spintotalEstimate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spintotalEstimate.Properties.ReadOnly = true;
            this.spintotalEstimate.Size = new System.Drawing.Size(123, 20);
            this.spintotalEstimate.TabIndex = 30;
            // 
            // labTotalEstimate
            // 
            this.labTotalEstimate.Location = new System.Drawing.Point(681, 60);
            this.labTotalEstimate.Name = "labTotalEstimate";
            this.labTotalEstimate.Size = new System.Drawing.Size(87, 13);
            this.labTotalEstimate.TabIndex = 26;
            this.labTotalEstimate.Text = "Tổng tiền ước tính";
            // 
            // spinTotalPeople
            // 
            this.spinTotalPeople.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalPeople.Location = new System.Drawing.Point(810, 25);
            this.spinTotalPeople.Name = "spinTotalPeople";
            this.spinTotalPeople.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinTotalPeople.Properties.Appearance.BackColor = System.Drawing.Color.Pink;
            this.spinTotalPeople.Properties.Appearance.Options.UseBackColor = true;
            this.spinTotalPeople.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTotalPeople.Properties.ReadOnly = true;
            this.spinTotalPeople.Size = new System.Drawing.Size(123, 20);
            this.spinTotalPeople.TabIndex = 31;
            // 
            // labTotalPeople
            // 
            this.labTotalPeople.Location = new System.Drawing.Point(681, 28);
            this.labTotalPeople.Name = "labTotalPeople";
            this.labTotalPeople.Size = new System.Drawing.Size(115, 13);
            this.labTotalPeople.TabIndex = 27;
            this.labTotalPeople.Text = "Tổng số người ở dự kiến";
            // 
            // spinTotalRoom
            // 
            this.spinTotalRoom.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinTotalRoom.Location = new System.Drawing.Point(524, 25);
            this.spinTotalRoom.Name = "spinTotalRoom";
            this.spinTotalRoom.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.spinTotalRoom.Properties.Appearance.BackColor = System.Drawing.Color.Pink;
            this.spinTotalRoom.Properties.Appearance.Options.UseBackColor = true;
            this.spinTotalRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTotalRoom.Properties.ReadOnly = true;
            this.spinTotalRoom.Size = new System.Drawing.Size(123, 20);
            this.spinTotalRoom.TabIndex = 32;
            // 
            // labTotalRoom
            // 
            this.labTotalRoom.Location = new System.Drawing.Point(440, 28);
            this.labTotalRoom.Name = "labTotalRoom";
            this.labTotalRoom.Size = new System.Drawing.Size(71, 13);
            this.labTotalRoom.TabIndex = 28;
            this.labTotalRoom.Text = "Tổng số phòng";
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.labOrderOfDateValue);
            this.grpOrderInfo.Controls.Add(this.labStaffNameValue);
            this.grpOrderInfo.Controls.Add(this.labelControl7);
            this.grpOrderInfo.Controls.Add(this.labStaffName);
            this.grpOrderInfo.Controls.Add(this.labAddressValue);
            this.grpOrderInfo.Controls.Add(this.labAddress);
            this.grpOrderInfo.Controls.Add(this.labNumberIDValue);
            this.grpOrderInfo.Controls.Add(this.labNumberID);
            this.grpOrderInfo.Controls.Add(this.labCustomerNameValue);
            this.grpOrderInfo.Controls.Add(this.labCustomerIDValue);
            this.grpOrderInfo.Controls.Add(this.labCustomerName);
            this.grpOrderInfo.Controls.Add(this.labCustomerID);
            this.grpOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOrderInfo.Location = new System.Drawing.Point(2, 2);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Size = new System.Drawing.Size(967, 104);
            this.grpOrderInfo.TabIndex = 0;
            this.grpOrderInfo.Text = "Thông tin hóa đơn";
            // 
            // labOrderOfDateValue
            // 
            this.labOrderOfDateValue.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labOrderOfDateValue.Location = new System.Drawing.Point(800, 41);
            this.labOrderOfDateValue.Name = "labOrderOfDateValue";
            this.labOrderOfDateValue.Size = new System.Drawing.Size(42, 13);
            this.labOrderOfDateValue.TabIndex = 7;
            this.labOrderOfDateValue.Text = "Ngày lập";
            // 
            // labStaffNameValue
            // 
            this.labStaffNameValue.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labStaffNameValue.Location = new System.Drawing.Point(800, 75);
            this.labStaffNameValue.Name = "labStaffNameValue";
            this.labStaffNameValue.Size = new System.Drawing.Size(48, 13);
            this.labStaffNameValue.TabIndex = 8;
            this.labStaffNameValue.Text = "Nhân viên";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(690, 41);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Ngày lập";
            // 
            // labStaffName
            // 
            this.labStaffName.Location = new System.Drawing.Point(690, 75);
            this.labStaffName.Name = "labStaffName";
            this.labStaffName.Size = new System.Drawing.Size(48, 13);
            this.labStaffName.TabIndex = 8;
            this.labStaffName.Text = "Nhân viên";
            // 
            // labAddressValue
            // 
            this.labAddressValue.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labAddressValue.Location = new System.Drawing.Point(419, 72);
            this.labAddressValue.Name = "labAddressValue";
            this.labAddressValue.Size = new System.Drawing.Size(36, 13);
            this.labAddressValue.TabIndex = 3;
            this.labAddressValue.Text = "Địa chỉ";
            // 
            // labAddress
            // 
            this.labAddress.Location = new System.Drawing.Point(305, 71);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(36, 13);
            this.labAddress.TabIndex = 3;
            this.labAddress.Text = "Địa chỉ";
            // 
            // labNumberIDValue
            // 
            this.labNumberIDValue.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labNumberIDValue.Location = new System.Drawing.Point(160, 72);
            this.labNumberIDValue.Name = "labNumberIDValue";
            this.labNumberIDValue.Size = new System.Drawing.Size(44, 13);
            this.labNumberIDValue.TabIndex = 4;
            this.labNumberIDValue.Text = "Số CMND";
            // 
            // labNumberID
            // 
            this.labNumberID.Location = new System.Drawing.Point(46, 71);
            this.labNumberID.Name = "labNumberID";
            this.labNumberID.Size = new System.Drawing.Size(44, 13);
            this.labNumberID.TabIndex = 4;
            this.labNumberID.Text = "Số CMND";
            // 
            // labCustomerNameValue
            // 
            this.labCustomerNameValue.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labCustomerNameValue.Location = new System.Drawing.Point(419, 40);
            this.labCustomerNameValue.Name = "labCustomerNameValue";
            this.labCustomerNameValue.Size = new System.Drawing.Size(76, 13);
            this.labCustomerNameValue.TabIndex = 5;
            this.labCustomerNameValue.Text = "Tên khách hàng";
            // 
            // labCustomerIDValue
            // 
            this.labCustomerIDValue.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labCustomerIDValue.Location = new System.Drawing.Point(160, 41);
            this.labCustomerIDValue.Name = "labCustomerIDValue";
            this.labCustomerIDValue.Size = new System.Drawing.Size(72, 13);
            this.labCustomerIDValue.TabIndex = 6;
            this.labCustomerIDValue.Text = "Mã khách hàng";
            // 
            // labCustomerName
            // 
            this.labCustomerName.Location = new System.Drawing.Point(305, 39);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labCustomerName.TabIndex = 5;
            this.labCustomerName.Text = "Tên khách hàng";
            // 
            // labCustomerID
            // 
            this.labCustomerID.Location = new System.Drawing.Point(46, 40);
            this.labCustomerID.Name = "labCustomerID";
            this.labCustomerID.Size = new System.Drawing.Size(72, 13);
            this.labCustomerID.TabIndex = 6;
            this.labCustomerID.Text = "Mã khách hàng";
            // 
            // frmOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 523);
            this.Controls.Add(this.pnlOrderView);
            this.Controls.Add(this.pnlExecute);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmOrderView";
            this.Text = "Phiếu nhận phòng";
            this.Load += new System.EventHandler(this.frmOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitle)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlExecute)).EndInit();
            this.pnlExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrderView)).EndInit();
            this.pnlOrderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoom)).EndInit();
            this.grpListRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDeposit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spintotalEstimate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalPeople.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpOrderInfo)).EndInit();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTitle;
        private DevExpress.XtraEditors.LabelControl labOrder;
        private DevExpress.XtraEditors.PanelControl pnlExecute;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnChangeToView;
        private DevExpress.XtraEditors.PanelControl pnlOrderView;
        private DevExpress.XtraEditors.GroupControl grpOrderInfo;
        private DevExpress.XtraEditors.LabelControl labAddress;
        private DevExpress.XtraEditors.LabelControl labNumberID;
        private DevExpress.XtraEditors.LabelControl labCustomerName;
        private DevExpress.XtraEditors.LabelControl labCustomerID;
        private DevExpress.XtraEditors.LabelControl labAddressValue;
        private DevExpress.XtraEditors.LabelControl labNumberIDValue;
        private DevExpress.XtraEditors.LabelControl labCustomerNameValue;
        private DevExpress.XtraEditors.LabelControl labCustomerIDValue;
        private DevExpress.XtraEditors.GroupControl grpListRoom;
        private DevExpress.XtraGrid.GridControl grdListRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoom;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1RoomSno;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1RoomID;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1RoomName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1RoomTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1StartDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1EndDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1NumberOfPeople;
        private DevExpress.XtraGrid.Columns.GridColumn grpCol1Price;
        private DevExpress.XtraGrid.Columns.GridColumn grdCol1Monetized;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labOrderOfDateValue;
        private DevExpress.XtraEditors.LabelControl labStaffNameValue;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labStaffName;
        private DevExpress.XtraEditors.SpinEdit spinDeposit;
        private DevExpress.XtraEditors.LabelControl labDeposit;
        private DevExpress.XtraEditors.SpinEdit spintotalEstimate;
        private DevExpress.XtraEditors.LabelControl labTotalEstimate;
        private DevExpress.XtraEditors.SpinEdit spinTotalPeople;
        private DevExpress.XtraEditors.LabelControl labTotalPeople;
        private DevExpress.XtraEditors.SpinEdit spinTotalRoom;
        private DevExpress.XtraEditors.LabelControl labTotalRoom;
    }
}