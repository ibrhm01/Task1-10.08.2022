using System;
using System.Collections.Generic;
using System.Text;

namespace Task1_10._08._2022.Models
{
    class Vehicle
    {
        public string color;
        public int year;
        public Vehicle(int year)
        {
            this.year = year;
        }
        public Vehicle(string color, int year) : this(year)
        {
            this.color = color;
        }
    }
}
