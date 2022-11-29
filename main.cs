// Created by: sophie
// Created on: oct 2020
//
// This program tells you what kind of triangle you have or if it
//even is a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        int a;
        int b;
        int c;

        Console.Write("Enter length a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length b ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length c ");
        c = Convert.ToInt32(Console.ReadLine());

        int angleA = Math.acos((b**2 + c**2 - a**2) / (2 * b * c)) * (180/Math.PI)
        int angleB = Math.acos((c**2 + a**2 - b**2) / (2 * c * a)) * (180/Math.PI)
        int angleC = Math.acos((a**2 + b**2 - c**2) / (2 * a * b)) * (180/Math.PI)

        int sumOfAngles = Number((angleA).toFixed(2)) + Number((angleB).toFixed(2)) + Number((angleC).toFixed(2))


        if (sumOfAngles == 180)
        {
            if ((a == b) && (b == c) && (c == a))
            {
              
            }
        }
        Console.WriteLine("\nDone.");
    }
}