using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction example1 = new Fraction(25 , 5);
        Console.WriteLine(example1.GetFractionString());
        Console.WriteLine(example1.GetDecimalValue());   

        Fraction example2 = new Fraction();
        Console.WriteLine(example2.GetFractionString());
        Console.WriteLine(example2.GetDecimalValue());

        Fraction example3 = new Fraction(5);
        Console.WriteLine(example3.GetFractionString());
        Console.WriteLine(example3.GetDecimalValue());


        Fraction example4 = new Fraction(3,4);
        Console.WriteLine(example4.GetFractionString());
        Console.WriteLine(example4.GetDecimalValue());


        Fraction example5 = new Fraction(1,3);
        Console.WriteLine(example5.GetFractionString());
        Console.WriteLine(example5.GetDecimalValue());

    }
}