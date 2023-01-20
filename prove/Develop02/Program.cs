using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome to the Journal Program: ") ;
       int menuChoice = 9;
       Journal journal = new Journal();

do
{
   menuChoice = GetMenuOption();

//MUST HAVE DO-WHILE OR WHILE LOOP: 
        if (menuChoice == 1)
        {
         journal.AddEntry();
            //go to Journal, add Entry, generate prompt, entry itself
        }

            else if (menuChoice == 2)
        {
        journal.DisplayEntries();        
        }

        else if (menuChoice == 3)
        {
        journal.LoadFile();
        }

        else if (menuChoice == 4)
        {
        journal.SaveEntries();
        }

} while (menuChoice !=5);







 }

 static int GetMenuOption()
 {
  Console.WriteLine("Please select one of the following choices:");
  Console.WriteLine("1. Write");
  Console.WriteLine("2. Display");
  Console.WriteLine("3. Load");
  Console.WriteLine("4. Save");
  Console.WriteLine("5. Quit");
  Console.Write("What would you like to do? ");
  string menuString = Console.ReadLine();
  int menuChoice = int.Parse(menuString);

  return menuChoice;
 }
}