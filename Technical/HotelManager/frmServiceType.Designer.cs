namespace HotelManager
{
    partial class frmServiceType
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panelAuthorDetail = new DevExpress.XtraEditors.PanelControl();
            this.txtServicesTypeId = new DevExpress.XtraEditors.TextEdit();
            this.txtServicesTypeName = new DevExpress.XtraEditors.TextEdit();
            this.lblServicesTypeId = new DevExpress.XtraEditors.LabelControl();
            this.lblServicesTypeName = new DevExpress.XtraEditors.LabelControl();
            this.grdListServicesType = new DevExpress.XtraGrid.GridControl();
            this.grdvListServicesType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ServicesTypeSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ServicesTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtServicesTypeId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ServicesTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtServicesTypeName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.ServicesTypeDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labServiceType = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtServicesTypeNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblServicesTypeNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServicesType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServicesType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesTypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeNameLA.Properties)).BeginInit();
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
            this.panelAuthorExecute.Controls.Add(this.btnAdd);
            this.panelAuthorExecute.Controls.Add(this.btnCancelOfUpdate);
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
            this.btnSave.Size = new System.Drawing.Size(81, 33);
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(369, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(F8)Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(369, 9);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelAuthorDetail
            // 
            this.panelAuthorDetail.Controls.Add(this.txtServicesTypeId);
            this.panelAuthorDetail.Controls.Add(this.txtServicesTypeName);
            this.panelAuthorDetail.Controls.Add(this.lblServicesTypeId);
            this.panelAuthorDetail.Controls.Add(this.lblServicesTypeName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 75);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // txtServicesTypeId
            // 
            this.txtServicesTypeId.Location = new System.Drawing.Point(114, 27);
            this.txtServicesTypeId.Name = "txtServicesTypeId";
            this.txtServicesTypeId.Properties.ReadOnly = true;
            this.txtServicesTypeId.Size = new System.Drawing.Size(200, 20);
            this.txtServicesTypeId.TabIndex = 12;
            // 
            // txtServicesTypeName
            // 
            this.txtServicesTypeName.Location = new System.Drawing.Point(428, 27);
            this.txtServicesTypeName.Name = "txtServicesTypeName";
            this.txtServicesTypeName.Properties.MaxLength = 100;
            this.txtServicesTypeName.Properties.ReadOnly = true;
            this.txtServicesTypeName.Size = new System.Drawing.Size(302, 20);
            this.txtServicesTypeName.TabIndex = 0;
            this.txtServicesTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServicesTypeName_KeyDown);
            this.txtServicesTypeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtservicesTypeName_KeyPress);
            // 
            // lblServicesTypeId
            // 
            this.lblServicesTypeId.Location = new System.Drawing.Point(24, 30);
            this.lblServicesTypeId.Name = "lblServicesTypeId";
            this.lblServicesTypeId.Size = new System.Drawing.Size(74, 13);
            this.lblServicesTypeId.TabIndex = 0;
            this.lblServicesTypeId.Text = "Mã loại dịch vụ:";
            // 
            // lblServicesTypeName
            // 
            this.lblServicesTypeName.Location = new System.Drawing.Point(332, 30);
            this.lblServicesTypeName.Name = "lblServicesTypeName";
            this.lblServicesTypeName.Size = new System.Drawing.Size(78, 13);
            this.lblServicesTypeName.TabIndex = 0;
            this.lblServicesTypeName.Text = "Tên loại dịch vụ:";
            // 
            // grdListServicesType
            // 
            this.grdListServicesType.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListServicesType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListServicesType.Location = new System.Drawing.Point(2, 77);
            this.grdListServicesType.MainView = this.grdvListServicesType;
            this.grdListServicesType.Name = "grdListServicesType";
            this.grdListServicesType.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtServicesTypeId,
            this.rtxtServicesTypeName,
            this.rtxtDecriptions});
            this.grdListServicesType.Size = new System.Drawing.Size(747, 251);
            this.grdListServicesType.TabIndex = 0;
            this.grdListServicesType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListServicesType});
            // 
            // grdvListServicesType
            // 
            this.grdvListServicesType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ServicesTypeSno,
            this.ServicesTypeID,
            this.ServicesTypeName,
            this.ServicesTypeDrecription});
            this.grdvListServicesType.GridControl = this.grdListServicesType;
            this.grdvListServicesType.Name = "grdvListServicesType";
            this.grdvListServicesType.OptionsView.ShowGroupPanel = false;
            this.grdvListServicesType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // ServicesTypeSno
            // 
            this.ServicesTypeSno.AppearanceCell.Options.UseTextOptions = true;
            this.ServicesTypeSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ServicesTypeSno.Caption = "STT";
            this.ServicesTypeSno.FieldName = "STT";
            this.ServicesTypeSno.Name = "ServicesTypeSno";
            this.ServicesTypeSno.Visible = true;
            this.ServicesTypeSno.VisibleIndex = 0;
            this.ServicesTypeSno.Width = 36;
            // 
            // ServicesTypeID
            // 
            this.ServicesTypeID.Caption = "Mã loại dịch vụ";
            this.ServicesTypeID.ColumnEdit = this.rtxtServicesTypeId;
            this.ServicesTypeID.FieldName = "ServicesTypeID";
            this.ServicesTypeID.Name = "ServicesTypeID";
            this.ServicesTypeID.Visible = true;
            this.ServicesTypeID.VisibleIndex = 1;
            this.ServicesTypeID.Width = 133;
            // 
            // rtxtServicesTypeId
            // 
            this.rtxtServicesTypeId.AutoHeight = false;
            this.rtxtServicesTypeId.Name = "rtxtServicesTypeId";
            this.rtxtServicesTypeId.ReadOnly = true;
            // 
            // ServicesTypeName
            // 
            this.ServicesTypeName.Caption = "Tên loại dịch vụ";
            this.ServicesTypeName.ColumnEdit = this.rtxtServicesTypeName;
            this.ServicesTypeName.FieldName = "ServicesTypeName";
            this.ServicesTypeName.Name = "ServicesTypeName";
            this.ServicesTypeName.Visible = true;
            this.ServicesTypeName.VisibleIndex = 2;
            this.ServicesTypeName.Width = 267;
            // 
            // rtxtServicesTypeName
            // 
            this.rtxtServicesTypeName.AutoHeight = false;
            this.rtxtServicesTypeName.Name = "rtxtServicesTypeName";
            this.rtxtServicesTypeName.ReadOnly = true;
            // 
            // ServicesTypeDrecription
            // 
            this.ServicesTypeDrecription.Caption = "Mô tả";
            this.ServicesTypeDrecription.ColumnEdit = this.rtxtDecriptions;
            this.ServicesTypeDrecription.FieldName = "MoTa";
            this.ServicesTypeDrecription.Name = "ServicesTypeDrecription";
            this.ServicesTypeDrecription.Width = 293;
            // 
            // rtxtDecriptions
            // 
            this.rtxtDecriptions.AutoHeight = false;
            this.rtxtDecriptions.Name = "rtxtDecriptions";
            this.rtxtDecriptions.ReadOnly = true;
            // 
            // panelAuthorTitle
            // 
            this.panelAuthorTitle.Controls.Add(this.labServiceType);
            this.panelAuthorTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorTitle.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorTitle.Name = "panelAuthorTitle";
            this.panelAuthorTitle.Size = new System.Drawing.Size(983, 43);
            this.panelAuthorTitle.TabIndex = 2;
            // 
            // labServiceType
            // 
            this.labServiceType.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labServiceType.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labServiceType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labServiceType.Location = new System.Drawing.Point(305, 5);
            this.labServiceType.Name = "labServiceType";
            this.labServiceType.Size = new System.Drawing.Size(309, 32);
            this.labServiceType.TabIndex = 1;
            this.labServiceType.Text = "DANH SÁCH LOẠI DỊCH VỤ";
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
            this.navBarGroupControlContainer1.Controls.Add(this.txtServicesTypeNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblServicesTypeNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtServicesTypeNameLA
            // 
            this.txtServicesTypeNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtServicesTypeNameLA.Name = "txtServicesTypeNameLA";
            this.txtServicesTypeNameLA.Properties.MaxLength = 100;
            this.txtServicesTypeNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtServicesTypeNameLA.TabIndex = 2;
            this.txtServicesTypeNameLA.TextChanged += new System.EventHandler(this.txtservicesTypeNameLA_TextChanged);
            // 
            // lblServicesTypeNameLA
            // 
            this.lblServicesTypeNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblServicesTypeNameLA.Name = "lblServicesTypeNameLA";
            this.lblServicesTypeNameLA.Size = new System.Drawing.Size(78, 13);
            this.lblServicesTypeNameLA.TabIndex = 1;
            this.lblServicesTypeNameLA.Text = "Tên loại dịch vụ:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListServicesType);
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
            // frmServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmServiceType";
            this.Text = "Quản lý loại dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServicesType_FormClosing);
            this.Load += new System.EventHandler(this.frmServicesType_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmServicesType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServicesType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServicesType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesTypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtServicesTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesTypeNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListServicesType;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListServicesType;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtServicesTypeName;
        private DevExpress.XtraEditors.LabelControl lblServicesTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesTypeName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtServicesTypeId;
        private DevExpress.XtraEditors.LabelControl lblServicesTypeId;
        private DevExpress.XtraEditors.LabelControl labServiceType;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtServicesTypeNameLA;
        private DevExpress.XtraEditors.LabelControl lblServicesTypeNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesTypeSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtServicesTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtServicesTypeName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn ServicesTypeDrecription;
    }
}