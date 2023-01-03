using System;

class Program
{
 static void Main(string[] args)
 {
  Console.Write("Enter your GPA: ");
  string gpaString = Console.ReadLine();
  int gpa = int.Parse(gpaString);
  char letterGrade = 'A';
  bool passedClass = true;
  string sign = "";


  if (gpa >= 90)
  {
   letterGrade = 'A';
  }
  else if (gpa >= 80)
  {
   letterGrade = 'B';
  }
  else if (gpa >= 70)
  {
   letterGrade = 'C';
  }
  else if (gpa >= 60)
  {
   letterGrade = 'D';
   passedClass = false;
  }
  else
  {
   letterGrade = 'F';
   passedClass = false;
  }

  int lastDigit = gpa % 10;
  if (lastDigit >= 7 && letterGrade != 'A' && letterGrade != 'F')
  {
   sign = "+";
  }
  else if (lastDigit <= 3 && letterGrade != 'F')
  {
   sign = "-";
  }


  Console.WriteLine($"Your grade is a {letterGrade}{sign}.");

  if (passedClass)
  {
   Console.WriteLine("Great Job! You passed the class!");
  }
  else
  {
   Console.WriteLine("You did not pass. Try again soon!");
  }

 }
}