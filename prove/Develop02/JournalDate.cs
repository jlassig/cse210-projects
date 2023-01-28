using System;
class JournalDate{
 private string _theDate;
 private int _theDay;


 public JournalDate(){
  _theDate = GetDate();
  _theDay = GetTheDay();
 }


 // getting the current date
 public string GetDate()
 {
  DateTime _thisDate = DateTime.Now;
  return (_thisDate.ToShortDateString());
  //returns the date like "1/16/2023"

 }
 public int GetTheDay()
 {
  DateTime _thisDay = DateTime.Now;
  // int weekday = _thisDay.DayOfWeek;
  return((int)_thisDay.DayOfWeek);
 }


}