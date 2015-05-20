using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator
{
    public static class Extensions
    {
        //taken from: http://stackoverflow.com/questions/6245546/how-can-i-get-todays-jewish-date-in-c


        public static string ToJewishDateString(this DateTime value, string format)
        {
            var ci = CultureInfo.CreateSpecificCulture("he-IL");
            ci.DateTimeFormat.Calendar = new HebrewCalendar();
            return value.ToString(format, ci);
        }

        /// <summary>
        /// Converts a gregorian date to its hebrew date string representation,
        /// using DateTime format options.
        /// </summary>
        /// <param name="value">The <see cref="DateTime"/> value to convert.</param>
        /// <param name="dayOfWeek">Specifies whether the return string should
        /// include the day of week.</param>
        public static string ToJewishDateString(this DateTime value, bool dayOfWeek)
        {
            var format = dayOfWeek ? "D" : "d";
            return value.ToJewishDateString(format);
        }
    }
}
