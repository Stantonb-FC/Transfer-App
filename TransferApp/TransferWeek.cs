using System;
// using System.Globalization; only used with my old code. Leaving for prosperity for myself.


namespace Warehouse_Transfer_Finder
{
    class TransferWeek
    {
        private readonly DateTime _staticDate;
        private DayOfWeek WeekDayName { get; set; }
        private readonly DateTime _today;

        public TransferWeek()
        {
            _today = DateTime.Now;
            WeekDayName = DateTime.Now.DayOfWeek;

            // Known valid " A Week ". 
            _staticDate = new DateTime(year: 2022, month: 1, day: 3);
        }

        public DayOfWeek GetWeekDayName()
        {
            var date = WeekDayName;

            return date;
        }

        public string CurrentWeek()
        {
            var date = _today;

            if (date < _staticDate)
                throw new Exception("Please check the date/time on your computer it may be wrong.");

            var elapsedWeeks = (date - _staticDate).Days / 7;

            if (elapsedWeeks % 2 == 0)
            {
                return "AWeek";
            }
            return "BWeek";
        }

        // Leaving this in for validation of effort. I really thought this would work well.
        // Breaks if "AWeek" bleeds over into the next year on a Monday. Would not break until 2029 but does break.

        /*  CultureInfo culture = CultureInfo.CurrentCulture;
          int weekNumber = culture.Calendar.GetWeekOfYear(
              date,
              CalendarWeekRule.FirstFullWeek,
              DayOfWeek.Monday);

          if(weekNumber%2 == 0)
          {
              return "BWeek";
          }

          else if (weekNumber%2 != 0)
          {
              return "AWeek";
          }

          else
          {
              throw new Exception("Your date/time setting is wrong. Please check it.);
          }*/

    }
}
