using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
        public class Car
        {
            // Data members
            private string make;
            private string model;
            private string colour;
            private string registrationNumber;

            // User-defined constructor
            public Car(string make, string model, string colour, string registrationNumber)
            {
                this.make = make;
                this.model = model;
                this.colour = colour;
                this.registrationNumber = registrationNumber;
            }

            // ReadOnly property for registrationNumber
            public string RegistrationNumber
            {
                get { return registrationNumber; }
            }

            // Property for make with validation
            public string Make
            {
                set { if (!string.IsNullOrEmpty(value)) make = value; }
                get { return make; }
            }

            // Method to output car data as a string
            public string GetCarData()
            {
                return $"Make: {make}, Model: {model}, Colour: {colour}, Registration Number: {registrationNumber}";
            }
        }
    }



