using static System.Console;

public abstract class Goal
{
 private string _type;  //the type of Goal
 private string _name;
 private string _description;
 private int _points;

 private List<string> _goalList = new List<string>();

 public Goal()
 {
 }

 public Goal(string type, string name, string description, int points)
 {
  _type = type;
  _name = name;
  _description = description;
  _points = points;
 }

 public string Type
 {
  get { return _type; }
  set { _type = value; }
 }

 public string Name
 {
  get { return _name; }
  set { _name = value; }
 }

 public string Description
 {
  get { return _description; }
  set { _description = value; }
 }

 public int Points
 {
  get { return _points; }
  set { _points = value; }
 }



 //----------METHODS-----------


 public abstract string SaveGoal();
 //SaveGoals() abstract method that writes out the different things needed for each goalType to save.

 public abstract void ListGoal(int counter);










}












