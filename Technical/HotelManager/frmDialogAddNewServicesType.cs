using BusinessLayer;
using DataTransferObject;
using DataTransferObject.Utils;
using HotelManager.General;
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
    public partial class frmDialogAddNewServicesType : DevExpress.XtraEditors.XtraForm
    {
        private BUSServicesType serviceTypeBUS;
        private DTOServicesType serviceTypeObject;
        public frmDialogAddNewServicesType()
        {
            InitializeComponent();
            //
            serviceTypeBUS = new BUSServicesType();
            //
            btnAdd.Enabled = false;
            txtServiceTypeName.Focus();
            txtServiceTypeId.Text = "LDV00000***";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!checkData())
            {
                return;
            }
            else
            {
                String serviceTypeName = Utils.standardNamePerson(txtServiceTypeName.Text);
                serviceTypeObject = new DTOServicesType("LDV0000000", serviceTypeName);

                if (serviceTypeBUS.InsertServicesType(serviceTypeObject))
                {
                    XtraCustomMessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", true, 1);
                    btnAdd.Enabled = true;
                    btnCancelAdd.Enabled = false;
                    btnCancelAdd.Visible = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    XtraCustomMessageBox.Show("Thêm dữ liệu thất bại!", "Lỗi", true, 4);
                }
            }
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            txtServiceTypeId.Text = null;
            txtServiceTypeName.Text = null;
            //
            btnAdd.Enabled = true;
            btnCancelAdd.Enabled = false;
            btnCancelAdd.Visible = false;
            btnSave.Enabled = false;
            //
            dxErrorProvider.ClearErrors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtServiceTypeId.Text = "LDV00000***";
            txtServiceTypeName.Text = null;
            txtServiceTypeName.Focus();
            //
            btnCancelAdd.Enabled = true;
            btnCancelAdd.Visible = true;
            btnSave.Enabled = true;
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtServiceTypeName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmDialogAddNewServiceType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnSave_Click(null, null);
            else
                if (e.KeyCode == Keys.F4)
                    btnAdd_Click(null, null);
                else
                    if (e.KeyCode == Keys.F6)
                        btnCancelAdd_Click(null, null);
                    else
                        if (e.KeyCode == Keys.Escape)
                            btnClose_Click(null, null);
        }
    }
}
