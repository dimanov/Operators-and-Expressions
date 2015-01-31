/*
 * Problem 5. Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is  7 .
 */

using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        int oneHundredth = number / 100;
        if (oneHundredth % 10 == 7)
        {
            Console.WriteLine("The third digit of the number {0} is 7", number);
        }
        else
        {
            Console.WriteLine("The third digit of the number {0} is NOT 7", number);
        }
    }
}