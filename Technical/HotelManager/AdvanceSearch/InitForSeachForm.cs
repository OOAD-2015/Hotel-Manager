using DataTransferObject.AdvanceSearch;
using DevExpress.XtraEditors;
using HotelManager.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.AdvanceSearch
{
    class InitForSeachForm
    {
        RadioGroup _rgrSearAfter;
        TextEdit _txtSearchDelay;
        GridFilter _GridFilter;

        public bool Init(Form form, GridFilter gridFilter, TextEdit txtSearchDelay, RadioGroup rgrSearAfter)
        {
            _rgrSearAfter = rgrSearAfter;
            _txtSearchDelay = txtSearchDelay;
            _GridFilter = gridFilter;

            // event
            form.KeyPress += frmSearch_Staff_KeyPress;
            txtSearchDelay.KeyPress += txtSearchDelay_KeyPress;
            txtSearchDelay.TextChanged += txtSearchDelay_TextChanged;
            rgrSearAfter.SelectedIndexChanged += rgrSearAfter_SelectedIndexChanged;

            // assign
            form.KeyPreview = true;
            rgrSearAfter.SelectedIndex = Properties.Settings.Default.rgrSearchAfter;
            txtSearchDelay.Text = Properties.Settings.Default.searchDelayTime.ToString();

            return true;
        }

        public void SearchWhenTextChanged(Control control)
        {
            control.TextChanged += (object sender, EventArgs e) =>
            {
                _GridFilter.StartFilter(false);
            };
        }

        public void onlyNumberic_KeyPress(Control control)
        {
            control.KeyPress += onlyNumberic_KeyPress;
        }

        public void onlyCharacter_KeyPress(Control control)
        {
            control.KeyPress += onlyCharacter_KeyPress;
        }

        private void rgrSearAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.rgrSearchAfter = _rgrSearAfter.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void txtSearchDelay_TextChanged(object sender, EventArgs e)
        {
            int time;
            try
            {
                time = int.Parse(_txtSearchDelay.Text);
            }
            catch
            {
                time = 500;
            }

            _GridFilter.SetDelayTime(time);
            Properties.Settings.Default.searchDelayTime = time;
            Properties.Settings.Default.Save();
        }

        private void frmSearch_Staff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // search khi bấm phím enter
                _GridFilter.StartFilter(false);
            else
            {
                if (_rgrSearAfter.SelectedIndex != 0)
                    _GridFilter.StartFilter(true);
            }
        }

        private void txtSearchDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void onlyCharacter_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 3);
        }

        private void onlyNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

    }
}
