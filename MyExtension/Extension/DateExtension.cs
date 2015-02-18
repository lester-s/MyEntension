using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension.Extension
{
    public static class DateExtension
    {
        public static int DaysInYear(this DateTime date)
        {
            return DateTime.IsLeapYear(date.Year) ? 366 : 365;
        }
    }
}
