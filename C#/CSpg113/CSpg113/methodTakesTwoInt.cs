using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg113
{
    class Page113Class
    {
        public static void TakesTwoInt(int methodIntegerOne, int methodIntegerTwo)
        {
            Random rng = new Random();
            int methodRandomInteger = rng.Next(100);

            Console.WriteLine("The number you entered: " + methodIntegerOne + " plus " + methodRandomInteger + " equals " + (methodIntegerOne + methodRandomInteger));
            Console.WriteLine("The second number you entered is: " + methodIntegerTwo);

            Console.ReadLine();
        }

    }
}
