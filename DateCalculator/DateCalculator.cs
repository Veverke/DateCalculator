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
        private TimeSpan _dateDifference;

        public DateCalculator(DateTime baseDate)
        {
            _baseDate = baseDate;
            _dateDifference = DateTime.Now.Subtract(baseDate);
        }

        public int GetWeeksPassedSince()
        {
            int daysPassed = GetDaysPassedSince();
            return daysPassed / 7;
        }

        public int GetDaysPassedSince()
        {
            return _dateDifference.Days;
        }

        public int GetSecondsPassedSince()
        {
            return (int)Math.Floor(_dateDifference.TotalSeconds);
        }

        public int GetHoursPassedSince()
        {
            return (int)Math.Floor(_dateDifference.TotalHours);
        }

        public int GetMonthsPassedSince()
        {
            int daysPassed = GetDaysPassedSince();
            return daysPassed / 30;
        }

        public int GetYearsPassedSince()
        {
            int daysPassed = GetDaysPassedSince();
            return daysPassed / 365;
        }

        public string GetJewishDate()
        {
            return _baseDate.ToJewishDateString("dd MMM yyyy");
        }
    }
}
