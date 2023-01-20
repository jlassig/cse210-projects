class Entry
{

 //**********************************
 // https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=net-7.0
public string Prompt{ get; set;}
public string Date{get; set;}
public string NewEntry{get; set;}

 
 public override string ToString()
 {
  return ($"{Date}, {Prompt}, {NewEntry}");
 }

 
 // public string DisplayEntry()
 // {
 //  return ($"{Date}, {Prompt}, {NewEntry}");
 // }


 // public string prompt;
 // public string date;
 // public string entry;




 //  public Entry(string randomPrompt)
 // {
 //   prompt = randomPrompt;
 //   entry = getEntry();
 //   date = GetDate();
 // }

 //  public string GetDate()
 //  {
 //   DateTime thisDay = DateTime.Now;
 //   return (thisDay.ToShortDateString());
 //   //returns the date like "1/16/2023"

 //  }

 //  public string getEntry()
 //  {
 //   entry = Console.ReadLine();
 //   return entry; 
 //  }


 // public string DisplayEntry()
 // {
 //  string fullEntry = ($"{date}, {prompt}, {entry}");
 //  return fullEntry;
 // }






}

