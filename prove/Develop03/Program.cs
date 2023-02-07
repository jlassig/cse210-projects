using System;

class Program
{
 static void Main(string[] args)
 {
  string scriptureText = "";
  string referenceString = "";
  string _input;

  Console.WriteLine("Welcome to the Scripture Memorizer!");
  Console.WriteLine("What scripture do you want to memorize?");
  Console.Write("Enter the Book Name (example: 1 Nephi, Doctrine and Covenants, Haggai): ");
  string book = Console.ReadLine();
  Console.Write("Enter the Chapter number: ");
  string chapterString = Console.ReadLine();
  int chapter = Int32.Parse(chapterString);
  Console.Write("Enter the Verse number: ");
  string verseString = Console.ReadLine();
  int verse = Int32.Parse(verseString);
  Console.Write("Do you want to enter another verse? Y or N: ");
  string answer = Console.ReadLine();

  if (answer.ToUpper() == "Y")
  {
   Console.Write("Enter the other verse number: ");
   string verse2String = Console.ReadLine();
   int verse2 = Int32.Parse(verse2String);
   Reference reference = new Reference(book, chapter, verse, verse2);
   referenceString = reference.DisplayReference();
   scriptureText = reference.GetScriptureString();
  }
  else
  {
   Reference reference = new Reference(book, chapter, verse);
   referenceString = reference.DisplayReference();
   scriptureText = reference.GetScriptureString();
  }

  Scripture scripture = new Scripture(scriptureText);


  scripture.GetScriptureWords();
  // scripture.ClearConsole();

  //this do-while loop runs the scripture so the user can memorize:
  do
  {
   scripture.ClearConsole();
   Console.WriteLine("");

   scripture.DisplayScripture(referenceString);
   Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish.");
   _input = Console.ReadLine();

   if (scripture.AllTheWords())

   {
    //methods to exit a C-sharp program:
    //  https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
    System.Environment.Exit(0);
   }
  }
  //how to exit out of the program: 
  while (_input.ToLower() != "quit");

  // 


  //  https://scriptures.nephi.org/  <--for adding to the bonus. I want the user to be able to choose any scripture! that would be cool!


 }
}