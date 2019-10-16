using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        ////------------------------------SECTION BEGIN------------------------------
        ////Lists can be created with any datatype


        //////Creating a List with integers
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);

        ////Ability to use math on items within the list without any conversion
        //Console.WriteLine(intList[0] + intList[1]);
        //Console.ReadLine();

        ////Creating a List with strings
        //List<string> stringList = new List<string>();
        //stringList.Add("Hello ");
        //stringList.Add("Zach");
        //stringList.Add("Bob");
        //stringList.Remove("Bob");

        ////Ability to concatenate strings in List without any additional work
        //Console.WriteLine(stringList[0] + stringList[1]);
        //Console.ReadLine();
        ////------------------------------SECTION END--------------------------------


        ////------------------------------SECTION BEGIN------------------------------
        ////An Arrary is a C# contruct
        ////An Array should be used when you know the exact amount of items or when you are storing a very large amount of data

        //// Creating the new Array and assigning it 5 items in length
        //int[] numArray = new int[5];
        ////Inserting values into each item of the Array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////Initialize an Array and assigning value to its items in a single line
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 42 };

        ////Compact way to initialize an Array and assigning value to its items
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 42, 4242 };

        ////Assigning a new value to an item in an Array
        //numArray2[4] = 42;


        ////Addition, Multiplication, and division of items from Arrays
        //Console.WriteLine(numArray2[4] + numArray2[5] * numArray[0] / numArray1[1]);
        ////Console.WriteLine(numArray1[2]);
        ////Console.WriteLine(numArray[3]);
        //Console.ReadLine();
        ////------------------------------SECTION END--------------------------------
    }
}

