using System.IO;
public class Journal
{


 List<Entry> entries = new List<Entry>();

// public string fileName = "entries.txt";
public string fileName;


 public void AddEntry()
{ // this just appends to a list. if the user doesn't "save" it, it will be lost forever. 
//first define a new instance of PromptGenerator
  PromptGenerator journalPrompt = new PromptGenerator();
  //pull out the prompt and assign it to a string variable
  string randomPrompt = journalPrompt.prompt;
  //write the string prompt: 
  Console.WriteLine(randomPrompt);
  string userEntry = Console.ReadLine();
////adding to the entries List the info for the recent entry
  entries.Add(new Entry() {Date = GetDate(), Prompt = randomPrompt, NewEntry = userEntry});

//iterating through the list to see if the full list prints. 
  foreach (Entry i in entries)
  {
    Console.WriteLine(i);
  }

}

public void SaveEntries()
{
  fileName = LoadFile();
  //NOTE to self: if you put "true" as a second argument, it doesn't overwrite what was previously written 
  //"using" is like "with" in Python in that it opens and subsequently closes the file when I am done. 
  //StreamWriter: "StreamWriter object is used to define a stream. The stream is then used to write data from the application to the file." --guru99.com 
  using (StreamWriter outputFile = new StreamWriter(fileName))
  {
   //going through the list of entries in the List:
   foreach (Entry i in entries)
   {
    //and then writing them to the txt file in the StreamWriter. 
    outputFile.WriteLine(i);

   }

  // outputFile.WriteLine("Julia is awesome");

  }

 }
public void DisplayEntries()
{
  fileName = LoadFile();
  //this shows all the entries in the "journal". 
 string[] lines = System.IO.File.ReadAllLines(fileName);
 //iterating through the entries in the txt file
 foreach (string line in lines)
   {
    //separating each line into parts
    string[] parts = line.Split(",");
    //the parts are defined here
    string date = parts[0];
    string prompt = parts[1];
    string entry = parts[2];
    //putting the parts into a readable string: 
    Console.WriteLine($"Date: {date} - Prompt: {prompt} - Entry: {entry}");
   }


}

public string LoadFile()
{
  Console.Write("What file do you want to open? ");
  fileName = Console.ReadLine();

  ////https://rollbar.com/blog/csharp-filenotfoundexception/#:~:text=One%20of%20the%20most%20commonly,mismatch%20in%20the%20file%20name.
  // try{
  //   using (StreamReader reader = new StreamReader(fileName)){
  //     reader.ReadToEnd();

  //   }}
  //   catch{FileNotFoundException e)
  //   {
  //     Console.WriteLine(e.ToString());
  //   }

  //   }
  return fileName;
 //load the file and set the "fileName" to the file the user entered.




}

//getting the current date
  public string GetDate()
  {
   DateTime thisDay = DateTime.Now;
   return (thisDay.ToShortDateString());
   //returns the date like "1/16/2023"

  }
//where the user enters their entry for the journal
  // public string GetEntry()
  // {
  //   return Console.ReadLine();

  // }



}