using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DataStructure.Utility
{
    public static class DateTimeUtil
    {
        public static string  ToShamsi(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            var year = pc.GetYear(date);
            var month = pc.GetMonth(date);
            var day = pc.GetDayOfMonth(date);
            return $"{year}/{month}/{date}";
        }
    }
}
