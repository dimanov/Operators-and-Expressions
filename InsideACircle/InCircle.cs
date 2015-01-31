/*
 * Problem 7. Point in a Circle
 * Write an expression that checks if given point (x, y) is inside a circle  K({0, 0}, 2) .
 */

using System;
using System.Globalization;
using System.Threading;


class InCircle
{
    static void Main()
    {
        //ensure the decimal separator is "." 
        //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double radius = 2;

        Console.Write("PLease enter the x-coordinate of the point! \nx=");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("PLease enter the y-coordinate of the point! \ny=");
        double yCoordinate = double.Parse(Console.ReadLine());
        
        double position = Math.Sqrt(xCoordinate*xCoordinate+yCoordinate*yCoordinate);

        if (position <= radius)
        {
            Console.WriteLine("The given point is inside a circle with raduis {0} and center (0,0)", radius);
        }
        else
        {
            Console.WriteLine("The given point is NOT inside a circle with raduis {0} and center (0,0)", radius);
        }
    }
}