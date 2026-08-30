using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal static class DataGridViewUtilities
    {
        #region Getters ============================================
        public static long GetCellValue_Long(DataGridViewRow row, string columnName)
        {
            if (row == null) return -1;
            string cellValue = GetCellValue_String(row, columnName);
            if (cellValue.Equals("")) return -2;

            long value = 0;
            bool isValid = long.TryParse(cellValue, out value);
            if (isValid) return value;

            return -3;
        }

        public static string GetCellValue_String(DataGridViewRow row, string columnName)
        {
            if (row == null) return "";
            return row.Cells[columnName].Value?.ToString() ?? "";
        }
        #endregion Getters
    }
}
