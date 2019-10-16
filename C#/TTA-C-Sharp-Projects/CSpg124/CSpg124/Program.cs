using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg124
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.Id = 42;


            employee.sayName();
        }

        public static bool operator== (Employee empId1, Employee empId2)
        {
        if (empId1 == empId2)
            {
            return true;
            }
            return false;
        }

        ////3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
        //IQuittable quit = new Employee();
        //quit.Quit();

        //------------------------------SECTION BEGIN------------------------------

        //Console.ReadLine();
        
        }
}
}
