
using static System.Console;
class RVActivity : Activity
{

 private int maxNumber;
 private int answer;
 private int luckyNumber;
 public RVActivity()
 {

 }

 public RVActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public RVActivity(string name, int seconds) : base(name, seconds)
 {
 }

 // public int GetRange()
 // {
 //  Write("Choose any number greater than 9: ");
 //  bool isNumber = false;
 //  while (isNumber == false)
 //  {
 //   // get the input:
 //   string numInput = ReadLine();
 //   //check it is an integer and turn it into an integer:
 //   if (int.TryParse(numInput, out maxNumber))
 //   {
 //    isNumber = true;
 //   }
 //   else
 //   {
 //    WriteLine("Not a valid number, please try again.");
 //   }
 //  }
 //  return maxNumber;
 // }
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
   if (int.TryParse(numInput, out maxNumber))
   {
    if (maxNumber > 9)
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
  return maxNumber;
 }


 public int GetNumber()
 {
  GetRange();
  Random random = new Random();
  int randomNum = random.Next(0, maxNumber);
  return randomNum;
 }

 public void RVFurtherInstructions()
 {
  luckyNumber = GetNumber();
  Clear();
  WriteLine($"The computer is going to pull a random number from a range of 0 and {maxNumber}\n");
  WriteLine("When the timer begins, breathe in and out and try to picture \nthat random number in your mind for the duration of the timer.\n");
  Thread.Sleep(8000);
 }

 public void RemoteView()
 {
  Write("Timer: ");
  CountdownTimer(Seconds);
  int answerNumber = GetAnswer();
  CheckIfWin(luckyNumber, answerNumber);
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
   if (int.TryParse(answerString, out answer))
   {
    isNumber = true;
   }
   else
   {
    WriteLine("Not a valid number, please try again.");
   }
  }
  return answer;
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