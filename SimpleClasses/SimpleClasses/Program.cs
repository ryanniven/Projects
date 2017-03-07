using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the car class
            Car myCar = new Car();
            myCar.Make = "Mercedes";
            myCar.Model = "C63";
            myCar.Year = 2017;
            myCar.Colour = "Black";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Colour);

            //decimal value = DetermineMarketValue(myCar);
            //:C is for currency
            // Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", 
                myCar.DetermineMarketValue());

            Console.ReadLine();


        }
        //upper case Car is the class, lower case is the object
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            //someday i might look up the car online website to get more accruate val

            return carValue;

        }

    }

    //class is a blueprint for future instances
    class Car
    {
        //prop tab tab shortcut
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }


        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;

        }








        /*propfull tab tab shortcut
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

    }

}

