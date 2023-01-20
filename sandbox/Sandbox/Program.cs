using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime thisDay = DateTime.Now;
        Console.WriteLine(thisDay.ToShortDateString());
        
    }
}