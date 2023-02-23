
using static System.Console;
class Activity
{
 private string _name;
 private string _instructions;
 private int _seconds;

 public Activity()
 {

 }
 public Activity(string name, string instructions)
 {
  _name = name;
  _instructions = instructions;
 }
 public Activity(string name, int seconds)
 {
  _name = name;
  _seconds = seconds;
 }

//getting and setting a Name property
 public string Name
 {
  get { return _name; }
  set { _name = value; }
 }

 public string Instructions
 {
  get { return _instructions; }
  set { _instructions = value; }
 }

 public int Seconds
 {
  get { return _seconds; }
  set { _seconds = value; }
 }

 public void Welcome()
 {
  Clear();
  WriteLine($"Welcome to the {Name} Activity\n");
  WriteLine(Instructions + "\n");
 }
 public int GetTime()
 {
  //make sure the user gives a number:
  bool isNumber = false;

  while (isNumber == false)
  {
   //get the amount of time from the user, in seconds:
   Write("How long, in seconds, would you like for your session? ");
   // get the input:
   string secondsString = ReadLine();
   //check it is an integer and turn it into an integer:
   if (int.TryParse(secondsString, out _seconds))
   {
    isNumber = true;
   }

   else
   {
    WriteLine("Not a valid number, please try again.");
   }

  }

  return _seconds;
 }
 public void SpinTheSpinner(int numSpins)
 {
  string[] spinner = { "/", "-", "\\", "|" };
  int counter = 0;
  //hide the cursor during the animation:
  CursorVisible = false;

  while (counter < numSpins)
  {
   for (int i = 0; i < spinner.Length; i++)
   {
    Write(spinner[i]);
    Thread.Sleep(100);
    Console.Write("\b \b");

   }
   counter++;
  }
  CursorVisible = true;
 }

 public void GetReady()
 {
  Console.Clear();
  WriteLine("Get ready...");
  //add spinner!!!
  SpinTheSpinner(6);

 }
 public void EndMessage()
 {
  WriteLine("\nWell done!!\n");
  WriteLine($"You have completed another {Seconds} seconds of the {Name} Activity");
  //add spinner!!
  SpinTheSpinner(5);
 }
 public void CountdownTimer(int timerLength)
 {
  CursorVisible = false;
  for (int i = timerLength; i > 0; i--)
  {
   Write(i);
   Thread.Sleep(1000);
   if(i>99)
   {
    Write("\b\b\b   \b\b\b");
   }
   else if (i > 9)
   {
    Write("\b\b  \b\b");
   }
   else
   {
    Write("\b \b");
   }
  }
  Write("0");
  CursorVisible = true;
 }

 public void EatDotsTimer(int duration)
 {
  //I like having the cursor visible because it reminds me of Pac Man eating the dots!
  string dots = new string('.', duration);
  Write(dots);
  for (int i=duration; i>0; i--)
  {
   Thread.Sleep(1000);
   Write("\b \b");
  }

 }

 // public void DotTimer(int duration)
 // {
 //  CursorVisible = false;
 //  for (int i=duration; i>0; i--)
 //  {
 //   Write(".");
 //   Thread.Sleep(1000);
 //  }
 //  CursorVisible = true;

 // }


}