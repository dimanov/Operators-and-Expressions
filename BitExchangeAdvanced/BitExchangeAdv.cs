/*
* Problem 16.** Bit Exchange (Advanced)
* Write a program that exchanges bits  {p, p+1, …, p+k-1}  with bits  {q, q+1, …, q+k-1}  of a given 32-bit unsigned integer.
* The first and the second sequence of bits may not overlap.
 */

using System;

class Bitsexchange
{
    static void Main()
    {
        Console.WriteLine("This program exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer");
        Console.Write("Please enter an unsigned integer number: \t");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("Enter position P: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter position Q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter step K: ");
        int k = int.Parse(Console.ReadLine());

        string strNumber = Convert.ToString(number, 2);
        Console.WriteLine("Number\t{0,10}\t =>\t{1,32}", number, strNumber);

        if (p > q)
        {
            int temp = q;
            q = p;
            p = temp;
        }

        if (p + k >= q || q + k > 32)
        {
            Console.WriteLine("The operation cannot be done.");
            return;
        }

        uint mask = ((number >> p) ^ (number >> q)) & ((1u << k) - 1);
        uint result = number ^ ((mask << p) | (mask << q));

        string strResult = Convert.ToString(result, 2);
        Console.WriteLine("Result\t{0,10}\t =>\t{1,32}", result, strResult);
    }
}
// 10x to Dentia for the solution