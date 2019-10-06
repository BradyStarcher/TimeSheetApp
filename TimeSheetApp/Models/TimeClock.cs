﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApp.Models
{
    public class TimeClock
    {
        public Guid ID { get; set; }

        public DateTime ClockIn { get; set; }

        public DateTime OutForLunch { get; set; }

        public DateTime InFromLunch { get; set; }

        public DateTime ClockOut { get; set; }
    }
}
