/*
 * Problem 12. Extract Bit from Integer
 * Write an expression that extracts from given integer  n  the value of given bit at index  p .
 */

using System;


class Extractbit
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

        Console.WriteLine("The {0}th bit form left to right is \t\t{1}", position, (result != 0 ? 1 : 0));
    }
}