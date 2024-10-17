using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
     class exercise6
    {
        static void Main(string[] args)
        {
            // Create a new Car object
            Car myCar = new Car("Toyota", "Corolla", "Blue", "ABC123");

            // Output the car data
            Console.WriteLine(myCar.GetCarData());

            // Attempt to change the make with a valid value
            myCar.Make = "Honda";

            // Output the updated car data
            Console.WriteLine(myCar.GetCarData());
        }
    }
}
