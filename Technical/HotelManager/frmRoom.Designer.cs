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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoom));
            this.tabCutomerInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabpRoomInfo = new DevExpress.XtraTab.XtraTabPage();
            this.grpListRoom = new DevExpress.XtraEditors.GroupControl();
            this.grdListRoom = new DevExpress.XtraGrid.GridControl();
            this.grdvListRoom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkRoomTypeName = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtRoomID = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.labDescription = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.labStatus = new DevExpress.XtraEditors.LabelControl();
            this.txtRoomBedCount = new DevExpress.XtraEditors.TextEdit();
            this.labRoomBedCount = new DevExpress.XtraEditors.LabelControl();
            this.labPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtRoomName = new DevExpress.XtraEditors.TextEdit();
            this.labRoomID = new DevExpress.XtraEditors.LabelControl();
            this.labRoomName = new DevExpress.XtraEditors.LabelControl();
            this.picTitle = new DevExpress.XtraEditors.PictureEdit();
            this.panHeader = new DevExpress.XtraEditors.PanelControl();
            this.labTitle = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).BeginInit();
            this.tabCutomerInfo.SuspendLayout();
            this.tabpRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoom)).BeginInit();
            this.grpListRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRoomTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomBedCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCutomerInfo
            // 
            this.tabCutomerInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCutomerInfo.Location = new System.Drawing.Point(0, 47);
            this.tabCutomerInfo.Name = "tabCutomerInfo";
            this.tabCutomerInfo.SelectedTabPage = this.tabpRoomInfo;
            this.tabCutomerInfo.Size = new System.Drawing.Size(684, 431);
            this.tabCutomerInfo.TabIndex = 7;
            this.tabCutomerInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabpRoomInfo});
            // 
            // tabpRoomInfo
            // 
            this.tabpRoomInfo.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.tabpRoomInfo.Appearance.Header.Options.UseFont = true;
            this.tabpRoomInfo.Controls.Add(this.grpListRoom);
            this.tabpRoomInfo.Controls.Add(this.panelControl1);
            this.tabpRoomInfo.Name = "tabpRoomInfo";
            this.tabpRoomInfo.Size = new System.Drawing.Size(678, 400);
            this.tabpRoomInfo.Text = "Thông tin phòng";
            // 
            // grpListRoom
            // 
            this.grpListRoom.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListRoom.Appearance.Options.UseFont = true;
            this.grpListRoom.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpListRoom.AppearanceCaption.Options.UseFont = true;
            this.grpListRoom.Controls.Add(this.grdListRoom);
            this.grpListRoom.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", ((System.Drawing.Image)(resources.GetObject("grpListRoom.CustomHeaderButtons")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa ", ((System.Drawing.Image)(resources.GetObject("grpListRoom.CustomHeaderButtons1")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sửa", ((System.Drawing.Image)(resources.GetObject("grpListRoom.CustomHeaderButtons2")))),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", ((System.Drawing.Image)(resources.GetObject("grpListRoom.CustomHeaderButtons3"))))});
            this.grpListRoom.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListRoom.Location = new System.Drawing.Point(0, 181);
            this.grpListRoom.Name = "grpListRoom";
            this.grpListRoom.Size = new System.Drawing.Size(678, 219);
            this.grpListRoom.TabIndex = 4;
            this.grpListRoom.Text = "Danh sách phòng";
            // 
            // grdListRoom
            // 
            this.grdListRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListRoom.Location = new System.Drawing.Point(2, 45);
            this.grdListRoom.MainView = this.grdvListRoom;
            this.grdListRoom.Name = "grdListRoom";
            this.grdListRoom.Size = new System.Drawing.Size(674, 172);
            this.grdListRoom.TabIndex = 3;
            this.grdListRoom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListRoom});
            // 
            // grdvListRoom
            // 
            this.grdvListRoom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.grdvListRoom.GridControl = this.grdListRoom;
            this.grdvListRoom.Name = "grdvListRoom";
            this.grdvListRoom.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã phòng";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên phòng";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Loại phòng";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số giường";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trạng thái";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mô tả";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lkRoomTypeName);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.txtRoomID);
            this.panelControl1.Controls.Add(this.txtDescription);
            this.panelControl1.Controls.Add(this.labDescription);
            this.panelControl1.Controls.Add(this.txtStatus);
            this.panelControl1.Controls.Add(this.labStatus);
            this.panelControl1.Controls.Add(this.txtRoomBedCount);
            this.panelControl1.Controls.Add(this.labRoomBedCount);
            this.panelControl1.Controls.Add(this.labPrice);
            this.panelControl1.Controls.Add(this.txtRoomName);
            this.panelControl1.Controls.Add(this.labRoomID);
            this.panelControl1.Controls.Add(this.labRoomName);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(678, 181);
            this.panelControl1.TabIndex = 3;
            // 
            // lkRoomTypeName
            // 
            this.lkRoomTypeName.Location = new System.Drawing.Point(316, 60);
            this.lkRoomTypeName.Name = "lkRoomTypeName";
            this.lkRoomTypeName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkRoomTypeName.Size = new System.Drawing.Size(100, 20);
            this.lkRoomTypeName.TabIndex = 4;
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
            // txtRoomID
            // 
            this.txtRoomID.Location = new System.Drawing.Point(316, 17);
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Size = new System.Drawing.Size(100, 20);
            this.txtRoomID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(316, 140);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(343, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // labDescription
            // 
            this.labDescription.Location = new System.Drawing.Point(216, 143);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(27, 13);
            this.labDescription.TabIndex = 1;
            this.labDescription.Text = "Mô tả";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(316, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(343, 20);
            this.txtStatus.TabIndex = 0;
            // 
            // labStatus
            // 
            this.labStatus.Location = new System.Drawing.Point(216, 103);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(49, 13);
            this.labStatus.TabIndex = 1;
            this.labStatus.Text = "Trạng thái";
            // 
            // txtRoomBedCount
            // 
            this.txtRoomBedCount.Location = new System.Drawing.Point(557, 60);
            this.txtRoomBedCount.Name = "txtRoomBedCount";
            this.txtRoomBedCount.Size = new System.Drawing.Size(100, 20);
            this.txtRoomBedCount.TabIndex = 0;
            // 
            // labRoomBedCount
            // 
            this.labRoomBedCount.Location = new System.Drawing.Point(457, 63);
            this.labRoomBedCount.Name = "labRoomBedCount";
            this.labRoomBedCount.Size = new System.Drawing.Size(48, 13);
            this.labRoomBedCount.TabIndex = 1;
            this.labRoomBedCount.Text = "Số giường";
            // 
            // labPrice
            // 
            this.labPrice.Location = new System.Drawing.Point(216, 63);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(52, 13);
            this.labPrice.TabIndex = 1;
            this.labPrice.Text = "Loại phòng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(559, 17);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(100, 20);
            this.txtRoomName.TabIndex = 0;
            // 
            // labRoomID
            // 
            this.labRoomID.Location = new System.Drawing.Point(216, 20);
            this.labRoomID.Name = "labRoomID";
            this.labRoomID.Size = new System.Drawing.Size(47, 13);
            this.labRoomID.TabIndex = 1;
            this.labRoomID.Text = "Mã phòng";
            // 
            // labRoomName
            // 
            this.labRoomName.Location = new System.Drawing.Point(457, 20);
            this.labRoomName.Name = "labRoomName";
            this.labRoomName.Size = new System.Drawing.Size(51, 13);
            this.labRoomName.TabIndex = 1;
            this.labRoomName.Text = "Tên phòng";
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
            this.panHeader.Size = new System.Drawing.Size(684, 47);
            this.panHeader.TabIndex = 6;
            // 
            // labTitle
            // 
            this.labTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.Appearance.ForeColor = System.Drawing.Color.RosyBrown;
            this.labTitle.Location = new System.Drawing.Point(67, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(170, 25);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Thông tin phòng";
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 478);
            this.Controls.Add(this.tabCutomerInfo);
            this.Controls.Add(this.panHeader);
            this.Name = "frmRoom";
            this.Text = "Danh mục phòng";
            ((System.ComponentModel.ISupportInitialize)(this.tabCutomerInfo)).EndInit();
            this.tabCutomerInfo.ResumeLayout(false);
            this.tabpRoomInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpListRoom)).EndInit();
            this.grpListRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkRoomTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomBedCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tabCutomerInfo;
        private DevExpress.XtraTab.XtraTabPage tabpRoomInfo;
        private DevExpress.XtraEditors.GroupControl grpListRoom;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtRoomID;
        private DevExpress.XtraEditors.LabelControl labPrice;
        private DevExpress.XtraEditors.TextEdit txtRoomName;
        private DevExpress.XtraEditors.LabelControl labRoomID;
        private DevExpress.XtraEditors.LabelControl labRoomName;
        private DevExpress.XtraEditors.PictureEdit picTitle;
        private DevExpress.XtraEditors.PanelControl panHeader;
        private DevExpress.XtraEditors.LabelControl labTitle;
        private DevExpress.XtraGrid.GridControl grdListRoom;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListRoom;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LookUpEdit lkRoomTypeName;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.LabelControl labDescription;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private DevExpress.XtraEditors.LabelControl labStatus;
        private DevExpress.XtraEditors.TextEdit txtRoomBedCount;
        private DevExpress.XtraEditors.LabelControl labRoomBedCount;
    }
}