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
using BusinessLayer;
using System.Collections;
using DevExpress.Skins;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Drawing;

namespace HotelManager
{
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        #region "variable"
        private GridCheckMarksSelection roomMulitiSelect;
        private GridCheckMarksSelection roomSelectsMulitiSelect;
        private BUSRoomType roomTypeBUS;
        private DataTable customerDataTable;
        private BUSCustomer customerBUS;
        private DataTable roomTypeDataTable;
        private DataTable roomResultDataTable;
        private DataTable roomResultDataTableClone;
        #endregion
        //Sang test
        private BUSRoom roomBUS;
        private DataTable roomSelectsDataTable;
        public frmOrder()
        {
            InitializeComponent();
            roomTypeBUS = new BUSRoomType();
            //roomMulitiSelect = new GridCheckMarksSelection();
            customerBUS = new BUSCustomer();
            //Test
            roomBUS = new BUSRoom();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            OrderOfDate.EditValue = DateTime.Now;
            dateStart.EditValue = DateTime.Now;
            dateEnd.EditValue = DateTime.Now;
            //            
            //roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            //lkRoomType.Properties.DataSource = roomTypeDataTable;
            //lkRoomType.Properties.DisplayMember = "RoomTypeName";
            //lkRoomType.Properties.ValueMember = "RoomTypeID";
            //
            roomTypeDataTable = roomTypeBUS.GetAllRoomType();
            chkCmbRoomTypeName.Properties.DataSource = roomTypeDataTable;
            chkCmbRoomTypeName.Properties.DisplayMember = "RoomTypeName";
            chkCmbRoomTypeName.Properties.ValueMember = "RoomTypeID";
            chkCmbRoomTypeName.CheckAll();
            //
            customerDataTable = customerBUS.GetAllCustomer();
            lkCustomer.Properties.DataSource = customerDataTable;
            lkCustomer.Properties.DisplayMember = "CustomerName";
            lkCustomer.Properties.ValueMember = "CustomerID";

            //
            grdColRomSno.VisibleIndex = 1;
            roomResultDataTable = roomBUS.GetAllRoom();
            roomResultDataTableClone = roomBUS.GetAllRoom();
            roomMulitiSelect = new GridCheckMarksSelection(grdvSearchRoomResult);
            grdSearchRoomResult.DataSource = roomResultDataTableClone;
            //
            grdCol1RoomSno.VisibleIndex = 1;
            roomSelectsMulitiSelect = new GridCheckMarksSelection(grdvListRoom);
            roomSelectsDataTable = new DataTable();
            makeDataTable(new string[] { "RoomID", "RoomName", "RoomTypeName", "StartDate", "EndDate", "NumberOfBeds", "Price", "Monetized", "StatusName" }, ref roomSelectsDataTable);
            grdListRoom.DataSource = roomSelectsDataTable;
            //grdListRoom.DataSource = roomResultDataTable;
            //
            grdvListRoom.OptionsSelection.EnableAppearanceFocusedRow = false;
            grdvListRoom.Columns["CheckMarkSelection"].OptionsColumn.AllowEdit = true;

           
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            (new frmCustomer()).ShowDialog();
        }

        private void lkCustomer_EditValueChanged(object sender, EventArgs e)
        {
            if(sender is LookUpEdit)
            {
                LookUpEdit lkTemp = sender as LookUpEdit;
                txtCustomerID.Text = lkTemp.EditValue.ToString();
                DataRowView rowView = (DataRowView)lkTemp.GetSelectedDataRow();
                DataRow row = rowView.Row;
                txtAddress.Text = row["Address"].ToString();
                txtNumberID.Text = row["IDNumber"].ToString();
            }
        }

        private void txtNumberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInformationEntered.checkCharacterInput(e, 1);
        }

        private void dateEnd_EditValueChanged(object sender, EventArgs e)
        {
            if(!CheckInformationEntered.checkDate(dateEnd.DateTime, dateStart.DateTime))
            {
                if (dateEnd.EditValue != null)
                {
                    dateEnd.EditValue = null;
                    XtraCustomMessageBox.Show("Ngày đi không được nhỏ hơn ngày đến! \nXin vui lòng nhập lại", "Thông báo", true, 4);
                }
            
            }
        }

        private void dateStart_EditValueChanged(object sender, EventArgs e)
        {
            if (!CheckInformationEntered.checkDate(dateStart.DateTime, DateTime.Now))
            {
                if (dateStart.EditValue != null)
                {
                    dateStart.EditValue = null;
                    XtraCustomMessageBox.Show("Ngày đến không được nhỏ hơn ngày hiện tại! \nXin vui lòng nhập lại", "Thông báo", true, 4);
                }
            }
        }

        private void btnCancelChooseRoom_Click(object sender, EventArgs e)
        {
            roomMulitiSelect.ClearSelection();
        }

        private void btnAcceptChooseRoom_Click(object sender, EventArgs e)
        {
           
            ArrayList rowViews =  roomMulitiSelect.Selection;
            if (rowViews.Count > 0)
            {
                foreach (DataRowView rowView in rowViews)
                {
                    DataRow row = rowView.Row;
                    DataRow newRow = copyToRow(row, ref roomSelectsDataTable, true);
                    roomResultDataTableClone.Rows.Remove(row);
                    //
                    roomSelectsDataTable.Rows.Add(newRow);

                }

                roomResultDataTableClone = DataTableCustomize.AutoNumberedTable(roomResultDataTableClone);
                grdSearchRoomResult.DataSource = roomResultDataTableClone;
                //
                roomSelectsDataTable = DataTableCustomize.AutoNumberedTable(roomSelectsDataTable);
                grdListRoom.DataSource = roomSelectsDataTable;
                //Set gia tri
                spinTotalRoom.Text = roomSelectsDataTable.Rows.Count.ToString();
                if (grdCol1NumberOfPeople.SummaryItem.SummaryValue != null)
                    spinTotalPeople.Text = grdCol1NumberOfPeople.SummaryItem.SummaryValue.ToString();
                else
                    spinTotalPeople.Text = "0";
                if (grdCol1Monetized.SummaryItem.SummaryValue != null)
                    spintotalEstimate.Text = grdCol1Monetized.SummaryItem.SummaryValue.ToString();
                else
                    spintotalEstimate.Text = "0";
                roomMulitiSelect.ClearSelection();
            }
        }

        private DataRow copyToRow(DataRow sourceRow,ref DataTable destDataTable, bool isListRoomTable)
        {
            DataRow newRow = destDataTable.NewRow();
            newRow["RoomID"] = sourceRow["RoomID"];
            newRow["RoomName"] = sourceRow["RoomName"];
            newRow["RoomTypeName"] = sourceRow["RoomTypeName"];
            newRow["NumberOfBeds"] = sourceRow["NumberOfBeds"];
            newRow["StatusName"] = sourceRow["StatusName"];
            //newRow["Price"] = sourceRow["Price"];
            if (isListRoomTable)
            {
                newRow["StartDate"] = dateStart.DateTime;
                newRow["EndDate"] = dateEnd.DateTime;
                double dateDiff = (dateEnd.DateTime - dateStart.DateTime).Days;
                newRow["Monetized"] = ((dateDiff == 0) ? 1 : dateDiff + 1) * 1000;
            }
            return newRow;
        }

        private void makeDataTable(string[] columnNames, ref DataTable dataTable)
        {
            foreach (string columnCaption in columnNames)
            {
                DataColumn newColumn = new DataColumn();
                newColumn.ColumnName = columnCaption;
                newColumn.DataType = System.Type.GetType("System.String");
                dataTable.Columns.Add(newColumn);
            }
        }

        private void grpListRoom_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button == grpListRoom.CustomHeaderButtons[0])
            {
                ArrayList rowViews = roomSelectsMulitiSelect.Selection;
                foreach (DataRowView rowView in rowViews)
                {
                    DataRow row = rowView.Row;
                    roomSelectsDataTable.Rows.Remove(row);

                }
                grdListRoom.DataSource = roomSelectsDataTable;
                roomSelectsMulitiSelect.ClearSelection();
            }
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            ArrayList rowViews = roomSelectsMulitiSelect.Selection;
            if (rowViews.Count > 0)
            {
                foreach (DataRowView rowView in rowViews)
                {
                    DataRow row = rowView.Row;
                    DataRow newRow = copyToRow(row, ref roomResultDataTableClone, false);
                    roomSelectsDataTable.Rows.Remove(row);
                    //

                    roomResultDataTableClone.Rows.Add(newRow);

                }
                roomResultDataTableClone = DataTableCustomize.AutoNumberedTable(roomResultDataTableClone);
                grdSearchRoomResult.DataSource = roomResultDataTableClone;
                roomSelectsDataTable = DataTableCustomize.AutoNumberedTable(roomSelectsDataTable);
                grdListRoom.DataSource = roomSelectsDataTable;
                //reset gia tri o tinh
                spinTotalRoom.Text = roomSelectsDataTable.Rows.Count.ToString();
                if (grdCol1NumberOfPeople.SummaryItem.SummaryValue != null)
                    spinTotalPeople.Text = grdCol1NumberOfPeople.SummaryItem.SummaryValue.ToString();
                else
                    spinTotalPeople.Text = "0";
                if (grdCol1Monetized.SummaryItem.SummaryValue != null)
                    spintotalEstimate.Text = grdCol1Monetized.SummaryItem.SummaryValue.ToString();
                else
                    spintotalEstimate.Text = "0";
                roomSelectsMulitiSelect.ClearSelection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            roomMulitiSelect.ClearSelection();
            if (roomResultDataTable == null || roomResultDataTable.Rows.Count == 0)
            {
                XtraCustomMessageBox.Show("Không tìm thấy dữ liệu nào!", "Thông báo", true,  1);
                return;
            }
            string[] roomTypeIDs = (chkCmbRoomTypeName.EditValue.ToString()).Split(',');
            if (roomTypeIDs.Count() == 0)
            {
                XtraCustomMessageBox.Show("Bạn chưa chọn loại phòng!", "Thông báo", true, 1);
                return;
            }
            string expression = "RoomTypeID IN (";
            for (int i = 0; i <  roomTypeIDs.Count(); ++i)
            {
                expression += "'" + roomTypeIDs[i] + "'";
                if(i < roomTypeIDs.Count() - 1)
                {
                    expression += ", ";
                }
            }
            expression += ")";
            DataRow[] foundRows;
            foundRows = roomResultDataTable.Select(expression);
          //  DataRow newRow = roomResultDataTable.NewRow();
            roomResultDataTableClone = roomResultDataTableClone.Clone();
            foreach (DataRow row in foundRows)
            {
                if (!this.checkRowValue(ref roomSelectsDataTable , row))
                {
                    DataRow newRow = this.copyToRow(row, ref roomResultDataTableClone, false);
                    roomResultDataTableClone.Rows.Add(newRow);
                }
            }
            roomResultDataTableClone = DataTableCustomize.AutoNumberedTable(roomResultDataTableClone);
            grdSearchRoomResult.DataSource = roomResultDataTableClone;
        }

        private bool checkRowValue(ref DataTable destResource, DataRow value){
            if(destResource == null || destResource.Rows.Count == 0)
            {
                return false;
            }
            foreach (DataRow row in destResource.Rows)
            {
                if (value["RoomID"] == row["RoomID"])
                    return true;
            }
            return false;
        }
    }   
}