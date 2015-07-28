namespace HotelManager
{
    partial class frmHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallimageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.bbtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnConnectData = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnCustomerCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnProductCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRoomTypeCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnRoomCategory = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnAreaCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barSiInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barhiStatus = new DevExpress.XtraBars.BarStaticItem();
            this.barHiDateLogin = new DevExpress.XtraBars.BarHeaderItem();
            this.largeimageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpAction = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribgCategory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribpManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribpStaff = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribpHelp = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallimageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeimageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.smallimageCollection;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbtnLogin,
            this.bbtnConnectData,
            this.bbtnCustomerCategory,
            this.bbtnProductCategory,
            this.bbtnRoomTypeCategory,
            this.bbtnRoomCategory,
            this.bbtnAreaCategory,
            this.barSiInfo,
            this.barhiStatus,
            this.barHiDateLogin});
            this.ribbon.LargeImages = this.largeimageCollection;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 13;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribpSystem,
            this.ribpAction,
            this.ribpManager,
            this.ribpStaff,
            this.ribpHelp});
            this.ribbon.Size = new System.Drawing.Size(812, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // smallimageCollection
            // 
            this.smallimageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallimageCollection.ImageStream")));
            this.smallimageCollection.Images.SetKeyName(0, "Login.png");
            this.smallimageCollection.Images.SetKeyName(1, "database.png");
            this.smallimageCollection.Images.SetKeyName(2, "customer.png");
            // 
            // bbtnLogin
            // 
            this.bbtnLogin.Caption = "Đăng nhập";
            this.bbtnLogin.Id = 1;
            this.bbtnLogin.LargeImageIndex = 0;
            this.bbtnLogin.Name = "bbtnLogin";
            this.bbtnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnConnectData
            // 
            this.bbtnConnectData.Caption = "Kết nối CSDL";
            this.bbtnConnectData.Id = 2;
            this.bbtnConnectData.LargeImageIndex = 1;
            this.bbtnConnectData.Name = "bbtnConnectData";
            this.bbtnConnectData.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // bbtnCustomerCategory
            // 
            this.bbtnCustomerCategory.Caption = "Danh mục khách hàng";
            this.bbtnCustomerCategory.Id = 3;
            this.bbtnCustomerCategory.ImageIndex = 2;
            this.bbtnCustomerCategory.Name = "bbtnCustomerCategory";
            // 
            // bbtnProductCategory
            // 
            this.bbtnProductCategory.Caption = "Danh mục mặt hàng";
            this.bbtnProductCategory.Id = 4;
            this.bbtnProductCategory.Name = "bbtnProductCategory";
            // 
            // bbtnRoomTypeCategory
            // 
            this.bbtnRoomTypeCategory.Caption = "Danh mục loại phòng";
            this.bbtnRoomTypeCategory.Id = 5;
            this.bbtnRoomTypeCategory.Name = "bbtnRoomTypeCategory";
            // 
            // bbtnRoomCategory
            // 
            this.bbtnRoomCategory.Caption = "Danh mục phòng";
            this.bbtnRoomCategory.Id = 6;
            this.bbtnRoomCategory.Name = "bbtnRoomCategory";
            // 
            // bbtnAreaCategory
            // 
            this.bbtnAreaCategory.Caption = "Danh sách khu vực";
            this.bbtnAreaCategory.Id = 7;
            this.bbtnAreaCategory.Name = "bbtnAreaCategory";
            // 
            // barSiInfo
            // 
            this.barSiInfo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSiInfo.Caption = "Đăng nhập với quyền: ";
            this.barSiInfo.Id = 10;
            this.barSiInfo.Name = "barSiInfo";
            this.barSiInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barhiStatus
            // 
            this.barhiStatus.Caption = "Khách sạn";
            this.barhiStatus.Id = 11;
            this.barhiStatus.Name = "barhiStatus";
            this.barhiStatus.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barHiDateLogin
            // 
            this.barHiDateLogin.Id = 12;
            this.barHiDateLogin.Name = "barHiDateLogin";
            // 
            // largeimageCollection
            // 
            this.largeimageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeimageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeimageCollection.ImageStream")));
            this.largeimageCollection.Images.SetKeyName(0, "Login.png");
            this.largeimageCollection.Images.SetKeyName(1, "database.png");
            this.largeimageCollection.Images.SetKeyName(2, "customer.png");
            // 
            // ribpSystem
            // 
            this.ribpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribpgSystem});
            this.ribpSystem.Name = "ribpSystem";
            this.ribpSystem.Text = "Hệ thống";
            // 
            // ribpgSystem
            // 
            this.ribpgSystem.ItemLinks.Add(this.bbtnLogin);
            this.ribpgSystem.ItemLinks.Add(this.bbtnConnectData);
            this.ribpgSystem.Name = "ribpgSystem";
            this.ribpgSystem.Text = "Nhóm hệ thống";
            // 
            // ribpAction
            // 
            this.ribpAction.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribgCategory});
            this.ribpAction.Name = "ribpAction";
            this.ribpAction.Text = "Hoạt động";
            // 
            // ribgCategory
            // 
            this.ribgCategory.ItemLinks.Add(this.bbtnCustomerCategory);
            this.ribgCategory.ItemLinks.Add(this.bbtnProductCategory);
            this.ribgCategory.ItemLinks.Add(this.bbtnRoomTypeCategory, true);
            this.ribgCategory.ItemLinks.Add(this.bbtnRoomCategory);
            this.ribgCategory.ItemLinks.Add(this.bbtnAreaCategory);
            this.ribgCategory.Name = "ribgCategory";
            this.ribgCategory.Text = "Nhóm danh mục";
            // 
            // ribpManager
            // 
            this.ribpManager.Name = "ribpManager";
            this.ribpManager.Text = "Quản trị";
            // 
            // ribpStaff
            // 
            this.ribpStaff.Name = "ribpStaff";
            this.ribpStaff.Text = "Nhân sự";
            // 
            // ribpHelp
            // 
            this.ribpHelp.Name = "ribpHelp";
            this.ribpHelp.Text = "Trợ giúp";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barSiInfo);
            this.ribbonStatusBar.ItemLinks.Add(this.barhiStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.barHiDateLogin);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 307);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonStatusBar.Size = new System.Drawing.Size(812, 31);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 338);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmHomePage";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý khách sạn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomePage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHomePage_FormClosed);
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallimageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeimageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribpgSystem;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem bbtnLogin;
        private DevExpress.Utils.ImageCollection smallimageCollection;
        private DevExpress.XtraBars.BarButtonItem bbtnConnectData;
        private DevExpress.Utils.ImageCollection largeimageCollection;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpAction;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpManager;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpStaff;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribpHelp;
        private DevExpress.XtraBars.BarButtonItem bbtnCustomerCategory;
        private DevExpress.XtraBars.BarButtonItem bbtnProductCategory;
        private DevExpress.XtraBars.BarButtonItem bbtnRoomTypeCategory;
        private DevExpress.XtraBars.BarButtonItem bbtnRoomCategory;
        private DevExpress.XtraBars.BarButtonItem bbtnAreaCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribgCategory;
        private DevExpress.XtraBars.BarStaticItem barSiInfo;
        private DevExpress.XtraBars.BarStaticItem barhiStatus;
        private DevExpress.XtraBars.BarHeaderItem barHiDateLogin;
    }
}