using static System.Console;


class ListActivity : Activity
{
 private List<string> promptList = new List<string>
 {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
 };

 private string _prompt;

 private int _responseCounter = 0;

 public ListActivity()
 {

 }
 public ListActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public ListActivity(string name, int seconds) : base(name, seconds)
 {
  _prompt = GetPrompt();
 }

 public string Prompt
 {
  get { return _prompt; }
  set { _prompt = value; }
 }

 public void ListIt()
 {
  WriteLine("List as many responses as you can to the following prompt:\n");

  WriteLine($"--{Prompt}--");
  Write("         You may begin in: ");
  CountdownTimer(5);
  WriteLine("");
  WriteLine("");
  GetResponses();
  WriteLine($"You listed {_responseCounter} items!");
 }

 public string GetPrompt()
 {
  var random = new Random();
  int index = random.Next(promptList.Count);
  return (promptList[index]);
 }

 public void GetResponses()
 {
  DateTime startTime = DateTime.Now;
  DateTime futureTime = startTime.AddSeconds(Seconds);

  DateTime currentTime = DateTime.Now;
  while (currentTime < futureTime)
  {
   Write("> ");
   string input = ReadLine();
   //make sure the user didn't just hit "enter" without entering anything!
   if (input.Length != 0)
   {
    //if the user put in a response, count it.
    _responseCounter++;
   }
   currentTime = DateTime.Now;
  }
 }
}