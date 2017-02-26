using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3 ");
            string userValue = Console.ReadLine();
            string message = "";

            if (userValue == "1")
                message = "you won a new car";
            else if (userValue == "2")
                message = "you won a new boat";

            else if (userValue == "3")
                message = "you won a new cat";
            else
            {
                message = "Sorry we didn't understand.";
                //message = message + "you lose!";
                message += "You Lose.";

   
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3 ");
            string userValue = Console.ReadLine();

            //if userValue = 1 then assign the word boat the the variable, message else if strand of lint
            string message = (userValue =="1") ? "boat" : "strand of lint";

            //Console.Write("you won a");
            //Console.Write(message);
            //Console.Write(".");

            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("you entered: {0}, therefore you won a {1}.", userValue, message);
            Console.ReadLine();

        }
    }
}
