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
    public partial class frmSearchCustomer : Form
    {
        #region "Variable"
        private DTOCustomer customerObject;
        private BUSCustomer customerBUS;
        private DataTable customerDataTable;
        private GridCheckMarksSelection customerMultiSelect;
        private BUSRule ruleBUS;
        private int maxAge, minAge;

        //search
        private GridFilter _GridFilter;
        #endregion

        public frmSearchCustomer()
        {
            InitializeComponent();
            customerDataTable = new DataTable();
            customerBUS = new BUSCustomer();
            customerObject = new DTOCustomer();
            customerMultiSelect = new GridCheckMarksSelection(grdvListCustomer);
            ruleBUS = new BUSRule();
            CustomerSno.VisibleIndex = 1;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            customerDataTable = customerBUS.GetAllCustomer();
            grdListCustomer.DataSource = customerDataTable;
            //
            minAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiThieu"));
            maxAge = Int32.Parse(ruleBUS.GetRuleByLabel("DoTuoiNhanVienToiDa"));


            // -------------------------- search -------------------------- --------------

            // tag
            dateBirthDay.Tag = dateBirthDayMax;

            //search engine init
            _GridFilter = new GridFilter(grdvListCustomer);
            _GridFilter.AddTextbox("CustomerID", txtCustomerId);
            _GridFilter.AddTextbox("CustomerName", txtCustomerName);
            _GridFilter.AddTextbox("Gender", cmbCustomerGender, false);
            _GridFilter.AddDateControl("DateOfBirth", dateBirthDay);
            _GridFilter.AddTextbox("Address", txtCustomerAddress);
            _GridFilter.AddTextbox("PhoneNumber", txtCustomerPhone);
            _GridFilter.AddTextbox("Email", txtCustomerEmail);
            _GridFilter.AddTextbox("IDNumber", txtCMND);

            // assign
            dateBirthDayMax.DateTime = DateTime.Now.AddYears(-15);
            dateBirthDay.DateTime = dateBirthDayMax.DateTime.AddYears(-50);

            //event
            InitForSeachForm init = new InitForSeachForm();
            init.Init(this, _GridFilter, txtSearchDelay, rgrSearAfter);
            init.SearchWhenTextChanged(dateBirthDay);
            init.SearchWhenTextChanged(dateBirthDayMax);
            init.SearchWhenTextChanged(cmbCustomerGender);
        }

        private void txtCustomerNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }

        private void dateBirthDay_EditValueChanged(object sender, EventArgs e)
        {
            if (dateBirthDay.DateTime > DateTime.Now)
            {
                dateBirthDay.Focus();
                dxErrorProvider.SetError(dateBirthDay, "Ngày sinh không thể lớn hơn ngày hiện tại!");
            }
            else
            {
                dxErrorProvider.ClearErrors();
            }
        }

        private void txtCustomerEmail_Leave(object sender, EventArgs e)
        {
            if (!CheckInformationEntered.isEmail(txtCustomerEmail.Text.Trim()))
                dxErrorProvider.SetError(txtCustomerEmail, "Email không đúng định dạng!");
            else
                dxErrorProvider.ClearErrors();
        }

        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }
    }
}

namespace HotelManager
{
    public partial class frmCustomer : Form
    {
        private GridFilter _GridFilter;

        private void LoadSerach()
        {
            _GridFilter = new GridFilter(grdvListCustomer);
            _GridFilter.SetDelayTime(Properties.Settings.Default.searchDelayTime);
            _GridFilter.AddTextbox("CustomerName", txtCustomerNameLA, false);
        }

        private void txtCustomerNameLA_TextChanged(object sender, EventArgs e)
        {
            _GridFilter.StartFilter(true);
        }
    }
}