namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

       public Motorcycle()
        {
            this.Make = "Harley Davidson";
            this.Model = "Fat Boy";
        }

        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is out for a cruise...");
        }

    }
}
