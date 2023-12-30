using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05
{
    public class MyDate
    {
        protected static MyDate defaultDate = new MyDate(2023, 12, 30, 14, 48);
        public static MyDate DefaultDate { get { return defaultDate; } protected set { defaultDate = value; } }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public MyDate(int year, int month, int day, int hour, int minute) 
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
        }
        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = Math.Clamp(month, 1,  12);
            Day = day;
            Hour = 23;
            Minute = 59;
        }
        public MyDate(MyDate date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hour = date.Hour;
            Minute = date.Minute;
        }
        public MyDate() 
        {
            Year = DefaultDate.Year;
            Month = DefaultDate.Month;
            Day = DefaultDate.Day;
            Hour = DefaultDate.Hour;
            Minute = DefaultDate.Minute;
        }
    }

}
