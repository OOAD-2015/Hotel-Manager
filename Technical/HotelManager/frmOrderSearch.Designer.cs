namespace HotelManager
{
    partial class frmOrderSearch
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
            this.panelRoomsT = new DevExpress.XtraEditors.PanelControl();
            this.labOrders = new DevExpress.XtraEditors.LabelControl();
            this.grpSearchInfo = new DevExpress.XtraEditors.GroupControl();
            this.labCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lkCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtIDNumber = new DevExpress.XtraEditors.TextEdit();
            this.grpResult = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelRoomsT)).BeginInit();
            this.panelRoomsT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchInfo)).BeginInit();
            this.grpSearchInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoomsT
            // 
            this.panelRoomsT.Controls.Add(this.labOrders);
            this.panelRoomsT.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoomsT.Location = new System.Drawing.Point(0, 0);
            this.panelRoomsT.Name = "panelRoomsT";
            this.panelRoomsT.Size = new System.Drawing.Size(648, 69);
            this.panelRoomsT.TabIndex = 8;
            // 
            // labOrders
            // 
            this.labOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOrders.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labOrders.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labOrders.Location = new System.Drawing.Point(170, 21);
            this.labOrders.Name = "labOrders";
            this.labOrders.Size = new System.Drawing.Size(370, 32);
            this.labOrders.TabIndex = 0;
            this.labOrders.Text = "DANH SÁCH PHIẾU ĐẶT PHÒNG";
            // 
            // grpSearchInfo
            // 
            this.grpSearchInfo.Controls.Add(this.txtIDNumber);
            this.grpSearchInfo.Controls.Add(this.lkCustomer);
            this.grpSearchInfo.Controls.Add(this.labelControl1);
            this.grpSearchInfo.Controls.Add(this.labCustomerName);
            this.grpSearchInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchInfo.Location = new System.Drawing.Point(0, 69);
            this.grpSearchInfo.Name = "grpSearchInfo";
            this.grpSearchInfo.Size = new System.Drawing.Size(648, 79);
            this.grpSearchInfo.TabIndex = 9;
            this.grpSearchInfo.Text = "Thông tin ";
            // 
            // labCustomerName
            // 
            this.labCustomerName.Location = new System.Drawing.Point(26, 43);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(102, 13);
            this.labCustomerName.TabIndex = 0;
            this.labCustomerName.Text = "Nhập tên khách hàng";
            // 
            // lkCustomer
            // 
            this.lkCustomer.Location = new System.Drawing.Point(158, 40);
            this.lkCustomer.Name = "lkCustomer";
            this.lkCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Tên khách hàng")});
            this.lkCustomer.Properties.NullText = "";
            this.lkCustomer.Size = new System.Drawing.Size(128, 20);
            this.lkCustomer.TabIndex = 24;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(364, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nhập số CMND";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.EditValue = "";
            this.txtIDNumber.Location = new System.Drawing.Point(471, 43);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Properties.MaxLength = 11;
            this.txtIDNumber.Size = new System.Drawing.Size(125, 20);
            this.txtIDNumber.TabIndex = 25;
            this.txtIDNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNumber_KeyPress);
            // 
            // grpResult
            // 
            this.grpResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpResult.Location = new System.Drawing.Point(0, 148);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(648, 324);
            this.grpResult.TabIndex = 10;
            this.grpResult.Text = "Kết quả tìm kiếm";
            // 
            // frmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 472);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpSearchInfo);
            this.Controls.Add(this.panelRoomsT);
            this.Name = "frmOrderSearch";
            this.Text = "TÌM PHIẾU ĐẶT PHÒNG";
            ((System.ComponentModel.ISupportInitialize)(this.panelRoomsT)).EndInit();
            this.panelRoomsT.ResumeLayout(false);
            this.panelRoomsT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSearchInfo)).EndInit();
            this.grpSearchInfo.ResumeLayout(false);
            this.grpSearchInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelRoomsT;
        private DevExpress.XtraEditors.LabelControl labOrders;
        private DevExpress.XtraEditors.GroupControl grpSearchInfo;
        private DevExpress.XtraEditors.LabelControl labCustomerName;
        private DevExpress.XtraEditors.LookUpEdit lkCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtIDNumber;
        private DevExpress.XtraEditors.GroupControl grpResult;
    }
}