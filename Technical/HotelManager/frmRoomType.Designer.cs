namespace HotelManager
{
    partial class frmRoomType
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
            this.spPrices = new DevExpress.XtraEditors.SpinEdit();
            this.labMoneyStyle2 = new DevExpress.XtraEditors.LabelControl();
            this.labImportPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtRoomTypeId = new DevExpress.XtraEditors.TextEdit();
            this.txtRoomTypeName = new DevExpress.XtraEditors.TextEdit();
            this.lblRoomTypeId = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomTypeName = new DevExpress.XtraEditors.LabelControl();
            this.grdListRoomType = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoomType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RoomTypeSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtRoomTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RoomTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtRoomTypeName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.RoomTypeDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labRoomType = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtRoomTypeNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblRoomTypeNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPrices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeNameLA.Properties)).BeginInit();
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
            this.panelAuthorDetail.Controls.Add(this.spPrices);
            this.panelAuthorDetail.Controls.Add(this.labMoneyStyle2);
            this.panelAuthorDetail.Controls.Add(this.labImportPrice);
            this.panelAuthorDetail.Controls.Add(this.txtRoomTypeId);
            this.panelAuthorDetail.Controls.Add(this.txtRoomTypeName);
            this.panelAuthorDetail.Controls.Add(this.lblRoomTypeId);
            this.panelAuthorDetail.Controls.Add(this.lblRoomTypeName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 84);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // spPrices
            // 
            this.spPrices.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spPrices.Location = new System.Drawing.Point(114, 46);
            this.spPrices.Name = "spPrices";
            this.spPrices.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spPrices.Properties.IsFloatValue = false;
            this.spPrices.Properties.Mask.EditMask = "c0";
            this.spPrices.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spPrices.Properties.MaxLength = 10;
            this.spPrices.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spPrices.Properties.ReadOnly = true;
            this.spPrices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spPrices.Size = new System.Drawing.Size(200, 20);
            this.spPrices.TabIndex = 15;
            // 
            // labMoneyStyle2
            // 
            this.labMoneyStyle2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labMoneyStyle2.Location = new System.Drawing.Point(318, 49);
            this.labMoneyStyle2.Name = "labMoneyStyle2";
            this.labMoneyStyle2.Size = new System.Drawing.Size(21, 13);
            this.labMoneyStyle2.TabIndex = 13;
            this.labMoneyStyle2.Text = "VNĐ";
            // 
            // labImportPrice
            // 
            this.labImportPrice.Location = new System.Drawing.Point(44, 53);
            this.labImportPrice.Name = "labImportPrice";
            this.labImportPrice.Size = new System.Drawing.Size(41, 13);
            this.labImportPrice.TabIndex = 14;
            this.labImportPrice.Text = "Đơn giá:";
            // 
            // txtRoomTypeId
            // 
            this.txtRoomTypeId.Location = new System.Drawing.Point(114, 20);
            this.txtRoomTypeId.Name = "txtRoomTypeId";
            this.txtRoomTypeId.Properties.ReadOnly = true;
            this.txtRoomTypeId.Size = new System.Drawing.Size(200, 20);
            this.txtRoomTypeId.TabIndex = 12;
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(453, 20);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Properties.MaxLength = 100;
            this.txtRoomTypeName.Properties.ReadOnly = true;
            this.txtRoomTypeName.Size = new System.Drawing.Size(277, 20);
            this.txtRoomTypeName.TabIndex = 0;
            this.txtRoomTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoomTypeName_KeyDown);
            this.txtRoomTypeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtroomTypeName_KeyPress);
            // 
            // lblRoomTypeId
            // 
            this.lblRoomTypeId.Location = new System.Drawing.Point(24, 23);
            this.lblRoomTypeId.Name = "lblRoomTypeId";
            this.lblRoomTypeId.Size = new System.Drawing.Size(70, 13);
            this.lblRoomTypeId.TabIndex = 0;
            this.lblRoomTypeId.Text = "Mã loại phòng:";
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.Location = new System.Drawing.Point(367, 23);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.Size = new System.Drawing.Size(74, 13);
            this.lblRoomTypeName.TabIndex = 0;
            this.lblRoomTypeName.Text = "Tên loại phòng:";
            // 
            // grdListRoomType
            // 
            this.grdListRoomType.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoomType.Location = new System.Drawing.Point(2, 86);
            this.grdListRoomType.MainView = this.grdvListRoomType;
            this.grdListRoomType.Name = "grdListRoomType";
            this.grdListRoomType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtRoomTypeId,
            this.rtxtRoomTypeName,
            this.rtxtDecriptions});
            this.grdListRoomType.Size = new System.Drawing.Size(747, 242);
            this.grdListRoomType.TabIndex = 0;
            this.grdListRoomType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoomType});
            // 
            // grdvListRoomType
            // 
            this.grdvListRoomType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RoomTypeSno,
            this.RoomTypeId,
            this.RoomTypeName,
            this.RoomTypeDrecription,
            this.Price});
            this.grdvListRoomType.GridControl = this.grdListRoomType;
            this.grdvListRoomType.Name = "grdvListRoomType";
            this.grdvListRoomType.OptionsView.ShowGroupPanel = false;
            this.grdvListRoomType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // RoomTypeSno
            // 
            this.RoomTypeSno.AppearanceCell.Options.UseTextOptions = true;
            this.RoomTypeSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RoomTypeSno.Caption = "STT";
            this.RoomTypeSno.FieldName = "STT";
            this.RoomTypeSno.Name = "RoomTypeSno";
            this.RoomTypeSno.Visible = true;
            this.RoomTypeSno.VisibleIndex = 0;
            this.RoomTypeSno.Width = 36;
            // 
            // RoomTypeId
            // 
            this.RoomTypeId.Caption = "Mã loại phòng";
            this.RoomTypeId.ColumnEdit = this.rtxtRoomTypeId;
            this.RoomTypeId.FieldName = "RoomTypeID";
            this.RoomTypeId.Name = "RoomTypeId";
            this.RoomTypeId.Visible = true;
            this.RoomTypeId.VisibleIndex = 1;
            this.RoomTypeId.Width = 133;
            // 
            // rtxtRoomTypeId
            // 
            this.rtxtRoomTypeId.AutoHeight = false;
            this.rtxtRoomTypeId.Name = "rtxtRoomTypeId";
            this.rtxtRoomTypeId.ReadOnly = true;
            // 
            // RoomTypeName
            // 
            this.RoomTypeName.Caption = "Tên loại phòng";
            this.RoomTypeName.ColumnEdit = this.rtxtRoomTypeName;
            this.RoomTypeName.FieldName = "RoomTypeName";
            this.RoomTypeName.Name = "RoomTypeName";
            this.RoomTypeName.Visible = true;
            this.RoomTypeName.VisibleIndex = 2;
            this.RoomTypeName.Width = 381;
            // 
            // rtxtRoomTypeName
            // 
            this.rtxtRoomTypeName.AutoHeight = false;
            this.rtxtRoomTypeName.Name = "rtxtRoomTypeName";
            this.rtxtRoomTypeName.ReadOnly = true;
            // 
            // RoomTypeDrecription
            // 
            this.RoomTypeDrecription.Caption = "Mô tả";
            this.RoomTypeDrecription.ColumnEdit = this.rtxtDecriptions;
            this.RoomTypeDrecription.FieldName = "MoTa";
            this.RoomTypeDrecription.Name = "RoomTypeDrecription";
            // 
            // rtxtDecriptions
            // 
            this.rtxtDecriptions.AutoHeight = false;
            this.rtxtDecriptions.Name = "rtxtDecriptions";
            this.rtxtDecriptions.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Caption = "Giá phòng";
            this.Price.FieldName = "Price";
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 3;
            this.Price.Width = 179;
            // 
            // panelAuthorTitle
            // 
            this.panelAuthorTitle.Controls.Add(this.labRoomType);
            this.panelAuthorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorTitle.Name = "panelAuthorTitle";
            this.panelAuthorTitle.Size = new System.Drawing.Size(983, 43);
            this.panelAuthorTitle.TabIndex = 2;
            // 
            // labRoomType
            // 
            this.labRoomType.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labRoomType.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labRoomType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labRoomType.Location = new System.Drawing.Point(305, 5);
            this.labRoomType.Name = "labRoomType";
            this.labRoomType.Size = new System.Drawing.Size(297, 32);
            this.labRoomType.TabIndex = 1;
            this.labRoomType.Text = "DANH SÁCH LOẠI PHÒNG";
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
            this.navBarGroupControlContainer1.Controls.Add(this.txtRoomTypeNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblRoomTypeNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtRoomTypeNameLA
            // 
            this.txtRoomTypeNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtRoomTypeNameLA.Name = "txtRoomTypeNameLA";
            this.txtRoomTypeNameLA.Properties.MaxLength = 100;
            this.txtRoomTypeNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtRoomTypeNameLA.TabIndex = 2;
            this.txtRoomTypeNameLA.TextChanged += new System.EventHandler(this.txtroomTypeNameLA_TextChanged);
            // 
            // lblRoomTypeNameLA
            // 
            this.lblRoomTypeNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblRoomTypeNameLA.Name = "lblRoomTypeNameLA";
            this.lblRoomTypeNameLA.Size = new System.Drawing.Size(74, 13);
            this.lblRoomTypeNameLA.TabIndex = 1;
            this.lblRoomTypeNameLA.Text = "Tên loại phòng:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListRoomType);
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
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmRoomType";
            this.Text = "Quản lý loại phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoomType_FormClosing);
            this.Load += new System.EventHandler(this.frmRoomType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoomType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spPrices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtRoomTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListRoomType;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoomType;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeName;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn RoomTypeId;
        private DevExpress.XtraGrid.Columns.GridColumn RoomTypeName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeId;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeId;
        private DevExpress.XtraEditors.LabelControl labRoomType;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeNameLA;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn RoomTypeSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtRoomTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtRoomTypeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn RoomTypeDrecription;
        private DevExpress.XtraEditors.SpinEdit spPrices;
        private DevExpress.XtraEditors.LabelControl labMoneyStyle2;
        private DevExpress.XtraEditors.LabelControl labImportPrice;
        private DevExpress.XtraGrid.Columns.GridColumn Price;

    }
}