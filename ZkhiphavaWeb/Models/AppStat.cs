﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZkhiphavaWeb.Models
{
    public class AppStat
    {
        public AppStat() {
            date = DateTime.Now;
            dayOfWeek = date.DayOfWeek;
        }
        public int id { get; set; }
        public DayOfWeek  dayOfWeek { get; set; }
        public DateTime date { get; set; }
        public int counter { get; set; }
    }
}