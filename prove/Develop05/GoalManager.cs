
using static System.Console;
using System.IO;

public class GoalManager
{
 private int _points = 0;
 private int _menuWidth = 40;
 private string _newLine = "newLine";
 private string _midLine = "midLine";
 private string _endLine = "endLine";
 private string _fileName = "";
 private List<Goal> _goalObjects = new List<Goal>();
 public GoalManager()
 {
 }

 public void Start()
 {
  string menuChoice = "9";
  do
  {
   menuChoice = GetMenuChoice();
   if (menuChoice == "1")
   {
    string goalChoice = "9";
    do
    {
     goalChoice = GetGoalType();

     WriteLine("Enter the name of your goal: ");
     string name = ReadLine();

     WriteLine("Enter a short description: ");
     string description = ReadLine();

     int points = 0;

     bool isNumber = false;

     while (isNumber == false)
     {
      //get the point value from the user:
      WriteLine("Enter the points value of your goal: ");
      // get the input:
      string pointsString = ReadLine();
      //check it is an integer and turn it into an integer:
      if (int.TryParse(pointsString, out points))
      {
       isNumber = true;
      }

      else
      {
       WriteLine("Not a valid number, please try again.");
      }

     }


     //CREATE NEW GOAL
     if (goalChoice == "1")
     {
      //SIMPLE GOAL
      string type = "Simple Goal";
      string isComplete = "False";
      SimpleGoal goal = new SimpleGoal(type, name, description, points, isComplete);
      _goalObjects.Add(goal);
     }

     else if (goalChoice == "2")
     {
      //ETERNAL GOAL
      string type = "Eternal Goal";
      EternalGoal goal = new EternalGoal(type, name, description, points);
      _goalObjects.Add(goal);
     }

     else if (goalChoice == "3")
     {
      //CHECKLIST GOAL
      string type = "Checklist Goal";

      WriteLine("How many times does this goal need to be done for a bonus? ");
      string goalAmountString = ReadLine();
      int goalAmount = Int32.Parse(goalAmountString);

      WriteLine("Enter the bonus amount for accomplishing it that many times: ");
      string bonusString = ReadLine();
      int bonus = Int32.Parse(bonusString);

      int currentAmount = 0;
      CheckListGoal goal = new CheckListGoal(type, name, description, points, bonus, goalAmount, currentAmount);
      _goalObjects.Add(goal);
     }

     else if (goalChoice != "4")
     {
      WriteLine("You entered an invalid number.");
      WriteLine("Please enter a valid number between 1-4.");
     }


     break;

    } while (goalChoice != "4");
   }

   else if (menuChoice == "2")
   {
    //LIST GOALS: 
    ListAllGoals();
   }

   else if (menuChoice == "3")
   {
    //SAVE GOALS
    SaveAllGoals(false);
   }

   else if (menuChoice == "4")
   {
    //LOAD GOALS
    LoadGoals();
   }

   else if (menuChoice == "5")
   {
    //RECORD EVENT
    RecordEvent();
   }

   else if (menuChoice == "6")
   {
    //DELETE GOAL
    DeleteGoal();
   }

   else if (menuChoice != "7")
   {
    WriteLine("You entered an invalid number.");
    WriteLine("please enter a valid number between 1-7");
   }

  } while (menuChoice != "7");
 }

 public string GetMenuChoice()
 {
  PrettifyLines(_newLine);
  CenterString("ETERNAL GOAL PROGRAM");
  CenterString($"Points earned: {_points}");
  PrettifyLines(_midLine);
  WriteLine("1. Create New Goal");
  WriteLine("2. List Goals");
  WriteLine("3. Save Goals");
  WriteLine("4. Load Goals");
  WriteLine("5. Record Event");
  WriteLine("6. Delete Goal");  //------------this is for my extra!
  WriteLine("7. Quit");
  PrettifyLines(_midLine);
  Write("Select a choice from the menu: ");
  string menuNum = ReadLine();
  return menuNum;
 }

 public void CenterString(string words)
 {
  int wordLength = words.Length / 2;
  int position = _menuWidth / 2 - wordLength;
  string spaces = new string(' ', position);
  WriteLine(spaces + words);
 }

 public string GetGoalType()
 {
  PrettifyLines(_newLine);
  string goalTypeString = ("Which goal do you want to create?");
  CenterString(goalTypeString);
  PrettifyLines(_midLine);
  WriteLine("1. Simple Goal");
  WriteLine("2. Eternal Goal");
  WriteLine("3. Checklist Goal");
  WriteLine("4. Go Back");
  PrettifyLines(_midLine);
  Write("Select a choice from the menu: ");
  string menuNum = ReadLine();
  return menuNum;
 }

 public void PrettifyLines(string line)
 {
  string prettyLines = new string('-', _menuWidth);
  if (line == _newLine)
  {
   WriteLine("\n" + prettyLines);
  }
  else if (line == _endLine)
  {
   WriteLine(prettyLines + "\n");
  }
  else
  {
   WriteLine(prettyLines);
  }
 }

 public void LoadGoals()
 {
  //before we load the goals from the txt file into the list, we want to clear the list:
  _goalObjects.Clear();
  GetFileName();
  //go through and read the file and add them into the array lines: 
  string[] lines = System.IO.File.ReadAllLines(_fileName);
  foreach (string line in lines)
  {
   string pointsString = lines[0];
   _points = Int32.Parse(pointsString);
  }
  //iterate through the txt.file, but skip the first line which is the _points. 
  foreach (string line in lines.Skip(1))
  {
   string[] parts = line.Split('|');
   if (parts.Length == 4) //eternal goal
   {
    EternalGoal goal = new EternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]));
    _goalObjects.Add(goal);
   }
   else if (parts.Length == 5)//simple goal
   {
    SimpleGoal goal = new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), parts[4]);
    _goalObjects.Add(goal);
   }
   else if (parts.Length == 7)//checklist goal
   {
    CheckListGoal goal = new CheckListGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
    _goalObjects.Add(goal);
   }
  }
 }

 public void ListAllGoals()
 {
  int counter = 1;
  foreach (Goal goalInstance in _goalObjects)
  {
   goalInstance.ListGoal(counter);
   counter++;
  }
 }

 public void GetFileName()
 {
  bool gotFileName = false;
  if (_fileName.Length == 0)
  {
   do
   {

    WriteLine("Enter the filename for the goal file: ");
    _fileName = ReadLine();
    try
    {
     using (StreamReader reader = new StreamReader(_fileName))
     {
      reader.ReadToEnd();
      gotFileName = true;

     }
    }
    catch (FileNotFoundException)
    {
     WriteLine("File not found. Please try again.");
    }
   } while (gotFileName == false);
  }
 }

 public void SaveAllGoals(bool overwrite)
 {
  GetFileName();

  //other than the first time, usually the file already has stuff in it, so it is false: 
  bool isEmptyFile = false;
  string[] lines = System.IO.File.ReadAllLines(_fileName);
  //we need to see if there is anything already in the save file. 
  //if the length is zero, then the file is empty. 
  if (lines.Length == 0)
  {
   isEmptyFile = true;
  }
  //if the file already has stuff in it
  if (isEmptyFile == false)
  {
   if (overwrite)
   {//this overwrites the goals in there
    using (StreamWriter outputFile = new StreamWriter(_fileName, false))
    {

     outputFile.WriteLine(_points);
     foreach (Goal goal in _goalObjects)
     {//then ONLY write the new goals. 
      outputFile.WriteLine(goal.SaveGoal());
     }
    }
   }
   //this only adds the new goals on, nothing else
   else
   {
    using (StreamWriter outputFile = File.AppendText(_fileName))
    {
     foreach (Goal goal in _goalObjects)
     {//then ONLY write the new goals. 
      outputFile.WriteLine(goal.SaveGoal());
     }
    }
   }
  }
  else
  {
   using (StreamWriter outputFile = new StreamWriter(_fileName))
   {

    //if the file is completely empty, then put in the points and the new goals. 
    outputFile.WriteLine(_points);
    foreach (Goal goal in _goalObjects)
    {
     outputFile.WriteLine(goal.SaveGoal());
    }
   }
  }
  //now empty the list of goals that the user is inputting
  _goalObjects.Clear();
 }


 public void DeleteGoal()
 {
  bool isNumber = false;
  int goalNumber = 0;
  LoadGoals();
  ListAllGoals();


  while (isNumber == false)
  {
   WriteLine("Which goal do you want to delete? ");
   string goalNumberString = Console.ReadLine();
   if (Int32.TryParse(goalNumberString, out goalNumber))
   {
    bool userNumInList = (goalNumber - 1) < _goalObjects.Count;
    if (userNumInList)
    {
     _goalObjects.RemoveAt(goalNumber - 1);
     //updating the file with the new information:
     SaveAllGoals(true);
     isNumber = true;
    }
    else
    {
     WriteLine("Ooops. You entered an invalid number.");
    }
   }
   else
   {
    WriteLine("Oops, that's not a number. Try again");
   }
  }
 }

 public void RecordEvent()
 {
  bool isNumber = false;

  LoadGoals();
  ListAllGoals();
  int goalNumber = 0;

  while (isNumber == false)
  {
   WriteLine("Which goal did you accomplish? ");
   // get the input:
   string goalNumberString = ReadLine();

   //check it is an integer and turn it into an integer:
   if (Int32.TryParse(goalNumberString, out goalNumber))
   {
    bool userNumInList = (goalNumber - 1) < _goalObjects.Count;
    if (userNumInList)
    {//Now to update the goal:
     //go through the list of goals in the goalObjects list
     for (int i = 0; i < _goalObjects.Count; i++)
     {
      //if the index matches the number that the user chose:
      if (i == goalNumber - 1)
      {

       Goal goal = _goalObjects[i];
       // add points from the goal to the total points
       _points += goal.Points;
       Animation(goal.Points);
       if (goal is SimpleGoal simpleGoal)  //simple goal
       {
        simpleGoal.IsComplete = "True";
       }
       else if (goal is CheckListGoal checkListGoal)//checklist goal
       {//add a BONUS if currentAmount = goalAmount

        checkListGoal.CurrentAmount++;
        if (checkListGoal.CurrentAmount == checkListGoal.GoalAmount)
        {
         CenterString("Congratulations!");
         CenterString($"You got a bonus of {checkListGoal.Bonus} points!");
         _points += checkListGoal.Bonus;

        }
       }
      }
     }
     SaveAllGoals(true);
     isNumber = true;
    }
    else
    {
     WriteLine("That number is invalid. Try again.");
    }
   }
   else
   {
    WriteLine("Oops, that's not a number! Please try again. ");
   }
  }
 }

 public void Animation(int pointsNumber)
 {
  CursorVisible = false;
  int numOfTimes = 5;
  int msNum = 200; //number of milliseconds
  for (int i = 0; i < numOfTimes; i++)
  {
   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                     .                            ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                 /                ");
   WriteLine("              *                 /                 ");
   WriteLine("              |                                   ");
   WriteLine("            \\ | /                                  ");
   WriteLine("          *--- ----*                               ");
   WriteLine("            / |\\                                  ");
   WriteLine("              |                                   ");
   WriteLine("              *                                    ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                   \\ | /                           ");
   WriteLine("                  -  *  -                         ");
   WriteLine("                   / | \\                          ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                  /               ");
   WriteLine("                                 /                ");
   WriteLine("              *                 /                 ");
   WriteLine("              |                                   ");
   WriteLine("                                                  ");
   WriteLine("          *-      -*                               ");
   WriteLine("                                                  ");
   WriteLine("              |                                    ");
   WriteLine("              *                                    ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                  *  |  *                         ");
   WriteLine("                   \\ | /                           ");
   WriteLine("                ---  *  ---                       ");
   WriteLine("                   / | \\                          ");
   WriteLine("                                                  ");
   WriteLine("                                   /              ");
   WriteLine("                                  /               ");
   WriteLine("                                 /                ");
   WriteLine("                                /                 ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                     |                            ");
   WriteLine("                  *  |  *                         ");
   WriteLine("                   \\ | /                           ");
   WriteLine("               ----  .  ----                      ");
   WriteLine("                   / | \\                          ");
   WriteLine("                  *  |  *           *              ");
   WriteLine("                     |             /              ");
   WriteLine("                                  /               ");
   WriteLine("                                 /                ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                \\                                 ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                     |                            ");
   WriteLine("                  *  |  *                         ");
   WriteLine("                   \\ | /                           ");
   WriteLine("             * ----  .  ---- *                    ");
   WriteLine("                   / | \\            |              ");
   WriteLine("                  *  |  *        -- * --            ");
   WriteLine("                     |             /|             ");
   WriteLine("                     *            /               ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("               \\                                  ");
   WriteLine("                \\                                 ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                     |                            ");
   WriteLine("                  *  |  *                         ");
   WriteLine("                   \\ | /                           ");
   WriteLine("             * ----     ---- *      *             ");
   WriteLine("                   / | \\            |             ");
   WriteLine("                  *  |  *      * --   -- *        ");
   WriteLine("                     |             /|             ");
   WriteLine("                     *              *             ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("              .                                    ");
   WriteLine("               \\                                  ");
   WriteLine("                \\                                 ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                     |                            ");
   WriteLine("                  *  |  *                         ");
   WriteLine("                   \\   /                           ");
   WriteLine("             * ---       --- *      *              ");
   WriteLine("                   /   \\                          ");
   WriteLine("                  *  |  *      *         *        ");
   WriteLine("                     |                            ");
   WriteLine("                     *              *             ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("              |                                   ");
   WriteLine("            --.--                                  ");
   WriteLine("              |\\                                  ");
   WriteLine("                \\                                 ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);

   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                     |                            ");
   WriteLine("                  *     *                         ");
   WriteLine("                                                   ");
   WriteLine("             * --         -- *                    ");
   WriteLine("                                                  ");
   WriteLine("                  *     *                         ");
   WriteLine("                     |                            ");
   WriteLine("                     *                            ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("              |                                   ");
   WriteLine("            \\ | /                                  ");
   WriteLine("           ---.----                                ");
   WriteLine("            / |\\                                  ");
   WriteLine("              | \\                                 ");
   WriteLine("                 \\                                ");
   Thread.Sleep(msNum);


   CongratsMessage(pointsNumber);
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                                                  ");
   WriteLine("                  *     *                         ");
   WriteLine("                                                   ");
   WriteLine("             *               *                    ");
   WriteLine("                                                  ");
   WriteLine("                  *     *                         ");
   WriteLine("                                                  ");
   WriteLine("                     *                            ");
   WriteLine("                                                  ");
   WriteLine("              *                 /                 ");
   WriteLine("              |                                   ");
   WriteLine("            \\ | /                                  ");
   WriteLine("          *---.----*                               ");
   WriteLine("            / |\\                                  ");
   WriteLine("              | \\                                 ");
   WriteLine("              *                                   ");
   Thread.Sleep(msNum);
  }
  Clear();
  CursorVisible = true;
 }


 public void CongratsMessage(int pointsInfo)
 {
  {
   Clear();
   WriteLine("                                                  ");
   WriteLine("                                                  ");
   WriteLine("               CONGRATULATIONS!                   ");
   WriteLine("                                                  ");
   WriteLine($"            You earned {pointsInfo} points!      ");
   WriteLine("                                                  ");
   WriteLine("                                                  ");
  }
 }
}


