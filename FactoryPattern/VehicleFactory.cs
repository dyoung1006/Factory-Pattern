using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
                public static IVehicle CreateVehicle(int NumOfWheels)
        {
            switch (NumOfWheels)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
