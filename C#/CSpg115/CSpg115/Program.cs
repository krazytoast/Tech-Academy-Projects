using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg115
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------SECTION BEGIN------------------------------
            //instantiate the class
            ClassOne objectName = new ClassOne();

            //This section is for the first required parameter
            Console.WriteLine("Please enter a number: ");
            int userInputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can enter a second number but it is optional: ");

            //This is for the second optional parameter and to handle if they enter a null or string

            // Take user input in form as string
            string optionalInput = Console.ReadLine();

            //if statement to check if string can be parsed to int
            if (Int32.TryParse(optionalInput, out int userOptionalInput))
            {
                Console.WriteLine(objectName.MethodOne(userInputOne, userOptionalInput));
            }
            else //if string cannot be parsed then use default value for the optional parameter
            {
                Console.WriteLine(objectName.MethodOne(userInputOne));
            }

            //------------------------------SECTION END--------------------------------




            //------------------------------SECTION BEGIN------------------------------
            //This section is for testing
            Console.ReadLine();


            //------------------------------SECTION END--------------------------------
        }
    }
}
