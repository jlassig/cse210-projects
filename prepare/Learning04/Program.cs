using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Assignment assignment = new Assignment("Vanna White","Underwater Letter-Turning");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");

        MathAssignment mathwork = new MathAssignment("Bob Barker", "Finance", "Section 8.2", "Problems 1-10");
        Console.WriteLine(mathwork.GetSummary());
        Console.WriteLine(mathwork.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment essay = new WritingAssignment("Pat Sejak", "English", "Can I Buy a Vowel? ");
        Console.WriteLine(essay.GetSummary());
        Console.WriteLine(essay.GetWritingInformation());

    }
}