using static System.Console;
class ReflectActivity : Activity
{

 private List<string> promptList = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
 private List<string> questionList = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

 private string _prompt;
 private string _question;

 public ReflectActivity()
 {

 }

 public ReflectActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public ReflectActivity(string name, int seconds) : base(name, seconds)
 {
  _prompt = GetPrompt();
 }

 public string Prompt
 {
  get { return _prompt; }
  set { _prompt = value; }
 }

 public string GetPrompt()
 {
  var random = new Random();
  int index = random.Next(promptList.Count);
  return (promptList[index]);
 }
 public string GetQuestion()
 {
  var random = new Random();
  int index = random.Next(questionList.Count);
  return (questionList[index]);
 }

 public void Reflect()
 {
  WriteLine("Consider the following prompt:");
  WriteLine($"\n--{Prompt}--\n");
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
   _question = GetQuestion();
   Write($">{_question} ");
   SpinTheSpinner(10);
   WriteLine("");
  }
 }
}