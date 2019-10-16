using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg111
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------SECTION BEGIN------------------------------
            //This is for methodOne
            //Ask user for number and pass value to methodOne
            Console.WriteLine("Please enter a number: ");
            int userIntegerInOne = Convert.ToInt32(Console.ReadLine());

            //Pass userIntegerInOne to the methodOne
            Console.WriteLine("The number you gave multiplied by 13 = " + methods.methodOne(userIntegerInOne));
            Console.ReadLine();


            //This is for methodTwo
            //Ask user for number and pass value to methodTwo
            Console.WriteLine("Please enter a number: ");
            int userIntegerInTwo = Convert.ToInt32(Console.ReadLine());

            //Pass userIntegerInTwo to the methodTwo
            Console.WriteLine("The number you gave plus 10 = " + methods.methodTwo(userIntegerInTwo));
            Console.ReadLine();


            //This is for methodThree
            //Ask user for number and pass value to methodThree
            Console.WriteLine("Please enter a number: ");
            decimal userDecimalIn = Convert.ToInt32(Console.ReadLine());

            //Pass userDecimalIn to the methodThree
            Console.WriteLine("The number you gave divided by 55 = " + methods.methodThree(userDecimalIn));
            Console.ReadLine();

            Console.WriteLine("Have a nice day!");

            //------------------------------SECTION END--------------------------------






        }
    }
}
