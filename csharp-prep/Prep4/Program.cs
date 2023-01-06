using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        int sum = 0;
        int bigNumber = 0;
        int smallNumber = 999999999;
        List<int> entries = new List<int>();

        do
        {
            //tell the user to enter a number:
            Console.Write("Enter a number: ");
            //get a number string from the user:
            string numberEntry = Console.ReadLine();
            //turn that into an integer:
            number = int.Parse(numberEntry);
            //if that number ISN'T zero, add it to the list:
            if (number != 0)
            {
                //adding to the list of entries:
            entries.Add(number);
            }
        }
        while (number != 0);

        foreach (int entry in entries)
        {
            //the sum of all the numbers in the list:
            sum += entry;

            //finding the biggest number entered:
            if (entry > bigNumber)
            {
                bigNumber = entry;
            }

            //STRETCH: finding the smallest positive number: 
            if (entry > 0 && entry < smallNumber)
            {
                smallNumber = entry;
            }
        }

        float average = ((float)sum) / entries.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The biggest number is: {bigNumber}");
        Console.WriteLine($"The smallest positive number is: {smallNumber}");
        Console.WriteLine($"The sorted list is: ");

        //STRETCH: Sorting the entries: 
        entries.Sort();
        foreach (int entry in entries)
        {
            Console.WriteLine(entry);
        }
        

        // List<string> words = new List<string>();
        // words.Add("candy");
        // words.Add("fish");
        // words.Add("bread");

        // //get the length of the list: 
        // Console.WriteLine($"Number of words in words: {words.Count}");

        // foreach (string word in words)
        // {
        // Console.WriteLine(word);
        // }
            }
}