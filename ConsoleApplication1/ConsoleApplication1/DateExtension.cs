using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHelper
{
    public struct RDate
    {
        public int WeekNumber { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
    }
    public static partial class DateTimeExtensions
    {
        public static DateTime FirstDayOfWeek(this DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }

        public static DateTime LastDayOfWeek(this DateTime dt)
        {
            return dt.FirstDayOfWeek().AddDays(6);
        }

        public static DateTime FirstDayOfMonth(this DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }

        public static DateTime LastDayOfMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1).AddDays(-1);
        }

        public static DateTime FirstDayOfNextMonth(this DateTime dt)
        {
            return dt.FirstDayOfMonth().AddMonths(1);
        }
        public static List<RDate> SummarizeMonth(int month, int year)
        {
            DateTime dt = new DateTime(year, month, 1);
            DateTime d = new DateTime(year, month, 1);
            var rDates = new List<RDate>();
            var week = 1;
            while (d <= dt.AddMonths(1).AddDays(-1))
            {
                var r = new RDate
                {
                    WeekNumber = week,
                    StartDate = d.Date.Day,
                    EndDate = d.LastDayOfWeek().Day
                };

                if (r.EndDate < r.StartDate)
                    r.EndDate = dt.LastDayOfMonth().Day;

                rDates.Add(r);
                week++;
                d = d.LastDayOfWeek().AddDays(1);
            }

            return rDates;
        }

    }

}
