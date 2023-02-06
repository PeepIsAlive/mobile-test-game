using System;

namespace Core
{
    public struct Age
    {
        public int TotalYears;
        public int TotalMonths => new DateTime(TotalYears, 0, 0).Month;
        public int TotalDays => new DateTime(TotalYears, 0, 0).Day;

        public Age(int totalYears)
        {
            TotalYears = totalYears;
        }
    }
}
