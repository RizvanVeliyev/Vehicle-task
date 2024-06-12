using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_class
{
    public class Bus : Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(int year, string color, int passengerCount) : base(year, color)
        {
            PassengerCount = passengerCount;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Bus: Year = {Year}, Color = {Color}, Passenger Count = {PassengerCount}");
        }
    }
}
