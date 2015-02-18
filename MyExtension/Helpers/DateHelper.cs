using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension
{
    public static class DateHelper
    {

        public static int DaysInYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year) ? 366 : 365;
        }

        public static int DaysInYear(string year)
        {

            int parseInt;
            int result;
            var parseResult = int.TryParse(year, out parseInt);

            if(parseResult)
            {
                result = DateTime.IsLeapYear(int.Parse(year)) ? 366 : 365; 
            }
            else
            {
                throw new FormatException("La valeur saisie pour l'année est n'est pas bonne");
            }

            return result;
        }

        public static int DaysInYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException("year", year, "l'année doit être comprise entre 1 et 9999 borne incluse");
            }

            return DateTime.IsLeapYear(year) ? 366 : 365;
        }
    }
}
