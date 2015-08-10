namespace HotelManager
{
    partial class frmDialogAddNewRolePermission
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
            this.txtRolePermissionId = new DevExpress.XtraEditors.TextEdit();
            this.txtRolePermissionName = new DevExpress.XtraEditors.TextEdit();
            this.lblRolePermissionId = new DevExpress.XtraEditors.LabelControl();
            this.lblRolePermissionName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtRolePermissionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRolePermissionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRolePermissionId
            // 
            this.txtRolePermissionId.Location = new System.Drawing.Point(86, 52);
            this.txtRolePermissionId.Name = "txtRolePermissionId";
            this.txtRolePermissionId.Properties.ReadOnly = true;
            this.txtRolePermissionId.Size = new System.Drawing.Size(150, 20);
            this.txtRolePermissionId.TabIndex = 18;
            // 
            // txtRolePermissionName
            // 
            this.txtRolePermissionName.Location = new System.Drawing.Point(325, 52);
            this.txtRolePermissionName.Name = "txtRolePermissionName";
            this.txtRolePermissionName.Properties.MaxLength = 100;
            this.txtRolePermissionName.Size = new System.Drawing.Size(214, 20);
            this.txtRolePermissionName.TabIndex = 0;
            // 
            // lblRolePermissionId
            // 
            this.lblRolePermissionId.Location = new System.Drawing.Point(24, 55);
            this.lblRolePermissionId.Name = "lblRolePermissionId";
            this.lblRolePermissionId.Size = new System.Drawing.Size(59, 13);
            this.lblRolePermissionId.TabIndex = 14;
            this.lblRolePermissionId.Text = "Mã chức vụ:";
            // 
            // lblRolePermissionName
            // 
            this.lblRolePermissionName.Location = new System.Drawing.Point(259, 55);
            this.lblRolePermissionName.Name = "lblRolePermissionName";
            this.lblRolePermissionName.Size = new System.Drawing.Size(63, 13);
            this.lblRolePermissionName.TabIndex = 15;
            this.lblRolePermissionName.Text = "Tên chức vụ:";
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
            this.btnClose.Location = new System.Drawing.Point(363, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "(Esc)Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(236, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "(F2)Lưu xuống";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "(F4)Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(108, 8);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(94, 32);
            this.btnCancelAdd.TabIndex = 4;
            this.btnCancelAdd.Text = "(F6)Hủy thao tác";
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lblTitle);
            this.panelControl2.Controls.Add(this.lblRolePermissionName);
            this.panelControl2.Controls.Add(this.lblRolePermissionId);
            this.panelControl2.Controls.Add(this.txtRolePermissionName);
            this.panelControl2.Controls.Add(this.txtRolePermissionId);
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
            this.lblTitle.Size = new System.Drawing.Size(238, 28);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "THÊM MỚI CHỨC VỤ";
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // frmDialogAddNewRolePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 149);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.LookAndFeel.SkinName = "Metropolis";
            this.Name = "frmDialogAddNewRolePermission";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDialogAddNewRolePermission";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDialogAddNewRolePermission_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtRolePermissionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRolePermissionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtRolePermissionId;
        private DevExpress.XtraEditors.TextEdit txtRolePermissionName;
        private DevExpress.XtraEditors.LabelControl lblRolePermissionId;
        private DevExpress.XtraEditors.LabelControl lblRolePermissionName;
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