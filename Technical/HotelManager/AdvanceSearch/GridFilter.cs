using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using HotelManager.AdvanceSearch;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DataTransferObject.AdvanceSearch
{
    class GridFilter
    {
        protected GridView _GridView;
        protected DataRowCollection _RowCollection;

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, RelativeSearch> _SearchMap = new Dictionary<int, RelativeSearch>();

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, BaseEdit> _ControlMap = new Dictionary<int, BaseEdit>();
        protected Timer _Timer = new Timer();

        #region external

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, DateTimeRange> _DateSearchMap = new Dictionary<int, DateTimeRange>();

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, BaseEdit> _DateControlMap = new Dictionary<int, BaseEdit>();

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, IntRange> _IntSearchMap = new Dictionary<int, IntRange>();

        /// <summary>
        /// int: vị trí cột của DataSourc tương ứng với Control
        /// </summary>
        protected Dictionary<int, BaseEdit> _IntMap = new Dictionary<int, BaseEdit>();
        #endregion

        public GridFilter(GridView grid)
        {
            _GridView = grid;
            _RowCollection = ((DataView)_GridView.DataSource).Table.Rows;

            //event 
            _Timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// return false if can't find out columnName
        /// </summary>
        public bool AddTextbox(string columnName, BaseEdit control, bool createCheck = true, bool check = true)
        {
            int index = ((DataView)_GridView.DataSource).Table.Columns.IndexOf(columnName);

            if (index == -1)
            {
                MessageBox.Show("Can't find out column: " + columnName, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            _ControlMap.Add(index, control);
            if (createCheck)
                AddCheckbox(control, check);

            return true;
        }

        /// <summary>
        /// return false if can't find out columnName
        /// </summary>
        public bool AddDateControl(string columnName, BaseEdit control, bool createCheck = true, bool check = false)
        {
            int index = ((DataView)_GridView.DataSource).Table.Columns.IndexOf(columnName);

            if (index == -1)
            {
                MessageBox.Show("Can't find out column: " + columnName, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            _DateControlMap.Add(index, control);
            if (createCheck)
                AddCheckbox(control, check);
            return true;
        }

        /// <summary>
        /// return false if can't find out columnName
        /// </summary>
        public bool AddIntControl(string columnName, BaseEdit control, bool createCheck = true, bool check = false)
        {
            int index = ((DataView)_GridView.DataSource).Table.Columns.IndexOf(columnName);

            if (index == -1)
            {
                MessageBox.Show("Can't find out column: " + columnName, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            _IntMap.Add(index, control);
            if (createCheck)
                AddCheckbox(control, check);
            return true;
        }

        public void SetDelayTime(int time)
        {
            _Timer.Interval = time;
        }

        public void StartFilter(bool isDelay)
        {
            if (isDelay)
            {
                _Timer.Interval = _Timer.Interval;
                _Timer.Stop();
                _Timer.Start();
            }
            else
            {
                Timer_Tick(null, null);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _Timer.Stop();
            _SearchMap.Clear();
            _DateSearchMap.Clear();
            _IntSearchMap.Clear();

            foreach (var item in _ControlMap)
            {
                if (item.Value.Enabled)
                {
                    try
                    {
                        RelativeSearch rs = new RelativeSearch();
                        if (rs.SetTemplate((String)item.Value.EditValue))
                            _SearchMap.Add(item.Key, rs);
                    }
                    catch { }
                }
            }

            bool useExternal = false;
            foreach (var item in _DateControlMap)
            {
                if (item.Value.Enabled)
                {
                    try
                    {
                        DateEdit dateEdit = item.Value as DateEdit;
                        DateTimeRange dtr;
                        dtr.Min = dateEdit.DateTime;
                        dtr.Max = ((DateEdit)dateEdit.Tag).DateTime;

                        _DateSearchMap.Add(item.Key, dtr);
                        useExternal = true;
                    }
                    catch { }
                }
            }

            foreach (var item in _IntMap)
            {
                if (item.Value.Enabled)
                {
                    try
                    {
                        IntRange range;
                        range.Min = int.Parse((string)item.Value.EditValue);
                        range.Max = int.Parse((string)((BaseEdit)item.Value.Tag).EditValue);

                        _IntSearchMap.Add(item.Key, range);
                        useExternal = true;
                    }
                    catch (Exception ex)
                    { }
                }
            }

            _GridView.CustomRowFilter -= GridView_CustomRowFilter;
            _GridView.CustomRowFilter -= GridView_CustomRowFilter_external;
            if (useExternal)
                _GridView.CustomRowFilter += GridView_CustomRowFilter_external;
            else
                _GridView.CustomRowFilter += GridView_CustomRowFilter;
            //_GridView.RefreshData();
        }

        private void GridView_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            DataRow dr = _RowCollection[e.ListSourceRow];
            foreach (var item in _SearchMap)
            {
                if (item.Value.Include((String)dr[item.Key]) == false)
                {
                    e.Visible = false;
                    e.Handled = true;
                    return;
                }
            }

            e.Visible = true;
            e.Handled = true;
        }

        private void GridView_CustomRowFilter_external(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            DataRow dr = _RowCollection[e.ListSourceRow];

            // int search
            foreach (var item in _IntSearchMap)
            {
                if (decimal.Parse(dr[item.Key].ToString()) < item.Value.Min || decimal.Parse(dr[item.Key].ToString()) > item.Value.Max)
                {
                    e.Visible = false;
                    e.Handled = true;
                    return;
                }
            }

            // datetime search
            foreach (var item in _DateSearchMap)
            {
                if (((DateTime)dr[item.Key]).CompareTo(item.Value.Min) < 0 || ((DateTime)dr[item.Key]).CompareTo(item.Value.Max) > 0)
                {
                    e.Visible = false;
                    e.Handled = true;
                    return;
                }
            }

            // string search
            foreach (var item in _SearchMap)
            {
                if (item.Value.Include((String)dr[item.Key]) == false)
                {
                    e.Visible = false;
                    e.Handled = true;
                    return;
                }
            }

            e.Visible = true;
            e.Handled = true;
        }

        private void AddCheckbox(Control control, bool check)
        {
            CheckEdit checkE = new CheckEdit();
            checkE.Tag = control;
            checkE.Text = "";

            System.Drawing.Point location;
            if (control.Tag == null)
            {
                location = new System.Drawing.Point(
                control.Location.X + control.Size.Width + 5,
                control.Location.Y + 1);
            }
            else
            {
                Control tag = control.Tag as Control;
                location = new System.Drawing.Point(
                tag.Location.X + control.Size.Width + 5,
                tag.Location.Y + 1);
            }

            checkE.Location = location;
            checkE.CheckedChanged += chk_CheckedChanged;
            checkE.Checked = check;
            if (check == false)
                chk_CheckedChanged(checkE, null);

            control.Parent.Controls.Add(checkE);
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit checkE = sender as CheckEdit;
            if (checkE.Checked)
            {
                Control control = checkE.Tag as Control;
                control.Enabled = true;
                if (control.Tag != null)
                    (control.Tag as Control).Enabled = true;
            }
            else
            {
                Control control = checkE.Tag as Control;
                control.Enabled = false;
                if (control.Tag != null)
                    (control.Tag as Control).Enabled = false;
            }
        }

        ~GridFilter()
        {
            _GridView.CustomRowFilter -= GridView_CustomRowFilter;
            _Timer.Tick -= Timer_Tick;
        }
    }

    struct DateTimeRange
    {
        public DateTime Min;
        public DateTime Max;
    }


    struct IntRange
    {
        public decimal Min;
        public decimal Max;
    }
}
