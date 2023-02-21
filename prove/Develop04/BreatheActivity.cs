using static System.Console;
class BreatheActivity : Activity
{

 public BreatheActivity()
 {

 }

 public BreatheActivity(string name, string instructions) : base(name, instructions)
 {
 }
 public BreatheActivity(string name, int seconds) : base(name, seconds)
 {
 }


 public void Breathe()
 {
  //hide the cursor during the breathe in and out animations
  CursorVisible = false;
  int numBreaths = DivideUpBreaths();
  for (int i = 0; i < numBreaths; i++)
  {
   //each breath in is 5 seconds and each breath out is 5 seconds long
   BreatheIn();
   BreatheOut();
  }
  //now show the cursor:
  CursorVisible = true;
 }

 public int DivideUpBreaths()
 {
  ////DON'T FORGET TO CALCULATE IF THERE IS A REMAINDER!!!
  int breathingSeconds = Seconds / 10;
  return breathingSeconds;
 }

 //some simple C# console animations:
 // // https://www.youtube.com/watch?v=A3UqpcQu4E0
 public void BreatheIn()
 {

  BreatheInTop();
  WriteLine("");
  WriteLine("");
  WriteLine("");
  WriteLine("");
  WriteLine("    /\\ /\\");
  Thread.Sleep(1000);

  BreatheInTop();
  WriteLine("");
  WriteLine("");
  WriteLine("");
  WriteLine("    /\\ /\\");
  WriteLine("     | | ");
  Thread.Sleep(1000);

  BreatheInTop();
  WriteLine("");
  WriteLine("");
  WriteLine("    /\\ /\\");
  WriteLine("     | | ");
  WriteLine("     | | ");
  Thread.Sleep(1000);

  BreatheInTop();
  WriteLine("");
  WriteLine("    /\\ /\\");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  Thread.Sleep(1000);

  BreatheInTop();
  WriteLine("    /\\ /\\");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  Thread.Sleep(1000);
 }
 public void BreatheOut()
 {
  BreatheOutTop();
  WriteLine("    \\/ \\/");
  WriteLine("");
  WriteLine("");
  WriteLine("");
  WriteLine("");
  Thread.Sleep(1000);

  BreatheOutTop();
  WriteLine("     | | ");
  WriteLine("    \\/ \\/");
  WriteLine("");
  WriteLine("");
  WriteLine("");
  Thread.Sleep(1000);

  BreatheOutTop();
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("    \\/ \\/");
  WriteLine("");
  WriteLine("");
  Thread.Sleep(1000);

  BreatheOutTop();
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("    \\/ \\/");
  WriteLine("");
  Thread.Sleep(1000);

  BreatheOutTop();
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("     | | ");
  WriteLine("    \\/ \\/");
  Thread.Sleep(1000);
 }

 public void BreatheInTop()
 {
  Clear();
  WriteLine("");
  WriteLine("Breathe IN...");
  WriteLine("");
  WriteLine("     O O ");
  WriteLine("      o  ");
  WriteLine("");


 }

 public void BreatheOutTop()
 {
  Clear();
  WriteLine("");
  WriteLine("Breathe OUT...");
  WriteLine("");
  WriteLine("     - - ");
  WriteLine("      o  ");
  WriteLine("");
 }
}