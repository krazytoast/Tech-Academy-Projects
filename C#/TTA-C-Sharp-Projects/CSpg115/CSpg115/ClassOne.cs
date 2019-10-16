using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg115
{
    class ClassOne
    {
        public int MethodOne(int userInput, int methodOptionalInput = 10)
        {
            Console.WriteLine(userInput + " plus " + methodOptionalInput + " equals: ");
            return (userInput + methodOptionalInput);
            
        }
    }
}
