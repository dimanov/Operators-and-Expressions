/*
 * Problem 10. Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y) if it is within the circle  K({1, 1}, 1.5)  
 * and out of the rectangle  R(top=1, left=-1, width=6, height=2) .
 */

using System;


class InCircleOutRect
{
    static void Main()
    {
        //coordinates of the circle
        double xCenterCircle = 1;
        double yCenterCircle = 1;
        double radius = 1.5;

        //coordinates of the rectangle
        double xRectTopLeft = -1;
        double yRectTopLeft = 1;
        double rectWidth = 6;
        double rectHeight = 2;

        //Ask for coordinates of the point 
        Console.Write("PLease enter the x-coordinate of the point! \nx=");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.Write("PLease enter the y-coordinate of the point! \ny=");
        double yCoordinate = double.Parse(Console.ReadLine());
        
       //Check of the point is outside the rectangle
        bool check1 = xCoordinate < xRectTopLeft;
        bool check2 = yCoordinate > yRectTopLeft;
        bool check3 = xCoordinate > (xRectTopLeft + rectWidth);
        bool check4 = yCoordinate < (yRectTopLeft - rectHeight);
        bool rectResult = check1 || check2 || check3 || check4;

        //Check if the point is inside the cyrcle
        double position = Math.Sqrt((xCoordinate - xCenterCircle) * (xCoordinate - xCenterCircle) + (yCoordinate - yCenterCircle) * (yCoordinate - yCenterCircle));

        if ((position <= radius) && rectResult)
        {
            Console.WriteLine("YES\nThe given point is inside a circle with raduis {0} and center ({1},{2})\nAND outside the rectangle R(top={3}, left={4}, width={5}, height={6})", radius, xCenterCircle, yCenterCircle, xRectTopLeft, yRectTopLeft, rectWidth, rectHeight);
        }
        else
        {
            Console.WriteLine("NO\nThe given point is NOT inside a circle with raduis {0} and center ({1},{2})\nAND outside the rectangle R(top={3}, left={4}, width={5}, height={6})", radius, xCenterCircle, yCenterCircle, xRectTopLeft, yRectTopLeft, rectWidth, rectHeight);
        }
    }
}