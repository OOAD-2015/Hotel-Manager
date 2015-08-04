namespace HotelManager
{
    partial class frmUnit
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
            this.txtUnitId = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitId = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitName = new DevExpress.XtraEditors.LabelControl();
            this.grdListUnit = new DevExpress.XtraGrid.GridControl();
            this.grdvListUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UnitSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnitID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtUnitId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.UnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtUnitName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.UnitDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labServiceType = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtUnitNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUnitId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUnitName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitNameLA.Properties)).BeginInit();
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
            this.panelAuthorDetail.Controls.Add(this.txtUnitId);
            this.panelAuthorDetail.Controls.Add(this.txtUnitName);
            this.panelAuthorDetail.Controls.Add(this.lblUnitId);
            this.panelAuthorDetail.Controls.Add(this.lblUnitName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 75);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // txtUnitId
            // 
            this.txtUnitId.Location = new System.Drawing.Point(114, 27);
            this.txtUnitId.Name = "txtUnitId";
            this.txtUnitId.Properties.ReadOnly = true;
            this.txtUnitId.Size = new System.Drawing.Size(200, 20);
            this.txtUnitId.TabIndex = 12;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(428, 27);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Properties.MaxLength = 100;
            this.txtUnitName.Properties.ReadOnly = true;
            this.txtUnitName.Size = new System.Drawing.Size(302, 20);
            this.txtUnitName.TabIndex = 0;
            this.txtUnitName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnitName_KeyDown);
            this.txtUnitName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtunitName_KeyPress);
            // 
            // lblUnitId
            // 
            this.lblUnitId.Location = new System.Drawing.Point(24, 30);
            this.lblUnitId.Name = "lblUnitId";
            this.lblUnitId.Size = new System.Drawing.Size(50, 13);
            this.lblUnitId.TabIndex = 0;
            this.lblUnitId.Text = "Mã đơn vị:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.Location = new System.Drawing.Point(332, 30);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(54, 13);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "Tên đơn vị:";
            // 
            // grdListUnit
            // 
            this.grdListUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListUnit.Location = new System.Drawing.Point(2, 77);
            this.grdListUnit.MainView = this.grdvListUnit;
            this.grdListUnit.Name = "grdListUnit";
            this.grdListUnit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtUnitId,
            this.rtxtUnitName,
            this.rtxtDecriptions});
            this.grdListUnit.Size = new System.Drawing.Size(747, 251);
            this.grdListUnit.TabIndex = 0;
            this.grdListUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListUnit});
            // 
            // grdvListUnit
            // 
            this.grdvListUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UnitSno,
            this.UnitID,
            this.UnitName,
            this.UnitDrecription});
            this.grdvListUnit.GridControl = this.grdListUnit;
            this.grdvListUnit.Name = "grdvListUnit";
            this.grdvListUnit.OptionsView.ShowGroupPanel = false;
            this.grdvListUnit.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // UnitSno
            // 
            this.UnitSno.AppearanceCell.Options.UseTextOptions = true;
            this.UnitSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.UnitSno.Caption = "STT";
            this.UnitSno.FieldName = "STT";
            this.UnitSno.Name = "UnitSno";
            this.UnitSno.Visible = true;
            this.UnitSno.VisibleIndex = 0;
            this.UnitSno.Width = 36;
            // 
            // UnitID
            // 
            this.UnitID.Caption = "Mã đơn vị";
            this.UnitID.ColumnEdit = this.rtxtUnitId;
            this.UnitID.FieldName = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.Visible = true;
            this.UnitID.VisibleIndex = 1;
            this.UnitID.Width = 133;
            // 
            // rtxtUnitId
            // 
            this.rtxtUnitId.AutoHeight = false;
            this.rtxtUnitId.Name = "rtxtUnitId";
            this.rtxtUnitId.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.Caption = "Tên đơn vị";
            this.UnitName.ColumnEdit = this.rtxtUnitName;
            this.UnitName.FieldName = "UnitName";
            this.UnitName.Name = "UnitName";
            this.UnitName.Visible = true;
            this.UnitName.VisibleIndex = 2;
            this.UnitName.Width = 267;
            // 
            // rtxtUnitName
            // 
            this.rtxtUnitName.AutoHeight = false;
            this.rtxtUnitName.Name = "rtxtUnitName";
            this.rtxtUnitName.ReadOnly = true;
            // 
            // UnitDrecription
            // 
            this.UnitDrecription.Caption = "Mô tả";
            this.UnitDrecription.ColumnEdit = this.rtxtDecriptions;
            this.UnitDrecription.FieldName = "MoTa";
            this.UnitDrecription.Name = "UnitDrecription";
            this.UnitDrecription.Width = 293;
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
            this.labServiceType.Size = new System.Drawing.Size(236, 32);
            this.labServiceType.TabIndex = 1;
            this.labServiceType.Text = "DANH SÁCH ĐƠN VỊ";
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
            this.navBarGroupControlContainer1.Controls.Add(this.txtUnitNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblUnitNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtUnitNameLA
            // 
            this.txtUnitNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtUnitNameLA.Name = "txtUnitNameLA";
            this.txtUnitNameLA.Properties.MaxLength = 100;
            this.txtUnitNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtUnitNameLA.TabIndex = 2;
            this.txtUnitNameLA.TextChanged += new System.EventHandler(this.txtunitNameLA_TextChanged);
            // 
            // lblUnitNameLA
            // 
            this.lblUnitNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblUnitNameLA.Name = "lblUnitNameLA";
            this.lblUnitNameLA.Size = new System.Drawing.Size(54, 13);
            this.lblUnitNameLA.TabIndex = 1;
            this.lblUnitNameLA.Text = "Tên đơn vị:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListUnit);
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
            // frmUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmUnit";
            this.Text = "Quản lý đơn vị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUnit_FormClosing);
            this.Load += new System.EventHandler(this.frmUnit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUnit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUnitId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtUnitName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListUnit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.LabelControl lblUnitName;
        private DevExpress.XtraGrid.Columns.GridColumn UnitID;
        private DevExpress.XtraGrid.Columns.GridColumn UnitName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtUnitId;
        private DevExpress.XtraEditors.LabelControl lblUnitId;
        private DevExpress.XtraEditors.LabelControl labServiceType;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtUnitNameLA;
        private DevExpress.XtraEditors.LabelControl lblUnitNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn UnitSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtUnitId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtUnitName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn UnitDrecription;
    }
}