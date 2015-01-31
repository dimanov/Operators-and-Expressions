/*
 * Problem 13. Check a Bit at Given Position
 * Write a Boolean expression that returns if the bit at position  p  (counting from  0 , starting from the right) in given integer number  n , has value of 1.
 */

using System;


class Checkbit
{
    static void Main()
    {
        Console.Write("Please enter an unsigned integer number: \t");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Please enter the bit position to be checked: \t");
        int position = int.Parse(Console.ReadLine());
        int mask = 1 << position;

        //bitwise AND
        int result = number & mask;

        Console.WriteLine(result != 0 ? "True" : "False");
    }
}