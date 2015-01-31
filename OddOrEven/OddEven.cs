/*
 * Problem 1. Odd or Even Integers• 
 * Write an expression that checks if given integer is odd or even.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number:");
        string str = Console.ReadLine();
        int number;

        //Check if number is entered
        if (int.TryParse(str, out number))
        {
            // Check if the number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is an even number.", number);

            }
            else
            {
                Console.WriteLine("{0} is an odd number.", number);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number.", str);
        }

    }
}