using System;
using System.Collections.Generic;
using System.Text;

namespace Kahnban_ToDo
{
    internal static class DataGridViewUtilities
    {
        #region Getters ============================================
        public static DateTime GetCellValue_DateTIme(DataGridViewRow row, string columnName)
        {
            if (row == null) return DateTime.MinValue;
            string cellValue = GetCellValue_String(row, columnName);
            if (cellValue.Equals("")) return DateTime.MinValue;

            DateTime value = DateTime.MinValue;
            bool isValid = DateTime.TryParse(cellValue, out value);
            if (isValid) return value;

            return DateTime.MinValue;
        }

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
