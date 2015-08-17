using BusinessLayer;
using DataTransferObject.AdvanceSearch;
using DataTransferObject.Utils;
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
    public partial class frmSearchRoom : Form
    {
        #region "variable"
        private GridCheckMarksSelection roomsMulitSelect;
        private BUSRoom roomBUS;
        private DataTable roomDataTable;
        private DataTable statusDataTable;
        private DataTable roomTypeDataTable;
        private BUSStatus statusBUS;
        private BUSRoomType roomTypeBUS;

        //search
        private GridFilter _GridFilter;
        #endregion
        public frmSearchRoom()
        {
            InitializeComponent();
            statusDataTable = new DataTable();
            roomTypeDataTable = new DataTable();
            statusBUS = new BUSStatus();
            roomTypeBUS = new BUSRoomType();
            roomsMulitSelect = new GridCheckMarksSelection(grdvListRooms);
            roomBUS = new BUSRoom();
            roomDataTable = new DataTable();        
            RoomsSno.VisibleIndex = 1;
        }

        private void frmRooms_Load(object sender, EventArgs e)
        {
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            //Binding data
            lkRoomTypeName.Properties.DataSource = roomTypeDataTable;
            lkRoomTypeName.Properties.DisplayMember = "RoomTypeName";
            lkRoomTypeName.Properties.ValueMember = "RoomTypeID";
            //
            statusDataTable = statusBUS.GetAllStatus();
            lkStatus.Properties.DataSource = statusDataTable;
            lkStatus.Properties.DisplayMember = "StatusName";
            lkStatus.Properties.ValueMember = "StatusID";
            //
            roomDataTable = roomBUS.GetAllRoomWithDate();
            grdListRooms.DataSource = roomDataTable;


            // -------------------------- search -------------------------- --------------

            // tag range

            //search engine init
            _GridFilter = new GridFilter(grdvListRooms);
            _GridFilter.AddTextbox("RoomID", txtRoomId);
            _GridFilter.AddTextbox("RoomName", txtRoomName);
            _GridFilter.AddTextbox("RoomTypeID", lkRoomTypeName, true, false);
            _GridFilter.AddTextbox("StatusID", lkStatus, true, false);
            _GridFilter.AddTextbox("NumberOfBeds", txtNumberOfBeds, true, false);
            _GridFilter.AddDateControl("StartDate", dateFrom, true, false);
            _GridFilter.AddDateControl("EndDate", dateTo, true, false);

            dateFrom.DateTime = DateTime.Now;
            dateTo.DateTime = DateTime.Now;

            InitForSeachForm init = new InitForSeachForm();
            init.Init(this, _GridFilter, txtSearchDelay, rgrSearAfter);

            init.SearchWhenTextChanged(lkRoomTypeName);
            init.SearchWhenTextChanged(dateFrom);
            init.SearchWhenTextChanged(dateTo);
            init.SearchWhenTextChanged(lkStatus);
            init.SearchWhenTextChanged(txtNumberOfBeds);
            init.SearchWhenTextChanged(txtRoomName);
            // assign 
        } 

        private void txtRoomsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 3);
        }

        private bool checkData()
        {
            if(CheckInformationEntered.checkDataInput(lkRoomTypeName,Utils.errorMessage,ref dxErrorProvider)&&
                CheckInformationEntered.checkDataInput(txtRoomName, Utils.errorMessage, ref dxErrorProvider))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lkRoomTypeName_QueryPopUp(object sender, CancelEventArgs e)
        {
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            DataRow dr = roomTypeDataTable.NewRow();
            dr[0] = 0;
            dr[1] = "Tất cả";
            dr[2] = "Tất cả";
            roomTypeDataTable.Rows.InsertAt(dr, 0);
            lkRoomTypeName.Properties.DataSource = roomTypeDataTable;
        }

        private void lkStatus_QueryPopUp(object sender, CancelEventArgs e)
        {
            statusDataTable = statusBUS.GetAllStatus();
            DataRow dr = statusDataTable.NewRow();
            dr[0] = 0;
            dr[1] = "Tất cả";
            dr[2] = "Tất cả";
            statusDataTable.Rows.InsertAt(dr, 0);
            lkStatus.Properties.DataSource = statusDataTable;
        }

        private void txtRoomNameLA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 0);
        }
    }
}


namespace HotelManager
{
    public partial class frmRoom
    {
        private GridFilter _GridFilter;

        private void LoadSerach()
        {
            _GridFilter = new GridFilter(grdvListRoom);
            _GridFilter.SetDelayTime(Properties.Settings.Default.searchDelayTime);
            _GridFilter.AddTextbox("RoomName", txtRoomNameLA, false);
        }

        private void txtRoomNameLA_TextChanged(object sender, EventArgs e)
        {
            _GridFilter.StartFilter(true);
        }
    }
}