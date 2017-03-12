using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","m4","Blue",69);
            Car car2 = new Car();
            Car alternativeNameForCar2;
            alternativeNameForCar2 = car2;
            
            car1.Accelerate(10);
            car2.Accelerate(20);
            car2.Speed = 69;

            Console.WriteLine("The {0} {1} is currently travelling at {2}mph or for the europeans... {3} kph",car1.Make, car1.Model, car1.Speed, car1.SpeedInkph);
            Console.ReadLine();
        }
    }
}
