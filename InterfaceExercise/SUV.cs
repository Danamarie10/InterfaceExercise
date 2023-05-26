using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, Icompany
    {
        public int NumberOfWheels { get; set; }
        public string Manufacturer {get; set;}
        public string Model { get; set;}
        public string Color { get; set;}
        public string CargoHoldSize { get; set;}
        public string Logo { get; set;}
        public string Name { get; set;}

    }
}
