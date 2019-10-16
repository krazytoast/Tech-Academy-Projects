using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg117
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            ClassOne objectName = new ClassOne();

            //3. Have the user enter a number. 
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //3.(Continued) Call the method on that number. Display the output to the screen. It should be the entered number, divided by two.
            int results;
            objectName.MethodOne(userInput, out results);

            //5. Overload a method. Two methods with the same name but being called individually by using different data types
            decimal decimalOut; //declare variable
            objectName.MethodOne(11.2m, out decimalOut); //call method that uses output parameter
            Console.WriteLine(decimalOut); // print the variable that has been assigned the value from the method output parameter
            
            //print to screen from static class. This wasn't explicitly requested but figured it was a good way to show the method is running properly
            Console.WriteLine(ClassTwo.MethodOne());
            



            //------------------------------SECTION BEGIN------------------------------
            //This section is for testing
            Console.ReadLine();


            //------------------------------SECTION END--------------------------------
        }
    }
}
