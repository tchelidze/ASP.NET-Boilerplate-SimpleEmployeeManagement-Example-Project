using System;

namespace SimpleEmployeeManagement.Infrastructure.Extensions
{
    public static class DateTimeExtensions
    {
        public static int YearsDifference(this DateTime start, DateTime end)
            => end.Year - start.Year - 1
            + ((end.Month > start.Month)
            || ((end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
    }
}
