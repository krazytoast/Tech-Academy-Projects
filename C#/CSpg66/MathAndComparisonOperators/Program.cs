using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------
            // THESE ARE PRACTICES DONE WHILE FOLLOWING ALONG WITH VIDEOS FOR THE C# COURSE
            //-----------------------------------------------------------------------------

            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //double quotient = 100.00 / 17.00;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 71;

            //bool isWarm = currentTemperature == roomTemperature;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();


            //-----------------------------------------------
            // THESE ARE THE DRILL WORK FOR C# COURSE PAGE 66
            //-----------------------------------------------

            // Taking user input and multiplying by 50
            Console.WriteLine("Let's multiply! Pick a number...");
            string userInputTimes50 = Console.ReadLine();
            Console.WriteLine("Your number times 50 is: " + Int32.Parse(userInputTimes50) * 50);

            // Taking user input and adding 25
            Console.WriteLine("Let's do some Addition! Input a number...");
            string userInputPlus25 = Console.ReadLine();
            Console.WriteLine("Your number plus 25 equals: " + (Int32.Parse(userInputPlus25) + 25));

            // Taking user input and dividing by 12.5
            Console.WriteLine("Let's do some division! Give me a number please...");
            string userInputDividedBy12point5 = Console.ReadLine();
            Console.WriteLine("Your number divided by 12.5 is : " + float.Parse(userInputDividedBy12point5) / 12.5);

            // Takes input from user and outputs true or false if it is greater than 50
            Console.WriteLine("Let's play a game. Give me a number and I'll tell you if it is greater than 50...");
            string userInputTrueFalseGreaterThan50 = Console.ReadLine();
            Console.WriteLine("Is your number greater than 50?..." + (Int32.Parse(userInputTrueFalseGreaterThan50) > 50));

            // Takes input from user, divides it by 7 and prints the remainder
            Console.WriteLine("Let's play with remainders! Give me a number and I'll divide it by 7 and show you the remainder...");
            string userInputDivideBy7Remainder = Console.ReadLine();
            Console.WriteLine("The remainder of: " + userInputDivideBy7Remainder + " divided by 7 is : " + Int32.Parse(userInputDivideBy7Remainder) % 7);
            Console.ReadLine();
        }
    }
}
