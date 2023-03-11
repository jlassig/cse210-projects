public class EternalGoal : Goal
{

 public EternalGoal()
 {
 }
 public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
 {

 }


 public override string SaveGoal()
 {
  string goalString = ($"{Type}|{Name}|{Description}|{Points}");
  return goalString;
 }
 public override void ListGoal(int counter)
 {
  Console.WriteLine($"{counter}. [ ] {Type}: {Name} ({Description})");

 }

}

