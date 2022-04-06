using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServices
{
    public class DataService
    {
        static int[] daysInMonth = { 29, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static bool isLeap(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }

            if (year % 100 != 0)
            {
                return true;
            }

            if (year % 400 != 0)
            { return false; }

            return true;
        }

        public static int GetDay(string date)
        {
            string[] datestr = new string[3];
            datestr = date.Split('.', 3);
            int day = Convert.ToInt32(datestr[0]);
            int month = Convert.ToInt32(datestr[1]);
            int year = Convert.ToInt32(datestr[2]);
            if (year < 1)
            { return -1; }
            if (month < 1 || month > 12)
            { return -1; }
            if (isLeap(year))
            {
                if (month == 2)
                {
                    if (day > daysInMonth[0] || day < 1)
                    {
                        return -1;
                    }
                }
                else if (day > daysInMonth[month] || day < 1)
                { return -1; }
            }
            else if (day > daysInMonth[month] || day < 1)
            { return -1; }
            int Day2020 = 3;
            int days = 0;
            days = GetDaysSpan(1, 1, 2020, day, month, year);
            days = (days + Day2020 + 6) % 7 + 1;
            return days;
        }

        public static int GetDaysSpan(int day1, int month1, int year1, int day, int month, int year)
        {
            int days = 0;
            if (year < 1 || year < 1)
            { return -1; }
            if (month < 1 || month > 12 || month1 < 1 || month1 > 12)
            { return -1; }
            if (isLeap(year))
            {
                if (month == 2)
                {
                    if (day > daysInMonth[0] || day < 1)
                    {
                        return -1;
                    }
                }
                else if (day > daysInMonth[month] || day < 1)
                { return -1; }
            }
            else if (day > daysInMonth[month] || day < 1)
            { return -1; }
            if (isLeap(year1))
            {
                if (month1 == 2)
                {
                    if (day1 > daysInMonth[0] || day1 < 1)
                    {
                        return -1;
                    }
                }
                else if (day1 > daysInMonth[month1] || day1 < 1)
                { return -1; }
            }
            else if (day1 > daysInMonth[month1] || day1 < 1)
            { return -1; }

            if (day > day1)
            {
                days += day - day1;
                day = 1;
            }

            while (month > month1)
            {
                if (month == 3)
                {
                    if (isLeap(year))
                    { days += daysInMonth[0]; }
                    else
                    { days += daysInMonth[month - 1]; }
                }
                else
                { days += daysInMonth[month - 1]; }
                month--;
            }

            while(year > year1)
            {
                if(month <= 2)
                {
                    if (isLeap(year-1))
                    { days++; }
                }
                if (month > 2)
                {
                    if (isLeap(year))
                    { days++; }
                }

                days += 365;
                year--;

            }

            while (year < year1)
            {
                if (month <= 2)
                {
                    if (isLeap(year))
                    { days++; }
                }
                if (month > 2)
                {
                    if (isLeap(year + 1))
                    { days++; }
                }

                days += 365;
                year--;

            }

            return days;
        }

        public static int CurDaysSpan(int day, int month, int year)
        {
            return GetDaysSpan(DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year, day, month, year);
        }
    }
}
