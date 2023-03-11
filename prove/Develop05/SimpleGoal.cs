public class SimpleGoal : Goal
{
 private string _isComplete;

 public SimpleGoal()
 {
 }
 public SimpleGoal(string type, string name, string description, int points, string isComplete) : base(type, name, description, points)
 {
  _isComplete = isComplete;
 }

 public string IsComplete
 {
  get { return _isComplete; }
  set { _isComplete = value; }
 }


 public override string SaveGoal()
 {
  string goalString = ($"{Type}|{Name}|{Description}|{Points}|{IsComplete}");
  return goalString;
 }
 public override void ListGoal(int counter)
 {
  char completed = ' ';
  if (IsComplete == "True")
  {
   completed = 'X';
  }

  Console.WriteLine($"{counter}. [{completed}] {Type}: {Name} ({Description})");

 }


}




