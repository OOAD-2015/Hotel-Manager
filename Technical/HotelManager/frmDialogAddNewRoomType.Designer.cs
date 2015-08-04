namespace HotelManager
{
    partial class frmDialogAddNewRoomType
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
            this.txtRoomTypeId = new DevExpress.XtraEditors.TextEdit();
            this.txtRoomTypeName = new DevExpress.XtraEditors.TextEdit();
            this.lblRoomTypeId = new DevExpress.XtraEditors.LabelControl();
            this.lblRoomTypeName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomTypeId
            // 
            this.txtRoomTypeId.Location = new System.Drawing.Point(86, 52);
            this.txtRoomTypeId.Name = "txtRoomTypeId";
            this.txtRoomTypeId.Properties.ReadOnly = true;
            this.txtRoomTypeId.Size = new System.Drawing.Size(150, 20);
            this.txtRoomTypeId.TabIndex = 18;
            // 
            // txtRoomTypeName
            // 
            this.txtRoomTypeName.Location = new System.Drawing.Point(325, 52);
            this.txtRoomTypeName.Name = "txtRoomTypeName";
            this.txtRoomTypeName.Properties.MaxLength = 100;
            this.txtRoomTypeName.Size = new System.Drawing.Size(214, 20);
            this.txtRoomTypeName.TabIndex = 0;
            // 
            // lblRoomTypeId
            // 
            this.lblRoomTypeId.Location = new System.Drawing.Point(10, 55);
            this.lblRoomTypeId.Name = "lblRoomTypeId";
            this.lblRoomTypeId.Size = new System.Drawing.Size(73, 13);
            this.lblRoomTypeId.TabIndex = 14;
            this.lblRoomTypeId.Text = "Mã Loại Phòng:";
            // 
            // lblRoomTypeName
            // 
            this.lblRoomTypeName.Location = new System.Drawing.Point(250, 55);
            this.lblRoomTypeName.Name = "lblRoomTypeName";
            this.lblRoomTypeName.Size = new System.Drawing.Size(74, 13);
            this.lblRoomTypeName.TabIndex = 15;
            this.lblRoomTypeName.Text = "Tên loại phòng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnCancelAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 100);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(561, 49);
            this.panelControl1.TabIndex = 19;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(416, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "(Esc)Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "(F2)Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(172, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(F4)Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(50, 8);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(94, 32);
            this.btnCancelAdd.TabIndex = 4;
            this.btnCancelAdd.Text = "(F6)Hủy thao tác";
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblTitle);
            this.panelControl2.Controls.Add(this.lblRoomTypeName);
            this.panelControl2.Controls.Add(this.lblRoomTypeId);
            this.panelControl2.Controls.Add(this.txtRoomTypeName);
            this.panelControl2.Controls.Add(this.txtRoomTypeId);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(561, 100);
            this.panelControl2.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitle.Location = new System.Drawing.Point(169, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 28);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "THÊM MỚI LOẠI PHÒNG";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmDialogAddNewRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 149);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Metropolis";
            this.Name = "frmDialogAddNewRoomType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogAddNewRoomType";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDialogAddNewRoomType_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoomTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRoomTypeId;
        private DevExpress.XtraEditors.TextEdit txtRoomTypeName;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeId;
        private DevExpress.XtraEditors.LabelControl lblRoomTypeName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnCancelAdd;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
    }
}