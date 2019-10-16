using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg92
{
    class Program
    {
        static void Main(string[] args)
        {
            //Package Express shipping program

            
            //Initial welcome message and storing variable of weight then convert to int
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight: ");
            string packageWeight = Console.ReadLine();
            int weightLimit = Convert.ToInt32(packageWeight);
            

            //if statement to check if package is to heavy
            if (weightLimit > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //Package width
            Console.WriteLine("Please enter the package width: ");
            string packageWidth = Console.ReadLine();
            int widthLimit = Convert.ToInt32(packageWidth);


            //Package height
            Console.WriteLine("Please enter the package height: ");
            string packageHeight = Console.ReadLine();
            int heightLimit = Convert.ToInt32(packageHeight);


            //Package length
            Console.WriteLine("Please enter the package length: ");
            string packageLength = Console.ReadLine();
            int lengthLimit = Convert.ToInt32(packageLength);


            //if statement to evaluate package dimensions. Sum must be no greater than 50.
            //Additional variable to store total linear dimensions
            decimal packageLinearDimensions = widthLimit + heightLimit + lengthLimit;
            if (packageLinearDimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //Estimated total and thank you message
            //Variable to estimate qoute
            decimal packageQuote = packageLinearDimensions * weightLimit / 100.00m;
            Console.WriteLine("Your estimated total for shipping this package is : $" + packageQuote + "\r\nThank you.");
            Console.ReadLine();










            //This was for testing. Have a nice day and happy coding!
            //Console.WriteLine(packageLinearDimensions);
            //Console.ReadLine();
        }
    }
}
