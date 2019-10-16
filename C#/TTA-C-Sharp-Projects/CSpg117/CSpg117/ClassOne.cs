using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg117
{
    class ClassOne
    {
        //1. Create a class. In that class, create a void method
        //4. create a method with output parameters
        //5. Overload a method. Two methods with the same name
        public void MethodOne(int integerOne, out int results)
        {
            //1.(Continued) that outputs an integer. Have the method divide the data passed to it by 2.
            results = integerOne / 2;
            Console.WriteLine(results);
        }

        //5. Overload a method. Two methods with the same name
        //4. create a method with output parameters
        public void MethodOne(decimal decimalOne, out decimal decimalOut)
        {
            decimal decimalTwo = 15.3m;
            decimal decimalsAdded = decimalOne + decimalTwo;
            decimalOut = decimalTwo + decimalOne;
        }


    }
}
