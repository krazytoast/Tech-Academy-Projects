using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg114
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------SECTION BEGIN------------------------------
            //This section is for calling the method and passing in an integer,
            // such as 12. Then display the result to the screen.
            Console.WriteLine(CSpg114Class.MethodOne(12));

            //Decimal being passed into MethodOne and 
            Console.WriteLine(CSpg114Class.MethodOne(12.0m));

            //String
            Console.WriteLine(CSpg114Class.MethodOne("20"));

            //------------------------------SECTION END--------------------------------
            



            //------------------------------SECTION BEGIN------------------------------
            //This area is for testing
            Console.ReadLine();


            //------------------------------SECTION END--------------------------------
        }
    }
}
