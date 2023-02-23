using static System.Console;
class ReflectActivity : Activity
{

 private List<string> _promptList = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
 private List<string> _questionList = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

 


 public ReflectActivity()
 {

 }

 public ReflectActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public ReflectActivity(string name, int seconds) : base(name, seconds)
 {

 }



 public string GetPrompt()
 {
  var random = new Random();
  int index = random.Next(_promptList.Count);
  return (_promptList[index]);
 }
 public string GetQuestion()
 {
  var random = new Random();
  int index = random.Next(_questionList.Count);
  return (_questionList[index]);
 }

 public void Reflect()
 {
  string prompt = GetPrompt();
  WriteLine("Consider the following prompt:");
  WriteLine($"\n--{prompt}--\n");
  WriteLine("When you have something in mind, press enter to continue.\n");
  string input = Console.ReadLine();
  Write($"Now ponder on each of the following questions as they relate to this experience. \nYou may begin in: ");
  CountdownTimer(5);
  WriteLine("");
  WriteQuestion();
 }

 public void WriteQuestion()
 {
  Clear();
  int numQuestions = Seconds / 10;
  for (int i = 0; i < numQuestions; i++)
  {
   string question = GetQuestion();
   Write($">{question} ");
   SpinTheSpinner(10);
   WriteLine("");
  }
 }
}