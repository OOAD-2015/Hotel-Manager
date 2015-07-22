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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomType));
            this.tabCutomerInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabpRoomTypeInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grpListRoomType = new DevExpress.XtraEditors.GroupControl();
            this.grdListRoomType = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoomType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtRoomTypeID = new DevExpress.XtraEditors.TextEdit();
            this.txtGender = new DevExpress.XtraEditors.TextEdit();
            this.labPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtRoomTypeName = new DevExpress.XtraEditors.TextEdit();
            this.labRoomTypeID = new DevExpress.XtraEditors.LabelControl();
            this.labRoomTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).BeginInit();
            this.tabCutomerInfo.SuspendLayout();
            this.tabpRoomTypeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoomType)).BeginInit();
            this.grpListRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoomType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCutomerInfo
            // 
            this.tabCutomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCutomerInfo.Location = new System.Drawing.Point(0, 47);
            this.tabCutomerInfo.Name = "tabCutomerInfo";
            this.tabCutomerInfo.SelectedTabPage = this.tabpRoomTypeInfo;
            this.tabCutomerInfo.Size = new System.Drawing.Size(707, 442);
            this.tabCutomerInfo.TabIndex = 5;
            this.tabCutomerInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpRoomTypeInfo});
            // 
            // tabpRoomTypeInfo
            // 
            this.tabpRoomTypeInfo.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabpRoomTypeInfo.Appearance.Header.Options.UseFont = true;
            this.tabpRoomTypeInfo.Controls.Add(this.grpListRoomType);
            this.tabpRoomTypeInfo.Controls.Add(this.panelControl1);
            this.tabpRoomTypeInfo.Name = "tabpRoomTypeInfo";
            this.tabpRoomTypeInfo.Size = new System.Drawing.Size(701, 410);
            this.tabpRoomTypeInfo.Text = "Thông tin loại phòng";
            // 
            // grpListRoomType
            // 
            this.grpListRoomType.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListRoomType.Appearance.Options.UseFont = true;
            this.grpListRoomType.Controls.Add(this.grdListRoomType);
            this.grpListRoomType.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("grpListRoomType.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa ", ((System.Drawing.Image)(resources.GetObject("grpListRoomType.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("grpListRoomType.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("grpListRoomType.CustomHeaderButtons3"))))});
            this.grpListRoomType.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpListRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListRoomType.Location = new System.Drawing.Point(0, 181);
            this.grpListRoomType.Name = "grpListRoomType";
            this.grpListRoomType.Size = new System.Drawing.Size(701, 229);
            this.grpListRoomType.TabIndex = 4;
            this.grpListRoomType.Text = "Danh sách loại phòng";
            // 
            // grdListRoomType
            // 
            this.grdListRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoomType.Location = new System.Drawing.Point(2, 45);
            this.grdListRoomType.MainView = this.grdvListRoomType;
            this.grdListRoomType.Name = "grdListRoomType";
            this.grdListRoomType.Size = new System.Drawing.Size(697, 182);
            this.grdListRoomType.TabIndex = 2;
            this.grdListRoomType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoomType});
            // 
            // grdvListRoomType
            // 
            this.grdvListRoomType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.grdvListRoomType.GridControl = this.grdListRoomType;
            this.grdvListRoomType.Name = "grdvListRoomType";
            this.grdvListRoomType.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã loại phòng";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên loại phòng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Giá theo ngày";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.txtRoomTypeID);
            this.panelControl1.Controls.Add(this.txtGender);
            this.panelControl1.Controls.Add(this.labPrice);
            this.panelControl1.Controls.Add(this.txtRoomTypeName);
            this.panelControl1.Controls.Add(this.labRoomTypeID);
            this.panelControl1.Controls.Add(this.labRoomTypeName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(701, 181);
            this.panelControl1.TabIndex = 3;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(32, 20);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(150, 140);
            this.pictureEdit1.TabIndex = 3;
            // 
            // txtRoomTypeID
            // 
            this.txtRoomTypeID.Location = new System.Drawing.Point(316, 17);
            this.txtRoomTypeID.Name = "txtRoomTypeID";
            this.txtRoomTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtRoomTypeID.TabIndex = 0;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(316, 60);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 20);
            this.txtGender.TabIndex = 0;
            // 
            // labPrice
            // 
            this.labPrice.Location = new System.Drawing.Point(216, 63);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(67, 13);
            this.labPrice.TabIndex = 1;
            this.labPrice.Text = "Giá theo ngày";
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(559, 17);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomTypeName.TabIndex = 0;
            // 
            // labRoomTypeID
            // 
            this.labRoomTypeID.Location = new System.Drawing.Point(216, 20);
            this.labRoomTypeID.Name = "labRoomTypeID";
            this.labRoomTypeID.Size = new System.Drawing.Size(66, 13);
            this.labRoomTypeID.TabIndex = 1;
            this.labRoomTypeID.Text = "Mã loại phòng";
            // 
            // labRoomTypeName
            // 
            this.labRoomTypeName.Location = new System.Drawing.Point(457, 20);
            this.labRoomTypeName.Name = "labRoomTypeName";
            this.labRoomTypeName.Size = new System.Drawing.Size(70, 13);
            this.labRoomTypeName.TabIndex = 1;
            this.labRoomTypeName.Text = "Tên loại phòng";
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
            this.panHeader.TabIndex = 4;
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Appearance.ForeColor = System.Drawing.Color.RosyBrown;
            this.labTitle.Location = new System.Drawing.Point(67, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(214, 25);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Thông tin loại phòng";
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
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 489);
            this.Controls.Add(this.tabCutomerInfo);
            this.Controls.Add(this.panHeader);
            this.Name = "frmRoomType";
            this.Text = "Danh mục loại phòng";
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).EndInit();
            this.tabCutomerInfo.ResumeLayout(false);
            this.tabpRoomTypeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoomType)).EndInit();
            this.grpListRoomType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoomType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabCutomerInfo;
        private DevExpress.XtraTab.XtraTabPage tabpRoomTypeInfo;
        private DevExpress.XtraEditors.GroupControl grpListRoomType;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeID;
        private DevExpress.XtraEditors.TextEdit txtGender;
        private DevExpress.XtraEditors.LabelControl labPrice;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeName;
        private DevExpress.XtraEditors.LabelControl labRoomTypeID;
        private DevExpress.XtraEditors.LabelControl labRoomTypeName;
        private DevExpress.XtraEditors.PanelControl panHeader;
        private DevExpress.XtraEditors.LabelControl labTitle;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraGrid.GridControl grdListRoomType;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoomType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}