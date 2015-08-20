using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.General
{
    public class DataTableCustomize
    {
        public static DataTable AutoNumberedTable(DataTable SourceTable)
        {
            DataTable ResultTable = new DataTable();
            DataColumn AutoNumberColumn = new DataColumn();
            AutoNumberColumn.ColumnName = "STT";
            AutoNumberColumn.DataType = typeof(int);
            AutoNumberColumn.AutoIncrement = true;
            AutoNumberColumn.AutoIncrementSeed = 1;
            AutoNumberColumn.AutoIncrementStep = 1;
            ResultTable.Columns.Add(AutoNumberColumn);
            ResultTable.PrimaryKey = new DataColumn[] { AutoNumberColumn };
            if (SourceTable.Columns.Contains("STT"))
            {
                SourceTable.PrimaryKey = null;
                SourceTable.Columns.Remove("STT");
            }
            ResultTable.Merge(SourceTable);
            return ResultTable;

        }
    }
}
