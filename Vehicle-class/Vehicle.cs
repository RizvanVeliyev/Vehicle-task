using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_class
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; private set; }

        public Vehicle(int year, string color)
        {
            if (year <= 0)
                throw new ArgumentException("Year must be a positive integer.");

            Year = year;
            Color = color;
        }
        public abstract void ShowInfo();
    }
}
