/*
 * Problem 4. Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;
using System.Globalization;
using System.Threading;


class Rectangles
{
    static void Main()
    {
        //ensure the decimal separator is "." 
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double rectWidth;
        double rectHeight;
        double rectPerimeter;
        double rectArea;

        Console.Write("Please enter the width of the rectangle: ");
        rectWidth = double.Parse(Console.ReadLine());
        Console.Write("Please enter the height of the rectangle: ");
        rectHeight = double.Parse(Console.ReadLine());

        rectPerimeter = (rectWidth + rectHeight) * 2;
        rectArea = (rectWidth * rectWidth);

        Console.WriteLine("The perimeter of the rectangle is {0:F2}", rectPerimeter);
        Console.WriteLine("The area of the rectangle is {0:F2}", rectArea);
    }
}