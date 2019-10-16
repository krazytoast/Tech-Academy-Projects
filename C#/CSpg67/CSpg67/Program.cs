using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg67
{
    class Program
    {
        static void Main()
        {
            // Created Employees with (WorkingRate, HoursPerWeek, EmpName)
            Employee emp1 = new Employee(15, 40, "Person 1");
            Employee emp2 = new Employee(20, 40, "Person 2");


            // Console.WriteLine To print employees, their hourly rate, hours per week worked, 
            // and if statement to see if Person 1 makes more money than Person 2
            Console.WriteLine
                ("Anonymous Income Comparison Program \r\n"
                + emp1.EmpName + "\r\n"
                + "Hourly Rate? \r\n"
                + emp1.EmpWRate + "\r\n"
                + "Hours worked per week?\r\n"
                + emp1.EmpHours + "\r\n"
                + emp2.EmpName + "\r\n"
                + "Hourly Rate? \r\n"
                + emp2.EmpWRate + "\r\n"
                + "Hours worked per week? \r\n"
                + emp2.EmpHours + "\r\n"
                + "Weekly salary of " + emp1.EmpName + ":\r\n"
                + emp1.EmpWRate * emp1.EmpHours + "\r\n"
                + "Weekly salary of " + emp2.EmpName + "\r\n"
                + emp2.EmpWRate * emp2.EmpHours + "\r\n"
                + "Does " + emp1.EmpName + "make more money than " + emp2.EmpName + "?\r\n"
                +(emp1.EmpWRate * emp1.EmpHours > emp2.EmpWRate * emp2.EmpHours));
            // Readline placed here for humans to read output
            Console.ReadLine();
        }


        // Struct created to store employee data
        struct Employee
        {
            public int EmpHours;
            public int EmpWRate;
            public string EmpName;

            public Employee(int empwrate, int emphours, string empname)
            {
                EmpHours = emphours;
                EmpWRate = empwrate;
                EmpName = empname;
            }
        }
 
    }
}

