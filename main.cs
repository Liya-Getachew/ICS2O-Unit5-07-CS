// Created by: liya getachew
// Created on: Dec 6 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the sum of all numbers from 1 to the user's chosen number
        int num;
        int sum = 0;

        Console.WriteLine("I'm not sure what this is called but...");
        Console.WriteLine("...Enter a POSITIVE number here:");
        Console.WriteLine("");

        Console.WriteLine("number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        for (int counter = 1; counter < num + 1; counter++)
        {
            sum += counter;
        }

        Console.WriteLine("Sum of all numbers from 1 to " + num + " = " + sum);
        Console.WriteLine("\nDone.");
    }
}