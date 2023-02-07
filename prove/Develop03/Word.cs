class Word
{

 //all the indexes that have been used
 private List<int> _indicesUsed = new List<int>();
 //all the indexes that have been hidden already
 private List<int> _isHidden = new List<int>();

 //check to see if the random number in Scripture class in the GetRandomNumber() method has been used yet., if it has, the GetRandomNumber() method pulls a different one 
 public bool CheckIfRandomUsed(int num)
 {
  // https://www.geeksforgeeks.org/c-sharp-how-to-check-whether-a-list-contains-a-specified-element/
  // Check to see if the number that was passed in as an argument is in the _indicesUsed list. 
  if (_indicesUsed.Contains(num))
  {
   return true;
  }

  else
  {
   _indicesUsed.Add(num);
   return false;
  }

 }
 //has that index been used yet? 
 public bool CheckIfIndexUsed(int num)
 {
  return (_indicesUsed.Contains(num));

 }
 //within the GetRandomNumber() method in Scripture class, we check to see if the number is already hidden. 
 public bool CheckIfHidden(int num)
 {
  if (_isHidden.Contains(num))
  {
   return true;
  }
  else
  {
   _isHidden.Add(num);
   return false;
  }
 }
 //checking the index length of _isHidden so we can compare it to the _wordsFromScripture List to see if AllTheWords() have been used yet.  (_wordsFromScripture and AllTheWords() are in Scripture class)
 public int IsShownLength()
 {
  return _isHidden.Count;
 }








}