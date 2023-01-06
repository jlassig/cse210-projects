using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //A practice in functions.
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);
        DisplayResult(squared, name);

    }
    static void DisplayWelcome()
    {
    Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
    }
    static int PromptUserNumber()
    {
    Console.Write("Please enter your favorite number: ");
    string entryNumber = Console.ReadLine();
    int faveNumber = int.Parse(entryNumber);
    return faveNumber;
    }

    static int SquareNumber(int number)
    {
    int squaredNumber = number * number;
    return squaredNumber;
    }

    static void DisplayResult(int number, string name)
    {
    Console.WriteLine($"{name}, the square of your number is {number}");
    }
}

