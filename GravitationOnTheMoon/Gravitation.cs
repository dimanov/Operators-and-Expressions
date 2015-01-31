/*
 * Problem 2. Gravitation on the Moon
 * The gravitational field of the Moon is approximately  17%  of that on the Earth.
 * Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Please, enter your weight:");
        string str = Console.ReadLine();
        float earthWeight;
        float moonGravitation = 0.17F;
        //Check if number is entered
        if (float.TryParse(str, out earthWeight))
        {
            // Calculate the weight on the Moon
            Console.WriteLine("Your weight on the Moon should be {0:F2} kg", earthWeight * moonGravitation);
        }
        else
        {
            Console.WriteLine("{0} is not a valid number.", str);
        }
    }
}