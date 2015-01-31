/*
 * Problem 9. Trapezoids
 * Write an expression that calculates trapezoid's area by given sides  a  and  b  and height  h .
 */

using System;

class Trapezoid
{
    static void Main()
    {
        //To find the area of a trapezoid, take the sum of its bases, 
        //multiply the sum by the height of the trapezoid, and then divide the result by 2
        double trapBase1;
        double trapBase2;
        double trapHeight;
        double trapArea;

        Console.Write("Please enter the base 1 of the trapezoid: ");
        trapBase1 = double.Parse(Console.ReadLine());
        Console.Write("Please enter the base 2 of the trapezoid: ");
        trapBase2 = double.Parse(Console.ReadLine());
        Console.Write("Please enter the height of the trapezoid: ");
        trapHeight = double.Parse(Console.ReadLine());

        trapArea = (trapBase1 + trapBase2) * trapHeight / 2;

        Console.WriteLine("The area of the trapezoid is {0:F2}", trapArea);
    }
}