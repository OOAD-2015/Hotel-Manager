namespace HotelManager
{
    partial class frmStatus
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
            this.txtStatusId = new DevExpress.XtraEditors.TextEdit();
            this.txtStatusName = new DevExpress.XtraEditors.TextEdit();
            this.lblStatusId = new DevExpress.XtraEditors.LabelControl();
            this.lblStatusName = new DevExpress.XtraEditors.LabelControl();
            this.grdListStatus = new DevExpress.XtraGrid.GridControl();
            this.grdvListStatus = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.StatusSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtStatusId = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.StatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtStatusName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.StatusDrecription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rtxtDecriptions = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelAuthorTitle = new DevExpress.XtraEditors.PanelControl();
            this.labServiceType = new DevExpress.XtraEditors.LabelControl();
            this.navBarAuthorLookAt = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGAuthorLookAt = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.txtStatusNameLA = new DevExpress.XtraEditors.TextEdit();
            this.lblStatusNameLA = new DevExpress.XtraEditors.LabelControl();
            this.panelAuthorView = new DevExpress.XtraEditors.PanelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).BeginInit();
            this.panelAuthorExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).BeginInit();
            this.panelAuthorDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtStatusId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtStatusName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).BeginInit();
            this.panelAuthorTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).BeginInit();
            this.navBarAuthorLookAt.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusNameLA.Properties)).BeginInit();
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
            this.panelAuthorDetail.Controls.Add(this.txtStatusId);
            this.panelAuthorDetail.Controls.Add(this.txtStatusName);
            this.panelAuthorDetail.Controls.Add(this.lblStatusId);
            this.panelAuthorDetail.Controls.Add(this.lblStatusName);
            this.panelAuthorDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthorDetail.Location = new System.Drawing.Point(2, 2);
            this.panelAuthorDetail.Name = "panelAuthorDetail";
            this.panelAuthorDetail.Size = new System.Drawing.Size(747, 75);
            this.panelAuthorDetail.TabIndex = 1;
            // 
            // txtStatusId
            // 
            this.txtStatusId.Location = new System.Drawing.Point(114, 27);
            this.txtStatusId.Name = "txtStatusId";
            this.txtStatusId.Properties.ReadOnly = true;
            this.txtStatusId.Size = new System.Drawing.Size(200, 20);
            this.txtStatusId.TabIndex = 12;
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(428, 27);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Properties.MaxLength = 100;
            this.txtStatusName.Properties.ReadOnly = true;
            this.txtStatusName.Size = new System.Drawing.Size(302, 20);
            this.txtStatusName.TabIndex = 0;
            this.txtStatusName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStatusName_KeyDown);
            this.txtStatusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstatusName_KeyPress);
            // 
            // lblStatusId
            // 
            this.lblStatusId.Location = new System.Drawing.Point(24, 30);
            this.lblStatusId.Name = "lblStatusId";
            this.lblStatusId.Size = new System.Drawing.Size(68, 13);
            this.lblStatusId.TabIndex = 0;
            this.lblStatusId.Text = "Mã trạng thái:";
            // 
            // lblStatusName
            // 
            this.lblStatusName.Location = new System.Drawing.Point(332, 30);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(72, 13);
            this.lblStatusName.TabIndex = 0;
            this.lblStatusName.Text = "Tên trạng thái:";
            // 
            // grdListStatus
            // 
            this.grdListStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListStatus.Location = new System.Drawing.Point(2, 77);
            this.grdListStatus.MainView = this.grdvListStatus;
            this.grdListStatus.Name = "grdListStatus";
            this.grdListStatus.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rtxtStatusId,
            this.rtxtStatusName,
            this.rtxtDecriptions});
            this.grdListStatus.Size = new System.Drawing.Size(747, 251);
            this.grdListStatus.TabIndex = 0;
            this.grdListStatus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListStatus});
            // 
            // grdvListStatus
            // 
            this.grdvListStatus.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.StatusSno,
            this.StatusID,
            this.StatusName,
            this.StatusDrecription});
            this.grdvListStatus.GridControl = this.grdListStatus;
            this.grdvListStatus.Name = "grdvListStatus";
            this.grdvListStatus.OptionsView.ShowGroupPanel = false;
            this.grdvListStatus.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdvListAuthor_FocusedRowChanged);
            // 
            // StatusSno
            // 
            this.StatusSno.AppearanceCell.Options.UseTextOptions = true;
            this.StatusSno.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StatusSno.Caption = "STT";
            this.StatusSno.FieldName = "STT";
            this.StatusSno.Name = "StatusSno";
            this.StatusSno.Visible = true;
            this.StatusSno.VisibleIndex = 0;
            this.StatusSno.Width = 36;
            // 
            // StatusID
            // 
            this.StatusID.Caption = "Mã trạng thái";
            this.StatusID.ColumnEdit = this.rtxtStatusId;
            this.StatusID.FieldName = "StatusID";
            this.StatusID.Name = "StatusID";
            this.StatusID.Visible = true;
            this.StatusID.VisibleIndex = 1;
            this.StatusID.Width = 133;
            // 
            // rtxtStatusId
            // 
            this.rtxtStatusId.AutoHeight = false;
            this.rtxtStatusId.Name = "rtxtStatusId";
            this.rtxtStatusId.ReadOnly = true;
            // 
            // StatusName
            // 
            this.StatusName.Caption = "Tên trạng thái";
            this.StatusName.ColumnEdit = this.rtxtStatusName;
            this.StatusName.FieldName = "StatusName";
            this.StatusName.Name = "StatusName";
            this.StatusName.Visible = true;
            this.StatusName.VisibleIndex = 2;
            this.StatusName.Width = 267;
            // 
            // rtxtStatusName
            // 
            this.rtxtStatusName.AutoHeight = false;
            this.rtxtStatusName.Name = "rtxtStatusName";
            this.rtxtStatusName.ReadOnly = true;
            // 
            // StatusDrecription
            // 
            this.StatusDrecription.Caption = "Mô tả";
            this.StatusDrecription.ColumnEdit = this.rtxtDecriptions;
            this.StatusDrecription.FieldName = "MoTa";
            this.StatusDrecription.Name = "StatusDrecription";
            this.StatusDrecription.Width = 293;
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
            this.labServiceType.Size = new System.Drawing.Size(296, 32);
            this.labServiceType.TabIndex = 1;
            this.labServiceType.Text = "DANH SÁCH TRẠNG THÁI";
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
            this.navBarGroupControlContainer1.Controls.Add(this.txtStatusNameLA);
            this.navBarGroupControlContainer1.Controls.Add(this.lblStatusNameLA);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(232, 223);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // txtStatusNameLA
            // 
            this.txtStatusNameLA.Location = new System.Drawing.Point(41, 37);
            this.txtStatusNameLA.Name = "txtStatusNameLA";
            this.txtStatusNameLA.Properties.MaxLength = 100;
            this.txtStatusNameLA.Size = new System.Drawing.Size(161, 20);
            this.txtStatusNameLA.TabIndex = 2;
            this.txtStatusNameLA.TextChanged += new System.EventHandler(this.txtstatusNameLA_TextChanged);
            // 
            // lblStatusNameLA
            // 
            this.lblStatusNameLA.Location = new System.Drawing.Point(19, 18);
            this.lblStatusNameLA.Name = "lblStatusNameLA";
            this.lblStatusNameLA.Size = new System.Drawing.Size(72, 13);
            this.lblStatusNameLA.TabIndex = 1;
            this.lblStatusNameLA.Text = "Tên trạng thái:";
            // 
            // panelAuthorView
            // 
            this.panelAuthorView.Controls.Add(this.grdListStatus);
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
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 427);
            this.Controls.Add(this.panelAuthorView);
            this.Controls.Add(this.panelAuthorTitle);
            this.Controls.Add(this.panelAuthorExecute);
            this.KeyPreview = true;
            this.Name = "frmStatus";
            this.Text = "Quản lý trạng thái";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStatus_FormClosing);
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStatus_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorExecute)).EndInit();
            this.panelAuthorExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorDetail)).EndInit();
            this.panelAuthorDetail.ResumeLayout(false);
            this.panelAuthorDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtStatusId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtStatusName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtxtDecriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorTitle)).EndInit();
            this.panelAuthorTitle.ResumeLayout(false);
            this.panelAuthorTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarAuthorLookAt)).EndInit();
            this.navBarAuthorLookAt.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusNameLA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelAuthorView)).EndInit();
            this.panelAuthorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelAuthorExecute;
        private DevExpress.XtraEditors.PanelControl panelAuthorDetail;
        private DevExpress.XtraGrid.GridControl grdListStatus;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListStatus;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.TextEdit txtStatusName;
        private DevExpress.XtraEditors.LabelControl lblStatusName;
        private DevExpress.XtraGrid.Columns.GridColumn StatusID;
        private DevExpress.XtraGrid.Columns.GridColumn StatusName;
        private DevExpress.XtraEditors.PanelControl panelAuthorTitle;
        private DevExpress.XtraNavBar.NavBarControl navBarAuthorLookAt;
        private DevExpress.XtraNavBar.NavBarGroup navBarGAuthorLookAt;
        private DevExpress.XtraEditors.PanelControl panelAuthorView;
        private DevExpress.XtraEditors.TextEdit txtStatusId;
        private DevExpress.XtraEditors.LabelControl lblStatusId;
        private DevExpress.XtraEditors.LabelControl labServiceType;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraEditors.TextEdit txtStatusNameLA;
        private DevExpress.XtraEditors.LabelControl lblStatusNameLA;
        private DevExpress.XtraGrid.Columns.GridColumn StatusSno;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtStatusId;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtStatusName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit rtxtDecriptions;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn StatusDrecription;
    }
}