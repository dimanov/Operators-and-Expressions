/*
 * Problem 14. Modify a Bit at Given Position
 * We are given an integer number  n , a bit value  v  (v=0 or 1) and a position  p .
*  Write a sequence of operators (a few lines of C# code) that modifies  n  to hold the value  v  at the position  p  
 * from the binary representation of  n  while preserving all other bits in  n .
 */

using System;


class Modifybit
{
    static void Main()
    {
        Console.Write("Please enter an unsigned integer number: \t");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Please enter the bit position to be changed: \t");
        int position = int.Parse(Console.ReadLine());

        Console.Write("Please enter the bit value (0 or 1): \t\t");
        int bit = int.Parse(Console.ReadLine());

        Console.WriteLine("The result is \t\t\t\t\t{0}", (bit == 0 ? number = number & (~(1 << position)) : number = number | (1 << position)));
    }
}