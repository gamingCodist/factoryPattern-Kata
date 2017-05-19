using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Factory
    {
        public static IVehicle Create(string name, VehicleTypes vehicleType)
        {
            switch (vehicleType)
            {
                case VehicleTypes.Automotive:
                    return new Automotive(name);
                case VehicleTypes.Boat:
                    return new Boat(name);
                case VehicleTypes.Plane:
                    return new Plane(name);
                default:
                    throw new NotImplementedException("Sorry. This type is not supported");
            }
        }
    }
}
