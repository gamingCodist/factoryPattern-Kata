using System;
using System.Collections.Generic;
using System.Text;

namespace factoryPattern.Cli.Model.Domain.Vehicle
{
    public class Automotive : IVehicle
    {
        public Automotive(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public VehicleTypes VehicleType { get { return VehicleTypes.Automotive;}}
    }
}
