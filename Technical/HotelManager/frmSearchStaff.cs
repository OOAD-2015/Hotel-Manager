using BusinessLayer;
using DataTransferObject;
using DataTransferObject.AdvanceSearch;
using HotelManager.AdvanceSearch;
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
    public partial class frmSearchStaff : Form
    {
        #region "Variable"
        private DTORolePermission rolePermissionObject;
        private DataTable rolePermissionDataTable;
        private BUSRolePermission rolePermissionBUS;
        private DTOStaff staffObject;
        private BUSStaff staffBUS;
        private DataTable _StaffDT;
        private GridCheckMarksSelection staffMultiSelect;
        private BUSRule ruleBUS;
        private int maxAge, minAge;

        //search
        private GridFilter _GridFilter;
        #endregion

        public frmSearchStaff()
        {
            InitializeComponent();
            rolePermissionDataTable = new DataTable();
            rolePermissionBUS = new BUSRolePermission();
            rolePermissionObject = new DTORolePermission();
            _StaffDT = new DataTable();
            staffBUS = new BUSStaff();
            staffObject = new DTOStaff();
            staffMultiSelect = new GridCheckMarksSelection(grdvListStaff);
            ruleBUS = new BUSRule();
            StaffSno.VisibleIndex = 1;

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            //
            rolePermissionDataTable = rolePermissionBUS.GetAllRolePermission();
            lkStaffCharge.Properties.DataSource = rolePermissionDataTable;
            lkStaffCharge.Properties.DisplayMember = "RolePermissionName";
            lkStaffCharge.Properties.ValueMember = "RolePermissionID";
            //
            _StaffDT = staffBUS.GetAllStaff();
            grdListStaff.DataSource = _StaffDT;
            //
            minAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiThieu"));
            maxAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiDa"));


            // -------------------------- search -------------------------- --------------

            // tag
            dateBirthDay.Tag = dateBirthDayMax;

            dateToWork.Tag = dateToWorkMax;

            //search engine init
            _GridFilter = new GridFilter(grdvListStaff);
            _GridFilter.AddTextbox("StaffID", txtStaffId);
            _GridFilter.AddTextbox("StaffName", txtStaffName);
            _GridFilter.AddTextbox("Sex", cmbStaffGender, true, false);
            _GridFilter.AddDateControl("DateOfBirth", dateBirthDay);
            _GridFilter.AddTextbox("Address", txtStaffAddress);
            _GridFilter.AddTextbox("PhoneNumber", txtStaffPhone);
            _GridFilter.AddTextbox("Email", txtStaffEmail);
            _GridFilter.AddDateControl("DateCreated", dateToWork);
            _GridFilter.AddTextbox("RolePermissionID", lkStaffCharge, true, false);

            // assign
            dateToWorkMax.DateTime = DateTime.Now;
            dateToWork.DateTime = dateToWorkMax.DateTime.AddMonths(-3);
            dateBirthDayMax.DateTime = DateTime.Now.AddYears(-15);
            dateBirthDay.DateTime = dateBirthDayMax.DateTime.AddYears(-50);

            //event
            InitForSeachForm init = new InitForSeachForm();
            init.Init(this, _GridFilter, txtSearchDelay, rgrSearAfter);
            init.SearchWhenTextChanged(dateBirthDay);
            init.SearchWhenTextChanged(dateBirthDayMax);
            init.SearchWhenTextChanged(dateToWork);
            init.SearchWhenTextChanged(dateToWorkMax);
            init.SearchWhenTextChanged(lkStaffCharge);
            init.SearchWhenTextChanged(cmbStaffGender);
        }

        private void lkStaffCharge_QueryPopUp(object sender, CancelEventArgs e)
        {
            rolePermissionDataTable = rolePermissionBUS.GetAllRolePermission();
            DataRow dr = rolePermissionDataTable.NewRow();
            dr[0] = 0;
            dr[1] = "Tất cả";
            dr[2] = "Tất cả";
            rolePermissionDataTable.Rows.InsertAt(dr, 0);
            lkStaffCharge.Properties.DataSource = rolePermissionDataTable;
        }

        private void txtStaffNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }

        private void txtStaffEmail_Leave(object sender, EventArgs e)
        {
            if (!CheckInformationEntered.isEmail(txtStaffEmail.Text.Trim()))
                dxErrorProvider.SetError(txtStaffEmail, "Email không đúng định dạng!");
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtStaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void cmbStaffGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _GridFilter.StartFilter(false);
        }

        private void dateBirthDay_EditValueChanged(object sender, EventArgs e)
        {
            if (dateBirthDay.DateTime > DateTime.Now)
            {
                dateBirthDay.Focus();
                dxErrorProvider.SetError(dateBirthDay, "Ngày sinh không thể lớn hơn ngày hiện tại!");
            }
            else if (dateBirthDay.DateTime.AddYears(minAge) > DateTime.Now && dateBirthDay.DateTime.AddYears(maxAge) > DateTime.Now)
            {
                dateBirthDay.Focus();
                dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                //dateBirthDay.EditValue = null;
            }
            else
            {
                dxErrorProvider.ClearErrors();
            }
        }

        private void dateToWork_EditValueChanged(object sender, EventArgs e)
        {
            if (dateToWork.DateTime > DateTime.Now)
            {
                dateToWork.Focus();
                dxErrorProvider.SetError(dateToWork, "Ngày vào làm không thể lớn hơn ngày hiện tại!");
                return;
            }
            else
            {
                if (dateBirthDay.DateTime.AddYears(minAge) > DateTime.Now && dateBirthDay.DateTime.AddYears(maxAge) > DateTime.Now)
                {
                    dateBirthDay.Focus();
                    dxErrorProvider.SetError(dateBirthDay, "Độ tuổi không đúng với quy định!");
                    return;
                }
            }

            if (!String.IsNullOrEmpty(dateBirthDay.Text))
            {
                if (!staffBUS.checkAge(dateBirthDay.DateTime, dateToWork.DateTime))
                {
                    dateBirthDay.Focus();
                    dateToWork.EditValue = null;
                    dateToWork.Focus();
                    dxErrorProvider.SetError(dateToWork, "Độ tuổi không đúng với quy định!");
                }
                else
                {
                    dxErrorProvider.ClearErrors();
                }
            }
        }
    }
}


namespace HotelManager
{
    public partial class frmStaff : Form
    {
        private GridFilter _GridFilter;

        private void LoadSerach()
        {
            _GridFilter = new GridFilter(grdvListStaff);
            _GridFilter.SetDelayTime(Properties.Settings.Default.searchDelayTime);
            _GridFilter.AddTextbox("StaffName", txtStaffNameLA, false);
        }

        private void txtStaffNameLA_TextChanged(object sender, EventArgs e)
        {
            _GridFilter.StartFilter(true);
        }
    }
}
