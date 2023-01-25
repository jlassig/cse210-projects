using System.IO;
public class Journal
{
  


  List<Entry> _entries = new List<Entry>();
//  List<Entry> _entries = new List<Entry>();
  // public string fileName = "entries.txt";
  public string _fileName;
  public string _errorMessage = "That file was not found. Check the spelling.";

  public void AddEntry()
  { // this just appends to a list. if the user doesn't "save" it, it will be lost forever. 
    //first get the date: 
    JournalDate newDate = new JournalDate();
    string journalDate = newDate._theDate;

    //next define a new instance of PromptGenerator
    PromptGenerator journalPrompt = new PromptGenerator();
    //pull out the prompt and assign it to a string variable
    string randomPrompt = journalPrompt._prompt;
    //write the string prompt: 
    Console.WriteLine(randomPrompt);
    Console.Write("> ");
    string _userEntry = Console.ReadLine();
    ////adding to the entries List the info for the recent entry
    _entries.Add(new Entry() {_date = journalDate, _prompt = randomPrompt, _newEntry = _userEntry});

  // // // //iterating through the list to see if the full list prints. 
  // // foreach (Entry entry in _entries)
  // // {
  // //   Console.WriteLine(entry);
  // // }

  }

  public void SaveEntries()
  {
    _fileName = LoadFile();
    if(_fileName == _errorMessage)
    {
      Console.WriteLine(_errorMessage);
      Console.WriteLine("Please try again");
    }
    else
    {
    //NOTE to self: if you put "true" as a second argument, it doesn't overwrite what was previously written 
    //"using" is like "with" in Python in that it opens and subsequently closes the file when I am done. 
    //StreamWriter: "StreamWriter object is used to define a stream. The stream is then used to write data from the application to the file." --guru99.com 
    using (StreamWriter outputFile = new StreamWriter(_fileName, true))
    {
    //going through the list of entries in the List:
    foreach (Entry i in _entries)
    {
      //and then writing them to the txt file in the StreamWriter. 
      outputFile.WriteLine(i);

    }
    }
    }

  }
  public void DisplayEntries()
  {
    _fileName = LoadFile();
    if (_fileName == _errorMessage)
    {
      Console.WriteLine(_errorMessage);
      Console.WriteLine("Please try again");
    }
    else{
      //this shows all the entries in the "journal". 
      string[] lines = System.IO.File.ReadAllLines(_fileName);
    //iterating through the entries in the txt file
      foreach (string line in lines)
    
        {
          //separating each line into parts
          string[] parts = line.Split("|");
          //the parts are defined here
          string date = parts[0];
          string prompt = parts[1];
          string entry = parts[2];
          //putting the parts into a readable string: 
          Console.WriteLine($"\nDate: {date} - Prompt: {prompt} \nEntry: {entry}");
        }
       }

  }

  public string LoadFile()
  {
    //load the file and set the "fileName" to the file the user entered.
    Console.Write("What file do you want to open? ");
    _fileName = Console.ReadLine();

    //https://rollbar.com/blog/csharp-filenotfoundexception/#:~:text=One%20of%20the%20most%20commonly,mismatch%20in%20the%20file%20name
    try
    {
      using (StreamReader reader = new StreamReader(_fileName)){
        reader.ReadToEnd();
        return _fileName;
      }
    }
    catch(FileNotFoundException)
    {
  // Console.WriteLine(e.ToString());
      // return (e.ToString());
      _fileName = _errorMessage;
    
      return _fileName;
    }

  }

  public void AddBonusEntry()
  { // this just appends to a list. if the user doesn't "save" it, it will be lost forever. 

    //first get the date: 
    JournalDate newDate = new JournalDate();
    string journalDate = newDate._theDate;
    //first define a new instance of PromptGenerator
    PromptGenerator _bonusJournalPrompt = new PromptGenerator();
    //pull out the prompt and assign it to a string variable
    string _bonusRandomPrompt = _bonusJournalPrompt._bonusPrompt;
    //write the string prompt: 
    Console.WriteLine(_bonusRandomPrompt);
    Console.Write("> ");
    string _userEntry = Console.ReadLine();
    ////adding to the entries List the info for the recent entry
    _entries.Add(new Entry() { _date = journalDate, _prompt = _bonusRandomPrompt, _newEntry = _userEntry });

  // //   // //iterating through the list to see if the full list prints. 
  // //   foreach (Entry entry in _entries)
  // //   {
  // //    Console.WriteLine(entry);
  // //   }
  }

  

}