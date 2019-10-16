using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg75
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age input 
            Console.WriteLine("What is your age?");
            string ageInput = Console.ReadLine();
            int ageRequired = Convert.ToInt32(ageInput);

            //DUI input 
            Console.WriteLine("Have you ever had a DUI? true or false?");
            string duiInput = Console.ReadLine();
            bool duiRequired = Convert.ToBoolean(duiInput);

            //Speeding ticket input
            Console.WriteLine("How many Speeding tickets do you have?");
            string ticketInput = Console.ReadLine();
            int ticketRequired = Convert.ToInt32(ticketInput);

            //Comparison verification
            Console.WriteLine("Qualified?\r\n" + (ageRequired > 15 && ticketRequired < 3 != duiRequired));
            Console.ReadLine();
        }
    }
}
