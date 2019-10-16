using System;
//using System.Linq;
using System.Collections.Generic;


namespace CSpg100
{
    class Program
    {
        static void Main()
        {
            //------------------------------SECTION BEGIN------------------------------
            //This section is creating and assigning of the List and Array's
            //Create and initialize string Array with values
            string[] strArray = { "Zero", "One", "Forty-Two", "Eleventeen", "Negative-Zero" };

            //Create and initialize int Array with values
            int[] intArray = { 90, 63, 42, 71, 58 };

            //Create a List of strings with values
            List<string> strList = new List<string>();
            strList.Add("The");
            strList.Add("Greatest");
            strList.Add("Question");
            strList.Add("in");
            strList.Add("the");
            strList.Add("Universe");


            //Console writeline and convert user input
            Console.WriteLine("Please select an index of the string type Array 0-4...");
            string userStringSelection = Console.ReadLine();
            int convertStringSelection = Convert.ToInt32(userStringSelection);
            
            //if statement to verify validation of Array element selection. Exits program if selection is invalid
            if(convertStringSelection < strArray.Length && convertStringSelection >= 0)
            {
                Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            }
            else
            {
                Console.WriteLine("Sorry that is an invalid option. Please open the program again and follow the instructions.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //Create to console writeline and convert user input then display the intArray selected
            Console.WriteLine("Please select an index of the integer Array 0-4...");
            string userIntSelection = Console.ReadLine();
            int convertIntSelection = Convert.ToInt32(userIntSelection);

            //if statement to verify validation of Array element selection. Exits program if selection is invalid
            if (convertIntSelection < intArray.Length && convertIntSelection >= 0)
            {
                Console.WriteLine("Your selection was... " + intArray[convertIntSelection]);
            }
            else
            {
                Console.WriteLine("Sorry that is an invalid option. Please open the program again and follow the instructions.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            //Create to console writeline and convert user input then display the strList selected
            Console.WriteLine("Please select an index of the string list 0-5...");
            string userStringListSelection = Console.ReadLine();
            int convertStringListSelection = Convert.ToInt32(userStringListSelection);

            //if statement to verify validation of Array element selection. Exits program if selection is invalid
            if (convertStringListSelection != strList.Count && convertStringListSelection >= 0)
            {
                Console.WriteLine("Your selection was... " + strList[convertStringListSelection]);
            }
            else
            {
                Console.WriteLine("Sorry that is an invalid option. Please open the program again and follow the instructions.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            //------------------------------SECTION END--------------------------------




            //------------------------------SECTION BEGIN------------------------------
            //This area is for testing
            Console.ReadLine();


            //Testing of different statements in order to complete verification of valid array and list selections

            ////switch statement used to verify correct string array and exit if incorrect. This worked but was large and clunky.
            ////found a better and smaller option using an if statement
            //switch (convertStringSelection)
            //{
            //    case 0:
            //        Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            //        break;
            //    case 1:
            //        Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            //        break;
            //    case 2:
            //        Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            //        break;
            //    case 3:
            //        Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            //        break;
            //    case 4:
            //        Console.WriteLine("Your selection was... " + strArray[convertStringSelection]);
            //        break;
            //    default:
            //        Console.WriteLine("Sorry that is an invalid option. Please open the program again and follow the instructions.");
            //        Console.ReadLine();
            //        Environment.Exit(0);
            //        break;
            //}

            ////if statement test for the List. Didn't account for negative numbers or handle numbers outside of the valid options within the List
            ////added the using System.Linq; library in order to use the .ElementAtOrDefault property but ended up not needing it.
            //if (strList.ElementAtOrDefault(convertStringListSelection) != null)
            //{
            //    Console.WriteLine("Your selection was... " + strList[convertStringListSelection]);
            //}
            //else
            //{
            //    Console.WriteLine("Sorry that is an invalid option. Please open the program again and follow the instructions.");
            //    Console.ReadLine();
            //    Environment.Exit(0);
            //}
            //------------------------------SECTION END--------------------------------
        }
    }
}
