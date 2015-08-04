namespace HotelManager
{
    partial class XtraCustomMessageBox
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
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.labInfo = new DevExpress.XtraEditors.LabelControl();
            this.panelExecute = new DevExpress.XtraEditors.PanelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.panelView = new DevExpress.XtraEditors.PanelControl();
            this.picBoxImageShow = new System.Windows.Forms.PictureBox();
            this.panelLine = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelExecute)).BeginInit();
            this.panelExecute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(74, 11);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(70, 24);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Có";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(229, 11);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(71, 24);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "Không";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // labInfo
            // 
            this.labInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labInfo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labInfo.LineVisible = true;
            this.labInfo.Location = new System.Drawing.Point(22, 27);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(250, 14);
            this.labInfo.TabIndex = 1;
            this.labInfo.Text = "Nội dung";
            // 
            // panelExecute
            // 
            this.panelExecute.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelExecute.Controls.Add(this.btnOK);
            this.panelExecute.Controls.Add(this.btnYes);
            this.panelExecute.Controls.Add(this.btnNo);
            this.panelExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelExecute.Location = new System.Drawing.Point(0, 80);
            this.panelExecute.Name = "panelExecute";
            this.panelExecute.Size = new System.Drawing.Size(374, 45);
            this.panelExecute.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(149, 11);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Vâng";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panelView
            // 
            this.panelView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelView.Controls.Add(this.picBoxImageShow);
            this.panelView.Controls.Add(this.panelLine);
            this.panelView.Controls.Add(this.labInfo);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(374, 80);
            this.panelView.TabIndex = 1;
            // 
            // picBoxImageShow
            // 
            this.picBoxImageShow.InitialImage = null;
            this.picBoxImageShow.Location = new System.Drawing.Point(279, 0);
            this.picBoxImageShow.Name = "picBoxImageShow";
            this.picBoxImageShow.Size = new System.Drawing.Size(76, 76);
            this.picBoxImageShow.TabIndex = 3;
            this.picBoxImageShow.TabStop = false;
            // 
            // panelLine
            // 
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 78);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(374, 2);
            this.panelLine.TabIndex = 2;
            // 
            // XtraCustomMessageBox
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(374, 125);
            this.ControlBox = false;
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelExecute);
            this.Name = "XtraCustomMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.panelExecute)).EndInit();
            this.panelExecute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelView)).EndInit();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImageShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.LabelControl labInfo;
        private DevExpress.XtraEditors.PanelControl panelExecute;
        private DevExpress.XtraEditors.PanelControl panelView;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.PictureBox picBoxImageShow;
        private DevExpress.XtraEditors.PanelControl panelLine;
    }
}