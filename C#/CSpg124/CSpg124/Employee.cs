using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg124
{
    public class Employee : Person, IQuittable //2. Have your Employee class from the previous drill inherit that interface
    {
        public override void sayName()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine("Quality Assured!");
        }

        //2.(continued) and implement the Quit() method in any way you choose.
        public void Quit()
        {

            // throw new NotImplementedException(); //purposely throw error
        }

        public int Id;
        
        


    }
}
