namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NumOfwheels;
            bool UserInput = false;

            do
            {
                Console.WriteLine("Enter the number of tires for the vehcile you want to create:");
                UserInput = int.TryParse(Console.ReadLine(), out NumOfwheels); 
            }   while (!UserInput);

            var vehicle = VehicleFactory.CreateVehicle(NumOfwheels);
            vehicle.Drive();
            
        }
    }
}
