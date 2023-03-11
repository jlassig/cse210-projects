using static System.Console;
public class CheckListGoal : Goal
{

 private int _bonus;
 private int _goalAmount; // (amount of times to be accomplished)
 private int _currentAmount; //(current amount of times)

 public CheckListGoal()
 {
 }
 public CheckListGoal(string type, string name, string description, int points) : base(type, name, description, points)
 {

 }

 public CheckListGoal(string type, string name, string description, int points, int bonus, int goalAmount, int currentAmount) : base(type, name, description, points)
 {
  _bonus = bonus;
  _goalAmount = goalAmount;
  _currentAmount = currentAmount;
 }

 public int Bonus
 {
  get { return _bonus; }
  set { _bonus = value; }
 }
 public int GoalAmount
 {
  get { return _goalAmount; }
  set { _goalAmount = value; }
 }
 public int CurrentAmount
 {
  get { return _currentAmount; }
  set { _currentAmount = value; }
 }

 public override string SaveGoal()
 {
  string goalString = ($"{Type}|{Name}|{Description}|{Points}|{Bonus}|{GoalAmount}|{CurrentAmount}");
  return goalString;
 }

 public override void ListGoal(int counter)
 {
  string overachiever = "";
  char completed = ' ';
  if (GoalAmount == CurrentAmount)
  {
   completed = 'X';
  }
  else if (GoalAmount < CurrentAmount)
  {
   completed = 'X';
   overachiever = "Overachiever status unlocked";
  }
  WriteLine($"{counter}. [{completed}] {Type}: {Name} ({Description}) -- Currently completed: {CurrentAmount}/{GoalAmount} {overachiever}");

 }


}

