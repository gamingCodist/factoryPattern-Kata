using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Boat : IVehicle
    {
        public Boat(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public VehicleTypes VehicleType => VehicleTypes.Boat;
    }
}
