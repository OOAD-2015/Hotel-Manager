namespace HotelManager
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.tabCutomerInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabpStaffInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grpListStaff = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtStaffID = new DevExpress.XtraEditors.TextEdit();
            this.dateBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.txtGender = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.labAddress = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.labGender = new DevExpress.XtraEditors.LabelControl();
            this.txtStaffName = new DevExpress.XtraEditors.TextEdit();
            this.labBirthDate = new DevExpress.XtraEditors.LabelControl();
            this.labStaffID = new DevExpress.XtraEditors.LabelControl();
            this.labStaffName = new DevExpress.XtraEditors.LabelControl();
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.grdListStaff = new DevExpress.XtraGrid.GridControl();
            this.grdvListStaff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).BeginInit();
            this.tabCutomerInfo.SuspendLayout();
            this.tabpStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListStaff)).BeginInit();
            this.grpListStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCutomerInfo
            // 
            this.tabCutomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCutomerInfo.Location = new System.Drawing.Point(0, 47);
            this.tabCutomerInfo.Name = "tabCutomerInfo";
            this.tabCutomerInfo.SelectedTabPage = this.tabpStaffInfo;
            this.tabCutomerInfo.Size = new System.Drawing.Size(722, 416);
            this.tabCutomerInfo.TabIndex = 3;
            this.tabCutomerInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpStaffInfo});
            // 
            // tabpStaffInfo
            // 
            this.tabpStaffInfo.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabpStaffInfo.Appearance.Header.Options.UseFont = true;
            this.tabpStaffInfo.Controls.Add(this.grpListStaff);
            this.tabpStaffInfo.Controls.Add(this.panelControl1);
            this.tabpStaffInfo.Name = "tabpStaffInfo";
            this.tabpStaffInfo.Size = new System.Drawing.Size(716, 385);
            this.tabpStaffInfo.Text = "Thông tin nhân viên";
            // 
            // grpListStaff
            // 
            this.grpListStaff.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListStaff.Appearance.Options.UseFont = true;
            this.grpListStaff.Controls.Add(this.grdListStaff);
            this.grpListStaff.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("grpListStaff.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa ", ((System.Drawing.Image)(resources.GetObject("grpListStaff.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("grpListStaff.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("grpListStaff.CustomHeaderButtons3"))))});
            this.grpListStaff.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListStaff.Location = new System.Drawing.Point(0, 181);
            this.grpListStaff.Name = "grpListStaff";
            this.grpListStaff.Size = new System.Drawing.Size(716, 204);
            this.grpListStaff.TabIndex = 4;
            this.grpListStaff.Text = "Danh sách nhân viên";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.txtStaffID);
            this.panelControl1.Controls.Add(this.dateBirthDate);
            this.panelControl1.Controls.Add(this.txtGender);
            this.panelControl1.Controls.Add(this.txtPhoneNumber);
            this.panelControl1.Controls.Add(this.labAddress);
            this.panelControl1.Controls.Add(this.txtAddress);
            this.panelControl1.Controls.Add(this.labPhoneNumber);
            this.panelControl1.Controls.Add(this.labGender);
            this.panelControl1.Controls.Add(this.txtStaffName);
            this.panelControl1.Controls.Add(this.labBirthDate);
            this.panelControl1.Controls.Add(this.labStaffID);
            this.panelControl1.Controls.Add(this.labStaffName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(716, 181);
            this.panelControl1.TabIndex = 3;
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
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(316, 17);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 0;
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
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(316, 60);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(316, 102);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(343, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // labAddress
            // 
            this.labAddress.Location = new System.Drawing.Point(216, 147);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(32, 13);
            this.labAddress.TabIndex = 1;
            this.labAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(316, 144);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(343, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.Location = new System.Drawing.Point(216, 105);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(62, 13);
            this.labPhoneNumber.TabIndex = 1;
            this.labPhoneNumber.Text = "Số điện thoại";
            // 
            // labGender
            // 
            this.labGender.Location = new System.Drawing.Point(216, 63);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(38, 13);
            this.labGender.TabIndex = 1;
            this.labGender.Text = "Giới tính";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(559, 17);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(100, 20);
            this.txtStaffName.TabIndex = 0;
            // 
            // labBirthDate
            // 
            this.labBirthDate.Location = new System.Drawing.Point(457, 63);
            this.labBirthDate.Name = "labBirthDate";
            this.labBirthDate.Size = new System.Drawing.Size(47, 13);
            this.labBirthDate.TabIndex = 1;
            this.labBirthDate.Text = "Ngày sinh";
            // 
            // labStaffID
            // 
            this.labStaffID.Location = new System.Drawing.Point(216, 20);
            this.labStaffID.Name = "labStaffID";
            this.labStaffID.Size = new System.Drawing.Size(64, 13);
            this.labStaffID.TabIndex = 1;
            this.labStaffID.Text = "Mã nhân viên";
            // 
            // labStaffName
            // 
            this.labStaffName.Location = new System.Drawing.Point(457, 20);
            this.labStaffName.Name = "labStaffName";
            this.labStaffName.Size = new System.Drawing.Size(68, 13);
            this.labStaffName.TabIndex = 1;
            this.labStaffName.Text = "Tên nhân viên";
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
            this.panHeader.Size = new System.Drawing.Size(722, 47);
            this.panHeader.TabIndex = 2;
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Appearance.ForeColor = System.Drawing.Color.RosyBrown;
            this.labTitle.Location = new System.Drawing.Point(67, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(284, 25);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Thông tin chi tiết nhân viên";
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
            // grdListStaff
            // 
            this.grdListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListStaff.Location = new System.Drawing.Point(2, 45);
            this.grdListStaff.MainView = this.grdvListStaff;
            this.grdListStaff.Name = "grdListStaff";
            this.grdListStaff.Size = new System.Drawing.Size(712, 157);
            this.grdListStaff.TabIndex = 1;
            this.grdListStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListStaff});
            // 
            // grdvListStaff
            // 
            this.grdvListStaff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6});
            this.grdvListStaff.GridControl = this.grdListStaff;
            this.grdvListStaff.Name = "grdvListStaff";
            this.grdvListStaff.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã nhân viên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhân viên";
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
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Địa chỉ";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 463);
            this.Controls.Add(this.tabCutomerInfo);
            this.Controls.Add(this.panHeader);
            this.Name = "frmStaff";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).EndInit();
            this.tabCutomerInfo.ResumeLayout(false);
            this.tabpStaffInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListStaff)).EndInit();
            this.grpListStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdListStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabCutomerInfo;
        private DevExpress.XtraTab.XtraTabPage tabpStaffInfo;
        private DevExpress.XtraEditors.GroupControl grpListStaff;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtStaffID;
        private DevExpress.XtraEditors.DateEdit dateBirthDate;
        private DevExpress.XtraEditors.TextEdit txtGender;
        private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labAddress;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labPhoneNumber;
        private DevExpress.XtraEditors.LabelControl labGender;
        private DevExpress.XtraEditors.TextEdit txtStaffName;
        private DevExpress.XtraEditors.LabelControl labBirthDate;
        private DevExpress.XtraEditors.LabelControl labStaffID;
        private DevExpress.XtraEditors.LabelControl labStaffName;
        private DevExpress.XtraEditors.PanelControl panHeader;
        private DevExpress.XtraEditors.LabelControl labTitle;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraGrid.GridControl grdListStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListStaff;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;

    }
}