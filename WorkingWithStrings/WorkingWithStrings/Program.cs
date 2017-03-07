using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            quotes in quotes (string literal)
            string myString = " My \"so-called\" life";
            (new line)
            string myString = " What if I need a \nnew line?";
            how to use a backslash (double \\)
            string myString = "Go to your c:\\ drive";
            how to use a single backslash 
            string myString = @"Go to your c:\ drive";
            */
            // string myString = String.Format("{0} = {1}", "First", "Second");
            //currency
            //string myString = string.Format("{0:C}", 123.45);
            //comma separated numbers e.g 1,000,000,000
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //mobile number (UK)
            //string myString = string.Format("Phone Number:{0: (## ##########) }", 1234567890 );

            //string myString = " That summer we took threes accross the board  ";
            // only items from the following characters
            //myString = myString.Substring(6, 14);
            //upercase
            //string myString = myString.ToUpper;
            //remove characters
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove (6,14);
            //myString = String.Format("Length before: {0} --Length after: {1}",
            //  myString.Length, myString.Trim().Length);


            /*
             string myString = "";
             for (int i = 0; i < 100; i++)
             {
                 myString += "--" + i.ToString();
             }
 */

            //string builder is a more efficient way to alot of string manipulation / concatination
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }









            Console.WriteLine(myString);
            Console.ReadLine();
      
        }
    }
}
