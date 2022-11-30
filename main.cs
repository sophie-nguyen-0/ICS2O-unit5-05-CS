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
        Console.Write("Enter length b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter length c: ");
        c = Convert.ToInt32(Console.ReadLine());

        double angleA = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * (180 / Math.PI);
        double angleB = Math.Acos((Math.Pow(c, 2) + Math.Pow(a, 2) - Math.Pow(b, 2)) / (2 * c * a)) * (180 / Math.PI);
        double angleC = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * (180 / Math.PI);

        double sumOfAngles = (Math.Round(angleA, 2)) + (Math.Round(angleB, 2)) + (Math.Round(angleC, 2));

        if (sumOfAngles == 180)
        {
            if ((a == b) && (b == c) && (c == a))
            {
                Console.WriteLine("It's an equilateral triangle!");
            }
          else if ((a == b) || (b == c) || (a == c))
          {
              Console.WriteLine("It's an isosceles triangle!");
          }
          else
          {
              Console.WriteLine("It's a scalene triangle!");
          }
        }
        else
        {
            Console.WriteLine("It's not a triangle!");
        }
        Console.WriteLine("\nDone.");
    }
}