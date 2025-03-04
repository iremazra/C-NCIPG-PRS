using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
      
        public void brandOfCar()
        {
            Console.WriteLine("This car belongs to " + this.Brand + " brand.");
        }

        public void modelOfCar()
        {
            Console.WriteLine("This car's model is " + this.Model+".");
        }

        
    }
}

