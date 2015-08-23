namespace HotelManager
{
    partial class frmListOrder
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
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.RoomNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panOrderViewDatail = new DevExpress.XtraEditors.PanelControl();
            this.labOrderTitle = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelOfUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.StaffName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelOrderView = new DevExpress.XtraEditors.PanelControl();
            this.grdListOrder = new DevExpress.XtraGrid.GridControl();
            this.grdvListOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.OrderSno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rdateOrderBirthday = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.Deposit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelOrderExecute = new DevExpress.XtraEditors.PanelControl();
            this.panelOrderTitles = new DevExpress.XtraEditors.PanelControl();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NumberOfPeople = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderOfDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panOrderViewDatail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderView)).BeginInit();
            this.panelOrderView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateOrderBirthday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateOrderBirthday.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderExecute)).BeginInit();
            this.panelOrderExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderTitles)).BeginInit();
            this.panelOrderTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // RoomNumber
            // 
            this.RoomNumber.Caption = "Số phòng đặt";
            this.RoomNumber.FieldName = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.Visible = true;
            this.RoomNumber.VisibleIndex = 3;
            this.RoomNumber.Width = 87;
            // 
            // panOrderViewDatail
            // 
            this.panOrderViewDatail.Dock = System.Windows.Forms.DockStyle.Top;
            this.panOrderViewDatail.Location = new System.Drawing.Point(2, 2);
            this.panOrderViewDatail.Name = "panOrderViewDatail";
            this.panOrderViewDatail.Size = new System.Drawing.Size(1012, 29);
            this.panOrderViewDatail.TabIndex = 1;
            // 
            // labOrderTitle
            // 
            this.labOrderTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labOrderTitle.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labOrderTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labOrderTitle.Location = new System.Drawing.Point(373, 1);
            this.labOrderTitle.Name = "labOrderTitle";
            this.labOrderTitle.Size = new System.Drawing.Size(265, 32);
            this.labOrderTitle.TabIndex = 1;
            this.labOrderTitle.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(635, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "(F2)Lưu xuống";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(285, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "(F8)Thêm mới";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(533, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "(F4)Xóa bỏ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(411, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "(F6)Cập nhật";
            // 
            // btnCancelOfUpdate
            // 
            this.btnCancelOfUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOfUpdate.Location = new System.Drawing.Point(411, 15);
            this.btnCancelOfUpdate.Name = "btnCancelOfUpdate";
            this.btnCancelOfUpdate.Size = new System.Drawing.Size(86, 31);
            this.btnCancelOfUpdate.TabIndex = 16;
            this.btnCancelOfUpdate.Text = "Hủy thao tác";
            this.btnCancelOfUpdate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(285, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy thao tác";
            this.btnCancel.Visible = false;
            // 
            // StaffName
            // 
            this.StaffName.Caption = "Người lập";
            this.StaffName.FieldName = "StaffName";
            this.StaffName.Name = "StaffName";
            this.StaffName.OptionsColumn.ReadOnly = true;
            this.StaffName.Visible = true;
            this.StaffName.VisibleIndex = 10;
            this.StaffName.Width = 126;
            // 
            // panelOrderView
            // 
            this.panelOrderView.Controls.Add(this.grdListOrder);
            this.panelOrderView.Controls.Add(this.panOrderViewDatail);
            this.panelOrderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderView.Location = new System.Drawing.Point(0, 35);
            this.panelOrderView.Name = "panelOrderView";
            this.panelOrderView.Size = new System.Drawing.Size(1016, 401);
            this.panelOrderView.TabIndex = 9;
            // 
            // grdListOrder
            // 
            this.grdListOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdListOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListOrder.Location = new System.Drawing.Point(2, 31);
            this.grdListOrder.MainView = this.grdvListOrder;
            this.grdListOrder.Name = "grdListOrder";
            this.grdListOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rdateOrderBirthday});
            this.grdListOrder.Size = new System.Drawing.Size(1012, 368);
            this.grdListOrder.TabIndex = 2;
            this.grdListOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdvListOrder});
            // 
            // grdvListOrder
            // 
            this.grdvListOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OrderSno,
            this.OrderID,
            this.OrderName,
            this.TotalRoom,
            this.TotalService,
            this.Deposit,
            this.Total,
            this.StaffName,
            this.RoomNumber,
            this.Status,
            this.NumberOfPeople,
            this.OrderOfDate});
            this.grdvListOrder.GridControl = this.grdListOrder;
            this.grdvListOrder.Name = "grdvListOrder";
            this.grdvListOrder.OptionsView.ShowGroupPanel = false;
            // 
            // OrderSno
            // 
            this.OrderSno.Caption = "STT";
            this.OrderSno.FieldName = "STT";
            this.OrderSno.Name = "OrderSno";
            this.OrderSno.OptionsColumn.ReadOnly = true;
            this.OrderSno.Visible = true;
            this.OrderSno.VisibleIndex = 0;
            // 
            // OrderID
            // 
            this.OrderID.Caption = "Mã hóa đơn";
            this.OrderID.FieldName = "OrderID";
            this.OrderID.Name = "OrderID";
            this.OrderID.OptionsColumn.ReadOnly = true;
            this.OrderID.Visible = true;
            this.OrderID.VisibleIndex = 1;
            this.OrderID.Width = 116;
            // 
            // OrderName
            // 
            this.OrderName.Caption = "Tên khách hàng";
            this.OrderName.FieldName = "OrderName";
            this.OrderName.Name = "OrderName";
            this.OrderName.OptionsColumn.ReadOnly = true;
            this.OrderName.Visible = true;
            this.OrderName.VisibleIndex = 2;
            this.OrderName.Width = 116;
            // 
            // TotalRoom
            // 
            this.TotalRoom.Caption = "Tổng tiền phòng";
            this.TotalRoom.FieldName = "TotalRoom";
            this.TotalRoom.Name = "TotalRoom";
            this.TotalRoom.OptionsColumn.ReadOnly = true;
            this.TotalRoom.Visible = true;
            this.TotalRoom.VisibleIndex = 6;
            this.TotalRoom.Width = 109;
            // 
            // TotalService
            // 
            this.TotalService.Caption = "Tổng tiền dịch vụ";
            this.TotalService.ColumnEdit = this.rdateOrderBirthday;
            this.TotalService.FieldName = "TotalService";
            this.TotalService.Name = "TotalService";
            this.TotalService.OptionsColumn.ReadOnly = true;
            this.TotalService.Visible = true;
            this.TotalService.VisibleIndex = 7;
            this.TotalService.Width = 93;
            // 
            // rdateOrderBirthday
            // 
            this.rdateOrderBirthday.AutoHeight = false;
            this.rdateOrderBirthday.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateOrderBirthday.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rdateOrderBirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.rdateOrderBirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateOrderBirthday.EditFormat.FormatString = "dd/MM/yyyy";
            this.rdateOrderBirthday.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rdateOrderBirthday.Mask.EditMask = "dd/MM/yyyy";
            this.rdateOrderBirthday.Name = "rdateOrderBirthday";
            // 
            // Deposit
            // 
            this.Deposit.Caption = "Tiền đặt cọc";
            this.Deposit.FieldName = "Deposit";
            this.Deposit.Name = "Deposit";
            this.Deposit.Visible = true;
            this.Deposit.VisibleIndex = 8;
            this.Deposit.Width = 109;
            // 
            // Total
            // 
            this.Total.Caption = "Tổng tiền";
            this.Total.FieldName = "Email";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 9;
            this.Total.Width = 125;
            // 
            // panelOrderExecute
            // 
            this.panelOrderExecute.Controls.Add(this.btnSave);
            this.panelOrderExecute.Controls.Add(this.btnAdd);
            this.panelOrderExecute.Controls.Add(this.btnDelete);
            this.panelOrderExecute.Controls.Add(this.btnUpdate);
            this.panelOrderExecute.Controls.Add(this.btnCancelOfUpdate);
            this.panelOrderExecute.Controls.Add(this.btnCancel);
            this.panelOrderExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderExecute.Location = new System.Drawing.Point(0, 436);
            this.panelOrderExecute.Name = "panelOrderExecute";
            this.panelOrderExecute.Size = new System.Drawing.Size(1016, 58);
            this.panelOrderExecute.TabIndex = 8;
            // 
            // panelOrderTitles
            // 
            this.panelOrderTitles.Controls.Add(this.labOrderTitle);
            this.panelOrderTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderTitles.Location = new System.Drawing.Point(0, 0);
            this.panelOrderTitles.Name = "panelOrderTitles";
            this.panelOrderTitles.Size = new System.Drawing.Size(1016, 35);
            this.panelOrderTitles.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.Caption = "Trạng thái";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 11;
            // 
            // NumberOfPeople
            // 
            this.NumberOfPeople.Caption = "Số người";
            this.NumberOfPeople.FieldName = "NumberOfPeople";
            this.NumberOfPeople.Name = "NumberOfPeople";
            this.NumberOfPeople.Visible = true;
            this.NumberOfPeople.VisibleIndex = 4;
            // 
            // OrderOfDate
            // 
            this.OrderOfDate.Caption = "Ngày đặt";
            this.OrderOfDate.FieldName = "OrderOfDate";
            this.OrderOfDate.Name = "OrderOfDate";
            this.OrderOfDate.Visible = true;
            this.OrderOfDate.VisibleIndex = 5;
            // 
            // frmListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 494);
            this.Controls.Add(this.panelOrderView);
            this.Controls.Add(this.panelOrderExecute);
            this.Controls.Add(this.panelOrderTitles);
            this.Name = "frmListOrder";
            this.Text = "Danh sách đặt phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panOrderViewDatail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderView)).EndInit();
            this.panelOrderView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdvListOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateOrderBirthday.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdateOrderBirthday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderExecute)).EndInit();
            this.panelOrderExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelOrderTitles)).EndInit();
            this.panelOrderTitles.ResumeLayout(false);
            this.panelOrderTitles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.PanelControl panelOrderView;
        private DevExpress.XtraGrid.GridControl grdListOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView grdvListOrder;
        private DevExpress.XtraGrid.Columns.GridColumn OrderSno;
        private DevExpress.XtraGrid.Columns.GridColumn OrderID;
        private DevExpress.XtraGrid.Columns.GridColumn OrderName;
        private DevExpress.XtraGrid.Columns.GridColumn TotalRoom;
        private DevExpress.XtraGrid.Columns.GridColumn TotalService;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rdateOrderBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn Deposit;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        private DevExpress.XtraGrid.Columns.GridColumn StaffName;
        private DevExpress.XtraGrid.Columns.GridColumn RoomNumber;
        private DevExpress.XtraEditors.PanelControl panOrderViewDatail;
        private DevExpress.XtraEditors.PanelControl panelOrderExecute;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancelOfUpdate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.PanelControl panelOrderTitles;
        private DevExpress.XtraEditors.LabelControl labOrderTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn NumberOfPeople;
        private DevExpress.XtraGrid.Columns.GridColumn OrderOfDate;
    }
}