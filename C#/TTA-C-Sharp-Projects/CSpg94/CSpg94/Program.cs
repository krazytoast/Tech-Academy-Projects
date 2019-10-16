using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg94
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-------------------Section BEGIN------------------------------------------
            ////This is a while loop.Uncomment this section to run.


            ////Initial start of program. Output to user, input from user and assigning a variable for use with the while loop
            //Console.WriteLine("What temperature is it?");
            //int actualTemperature = Convert.ToInt32(Console.ReadLine());
            //bool correctTemperature = actualTemperature == 68;


            ////Here is the while loop. Gaze in amaze at its all powerful glory
            //while (!correctTemperature)
            //{
            //    switch (actualTemperature)
            //    {
            //        case 60:
            //            Console.WriteLine("That is too cold. Try Again");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 72:
            //            Console.WriteLine("That is room temperature but still a bit warm.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 80:
            //            Console.WriteLine("That is too warm.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 68:
            //            Console.WriteLine("Ah! not too cold or too hot. 68 is just right.");
            //            correctTemperature = true;
            //            Console.ReadLine();
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            ////This is here to catch the first guess being 68, if you guessed the first time ever congrats to you! Go buy a lotto ticket.
            //Console.WriteLine((actualTemperature = 68) + " Wow! you got it first try!");
            //Console.ReadLine();
            ////-------------------Section END------------------------------------------


            ////-------------------Section BEGIN------------------------------------------
            ////This is a do while loop. Uncomment this section to run.

            ////Initial start of program. Output to user, input from user and assigning a variable for the do while loop
            //Console.WriteLine("What temperature is it?");
            //int actualTemperature = Convert.ToInt32(Console.ReadLine());
            //// I have a question... this number right here \/ doesn't matter what I set it to. The do while loop still runs as it should but doesn't work if I remove it. Is there an alternative, a better way to do this?
            //bool correctTemperature = actualTemperature == 68;

            ////The do while loop is upon us, repent your sins! and repeat until holy. Act as if thyself is a do while loop.
            //do
            //{
            //    switch (actualTemperature)
            //    {
            //        case 61:
            //            Console.WriteLine("You guessed 61. Too cold.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 96:
            //            Console.WriteLine("You guessed 96. Too hot to not have HVAC.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 106:
            //            Console.WriteLine("You guessed 106. Only if you are in Redding, CA.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 70:
            //            Console.WriteLine("You guessed 70. Perfectly chill.");
            //            correctTemperature = true;
            //            Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong.");
            //            Console.WriteLine("Try again?");
            //            actualTemperature = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}
            //while (!correctTemperature);

            ////This area is for testing only. Have a nice day and happy coding!
            ////Console.ReadLine();
            ////-------------------Section END------------------------------------------
        }
    }
}
