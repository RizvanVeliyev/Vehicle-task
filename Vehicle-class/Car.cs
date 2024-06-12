using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_class
{
    public class Car : Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Maxspeed { get; set; }

        public Car(int year, string color, string model, string brand) : base(year, color)
        {
            Model = model;
            Brand = brand;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car: Model = {Model},Brand={Brand}, Year = {Year}, Color = {Color}");
        }
    }
}
