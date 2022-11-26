namespace FactoryPattern
{
    public class Car:IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public Car()
        {
            this.Make = "Kia";
            this.Model = "Optima";
        }
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is taking a smooth drive...");
        }
    }
}
