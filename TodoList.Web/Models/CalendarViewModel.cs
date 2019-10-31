﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Web.Models
{
    public class CalendarViewModel
    {
        public int OffsetFromSun { get; set; }
        public int NumberOfDays { get; set; }

        public string Name { get; set; }

        public CalendarViewModel(int month, int year)
        {
            DateTime firstDay = new DateTime(year, month, 1);
            OffsetFromSun = (int)firstDay.DayOfWeek;
            NumberOfDays = DateTime.DaysInMonth(year, month);
            Name = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
        }
    }
}
