//I added:
// 1. fun animation on the Breathing Activity
// 2. another kind of Activity: Remote Viewing! well... Remote Viewing for a number. Pictures would've been cooler, but numbers were easier for me to figure out this time.
// 2. In the list activity, if the user hit enter, without adding anything, that doesn't get counted as an "item". 

using System;
//so that I don't have to use Console.WriteLine, I can just do WriteLine!
//my new best friend:
using static System.Console;

class Program
{

 static void Main(string[] args)
 {
  string menuChoice = "9";
  do
  {
   menuChoice = GetMenuChoice();

   if (menuChoice == "1")
   {
    BreatheActivity breath = new BreatheActivity();
    breath.Name = ("Breathing");
    breath.Instructions = ("This activity will help you relax \nby walking you through breathing in and out slowly. \nClear your mind and focus on your breathing.");
    BreatheActivity breathActivity = new BreatheActivity(breath.Name, breath.Instructions);
    breathActivity.Welcome();
    int seconds = breathActivity.GetTime();
    BreatheActivity breathActivity2 = new BreatheActivity(breath.Name, seconds);
    breathActivity2.GetReady();
    breathActivity2.Breathe();
    breathActivity2.EndMessage();
   }

   else if (menuChoice == "2")
   {
    ReflectActivity reflect = new ReflectActivity();
    reflect.Name = "Reflecting";
    reflect.Instructions = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    ReflectActivity reflectActivity = new ReflectActivity(reflect.Name, reflect.Instructions);
    reflectActivity.Welcome();
    int seconds = reflectActivity.GetTime();
    ReflectActivity reflectActivity2 = new ReflectActivity(reflect.Name, seconds);
    reflectActivity2.GetReady();
    reflectActivity2.Reflect();
    reflectActivity2.EndMessage();
   }

   else if (menuChoice == "3")
   {
    ListActivity list = new ListActivity();
    list.Name = "Listing";
    list.Instructions = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    ListActivity listActivity = new ListActivity(list.Name, list.Instructions);
    listActivity.Welcome();
    int seconds = listActivity.GetTime();
    ListActivity listActivity2 = new ListActivity(list.Name, seconds);
    listActivity2.GetReady();
    listActivity2.ListIt();
    listActivity2.EndMessage();
   }

   else if (menuChoice == "4")
   {
    RVActivity remoteView = new RVActivity();
    remoteView.Name = "Remote Viewing";
    remoteView.Instructions = "This activity will help you to channel your ability to see a hidden number.";
    RVActivity rvActivity = new RVActivity(remoteView.Name, remoteView.Instructions);
    rvActivity.Welcome();
    int seconds = rvActivity.GetTime();
    RVActivity rvActivity2 = new RVActivity(remoteView.Name, seconds);
    rvActivity2.RVFurtherInstructions();
    rvActivity2.GetReady();
    rvActivity2.RemoteView();
    rvActivity2.EndMessage();
   }

   else if (menuChoice != "5")
   {
    WriteLine("You entered an invalid number.");
    WriteLine("please enter a valid number between 1-4");
   }
  } while (menuChoice != "5");
 }

 static string GetMenuChoice()
 {
  string prettyLines = new string('-', 34);
  WriteLine("\n" + prettyLines);
  WriteLine("          Menu Options:");
  WriteLine(prettyLines);
  WriteLine("1. Start breathing activity");
  WriteLine("2. Start reflecting activity");
  WriteLine("3. Start listing activity");
  WriteLine("4. Start remote viewing activity");
  WriteLine("5. Quit");
  WriteLine(prettyLines + "\n");
  Write("Select a choice from the menu: ");
  string menuNum = ReadLine();
  return menuNum;
 }
}