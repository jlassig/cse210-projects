class Scripture
{
 Word word = new Word();

 private List<string> _wordsFromScripture;
 private string _scripture;


 public Scripture(string verseWords)
 {
  this._scripture = verseWords;
 }
 public string VerseWords
 {
  get
  {
   return _scripture;
  }
 }



 public void GetScriptureWords()
 {
  //add to _wordsFromScripture List from _scripture
  _wordsFromScripture = new List<string>(VerseWords.Split(' '));

 }
 public void DisplayScripture(string reference)
 {
  Console.Write($"{reference} ");
  int randoNum = GetRandomNumber();
  //'palabra' means 'word' in spanish. I get tired of using the same 'word' too many times.
  foreach (string palabra in _wordsFromScripture)
  {

   // https://www.geeksforgeeks.org/c-sharp-string-indexof-method-set-1/
   //get the index of the palabra in the List
   int num = _wordsFromScripture.IndexOf(palabra);

   //check if that index is in the Word._indicesUsed List
   if (randoNum == num)
    // {word.DisplayWord(CheckIfRandomUsed,randoNum, palabra);
    //check if the number is in the List _indicesUsed
    if (word.CheckIfRandomUsed(randoNum))
    { //if true, print a blank
     for (int i = 0; i < palabra.Length; i++)
     {
      Console.Write('_');
     }
     //add a space for inbetween the words:
     Console.Write(' ');
    }
    else
    {//if that number is not in _indicesUsed, then print it:
     Console.Write($"{palabra} ");
    }



   else
   {
    // word.DisplayWord(CheckIfIndexUsed, num, palabra);
    //check if the number is in the List _indicesUsed
    if (word.CheckIfIndexUsed(num))
    { //if true, print a blank
     for (int i = 0; i < palabra.Length; i++)
     {
      Console.Write('_');
     }
     //add a space for inbetween the words:
     Console.Write(' ');
    }
    else
    {//if that number is not in _indicesUsed, then print it:
     Console.Write($"{palabra} ");
    }
   }
  }
 }
 public int GetRandomNumber()
 {
  //random variable
  var random = new Random();
  //get a random number
  int randoNum = random.Next(_wordsFromScripture.Count);
  //has that number already been shown? 

  if (word.CheckIfHidden(randoNum))
  {   //IF YES: as long as the randoNum has been shown, then keep pulling a number until you find one that hasn't been shown.  
   while (word.CheckIfHidden(randoNum))
   {
    //get a random number from that the range of numbers in the length of the _wordsFromScripture List:
    randoNum = random.Next(_wordsFromScripture.Count);
   }
  }

  return randoNum;
 }


 public void ClearConsole()
 {
  Console.Clear();
 }
 public bool AllTheWords()
 {
  if (word.IsShownLength() == _wordsFromScripture.Count)
  {
   return true;
  }
  else
  {
   return false;
  }
 }
}