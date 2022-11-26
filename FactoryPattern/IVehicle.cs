
namespace FactoryPattern
{
    public interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public void Drive();

    }
}
