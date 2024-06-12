namespace Vehicle_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Car(2020, "Red","camry", "Toyota"),
                new Bus(2021, "Yellow", 50),
                new Car(2019, "Blue","f10", "Bmw"),
                new Bus(2018, "Green", 30)
            };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}