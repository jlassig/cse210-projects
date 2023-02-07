using System.IO;
using System.Text.Json;
class Reference
{
 private string _book;
 private int _chapter;
 private int _verse;
 private int _verse2;

 public Reference(string book, int chapter, int verse)
 {
  this._book = book;
  this._chapter = chapter;
  this._verse = verse;
  _verse2 = -555;
 }
 public Reference(string book, int chapter, int verse, int verse2)
 {
  this._book = book;
  this._chapter = chapter;
  this._verse = verse;
  this._verse2 = verse2;
 }

 public string book
 {
  get
  {
   return _book;
  }
 }
 public int chapter
 {
  get
  {
   return _chapter;
  }
 }

 public int verse
 {
  get
  {
   return _verse;
  }
 }

 public int verse2
 {
  get
  {
   return _verse2;
  }
 }

 public string DisplayReference()
 {
  if (verse2 == -555)
  {
   return ($"{book} {chapter}:{verse}");
  }
  else
  {
   if((verse2-verse) == 1)
   {
   return ($"{book} {chapter}:{verse}-{verse2}");
   }
   else
   {
    return ($"{book} {chapter}:{verse},{verse2}");
   }
  }
 }


 public string GetScriptureString()
 {

  string scriptureText = "";
  string scriptureText2 = "";
  // https://www.educative.io/answers/how-to-read-a-json-file-in-c-sharp
  //turn the json into a incredibly long string.
  string textFromJson = File.ReadAllText(@"lds-scriptures.json");
  //now turn that string into a List
  JsonScripture[] jsonScriptures = JsonSerializer.Deserialize<JsonScripture[]>(textFromJson);
  //iterate through the list and check to see if the book/chapter/verse match. 
  if (verse2 == -555)
  {

   foreach (JsonScripture jsonScripture in jsonScriptures)
   {
    //if the book/chapter/title that the user entered:
    if (jsonScripture.book_title == book && jsonScripture.chapter_number == chapter && jsonScripture.verse_number == verse
  )
    {
     //pull the scripture text
     scriptureText = jsonScripture.scripture_text;
    }
   }
   return scriptureText;
  }
  //this is for 2 verses:
  else
  {
   foreach (JsonScripture jsonScripture in jsonScriptures)
   {
    if (jsonScripture.book_title == book && jsonScripture.chapter_number == chapter && jsonScripture.verse_number == verse
  )
    {
     //pull the scripture text
     scriptureText = jsonScripture.scripture_text;
    }
    if (jsonScripture.book_title == book && jsonScripture.chapter_number == chapter && jsonScripture.verse_number == verse2
  )
    {
     //pull the scripture text
     scriptureText2 = jsonScripture.scripture_text;
    }
   }
   return ($"{scriptureText} {scriptureText2}");
  }
 }

}