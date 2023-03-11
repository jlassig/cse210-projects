//I added a fun animation for the user whenever they record an event because I think that every. single. time. is worth celebrating! 
//I also added a way for the user to delete a goal, especially the ones they've already achieved like the checklist goal and the eternal goal. 
//I added a method called GetFileName, so the user only had to enter the fileName once per session. 

using System;


class Program
{

 static void Main(string[] args)
 {
  GoalManager session = new GoalManager();
  session.Start();
 }
}

