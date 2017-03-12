using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 10;
            int y = x;
            x++;
            Console.WriteLine(x);
            Console.WriteLine(x);
            Foo(x);
            Console.WriteLine(x);
            Console.ReadLine();
        }

        public static void Foo(int a)
        {
            a = a + 1;
        }
         
    }
}
