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
    public partial class frmDialogAddNewRoomType : DevExpress.XtraEditors.XtraForm
    {
         private BUSRoomType roomTypeBUS;
        private DTORoomType roomTypeObject;
        public frmDialogAddNewRoomType()
        {
            InitializeComponent();
            //
            roomTypeBUS = new BUSRoomType();
            //
            btnAdd.Enabled = false;
            txtRoomTypeName.Focus();
            txtRoomTypeId.Text = "LP00000***";
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
                String roomTypeName = Utils.standardNamePerson(txtRoomTypeName.Text);
                roomTypeObject = new DTORoomType("LP0000000", roomTypeName);

                if (roomTypeBUS.InsertRoomType(roomTypeObject))
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
            txtRoomTypeId.Text = null;
            txtRoomTypeName.Text = null;
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
            txtRoomTypeId.Text = "LP00000***";
            txtRoomTypeName.Text = null;
            txtRoomTypeName.Focus();
            //
            btnCancelAdd.Enabled = true;
            btnCancelAdd.Visible = true;
            btnSave.Enabled = true;
        }

        private bool checkData()
        {
            if (CheckInformationEntered.checkDataInput(txtRoomTypeName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
                return false;

        }

        private void frmDialogAddNewRoomType_KeyDown(object sender, KeyEventArgs e)
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
