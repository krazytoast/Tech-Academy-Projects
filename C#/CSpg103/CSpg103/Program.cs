using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSpg103
{
    class Program
    {
        static void Main(string[] args)
        {
            ////------------------------------SECTION BEGIN------------------------------
            ////This section is for the first task in the C# course pg 103

            ////Create one-dimensional Array of strings
            //string[] strArray01 = { "First", "Second", "Third", "Forth", "Fifth" };

            ////Ask the user to input some text
            //Console.WriteLine("Please enter some text");
            ////Assign user input to variable
            //string userInputText = Console.ReadLine();

            ////Create a loop that adds the userInputText to each string in the Array and prints each string on a new line to screen
            //for (int i = 0; i < strArray01.Length; i++)
            //{
            //    Console.WriteLine(strArray01[i] + userInputText);
            //}

            ////------------------------------SECTION END--------------------------------




            ////------------------------------SECTION BEGIN------------------------------
            ////This section is for the infinite loop and the fixed infinite loop

            //////Infinite loop
            ////int infinity = 00;
            ////for (int i = 1; i > infinity; i++)
            ////{
            ////    Console.WriteLine("To infinity and beyond!");
            ////}

            //////False infinite loop (aka fixed infinite loop)
            ////int infinityPlus1 = 11;
            ////for (int i = 1; i < infinityPlus1; i++)
            ////{
            ////    Console.WriteLine("That is just falling with style");
            ////}

            ////------------------------------SECTION END--------------------------------




            ////------------------------------SECTION BEGIN------------------------------
            //This section is for the loops using "<" and "<=" comparison operators

            ////While loop using the "<" comparison operator
            //int compareLessThan = 0;

            //while (compareLessThan < 11)
            //{
            //    Console.WriteLine(compareLessThan);
            //    compareLessThan++;
            //}

            ////While loop using the "<=" comparison operator
            //int compareLessThanOrEqual = 0;

            //while (compareLessThanOrEqual <= 10)
            //{
            //    Console.WriteLine(compareLessThanOrEqual);
            //    compareLessThanOrEqual++;
            //}

            ////------------------------------SECTION END--------------------------------




            ////------------------------------SECTION BEGIN------------------------------
            ////This section is for the loop on steps 6, 7, & 8

            ////Create a list of strings where each item in the list is unique
            //List<string> stringList = new List<string>();
            //stringList.Add("a apple");
            //stringList.Add("b busy");
            //stringList.Add("c car");
            //stringList.Add("d dog");
            //stringList.Add("e enough");
            //stringList.Add("f free");
            //stringList.Add("g goodness");

            ////Ask for user input and assign to a variable
            //Console.WriteLine("Please select text to seach for in the list: ");
            //string userInputTextSearch = (Console.ReadLine());

            ////Create string for return message if none of the strings match
            //string returnMessage = "Sorry, none of the strings contain that search. Please try again";

            ////for loop that iterates through the stringList.count and uses the string listItemText with 
            //// the userInputSearch to verify if a list item contains the user input
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    string listItemText = stringList[i];

            //    if (listItemText.Contains(userInputTextSearch))
            //    {
            //        returnMessage = i.ToString();
            //        break;
            //    }
            //}

            ////Console.WriteLine the retunMessage if the for loop finds no match
            //Console.WriteLine(returnMessage);

            ////------------------------------SECTION END--------------------------------




            ////------------------------------SECTION BEGIN------------------------------
            ////This section is for step 9 and 10
            
            ////Create a list of strings where at least two items have matching strings
            //List<string> stringList = new List<string>();
            //stringList.Add("a apple");
            //stringList.Add("b busy");
            //stringList.Add("c car");
            //stringList.Add("d dog");
            //stringList.Add("e enough");
            //stringList.Add("f free");
            //stringList.Add("a apple goes boom");

            ////Ask for user input and assign to a variable
            //Console.WriteLine("Please select text to seach for in the list: ");
            //string userInputTextSearch = (Console.ReadLine());

            ////Create string for return message if none of the strings match
            //string returnMessage = "Sorry, none of the strings contain that search. Please try again";

            ////Bool for tracking if the first match has occured. If it has then the second if statement runs and concatenates an additional match
            //bool firstItem = true;

            ////for loop that iterates through the stringList.count and uses the string listItemText with 
            //// the userInputSearch to verify if a list item contains a match to the user input
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    string listItemText = stringList[i];
                
            //    //if loop for initial match
            //    if (listItemText.Contains(userInputTextSearch) && firstItem)
            //    {
            //        returnMessage = i.ToString();
            //        firstItem = false;
                  
            //    }

            //    //else if loop for additional matches to concatenate to firstItem
            //    else if (listItemText.Contains(userInputTextSearch) && !firstItem)
            //    {
            //        returnMessage += ", " + i.ToString();

            //    }

            //}

            ////Console.WriteLine the retunMessage if the for loop doesn't find a match
            //Console.WriteLine(returnMessage);

            ////------------------------------SECTION END--------------------------------




            ////------------------------------SECTION BEGIN------------------------------
            ////Step 11

            ////Create a list that has at least two identical strings.
            //List<string> stringList = new List<string>();
            //stringList.Add("a apple");
            //stringList.Add("b busy");
            //stringList.Add("c car");
            //stringList.Add("a apple");
            //stringList.Add("e enough");
            //stringList.Add("f free");
            //stringList.Add("a apple");

            ////Second list, empty
            //List<string> secondList = new List<string>();

            //////Create a foreach loop that evaluates each item in the list and displays a message
            ////// showing the string and if it has already appeared in the list or not
            //foreach (string str in stringList)
            //{
            //    if (secondList.Contains(str) == false) //checks is secondList has the current string
            //    {
            //        secondList.Add(str); //.Add str to secondList
            //        Console.WriteLine(str); //WriteLine str
            //    }
            //    else if (secondList.Contains(str) == true)
            //    {
            //        Console.WriteLine(str + ": Already Exists");
            //        continue;
                    
            //    }


            //}

            ////------------------------------SECTION END--------------------------------




            //------------------------------SECTION BEGIN------------------------------
            //This area is for testing purposes only
            //Console.WriteLine(exists);
            //Console.WriteLine(stringList);
            Console.ReadLine();

            //------------------------------SECTION END--------------------------------
        }
    }
}
