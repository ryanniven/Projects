using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*
            myCar.Make = "Mercedes";
            myCar.Model = "C63";
            myCar.Year = 2017;
            myCar.Colour = "black";
            */


            //Car myThirdCar = new Car("Ford", "Mustang", 1969, "Blue");

            /*
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make, 
                myOtherCar.Model, 
                myOtherCar.Year, 
                myOtherCar.Colour);


            myOtherCar.Model = "G Wagon";
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Colour);


            myOtherCar = null;
       
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Colour);
           

            myCar = null;
             */
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        /*
        public Car()
        {
            //you could load from a config file/db. 
            Make = "Maybach";
        }

        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
        }
    */

        public static void MyMethod()
        {
            Console.WriteLine("Called the static MyMethod");
            Console.WriteLine(Make);
        }
            
     }

}
