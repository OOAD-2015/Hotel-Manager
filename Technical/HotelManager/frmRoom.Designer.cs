namespace HotelManager
{
    partial class frmRoom
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
            this.panelAuthorExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelAuthorDetail = new DevExpress.XtraEditors.PanelControl();
            this.btnAddRoomType = new DevExpress.XtraEditors.SimpleButton();
            this.lkRoomType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAddStatus = new DevExpress.XtraEditors.SimpleButton();
            this.lkStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.spNumberOfBeds = new DevExpress.XtraEditors.SpinEdit();
            this.lblNumberOfBeds = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomTypeID = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusID = new DevExpress.XtraEditors.LabelControl();
            this.rtxtDecription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtRoomId = new DevExpress.XtraEditors.TextEdit();
            this.txtRoomName = new DevExpress.XtraEditors.TextEdit();
            this.lblRoomId = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomName = new DevExpress.XtraEditors.LabelControl();
            this.grdListRoom = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtRoomId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RoomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtRoomName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RoomDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumberOfBeds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labRoom = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtRoomNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblRoomNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRoomType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNumberOfBeds.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNameLA.Properties)).BeginInit();
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
            this.btnAdd.Location = new System.Drawing.Point(369, 10);
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
            this.panelAuthorDetail.Controls.Add(this.btnAddRoomType);
            this.panelAuthorDetail.Controls.Add(this.lkRoomType);
            this.panelAuthorDetail.Controls.Add(this.btnAddStatus);
            this.panelAuthorDetail.Controls.Add(this.lkStatus);
            this.panelAuthorDetail.Controls.Add(this.spNumberOfBeds);
            this.panelAuthorDetail.Controls.Add(this.lblNumberOfBeds);
            this.panelAuthorDetail.Controls.Add(this.lblRoomTypeID);
            this.panelAuthorDetail.Controls.Add(this.lblStatusID);
            this.panelAuthorDetail.Controls.Add(this.rtxtDecription);
            this.panelAuthorDetail.Controls.Add(this.lblDescription);
            this.panelAuthorDetail.Controls.Add(this.txtRoomId);
            this.panelAuthorDetail.Controls.Add(this.txtRoomName);
            this.panelAuthorDetail.Controls.Add(this.lblRoomId);
            this.panelAuthorDetail.Controls.Add(this.lblRoomName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 151);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // btnAddRoomType
            // 
            this.btnAddRoomType.Location = new System.Drawing.Point(606, 74);
            this.btnAddRoomType.Name = "btnAddRoomType";
            this.btnAddRoomType.Size = new System.Drawing.Size(53, 23);
            this.btnAddRoomType.TabIndex = 23;
            this.btnAddRoomType.Text = "Thêm ";
            this.btnAddRoomType.Click += new System.EventHandler(this.btnAddRoomType_Click);
            // 
            // lkRoomType
            // 
            this.lkRoomType.Location = new System.Drawing.Point(453, 76);
            this.lkRoomType.Name = "lkRoomType";
            this.lkRoomType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkRoomType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("STT", "STT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("RoomTypeName", "Loại phòng")});
            this.lkRoomType.Properties.NullText = "";
            this.lkRoomType.Properties.ReadOnly = true;
            this.lkRoomType.Size = new System.Drawing.Size(147, 20);
            this.lkRoomType.TabIndex = 22;
            this.lkRoomType.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lkRoomType_QueryPopUp);
            // 
            // btnAddStatus
            // 
            this.btnAddStatus.Location = new System.Drawing.Point(284, 46);
            this.btnAddStatus.Name = "btnAddStatus";
            this.btnAddStatus.Size = new System.Drawing.Size(53, 23);
            this.btnAddStatus.TabIndex = 21;
            this.btnAddStatus.Text = "Thêm ";
            this.btnAddStatus.Click += new System.EventHandler(this.btnAddStatus_Click);
            // 
            // lkStatus
            // 
            this.lkStatus.Location = new System.Drawing.Point(114, 48);
            this.lkStatus.Name = "lkStatus";
            this.lkStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkStatus.Properties.NullText = "";
            this.lkStatus.Properties.ReadOnly = true;
            this.lkStatus.Size = new System.Drawing.Size(164, 20);
            this.lkStatus.TabIndex = 19;
            this.lkStatus.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lkStatus_QueryPopUp);
            // 
            // spNumberOfBeds
            // 
            this.spNumberOfBeds.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spNumberOfBeds.Location = new System.Drawing.Point(453, 48);
            this.spNumberOfBeds.Name = "spNumberOfBeds";
            this.spNumberOfBeds.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spNumberOfBeds.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spNumberOfBeds.Properties.ReadOnly = true;
            this.spNumberOfBeds.Size = new System.Drawing.Size(102, 20);
            this.spNumberOfBeds.TabIndex = 18;
            // 
            // lblNumberOfBeds
            // 
            this.lblNumberOfBeds.Location = new System.Drawing.Point(376, 51);
            this.lblNumberOfBeds.Name = "lblNumberOfBeds";
            this.lblNumberOfBeds.Size = new System.Drawing.Size(46, 13);
            this.lblNumberOfBeds.TabIndex = 17;
            this.lblNumberOfBeds.Text = "Số người:";
            // 
            // lblRoomTypeID
            // 
            this.lblRoomTypeID.Location = new System.Drawing.Point(366, 79);
            this.lblRoomTypeID.Name = "lblRoomTypeID";
            this.lblRoomTypeID.Size = new System.Drawing.Size(56, 13);
            this.lblRoomTypeID.TabIndex = 16;
            this.lblRoomTypeID.Text = "Loại phòng:";
            // 
            // lblStatusID
            // 
            this.lblStatusID.Location = new System.Drawing.Point(22, 51);
            this.lblStatusID.Name = "lblStatusID";
            this.lblStatusID.Size = new System.Drawing.Size(53, 13);
            this.lblStatusID.TabIndex = 15;
            this.lblStatusID.Text = "Trạng thái:";
            // 
            // rtxtDecription
            // 
            this.rtxtDecription.Location = new System.Drawing.Point(114, 76);
            this.rtxtDecription.Name = "rtxtDecription";
            this.rtxtDecription.ReadOnly = true;
            this.rtxtDecription.Size = new System.Drawing.Size(223, 47);
            this.rtxtDecription.TabIndex = 14;
            this.rtxtDecription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(44, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(31, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Mô tả:";
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(114, 20);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Properties.ReadOnly = true;
            this.txtRoomId.Size = new System.Drawing.Size(223, 20);
            this.txtRoomId.TabIndex = 12;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(453, 20);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Properties.MaxLength = 100;
            this.txtRoomName.Properties.ReadOnly = true;
            this.txtRoomName.Size = new System.Drawing.Size(277, 20);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoomName_KeyDown);
            this.txtRoomName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtroomName_KeyPress);
            // 
            // lblRoomId
            // 
            this.lblRoomId.Location = new System.Drawing.Point(24, 23);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(51, 13);
            this.lblRoomId.TabIndex = 0;
            this.lblRoomId.Text = "Mã phòng:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.Location = new System.Drawing.Point(367, 23);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(55, 13);
            this.lblRoomName.TabIndex = 0;
            this.lblRoomName.Text = "Tên phòng:";
            // 
            // grdListRoom
            // 
            this.grdListRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoom.Location = new System.Drawing.Point(2, 153);
            this.grdListRoom.MainView = this.grdvListRoom;
            this.grdListRoom.Name = "grdListRoom";
            this.grdListRoom.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtRoomId,
            this.rtxtRoomName,
            this.rtxtDecriptions});
            this.grdListRoom.Size = new System.Drawing.Size(747, 175);
            this.grdListRoom.TabIndex = 0;
            this.grdListRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoom});
            // 
            // grdvListRoom
            // 
            this.grdvListRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomSno,
            this.RoomId,
            this.RoomName,
            this.RoomDrecription,
            this.Status,
            this.NumberOfBeds,
            this.RoomType});
            this.grdvListRoom.GridControl = this.grdListRoom;
            this.grdvListRoom.Name = "grdvListRoom";
            this.grdvListRoom.OptionsView.ShowGroupPanel = false;
            this.grdvListRoom.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // RoomSno
            // 
            this.RoomSno.AppearanceCell.Options.UseTextOptions = true;
            this.RoomSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoomSno.Caption = "STT";
            this.RoomSno.FieldName = "STT";
            this.RoomSno.Name = "RoomSno";
            this.RoomSno.Visible = true;
            this.RoomSno.VisibleIndex = 0;
            this.RoomSno.Width = 26;
            // 
            // RoomId
            // 
            this.RoomId.Caption = "Mã phòng";
            this.RoomId.ColumnEdit = this.rtxtRoomId;
            this.RoomId.FieldName = "RoomID";
            this.RoomId.Name = "RoomId";
            this.RoomId.Visible = true;
            this.RoomId.VisibleIndex = 1;
            // 
            // rtxtRoomId
            // 
            this.rtxtRoomId.AutoHeight = false;
            this.rtxtRoomId.Name = "rtxtRoomId";
            this.rtxtRoomId.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.Caption = "Tên phòng";
            this.RoomName.ColumnEdit = this.rtxtRoomName;
            this.RoomName.FieldName = "RoomName";
            this.RoomName.Name = "RoomName";
            this.RoomName.Visible = true;
            this.RoomName.VisibleIndex = 2;
            this.RoomName.Width = 152;
            // 
            // rtxtRoomName
            // 
            this.rtxtRoomName.AutoHeight = false;
            this.rtxtRoomName.Name = "rtxtRoomName";
            this.rtxtRoomName.ReadOnly = true;
            // 
            // RoomDrecription
            // 
            this.RoomDrecription.Caption = "Mô tả";
            this.RoomDrecription.ColumnEdit = this.rtxtDecriptions;
            this.RoomDrecription.FieldName = "MoTa";
            this.RoomDrecription.Name = "RoomDrecription";
            // 
            // rtxtDecriptions
            // 
            this.rtxtDecriptions.AutoHeight = false;
            this.rtxtDecriptions.Name = "rtxtDecriptions";
            this.rtxtDecriptions.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "StatusName";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 3;
            this.Status.Width = 91;
            // 
            // NumberOfBeds
            // 
            this.NumberOfBeds.Caption = "Số người";
            this.NumberOfBeds.FieldName = "NumberOfBeds";
            this.NumberOfBeds.Name = "NumberOfBeds";
            this.NumberOfBeds.Visible = true;
            this.NumberOfBeds.VisibleIndex = 4;
            this.NumberOfBeds.Width = 84;
            // 
            // RoomType
            // 
            this.RoomType.Caption = "Loại phòng";
            this.RoomType.FieldName = "RoomTypeName";
            this.RoomType.Name = "RoomType";
            this.RoomType.Visible = true;
            this.RoomType.VisibleIndex = 5;
            this.RoomType.Width = 99;
            // 
            // panelAuthorTitle
            // 
            this.panelAuthorTitle.Controls.Add(this.labRoom);
            this.panelAuthorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorTitle.Name = "panelAuthorTitle";
            this.panelAuthorTitle.Size = new System.Drawing.Size(983, 43);
            this.panelAuthorTitle.TabIndex = 2;
            // 
            // labRoom
            // 
            this.labRoom.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labRoom.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labRoom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labRoom.Location = new System.Drawing.Point(305, 5);
            this.labRoom.Name = "labRoom";
            this.labRoom.Size = new System.Drawing.Size(236, 32);
            this.labRoom.TabIndex = 1;
            this.labRoom.Text = "DANH SÁCH PHÒNG";
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
            this.navBarGroupControlContainer1.Controls.Add(this.txtRoomNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblRoomNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtRoomNameLA
            // 
            this.txtRoomNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtRoomNameLA.Name = "txtRoomNameLA";
            this.txtRoomNameLA.Properties.MaxLength = 100;
            this.txtRoomNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtRoomNameLA.TabIndex = 2;
            this.txtRoomNameLA.TextChanged += new System.EventHandler(this.txtRoomNameLA_TextChanged);
            this.txtRoomNameLA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRoomNameLA_KeyPress);
            // 
            // lblRoomNameLA
            // 
            this.lblRoomNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblRoomNameLA.Name = "lblRoomNameLA";
            this.lblRoomNameLA.Size = new System.Drawing.Size(55, 13);
            this.lblRoomNameLA.TabIndex = 1;
            this.lblRoomNameLA.Text = "Tên phòng:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListRoom);
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
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmRoom";
            this.Text = "Quản lý phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoom_FormClosing);
            this.Load += new System.EventHandler(this.frmRoom_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoom_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRoomType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spNumberOfBeds.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoom;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtRoomName;
        private DevExpress.XtraEditors.LabelControl lblRoomName;
        private DevExpress.XtraGrid.Columns.GridColumn RoomId;
        private DevExpress.XtraGrid.Columns.GridColumn RoomName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtRoomId;
        private DevExpress.XtraEditors.LabelControl lblRoomId;
        private DevExpress.XtraEditors.LabelControl labRoom;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtRoomNameLA;
        private DevExpress.XtraEditors.LabelControl lblRoomNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn RoomSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtRoomId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtRoomName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn RoomDrecription;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraEditors.LabelControl lblNumberOfBeds;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeID;
        private DevExpress.XtraEditors.LabelControl lblStatusID;
        private System.Windows.Forms.RichTextBox rtxtDecription;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.SpinEdit spNumberOfBeds;
        private DevExpress.XtraEditors.SimpleButton btnAddRoomType;
        private DevExpress.XtraEditors.LookUpEdit lkRoomType;
        private DevExpress.XtraEditors.SimpleButton btnAddStatus;
        private DevExpress.XtraEditors.LookUpEdit lkStatus;
        private DevExpress.XtraGrid.Columns.GridColumn NumberOfBeds;
        private DevExpress.XtraGrid.Columns.GridColumn RoomType;
    }
}