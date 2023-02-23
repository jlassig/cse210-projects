
using static System.Console;
class RVActivity : Activity
{

 private int _maxNumber;
 private int _answer;
 private int _luckyNumber;
 public RVActivity()
 {

 }

 public RVActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public RVActivity(string name, int seconds) : base(name, seconds)
 {
 }


 public int GetRange()
 {
  Write("Choose any number greater than 9: ");
  bool isNumber = false;
  bool bigNumber = false;
  while (isNumber == false && bigNumber == false)
  {
   // get the input:
   string numInput = ReadLine();
   //check it is an integer and turn it into an integer:
   if (int.TryParse(numInput, out _maxNumber))
   {
    if (_maxNumber > 9)
    {
     bigNumber = true;
     isNumber = true;
    }
    else
    {
     WriteLine("Not a valid number, please try again.");
    }
   }
   else
   {
    WriteLine("Not a valid number, please try again.");
   }
  }
  return _maxNumber;
 }


 public int GetNumber()
 {
  GetRange();
  Random random = new Random();
  int randomNum = random.Next(0, _maxNumber);
  return randomNum;
 }

 public void RVFurtherInstructions()
 {
  _luckyNumber = GetNumber();
  Clear();
  WriteLine($"The computer is going to pull a random number from a range of 0 and {_maxNumber}\n");
  WriteLine("When the timer begins, breathe in and out and try to picture \nthat random number in your mind for the duration of the timer.\n");
  EatDotsTimer(7);
 }

 public void RemoteView()
 {
  Write("\nTimer: ");
  CountdownTimer(Seconds);
  int answerNumber = GetAnswer();
  CheckIfWin(_luckyNumber, answerNumber);
 }

 public int GetAnswer()
 {
  Console.Write("\nEnter the number you saw in your mind: ");
  bool isNumber = false;
  while (isNumber == false)
  {
   // get the input:
   string answerString = ReadLine();
   //check it is an integer and turn it into an integer:
   if (int.TryParse(answerString, out _answer))
   {
    isNumber = true;
   }
   else
   {
    WriteLine("Not a valid number, please try again.");
   }
  }
  return _answer;
 }
 public void CheckIfWin(int luckyNum, int answerNum)
 {
  if (answerNum == luckyNum)
  {
   WriteLine("Congratulations! You Win!");
  }
  else
  {
   WriteLine($"Oops! The number was: {luckyNum}");
   WriteLine("That's Ok. Try again soon!");
  }

 }


}