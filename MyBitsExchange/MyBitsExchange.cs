/*
 * Problem 15.* Bits Exchange
 * Write a program that exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer.
 */

using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


class Bitsexchange
{
    static void Main()
    {
        //Console.WriteLine("This program exchanges bits  3 ,  4  and  5  with bits  24 ,  25  and  26  of given 32-bit unsigned integer");
        //Console.Write("Please enter an unsigned integer number: \t");
        //uint number = uint.Parse(Console.ReadLine());

        uint number = 1140867093;
        string strNumber = Convert.ToString(number, 2);
        Console.WriteLine("Number\t\t{0,10}\t =>\t{1,32}", number, strNumber);

        //StringBuilder sb = new StringBuilder(strNumber);

        //Console.WriteLine(sb);

        uint initMask1 = 7 << 3;
        uint initMask2 = 7 << 24;

        //Console.WriteLine("initMask1\t{0,10}\t => \t{1,32}", initMask1, Convert.ToString(initMask1, 2));
        //Console.WriteLine("initMask2\t{0,10}\t => \t{1,32}", initMask2, Convert.ToString(initMask2, 2));

        uint wholeMask = initMask1 | initMask2;
        uint invertMask = ~wholeMask;

        uint midNumber1 = number & initMask1;
        uint midNumber2 = number & initMask2;

        //Console.WriteLine("wholeMask\t{0,10}\t => \t{1,32}", wholeMask, Convert.ToString(wholeMask, 2));
        //Console.WriteLine();
        Console.WriteLine("midNumber1\t{0,10}\t => \t{1,32}", midNumber1, Convert.ToString(midNumber1, 2));
        Console.WriteLine();
        Console.WriteLine("midNumber2\t{0,10}\t => \t{1,32}", midNumber2, Convert.ToString(midNumber2, 2));
        Console.WriteLine();
        Console.WriteLine("invertMask\t{0,10}\t => \t{1,32}", invertMask, Convert.ToString(invertMask, 2));

        midNumber1 <<= 21;
        midNumber2 >>= 21;

        Console.WriteLine("midNumber1\t{0,10}\t => \t{1,32}", midNumber1, Convert.ToString(midNumber1, 2));
        Console.WriteLine();
        Console.WriteLine("midNumber2\t{0,10}\t => \t{1,32}", midNumber2, Convert.ToString(midNumber2, 2));
        Console.WriteLine();




        //Console.WriteLine(String.Format(new BinaryFormatter(),  "{0} (binary: {0:B})", initMask1));

        //for (int i = 3, j = 24; i < 6; i++, j++)
        //{
        //    if (((number >> i) & 1) != ((number >> j) & 1))
        //    {
        //        number = ChangeBits(number, i, j);
        //    }
        //}
        //strNumber = Convert.ToString(number, 2);
        //Console.WriteLine("Result\t{0,10}\t =>\t{1,32}", number, strNumber);
    }

    //private static uint ChangeBits(uint number, int firstposition, int secondPosition)
    //{
    //    number ^= (uint)(1 << firstposition);
    //    return number ^ (uint)(1 << secondPosition);
    //}
}