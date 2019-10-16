using System;

namespace CSpg57
{
    class Program
    {
        static void Main()
        {
            // All data types left as strings because no exact data type was explicitly instructed as proper.
            
            Console.WriteLine("The Tech Academy" + Environment.NewLine + "Student Daily Report" + Environment.NewLine + "What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string currentPage = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string studentHelp = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string additionalFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
