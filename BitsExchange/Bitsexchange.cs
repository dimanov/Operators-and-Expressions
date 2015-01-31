/*
 * Problem 15.* Bits Exchange
 * Write a program that exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer.
 */

using System;


class Bitsexchange
{
    static void Main()
    {
        Console.WriteLine("This program exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer");
        Console.Write("Please enter an unsigned integer number: \t");
        uint number = uint.Parse(Console.ReadLine());
        string strNumber = Convert.ToString(number, 2);
        Console.WriteLine("Number\t{0,10}\t =>\t{1,32}", number, strNumber);
        for (int i = 3, j = 24; i < 6; i++, j++)
        {
            if (((number >> i) & 1) != ((number >> j) & 1))
            {
                number = ChangeBits(number, i, j);
            }
        }
        strNumber = Convert.ToString(number, 2);
        Console.WriteLine("Result\t{0,10}\t =>\t{1,32}", number, strNumber);
    }
    
    private static uint ChangeBits(uint number, int firstposition, int secondPosition)
    {
        number ^= (uint)(1 << firstposition);
        return number ^ (uint)(1 << secondPosition);
    }
}
// 10x to Dentia for the solution