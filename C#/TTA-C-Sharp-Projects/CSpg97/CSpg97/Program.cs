using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg97
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------SECTION BEGIN------------------------------
            //This section is for the use of StringBuilder

            //Initialize the StringBuilder with first sentence that is expected to hold 50 characters
            StringBuilder sb = new StringBuilder("I ate ONE fried egg with a runny yolk.", 50);

            //Append sentence
            sb.Append("My coffee had cream and THREE sugars in it.");
            
            //Insert this sentence after the first sentence.
            sb.Insert(sb.ToString().IndexOf("k.") + 2, " The toast was TWO dark and crisp. ");

            //Write sb which contains three sentences to form a very short paragraph.
            Console.WriteLine(sb);
            Console.ReadLine();
            //----------------SECTION END--------------------------------


            ////----------------SECTION BEGIN------------------------------
            ////This section is for the use of string
            ////Create strings
            //string one = "One, ";
            //string two = "Two, ";
            //string three = "Three!!!";

            //Convert to upper
            //three = three.ToUpper();

            //Concatenation of the 3 strings
            //Console.WriteLine(one + two + three);

            //Console.ReadLine();
            ////----------------SECTION END--------------------------------

        }
    }
}
