using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateSring());
            //Console.WriteLine(myValue.ToLongTimeString());

            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1994, 04, 25);
           //Console.WriteLine(myBirthday.ToShortDateString());



            DateTime myBirthday = DateTime.Parse("25/04/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
        }
    }
}
