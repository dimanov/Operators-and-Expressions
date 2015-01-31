/*
 * Problem 6. Four-Digit Number
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following: ◦ Calculates the sum of the digits (in our example  2 + 0 + 1 + 1 = 4 ).
 * Prints on the console the number in reversed order:  dcba  (in our example  1102 ).
 * Puts the last digit in the first position:  dabc  (in our example  1201 ).
 * Exchanges the second and the third digits:  acbd  (in our example  2101 ).

 * The number has always exactly 4 digits and cannot start with 0.
 */

using System;


class FourDigit
{
    static void Main()
    {
        Console.Write("Please enter a four-digit integer number: \t");
        int number = int.Parse(Console.ReadLine());

        //Initialize an array where digits of the number will be stored
        int[] digitsArray = new int[4];
        int lenght = digitsArray.Length;

        Console.Write("Prints the number in reversed order: \t\t");
        for (int count = 0; count < lenght; count++)
        {
            //Calculate every digit with the following formula "(number/(10^count)) % 10" 
            long degree = (long)Math.Pow(10, count);
            digitsArray[count] = (number / (int)degree) % 10;
            //Prints on the console the number in reversed order:
            Console.Write(digitsArray[count]);

        }
        Console.Write("\nPuts the last digit in the first position: \t");

        //Puts the last digit in the first position:  dabc  (in our example  1201 )
        Console.Write(digitsArray[0]);
        for (int count = lenght - 1; count > 0; count--)
        {
            Console.Write(digitsArray[count]);
        }
        Console.Write("\nExchanges the second and the third digits: \t");

        //Exchanges the second and the third digits:  acbd 
        //Just try anaother approach
        Console.WriteLine("{0}{2}{1}{3}", digitsArray[3], digitsArray[2], digitsArray[1], digitsArray[0]);
    }
}