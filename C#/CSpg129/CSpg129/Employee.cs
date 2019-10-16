using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg129
{
    class Employee
    {
        public int Id { get; set; }
        public string empName { get; set; }

        Employee employee = new Employee { Id = 40, empName = "Steve" };
        Employee employee1 = new Employee { Id = 42, empName = "Bob" };
        Employee employee2 = new Employee { Id = 40, empName = "Bob" };
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            return (true);
        }

        //public static bool operator !=(Employee employee1, Employee employee2)
        //{
        //    return !(employee1.Id == employee2.Id);
        //}

        //public override bool Equals(Employee emp)
        //    {
        //    return (Employee employee);
        //    }
    }
}
