/*
 * Problem 3. Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by  7  and  5  at the same time.
 */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please, enter a number:");
        string str = Console.ReadLine();
        int number;
        int divisor1 = 7;
        int divisor2 = 5;

        //Check if number is entered
        if (int.TryParse(str, out number))
        {
            // Check if the number can be divided (without remainder) by  7  and  5  at the same time
            if ((number % divisor1 == 0) && (number % divisor2 == 0))
            {
                Console.WriteLine("{0} can be divided by  7  and  5  at the same time.", number);
            }
            else
            {
                Console.WriteLine("{0} can NOT be divided by  7  and  5  at the same time.", number);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a valid number.", str);
        }
    }
}