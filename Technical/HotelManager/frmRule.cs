using BusinessLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class frmRule : Form
    {
        #region "Variable"
        private BUSRule ruleBUS;
        private DTORule ruleObject1, ruleObject2, ruleObject3,
            ruleObject4, ruleObject5, ruleObject6, ruleObject7,
            ruleObject8, ruleObject9, ruleObject10;
        #endregion
        public frmRule()
        {
            InitializeComponent();
        }

        private void frmRule_Load(object sender, EventArgs e)
        {
            ruleBUS = new BUSRule();

            spMinimumAge.EditValue = ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiThieu");
            spMaximumAge.EditValue = ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiDa");
            //
            spTax.EditValue = ruleBUS.GetRuleByLabel("ThueTNDN");
            //
            txtNameSystem.Text = ruleBUS.GetRuleByLabel("TenKhachSan");
            txtAddress.Text = ruleBUS.GetRuleByLabel("DiaChi");
            txtTaxId.Text = ruleBUS.GetRuleByLabel("MaSoThue");
            txtEmail.Text = ruleBUS.GetRuleByLabel("Email");
            txtPhone.Text = ruleBUS.GetRuleByLabel("Fax");
            txtWebsite.Text = ruleBUS.GetRuleByLabel("Website");
            txtFaxNumber.Text = ruleBUS.GetRuleByLabel("MaSoThue");
            //
            btnCancelUpdate.Visible = false;
            btnSave.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ruleObject1 = new DTORule("1", "DoTuoiNhanVienToiThieu", spMinimumAge.Value.ToString());
            ruleObject2 = new DTORule("2", "DoTuoiNhanVienToiDa", spMaximumAge.Value.ToString());
            //
            ruleObject3 = new DTORule("3", "ThueTNDN", spTax.Value.ToString());
            //
            ruleObject4 = new DTORule("4", "TenKhachSan", txtNameSystem.Text.Trim());
            ruleObject5 = new DTORule("5", "DiaChi", txtAddress.Text.Trim());
            ruleObject6 = new DTORule("6", "Email", txtEmail.Text.Trim());
            ruleObject7 = new DTORule("7", "DienThoai", txtPhone.Text.Trim());
            ruleObject8 = new DTORule("8", "Fax", txtFaxNumber.Text.Trim());
            ruleObject9 = new DTORule("9", "MaSoThue", txtTaxId.Text.Trim());
            ruleObject10 = new DTORule("10", "Website", txtWebsite.Text.Trim());

            if (ruleBUS.UpdateRule(ruleObject1) && ruleBUS.UpdateRule(ruleObject2) &&
                ruleBUS.UpdateRule(ruleObject3) && ruleBUS.UpdateRule(ruleObject4) &&
                ruleBUS.UpdateRule(ruleObject5) && ruleBUS.UpdateRule(ruleObject6) &&
                ruleBUS.UpdateRule(ruleObject7) && ruleBUS.UpdateRule(ruleObject8) &&
                ruleBUS.UpdateRule(ruleObject9) && ruleBUS.UpdateRule(ruleObject10))
            {
                XtraCustomMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", true, 1);
            }
            else
                XtraCustomMessageBox.Show("Cập nhật dữ liệu thất bại!", "Lỗi", true, 4);

            //
            btnCancelUpdate.Enabled = false;
            btnCancelUpdate.Visible = false;
            btnUpdate.Visible = true;
            btnUpdate.Enabled = true;
            btnSave.Enabled = false;
            //
            btnCancelUpdate_Click(null, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancelUpdate.Enabled = true;
            btnCancelUpdate.Visible = true;
            btnUpdate.Visible = false;
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            //
            spTax.Properties.ReadOnly = false;
            spMinimumAge.Properties.ReadOnly = false;
            spMaximumAge.Properties.ReadOnly = false;
            spTax.Properties.ReadOnly = false;
            //
            txtAddress.Properties.ReadOnly = false;
            txtNameSystem.Properties.ReadOnly = false;
            txtTaxId.Properties.ReadOnly = false;
            txtEmail.Properties.ReadOnly = false;
            txtPhone.Properties.ReadOnly = false;
            txtWebsite.Properties.ReadOnly = false;
            txtFaxNumber.Properties.ReadOnly = false;
        }
        private void navBarItemRule_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grpRule.Visible = true;
            //
            grpEmployeeRelations.Visible = false;
            grpInfoSytem.Visible = false;
            grpTax.Visible = false;
        }
        private void navBarItemEmployeeRegulation_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grpEmployeeRelations.Visible = true;
            //
            grpRule.Visible = false;
            grpInfoSytem.Visible = false;
            grpTax.Visible = false;
        }
        private void navBarItemTax_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grpTax.Visible = true;
            //
            grpEmployeeRelations.Visible = false;
            grpRule.Visible = false;
            grpInfoSytem.Visible = false;
        }
        private void navBarItemInfoSystem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            grpInfoSytem.Visible = true;
            //
            grpEmployeeRelations.Visible = false;
            grpRule.Visible = false;
            grpTax.Visible = false;
        }
        private void spMinimumAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' || e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void spMaximumAge_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }
        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            btnCancelUpdate.Enabled = false;
            btnCancelUpdate.Visible = false;
            //
            spTax.Properties.ReadOnly = true;
            spMinimumAge.Properties.ReadOnly = true;
            spMaximumAge.Properties.ReadOnly = true;
            spTax.Properties.ReadOnly = true;
            //
            txtAddress.Properties.ReadOnly = true;
            txtNameSystem.Properties.ReadOnly = true;
            txtTaxId.Properties.ReadOnly = true;
            txtEmail.Properties.ReadOnly = true;
            txtPhone.Properties.ReadOnly = true;
            txtWebsite.Properties.ReadOnly = true;
            txtFaxNumber.Properties.ReadOnly = true;
            //
            frmRule_Load(null, null);
        }
        private void frmRule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnSave_Click(null, null);
            else
                if (e.KeyCode == Keys.F4)
                    btnUpdate_Click(null, null);
                else
                    if (e.KeyCode == Keys.Escape)
                        btnCancelUpdate_Click(null, null);
        }
    }
}
