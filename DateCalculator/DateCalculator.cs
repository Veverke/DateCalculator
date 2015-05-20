using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator
{
    public class DateCalculator
    {
        private DateTime _baseDate;

        public DateCalculator()
        {
        }

        public DateCalculator(DateTime baseDate)
        {
            _baseDate = baseDate;
        }

        public int GetWeeksPassedSince(DateTime? baseDate = null, DateTime? startingDate = null)
        {
            if (!baseDate.HasValue)
            {
                baseDate = baseDate.HasValue ? baseDate.Value : _baseDate;
            }

            if (!startingDate.HasValue)
            {
                startingDate = DateTime.Now;
            }

            //DayOfWeek baseDayOfWeek = date.DayOfWeek;
            TimeSpan dateDifference = startingDate.Value.Subtract(baseDate.Value);
            int daysPassed = dateDifference.Days;

            return daysPassed / 7;
        }
    }
}
