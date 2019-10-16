using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg111
{
    public class methods
    {
        //------------------------------SECTION BEGIN------------------------------
        public static int methodOne(int integerIn)
        {
            //random integer created for use with user input
            //Random rnd = new Random();
            int methodOneInt = 13;
            integerIn = (integerIn * methodOneInt);
            return integerIn;
        }

        public static int methodTwo(int integerTwoIn)
        {
            //random integer created for use with user input
            //Random rnd = new Random();
            int methodTwoInt = 10;
            integerTwoIn = (integerTwoIn + methodTwoInt);
            return integerTwoIn;
        }

        public static decimal methodThree(decimal decimalIn)
        {
            //random integer created for use with user input
            //Random rnd = new Random();
            decimal methodThreeDecimal = 55;
            decimalIn = (decimalIn / methodThreeDecimal);
            return decimalIn;
        }

        //------------------------------SECTION END--------------------------------




        //------------------------------SECTION BEGIN------------------------------
        ////Section for testing purposes only
        ////void calls the method and the method will run its course.
        //// other types such as int can recieve a variable and then
        //// perform an action and return value to that variable
        //public static int methodFour(int integerIn)
        //{

        //    int methodOneInt = 5;

        //    return integerIn * methodOneInt;

        //}

        //------------------------------SECTION END--------------------------------
    }
}
