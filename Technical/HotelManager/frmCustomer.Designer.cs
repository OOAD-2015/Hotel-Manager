namespace HotelManager
{
    partial class frmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.tabCutomerInfo = new DevExpress.XtraTab.XtraTabControl();
            this.txtCustomerID = new DevExpress.XtraEditors.TextEdit();
            this.labCustomerID = new DevExpress.XtraEditors.LabelControl();
            this.tabpCustomerInfo = new DevExpress.XtraTab.XtraTabPage();
            this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
            this.txtGender = new DevExpress.XtraEditors.TextEdit();
            this.labGender = new DevExpress.XtraEditors.LabelControl();
            this.dateBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.labCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.txtNumberID = new DevExpress.XtraEditors.TextEdit();
            this.labNumberID = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labAddress = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grpListCustomer = new DevExpress.XtraEditors.GroupControl();
            this.grdListCustomer = new DevExpress.XtraGrid.GridControl();
            this.grdvListCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).BeginInit();
            this.tabCutomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).BeginInit();
            this.tabpCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListCustomer)).BeginInit();
            this.grpListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.panHeader.Size = new System.Drawing.Size(696, 47);
            this.panHeader.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Appearance.ForeColor = System.Drawing.Color.RosyBrown;
            this.labTitle.Location = new System.Drawing.Point(67, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(304, 25);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Thông tin chi tiết khách hàng";
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
            // tabCutomerInfo
            // 
            this.tabCutomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCutomerInfo.Location = new System.Drawing.Point(0, 47);
            this.tabCutomerInfo.Name = "tabCutomerInfo";
            this.tabCutomerInfo.SelectedTabPage = this.tabpCustomerInfo;
            this.tabCutomerInfo.Size = new System.Drawing.Size(696, 384);
            this.tabCutomerInfo.TabIndex = 1;
            this.tabCutomerInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpCustomerInfo});
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(316, 17);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // labCustomerID
            // 
            this.labCustomerID.Location = new System.Drawing.Point(216, 20);
            this.labCustomerID.Name = "labCustomerID";
            this.labCustomerID.Size = new System.Drawing.Size(72, 13);
            this.labCustomerID.TabIndex = 1;
            this.labCustomerID.Text = "Mã khách hàng";
            // 
            // tabpCustomerInfo
            // 
            this.tabpCustomerInfo.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabpCustomerInfo.Appearance.Header.Options.UseFont = true;
            this.tabpCustomerInfo.Controls.Add(this.grpListCustomer);
            this.tabpCustomerInfo.Controls.Add(this.panelControl1);
            this.tabpCustomerInfo.Name = "tabpCustomerInfo";
            this.tabpCustomerInfo.Size = new System.Drawing.Size(690, 353);
            this.tabpCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(559, 17);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(316, 60);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 0;
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(216, 63);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(38, 13);
            this.labGender.TabIndex = 1;
            this.labGender.Text = "Giới tính";
            // 
            // dateBirthDate
            // 
            this.dateBirthDate.EditValue = null;
            this.dateBirthDate.Location = new System.Drawing.Point(559, 63);
            this.dateBirthDate.Name = "dateBirthDate";
            this.dateBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dateBirthDate.TabIndex = 2;
            // 
            // labCustomerName
            // 
            this.labCustomerName.Location = new System.Drawing.Point(457, 20);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(76, 13);
            this.labCustomerName.TabIndex = 1;
            this.labCustomerName.Text = "Tên khách hàng";
            // 
            // labBirthDate
            // 
            this.labBirthDate.Location = new System.Drawing.Point(457, 63);
            this.labBirthDate.Name = "labBirthDate";
            this.labBirthDate.Size = new System.Drawing.Size(47, 13);
            this.labBirthDate.TabIndex = 1;
            this.labBirthDate.Text = "Ngày sinh";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(316, 102);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.Location = new System.Drawing.Point(216, 105);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(62, 13);
            this.labPhoneNumber.TabIndex = 1;
            this.labPhoneNumber.Text = "Số điện thoại";
            // 
            // txtNumberID
            // 
            this.txtNumberID.Location = new System.Drawing.Point(559, 102);
            this.txtNumberID.Name = "txtNumberID";
            this.txtNumberID.Size = new System.Drawing.Size(100, 20);
            this.txtNumberID.TabIndex = 0;
            // 
            // labNumberID
            // 
            this.labNumberID.Location = new System.Drawing.Point(457, 105);
            this.labNumberID.Name = "labNumberID";
            this.labNumberID.Size = new System.Drawing.Size(29, 13);
            this.labNumberID.TabIndex = 1;
            this.labNumberID.Text = "CMND";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(316, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(343, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // labAddress
            // 
            this.labAddress.Location = new System.Drawing.Point(216, 147);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(32, 13);
            this.labAddress.TabIndex = 1;
            this.labAddress.Text = "Địa chỉ";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.txtCustomerID);
            this.panelControl1.Controls.Add(this.dateBirthDate);
            this.panelControl1.Controls.Add(this.txtGender);
            this.panelControl1.Controls.Add(this.labNumberID);
            this.panelControl1.Controls.Add(this.txtPhoneNumber);
            this.panelControl1.Controls.Add(this.labAddress);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.labPhoneNumber);
            this.panelControl1.Controls.Add(this.txtNumberID);
            this.panelControl1.Controls.Add(this.labGender);
            this.panelControl1.Controls.Add(this.txtCustomerName);
            this.panelControl1.Controls.Add(this.labBirthDate);
            this.panelControl1.Controls.Add(this.labCustomerID);
            this.panelControl1.Controls.Add(this.labCustomerName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(690, 181);
            this.panelControl1.TabIndex = 3;
            // 
            // grpListCustomer
            // 
            this.grpListCustomer.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListCustomer.Appearance.Options.UseFont = true;
            this.grpListCustomer.Controls.Add(this.grdListCustomer);
            this.grpListCustomer.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("grpListCustomer.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa ", ((System.Drawing.Image)(resources.GetObject("grpListCustomer.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("grpListCustomer.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("grpListCustomer.CustomHeaderButtons3"))))});
            this.grpListCustomer.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListCustomer.Location = new System.Drawing.Point(0, 181);
            this.grpListCustomer.Name = "grpListCustomer";
            this.grpListCustomer.Size = new System.Drawing.Size(690, 172);
            this.grpListCustomer.TabIndex = 4;
            this.grpListCustomer.Text = "Danh sách khách hàng";
            // 
            // grdListCustomer
            // 
            this.grdListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListCustomer.Location = new System.Drawing.Point(2, 45);
            this.grdListCustomer.MainView = this.grdvListCustomer;
            this.grdListCustomer.Name = "grdListCustomer";
            this.grdListCustomer.Size = new System.Drawing.Size(686, 125);
            this.grdListCustomer.TabIndex = 0;
            this.grdListCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListCustomer});
            // 
            // grdvListCustomer
            // 
            this.grdvListCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grdvListCustomer.GridControl = this.grdListCustomer;
            this.grdvListCustomer.Name = "grdvListCustomer";
            this.grdvListCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(32, 20);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(142, 140);
            this.pictureEdit1.TabIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khách hàng";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giói tính";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CMND";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa chỉ";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frmCustomer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 431);
            this.Controls.Add(this.tabCutomerInfo);
            this.Controls.Add(this.panHeader);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "frmCustomer";
            this.Text = "Quản lý khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).EndInit();
            this.tabCutomerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerID.Properties)).EndInit();
            this.tabpCustomerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumberID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListCustomer)).EndInit();
            this.grpListCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panHeader;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraEditors.LabelControl labTitle;
        private DevExpress.XtraTab.XtraTabControl tabCutomerInfo;
        private DevExpress.XtraTab.XtraTabPage tabpCustomerInfo;
        private DevExpress.XtraEditors.DateEdit dateBirthDate;
        private DevExpress.XtraEditors.LabelControl labGender;
        private DevExpress.XtraEditors.LabelControl labCustomerID;
        private DevExpress.XtraEditors.TextEdit txtCustomerName;
        private DevExpress.XtraEditors.TextEdit txtGender;
        private DevExpress.XtraEditors.TextEdit txtCustomerID;
        private DevExpress.XtraEditors.LabelControl labCustomerName;
        private DevExpress.XtraEditors.GroupControl grpListCustomer;
        private DevExpress.XtraGrid.GridControl grdListCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labNumberID;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labPhoneNumber;
        private DevExpress.XtraEditors.TextEdit txtNumberID;
        private DevExpress.XtraEditors.LabelControl labBirthDate;
    }
}