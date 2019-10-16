using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-------------------SECTION BEGIN---------------------
            ////Practice of string functions
            //string name = "Zach";

            ////In order to use certain characters you must first use an escape sequence to tell the program to ignore the string functions
            ////Example: in order to use the quote symbol within a string you must first use the backslash \ as seen below
            //string quote = "The man said, \"hello\", Zach \n Hello on a new line. \n \t Hello on a new tab.";

            ////When using a filename in a string you must put double \\
            //string filename1 = "C:\\Users\\Zach";
            ////Or put the @ symbol just before the string
            //string filename2 = @"C:\Users\Zach";

            ////A bool that checks if the variable name contains the letter "Z"
            //bool trueOrFalse = name.Contains("Z");
            ////Bool checking if the variable name ends with an "s"
            //trueOrFalse = name.EndsWith("s");

            ////An int named length that is checking the length of the variable name
            //int length = name.Length;

            ////Convert to UpperCase
            //name = name.ToUpper();

            ////Convert to Lowercase
            //name = name.ToLower();

            ////This area is for testing. Have a nice day and happy coding!
            //Console.WriteLine(name);
            ////Console.WriteLine(length);
            //Console.ReadLine();
            ////-------------------SECTION END-----------------------


            ////-------------------SECTION BEGIN---------------------
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Zach");


            Console.WriteLine(sb);
            Console.ReadLine();
            ////-------------------SECTION END-----------------------

        }
    }
}
