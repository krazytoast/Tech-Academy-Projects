using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg113
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------SECTION BEGIN------------------------------
            //This section is for the output to the user and the input from the user

            //Ask user for a number
            Console.WriteLine("Please enter a number: ");
            //Take user input and assign to integerOneIn
            int userIntOneIn = Convert.ToInt32(Console.ReadLine());
            //Ask user for second number
            Console.WriteLine("PLEASE enter a second number: ");
            //Take user input and assign to integerTwoIn
            int userIntTwoIn = Convert.ToInt32(Console.ReadLine());

            //------------------------------SECTION END--------------------------------




            //------------------------------SECTION BEGIN------------------------------
            //This section is for calling the method and using the user input for the variables

            //Call the method in the class, pass in two parameters by order
            Page113Class.TakesTwoInt(userIntOneIn, userIntTwoIn);

            //Call the method in the class, specifying the parametes by name
            Page113Class.TakesTwoInt(methodIntegerTwo: userIntTwoIn, methodIntegerOne: userIntOneIn);

            //------------------------------SECTION END--------------------------------

        }
    }
}
