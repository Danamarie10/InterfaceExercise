using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        int NumberOfWheels { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        string Color { get; set; }
    }
    
}
