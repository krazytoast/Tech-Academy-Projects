using System;

class Program
{
    static void Main(string[] args)
    {
        //------------------------------SECTION BEGIN------------------------------
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        }
        catch (FormatException ex)
        {
            //Console.WriteLine(ex.Message);
            Console.WriteLine("Please type a whole number.");
            return;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }


        //------------------------------SECTION END--------------------------------




        //------------------------------SECTION BEGIN------------------------------
        //This section is for testing
        //Console.ReadLine();


        //------------------------------SECTION END--------------------------------
    }
}

