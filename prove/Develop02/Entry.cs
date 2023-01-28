class Entry
{

 //**********************************
 //  https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
 public string _prompt { get; set; }
 public string _date { get; set; }
 public string _newEntry { get; set; }

// private string _prompt;
// private string _date;
// private string _newEntry;
//  public Entry(){
//   _prompt = "";
//   _date = "";
//   _newEntry="";
//  }


 public override string ToString()
 {
  return ($"{_date}| {_prompt}| {_newEntry}");
 }


 // public List<Entry> _entries = new List<Entry>();


 // public string _prompt;
 // public string _date;
 // public string _entry;

 //  public Entry(string randomPrompt)
 // {
 //   _prompt = randomPrompt;
 //   _entry = getEntry();
 //   _date = GetDate();
 // }

 //   public string GetDate()
 //   {
 //    DateTime thisDay = DateTime.Now;
 //   // return (thisDay.ToShortDateString());
 //    _date = thisDay.ToShortDateString(); 
 //    return _date;
 //    //returns the date like "1/16/2023"

 //   }

   // public string getEntry()
   // {
   //  _newEntry = Console.ReadLine();
   //  return _newEntry; 
   // }


 //  public void DisplayEntry()
 //  {
 //   // string fullEntry = ($"{_date}, {_prompt}, {_entry}");
 //   // return fullEntry;
 //   Console.WriteLine($"{_date}, {_prompt}, {_entry}");

 // }

}

