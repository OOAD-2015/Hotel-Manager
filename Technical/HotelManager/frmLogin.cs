using BusinessLayer;
using DevExpress.XtraEditors;
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
    public partial class frmLogin : Form
    {
        private BUSStaff staffBUS;

        public frmLogin()
        {
            InitializeComponent();
            staffBUS = new BUSStaff();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin(txtUsername.Text, txtPassword.Text);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  CheckLogin(txtUsername.Text, txtPassword.Text);
            }
        }

        #region "FUNCTION"

        private void CheckLogin(string strUsername, string strPassword)
        {
            try
            {
                if (txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    XtraMessageBox.Show("Tên đăng nhập hoặc password chưa được nhập. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Text = null;
                    txtUsername.Text = null;
                    txtUsername.Focus();
                }
                else
                {
                    if (staffBUS.CheckLoginToSystem(strUsername, strPassword))
                    {
                        frmHomePage frmHomePage = new frmHomePage();
                        frmHomePage.staffLogin = staffBUS.GetStaffByUserNameToObject(strUsername);
                        frmHomePage.Show();
                        this.Hide();

                    }
                    else
                    {
                        XtraMessageBox.Show("Tên đăng nhập hoặc password không đúng. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Text = null;
                        txtPassword.Text = null;
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion
    }
}
