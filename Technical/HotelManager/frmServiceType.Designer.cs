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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceType));
            this.tabCutomerInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabpServicesInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grpListServices = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtServicesID = new DevExpress.XtraEditors.TextEdit();
            this.txtServicesName = new DevExpress.XtraEditors.TextEdit();
            this.labServicesID = new DevExpress.XtraEditors.LabelControl();
            this.labServicesName = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            this.grdListServices = new DevExpress.XtraGrid.GridControl();
            this.grdvListServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).BeginInit();
            this.tabCutomerInfo.SuspendLayout();
            this.tabpServicesInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListServices)).BeginInit();
            this.grpListServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCutomerInfo
            // 
            this.tabCutomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCutomerInfo.Location = new System.Drawing.Point(0, 47);
            this.tabCutomerInfo.Name = "tabCutomerInfo";
            this.tabCutomerInfo.SelectedTabPage = this.tabpServicesInfo;
            this.tabCutomerInfo.Size = new System.Drawing.Size(707, 417);
            this.tabCutomerInfo.TabIndex = 9;
            this.tabCutomerInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpServicesInfo});
            this.tabCutomerInfo.Click += new System.EventHandler(this.tabCutomerInfo_Click);
            // 
            // tabpServicesInfo
            // 
            this.tabpServicesInfo.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabpServicesInfo.Appearance.Header.Options.UseFont = true;
            this.tabpServicesInfo.Controls.Add(this.grpListServices);
            this.tabpServicesInfo.Controls.Add(this.panelControl1);
            this.tabpServicesInfo.Name = "tabpServicesInfo";
            this.tabpServicesInfo.Size = new System.Drawing.Size(701, 385);
            this.tabpServicesInfo.Text = "Thông tin dịch vụ";
            // 
            // grpListServices
            // 
            this.grpListServices.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListServices.Appearance.Options.UseFont = true;
            this.grpListServices.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListServices.AppearanceCaption.Options.UseFont = true;
            this.grpListServices.Controls.Add(this.grdListServices);
            this.grpListServices.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("grpListServices.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa ", ((System.Drawing.Image)(resources.GetObject("grpListServices.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("grpListServices.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("grpListServices.CustomHeaderButtons3"))))});
            this.grpListServices.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListServices.Location = new System.Drawing.Point(0, 51);
            this.grpListServices.Name = "grpListServices";
            this.grpListServices.Size = new System.Drawing.Size(701, 334);
            this.grpListServices.TabIndex = 4;
            this.grpListServices.Text = "Danh sách dịch vụ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtServicesID);
            this.panelControl1.Controls.Add(this.txtServicesName);
            this.panelControl1.Controls.Add(this.labServicesID);
            this.panelControl1.Controls.Add(this.labServicesName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(701, 51);
            this.panelControl1.TabIndex = 3;
            // 
            // txtServicesID
            // 
            this.txtServicesID.Location = new System.Drawing.Point(133, 21);
            this.txtServicesID.Name = "txtServicesID";
            this.txtServicesID.Size = new System.Drawing.Size(100, 20);
            this.txtServicesID.TabIndex = 0;
            // 
            // txtServicesName
            // 
            this.txtServicesName.Location = new System.Drawing.Point(376, 21);
            this.txtServicesName.Name = "txtServicesName";
            this.txtServicesName.Size = new System.Drawing.Size(100, 20);
            this.txtServicesName.TabIndex = 0;
            // 
            // labServicesID
            // 
            this.labServicesID.Location = new System.Drawing.Point(33, 24);
            this.labServicesID.Name = "labServicesID";
            this.labServicesID.Size = new System.Drawing.Size(51, 13);
            this.labServicesID.TabIndex = 1;
            this.labServicesID.Text = "Mã dịch vụ";
            // 
            // labServicesName
            // 
            this.labServicesName.Location = new System.Drawing.Point(274, 24);
            this.labServicesName.Name = "labServicesName";
            this.labServicesName.Size = new System.Drawing.Size(55, 13);
            this.labServicesName.TabIndex = 1;
            this.labServicesName.Text = "Tên dịch vụ";
            // 
            // picTitle
            // 
            this.picTitle.EditValue = ((object)(resources.GetObject("picTitle.EditValue")));
            this.picTitle.Location = new System.Drawing.Point(14, 7);
            this.picTitle.Name = "picTitle";
            this.picTitle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picTitle.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picTitle.Size = new System.Drawing.Size(47, 32);
            this.picTitle.TabIndex = 0;
            // 
            // panHeader
            // 
            this.panHeader.Appearance.BackColor = System.Drawing.Color.White;
            this.panHeader.Appearance.Options.UseBackColor = true;
            this.panHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panHeader.Controls.Add(this.labTitle);
            this.panHeader.Controls.Add(this.picTitle);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(707, 47);
            this.panHeader.TabIndex = 8;
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Appearance.ForeColor = System.Drawing.Color.RosyBrown;
            this.labTitle.Location = new System.Drawing.Point(67, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(179, 25);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Thông tin dịch vụ";
            // 
            // grdListServices
            // 
            this.grdListServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListServices.Location = new System.Drawing.Point(2, 45);
            this.grdListServices.MainView = this.grdvListServices;
            this.grdListServices.Name = "grdListServices";
            this.grdListServices.Size = new System.Drawing.Size(697, 287);
            this.grdListServices.TabIndex = 4;
            this.grdListServices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListServices});
            // 
            // grdvListServices
            // 
            this.grdvListServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.grdvListServices.GridControl = this.grdListServices;
            this.grdvListServices.Name = "grdvListServices";
            this.grdvListServices.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã dịch vụ";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên dịch vụ";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmServiceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 464);
            this.Controls.Add(this.tabCutomerInfo);
            this.Controls.Add(this.panHeader);
            this.Name = "frmServiceType";
            this.Text = "frmServiceType";
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).EndInit();
            this.tabCutomerInfo.ResumeLayout(false);
            this.tabpServicesInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListServices)).EndInit();
            this.grpListServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServicesName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabCutomerInfo;
        private DevExpress.XtraTab.XtraTabPage tabpServicesInfo;
        private DevExpress.XtraEditors.GroupControl grpListServices;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtServicesID;
        private DevExpress.XtraEditors.TextEdit txtServicesName;
        private DevExpress.XtraEditors.LabelControl labServicesID;
        private DevExpress.XtraEditors.LabelControl labServicesName;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraEditors.PanelControl panHeader;
        private DevExpress.XtraEditors.LabelControl labTitle;
        private DevExpress.XtraGrid.GridControl grdListServices;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListServices;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}