using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    class Program
    {
        //value types are always copied even when passed as parameteres
        //assigning x to y has no impact
        /*static void Main(string[] args)
        {
            int x = 21;
            DoSomething(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static void DoSomething(int y)
        {
            y = 42;
        }
        */
        //usinng the red keyword means y is not a reference to x
        //any chance to y is redirected to x
        static void Main(string[] args)
        {
            int x = 21;
            DoSomething(ref x);
            Console.WriteLine(x);
            Console.ReadLine();
        }
        public static void DoSomething(ref int y)
        {
            y = 42;
        }
    }
}
