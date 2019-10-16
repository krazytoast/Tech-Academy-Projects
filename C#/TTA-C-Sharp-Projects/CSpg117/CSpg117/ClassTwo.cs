using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg117
{
    //6. Declare a class to be static.
    static class ClassTwo
    {
        //static strings
        public static string courseName;
        public static string coursePage;

        
        public static string MethodOne()
        {
            //4. Create a method with output parameters.
            courseName = "C# ";
            coursePage = "Page: 117";
            return (courseName + coursePage);
        }

    }
}
