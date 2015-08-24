using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HotelManager.General;

namespace HotelManager
{
    public partial class frmOrderSearch : DevExpress.XtraEditors.XtraForm
    {
        public frmOrderSearch()
        {
            InitializeComponent();
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }
    }
}