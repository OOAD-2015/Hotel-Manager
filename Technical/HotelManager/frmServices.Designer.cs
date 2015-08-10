namespace HotelManager
{
    partial class frmServices
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
            this.components = new System.ComponentModel.Container();
            this.panelAuthorExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelAuthorDetail = new DevExpress.XtraEditors.PanelControl();
            this.btnAddServicesType = new DevExpress.XtraEditors.SimpleButton();
            this.lkServicesType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.lkUnit = new DevExpress.XtraEditors.LookUpEdit();
            this.spPrice = new DevExpress.XtraEditors.SpinEdit();
            this.lblNumberOfBeds = new DevExpress.XtraEditors.LabelControl();
            this.lblServicesTypeID = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitID = new DevExpress.XtraEditors.LabelControl();
            this.txtServicesId = new DevExpress.XtraEditors.TextEdit();
            this.txtServicesName = new DevExpress.XtraEditors.TextEdit();
            this.lblServicesId = new DevExpress.XtraEditors.LabelControl();
            this.lblServicesName = new DevExpress.XtraEditors.LabelControl();
            this.grdListServices = new DevExpress.XtraGrid.GridControl();
            this.grdvListServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ServicesSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServicesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtServicesId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ServicesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtServicesName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ServicesDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.UnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServicesType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labServices = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtServicesNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblServicesNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkServicesType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesNameLA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).BeginInit();
            this.panelAuthorView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAuthorExecute
            // 
            this.panelAuthorExecute.Controls.Add(this.btnUpdate);
            this.panelAuthorExecute.Controls.Add(this.btnSave);
            this.panelAuthorExecute.Controls.Add(this.btnDelete);
            this.panelAuthorExecute.Controls.Add(this.btnCancelOfUpdate);
            this.panelAuthorExecute.Controls.Add(this.btnAdd);
            this.panelAuthorExecute.Controls.Add(this.btnCancel);
            this.panelAuthorExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAuthorExecute.Location = new System.Drawing.Point(0, 373);
            this.panelAuthorExecute.Name = "panelAuthorExecute";
            this.panelAuthorExecute.Size = new System.Drawing.Size(983, 54);
            this.panelAuthorExecute.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(472, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "(F6)Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(681, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "(F2)Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(576, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "(F4)Xóa bỏ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelOfUpdate
            // 
            this.btnCancelOfUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOfUpdate.Location = new System.Drawing.Point(472, 9);
            this.btnCancelOfUpdate.Name = "btnCancelOfUpdate";
            this.btnCancelOfUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnCancelOfUpdate.TabIndex = 6;
            this.btnCancelOfUpdate.Text = "Hủy thao tác";
            this.btnCancelOfUpdate.Visible = false;
            this.btnCancelOfUpdate.Click += new System.EventHandler(this.btnCacelOfUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(369, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(F8)Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(369, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAuthorDetail
            // 
            this.panelAuthorDetail.Controls.Add(this.btnAddServicesType);
            this.panelAuthorDetail.Controls.Add(this.lkServicesType);
            this.panelAuthorDetail.Controls.Add(this.btnAddUnit);
            this.panelAuthorDetail.Controls.Add(this.lkUnit);
            this.panelAuthorDetail.Controls.Add(this.spPrice);
            this.panelAuthorDetail.Controls.Add(this.lblNumberOfBeds);
            this.panelAuthorDetail.Controls.Add(this.lblServicesTypeID);
            this.panelAuthorDetail.Controls.Add(this.lblUnitID);
            this.panelAuthorDetail.Controls.Add(this.txtServicesId);
            this.panelAuthorDetail.Controls.Add(this.txtServicesName);
            this.panelAuthorDetail.Controls.Add(this.lblServicesId);
            this.panelAuthorDetail.Controls.Add(this.lblServicesName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 115);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // btnAddServicesType
            // 
            this.btnAddServicesType.Location = new System.Drawing.Point(284, 45);
            this.btnAddServicesType.Name = "btnAddServicesType";
            this.btnAddServicesType.Size = new System.Drawing.Size(53, 23);
            this.btnAddServicesType.TabIndex = 23;
            this.btnAddServicesType.Text = "Thêm ";
            this.btnAddServicesType.Click += new System.EventHandler(this.btnAddServicesType_Click);
            // 
            // lkServicesType
            // 
            this.lkServicesType.Location = new System.Drawing.Point(114, 48);
            this.lkServicesType.Name = "lkServicesType";
            this.lkServicesType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkServicesType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServicesTypeName", "Loại dịch vụ")});
            this.lkServicesType.Properties.NullText = "";
            this.lkServicesType.Properties.ReadOnly = true;
            this.lkServicesType.Size = new System.Drawing.Size(164, 20);
            this.lkServicesType.TabIndex = 22;
            this.lkServicesType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lkServicesType_QueryPopUp);
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(284, 72);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(53, 23);
            this.btnAddUnit.TabIndex = 21;
            this.btnAddUnit.Text = "Thêm ";
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // lkUnit
            // 
            this.lkUnit.Location = new System.Drawing.Point(114, 74);
            this.lkUnit.Name = "lkUnit";
            this.lkUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitName", "Đơn vị")});
            this.lkUnit.Properties.NullText = "";
            this.lkUnit.Properties.ReadOnly = true;
            this.lkUnit.Size = new System.Drawing.Size(164, 20);
            this.lkUnit.TabIndex = 19;
            this.lkUnit.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lkUnit_QueryPopUp);
            // 
            // spPrice
            // 
            this.spPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPrice.Location = new System.Drawing.Point(453, 48);
            this.spPrice.Name = "spPrice";
            this.spPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPrice.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spPrice.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spPrice.Properties.ReadOnly = true;
            this.spPrice.Size = new System.Drawing.Size(102, 20);
            this.spPrice.TabIndex = 18;
            // 
            // lblNumberOfBeds
            // 
            this.lblNumberOfBeds.Location = new System.Drawing.Point(380, 51);
            this.lblNumberOfBeds.Name = "lblNumberOfBeds";
            this.lblNumberOfBeds.Size = new System.Drawing.Size(41, 13);
            this.lblNumberOfBeds.TabIndex = 17;
            this.lblNumberOfBeds.Text = "Đơn giá:";
            // 
            // lblServicesTypeID
            // 
            this.lblServicesTypeID.Location = new System.Drawing.Point(24, 50);
            this.lblServicesTypeID.Name = "lblServicesTypeID";
            this.lblServicesTypeID.Size = new System.Drawing.Size(60, 13);
            this.lblServicesTypeID.TabIndex = 16;
            this.lblServicesTypeID.Text = "Loại dịch vụ:";
            // 
            // lblUnitID
            // 
            this.lblUnitID.Location = new System.Drawing.Point(49, 77);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(35, 13);
            this.lblUnitID.TabIndex = 15;
            this.lblUnitID.Text = "Đơn vị:";
            // 
            // txtServicesId
            // 
            this.txtServicesId.Location = new System.Drawing.Point(114, 20);
            this.txtServicesId.Name = "txtServicesId";
            this.txtServicesId.Properties.ReadOnly = true;
            this.txtServicesId.Size = new System.Drawing.Size(223, 20);
            this.txtServicesId.TabIndex = 12;
            // 
            // txtServicesName
            // 
            this.txtServicesName.Location = new System.Drawing.Point(453, 20);
            this.txtServicesName.Name = "txtServicesName";
            this.txtServicesName.Properties.MaxLength = 100;
            this.txtServicesName.Properties.ReadOnly = true;
            this.txtServicesName.Size = new System.Drawing.Size(277, 20);
            this.txtServicesName.TabIndex = 0;
            this.txtServicesName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServicesName_KeyDown);
            this.txtServicesName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtservicesName_KeyPress);
            // 
            // lblServicesId
            // 
            this.lblServicesId.Location = new System.Drawing.Point(29, 23);
            this.lblServicesId.Name = "lblServicesId";
            this.lblServicesId.Size = new System.Drawing.Size(55, 13);
            this.lblServicesId.TabIndex = 0;
            this.lblServicesId.Text = "Mã dịch vụ:";
            // 
            // lblServicesName
            // 
            this.lblServicesName.Location = new System.Drawing.Point(367, 23);
            this.lblServicesName.Name = "lblServicesName";
            this.lblServicesName.Size = new System.Drawing.Size(59, 13);
            this.lblServicesName.TabIndex = 0;
            this.lblServicesName.Text = "Tên dịch vụ:";
            // 
            // grdListServices
            // 
            this.grdListServices.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListServices.Location = new System.Drawing.Point(2, 117);
            this.grdListServices.MainView = this.grdvListServices;
            this.grdListServices.Name = "grdListServices";
            this.grdListServices.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtServicesId,
            this.rtxtServicesName,
            this.rtxtDecriptions});
            this.grdListServices.Size = new System.Drawing.Size(747, 211);
            this.grdListServices.TabIndex = 0;
            this.grdListServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListServices});
            // 
            // grdvListServices
            // 
            this.grdvListServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ServicesSno,
            this.ServicesId,
            this.ServicesName,
            this.ServicesDrecription,
            this.UnitName,
            this.Price,
            this.ServicesType});
            this.grdvListServices.GridControl = this.grdListServices;
            this.grdvListServices.Name = "grdvListServices";
            this.grdvListServices.OptionsView.ShowGroupPanel = false;
            this.grdvListServices.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // ServicesSno
            // 
            this.ServicesSno.AppearanceCell.Options.UseTextOptions = true;
            this.ServicesSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ServicesSno.Caption = "STT";
            this.ServicesSno.FieldName = "STT";
            this.ServicesSno.Name = "ServicesSno";
            this.ServicesSno.Visible = true;
            this.ServicesSno.VisibleIndex = 0;
            this.ServicesSno.Width = 27;
            // 
            // ServicesId
            // 
            this.ServicesId.Caption = "Mã dịch vụ";
            this.ServicesId.ColumnEdit = this.rtxtServicesId;
            this.ServicesId.FieldName = "ServicesID";
            this.ServicesId.Name = "ServicesId";
            this.ServicesId.Visible = true;
            this.ServicesId.VisibleIndex = 1;
            this.ServicesId.Width = 78;
            // 
            // rtxtServicesId
            // 
            this.rtxtServicesId.AutoHeight = false;
            this.rtxtServicesId.Name = "rtxtServicesId";
            this.rtxtServicesId.ReadOnly = true;
            // 
            // ServicesName
            // 
            this.ServicesName.Caption = "Tên dịch vụ";
            this.ServicesName.ColumnEdit = this.rtxtServicesName;
            this.ServicesName.FieldName = "ServicesName";
            this.ServicesName.Name = "ServicesName";
            this.ServicesName.Visible = true;
            this.ServicesName.VisibleIndex = 2;
            this.ServicesName.Width = 197;
            // 
            // rtxtServicesName
            // 
            this.rtxtServicesName.AutoHeight = false;
            this.rtxtServicesName.Name = "rtxtServicesName";
            this.rtxtServicesName.ReadOnly = true;
            // 
            // ServicesDrecription
            // 
            this.ServicesDrecription.Caption = "Mô tả";
            this.ServicesDrecription.ColumnEdit = this.rtxtDecriptions;
            this.ServicesDrecription.FieldName = "MoTa";
            this.ServicesDrecription.Name = "ServicesDrecription";
            // 
            // rtxtDecriptions
            // 
            this.rtxtDecriptions.AutoHeight = false;
            this.rtxtDecriptions.Name = "rtxtDecriptions";
            this.rtxtDecriptions.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.Caption = "Đơn vị";
            this.UnitName.FieldName = "UnitName";
            this.UnitName.Name = "UnitName";
            this.UnitName.Visible = true;
            this.UnitName.VisibleIndex = 3;
            this.UnitName.Width = 97;
            // 
            // Price
            // 
            this.Price.Caption = "Đơn giá";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 4;
            this.Price.Width = 94;
            // 
            // ServicesType
            // 
            this.ServicesType.Caption = "Loại dịch vụ";
            this.ServicesType.FieldName = "ServicesTypeName";
            this.ServicesType.Name = "ServicesType";
            this.ServicesType.Visible = true;
            this.ServicesType.VisibleIndex = 5;
            this.ServicesType.Width = 113;
            // 
            // panelAuthorTitle
            // 
            this.panelAuthorTitle.Controls.Add(this.labServices);
            this.panelAuthorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorTitle.Name = "panelAuthorTitle";
            this.panelAuthorTitle.Size = new System.Drawing.Size(983, 43);
            this.panelAuthorTitle.TabIndex = 2;
            // 
            // labServices
            // 
            this.labServices.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labServices.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labServices.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labServices.Location = new System.Drawing.Point(305, 5);
            this.labServices.Name = "labServices";
            this.labServices.Size = new System.Drawing.Size(248, 32);
            this.labServices.TabIndex = 1;
            this.labServices.Text = "DANH SÁCH DỊCH VỤ";
            // 
            // navBarAuthorLookAt
            // 
            this.navBarAuthorLookAt.ActiveGroup = this.navBarGAuthorLookAt;
            this.navBarAuthorLookAt.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarAuthorLookAt.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarAuthorLookAt.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGAuthorLookAt});
            this.navBarAuthorLookAt.Location = new System.Drawing.Point(749, 2);
            this.navBarAuthorLookAt.Name = "navBarAuthorLookAt";
            this.navBarAuthorLookAt.OptionsNavPane.ExpandedWidth = 232;
            this.navBarAuthorLookAt.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarAuthorLookAt.Size = new System.Drawing.Size(232, 326);
            this.navBarAuthorLookAt.TabIndex = 0;
            this.navBarAuthorLookAt.Text = "navBarControl1";
            // 
            // navBarGAuthorLookAt
            // 
            this.navBarGAuthorLookAt.Caption = "Tìm nhanh";
            this.navBarGAuthorLookAt.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGAuthorLookAt.Expanded = true;
            this.navBarGAuthorLookAt.GroupClientHeight = 80;
            this.navBarGAuthorLookAt.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGAuthorLookAt.Name = "navBarGAuthorLookAt";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.txtServicesNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblServicesNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtServicesNameLA
            // 
            this.txtServicesNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtServicesNameLA.Name = "txtServicesNameLA";
            this.txtServicesNameLA.Properties.MaxLength = 100;
            this.txtServicesNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtServicesNameLA.TabIndex = 2;
            this.txtServicesNameLA.TextChanged += new System.EventHandler(this.txtservicesNameLA_TextChanged);
            // 
            // lblServicesNameLA
            // 
            this.lblServicesNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblServicesNameLA.Name = "lblServicesNameLA";
            this.lblServicesNameLA.Size = new System.Drawing.Size(59, 13);
            this.lblServicesNameLA.TabIndex = 1;
            this.lblServicesNameLA.Text = "Tên dịch vụ:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListServices);
            this.panelAuthorView.Controls.Add(this.panelAuthorDetail);
            this.panelAuthorView.Controls.Add(this.navBarAuthorLookAt);
            this.panelAuthorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuthorView.Location = new System.Drawing.Point(0, 43);
            this.panelAuthorView.Name = "panelAuthorView";
            this.panelAuthorView.Size = new System.Drawing.Size(983, 330);
            this.panelAuthorView.TabIndex = 4;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmServices";
            this.Text = "Quản lý dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServices_FormClosing);
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServices_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkServicesType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListServices;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListServices;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtServicesName;
        private DevExpress.XtraEditors.LabelControl lblServicesName;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesId;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtServicesId;
        private DevExpress.XtraEditors.LabelControl lblServicesId;
        private DevExpress.XtraEditors.LabelControl labServices;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtServicesNameLA;
        private DevExpress.XtraEditors.LabelControl lblServicesNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtServicesId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtServicesName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesDrecription;
        private DevExpress.XtraGrid.Columns.GridColumn UnitName;
        private DevExpress.XtraEditors.LabelControl lblNumberOfBeds;
        private DevExpress.XtraEditors.LabelControl lblServicesTypeID;
        private DevExpress.XtraEditors.LabelControl lblUnitID;
        private DevExpress.XtraEditors.SpinEdit spPrice;
        private DevExpress.XtraEditors.SimpleButton btnAddServicesType;
        private DevExpress.XtraEditors.LookUpEdit lkServicesType;
        private DevExpress.XtraEditors.SimpleButton btnAddUnit;
        private DevExpress.XtraEditors.LookUpEdit lkUnit;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesType;
    }
}