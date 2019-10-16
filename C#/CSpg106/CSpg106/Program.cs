using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Create list of integers
                List<int> intList = new List<int>() { 2, 4, 6, 8, 10 };

                //Ask user for a number to divide each number in the list by
                Console.WriteLine("Please enter a number to divide by each number in the list: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                //Loop to take each integer in the list and divide it by the number the user entered
                foreach (int i in intList)
                {
                    Console.WriteLine(i / userNumber);
                }
                Console.ReadLine();
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally //Not used
            //{
                
            //}
            Console.WriteLine("The program has emerged from the try/catch block.");
            Console.ReadLine();

        }
    }
}
