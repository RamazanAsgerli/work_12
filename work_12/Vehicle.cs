﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_12
{
    abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public Vehicle(string color, int year)
        {
            Color = color;
            Year = year;
        }
        public abstract void ShowInfo();
    }
}
