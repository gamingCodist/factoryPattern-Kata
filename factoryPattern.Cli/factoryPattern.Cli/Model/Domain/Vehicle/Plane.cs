using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Plane : IVehicle
    {
        public Plane(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public VehicleTypes VehicleType { get { return VehicleTypes.Plane;} }
    }
}
