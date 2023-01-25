using System;


//Extra Points: 
//I added FileNotFoundError exception handling for the loading of the file in the DisplayEntries and SaveEntries methods in the Journal class.
//Because I normally get bored writing in a journal, I added a Bonus entry--This is a way for a user to get a more randomized assortment based on the day of the week. Things like favorites, silly entries or family history moments. Also, Saturday has freestyle writing. 
//date class --I added a date class so that I could get the date for the journal entry, the Bonus entry and the day of the week for the Bonus Entry. 
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("\nWelcome to the Journal Program: ") ;
       string _menuChoice = "9";
       Journal journal = new Journal();

  //loop for the MENU: 
  do
{
    //which menu # does the user want to do: 
   _menuChoice = GetMenuOption();

        if (_menuChoice == "1")
        {
            //go to Journal, add Entry, generate prompt, entry itself
            journal.AddEntry();
        }

        else if (_menuChoice == "2")
        {
            //displays all the entries from the file that the user chooses  
            journal.DisplayEntries();      
        }

        else if (_menuChoice == "3")
        {
            //loads a file
            journal.LoadFile();
        }

        else if (_menuChoice == "4")
        {
            //saves entries to the file the user chooses
            journal.SaveEntries();
        }
        else if (_menuChoice == "5")
        {
            journal.AddBonusEntry();
        }

        else if (_menuChoice != "6")
        {
            Console.WriteLine("You entered an invalid number.");
            Console.WriteLine("Please enter a number between 1-6");
        }
//QUIT: 
} while (_menuChoice != "6");
 }

//The MENU: 
 static string GetMenuOption()
 {
  
  Console.WriteLine ("\n*******************************************");
  Console.WriteLine("Please select one of the following choices:");
  Console.WriteLine("1. Write");
  Console.WriteLine("2. Display");
  Console.WriteLine("3. Load");
  Console.WriteLine("4. Save");
  Console.WriteLine("5. Bonus Entry");
  Console.WriteLine("6. Quit");
  Console.WriteLine("*******************************************\n");
  Console.Write("What would you like to do? ");

  string _menuChoice = Console.ReadLine();
  return _menuChoice;
 }
}