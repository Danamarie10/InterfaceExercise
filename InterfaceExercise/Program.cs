using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany
            //DONE

            //Create 3 classes called Car , Truck , & SUV

            //DONE

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */

            //DONE
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */
                //DONE

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car();
            car.NumberOfWheels = 4;
            car.Manufacturer = "Toyota";
            car.Model = "Camry";
            car.Color = "Silver";
            car.TrunkSize = "Large";
            car.Logo = "car_logo.png";
            car.Name = "Toyota Motors";

            Console.WriteLine("Car Details: ");
            Console.WriteLine($"Manufacturer:{car.Manufacturer} ");
            Console.WriteLine($"Model {car.Model}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Number of Wheels: {car.NumberOfWheels}");
            Console.WriteLine($"Trunk Size: {car.TrunkSize}");
            Console.WriteLine($"Company Name: {car.Name}");
            Console.WriteLine($"Company Logo: {car.Logo}");

            Truck truck = new Truck();
            truck.NumberOfWheels = 4;
            truck.Manufacturer = "Ford";
            truck.Model = "F-150";
            truck.Color = "red";
            truck.BedSize = "8 feet";
            truck.Logo = "truck_logo.png";
            truck.Name = "Ford Motors";

            Console.WriteLine("Truck Details: ");
            Console.WriteLine($"Manufacturer:{truck.Manufacturer}");
            Console.WriteLine($"Model:{truck.Model}");
            Console.WriteLine($"Color:{truck.Color}");
            Console.WriteLine($"Number of Wheels:{truck.NumberOfWheels} ");
            Console.WriteLine($"Bed Size:{truck.BedSize} ");
            Console.WriteLine($"Company Name:{truck.Name} ");
            Console.WriteLine($"Company Logo:{truck.Logo} ");

            SUV suv = new SUV();
            suv.NumberOfWheels = 4;
            suv.Manufacturer = "Jeep";
            suv.Model = "Wrangler";
            suv.Color = "Black";
            suv.CargoHoldSize = "Medium";
            suv.Logo = "suv_logo.png";
            suv.Name = "Jeep Motors";

            Console.WriteLine("SUV Details: ");
            Console.WriteLine($"Manufacturer: {suv.Manufacturer}");
            Console.WriteLine($"Model: {suv.Model}");
            Console.WriteLine($"Color: {suv.Color}");
            Console.WriteLine($"Number of Wheels: {suv.NumberOfWheels}");
            Console.WriteLine($"Cargo Size: {suv.CargoHoldSize}");
            Console.WriteLine($"Company Name: {suv.Name}");
            Console.WriteLine($"Company Logo: {suv.Logo}");

        }
    }
}
