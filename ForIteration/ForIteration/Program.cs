using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);           
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    //you can add a break by clicking the grey bar to the left 
                    break;

                }
            }

            //double tab for snippets which will give you example placeholder values
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
