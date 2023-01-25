public class PromptGenerator
{
 public string _prompt;
 public string _bonusPrompt;


 List<string> _prompts = new List<string> { "What was I most grateful for today and why? ", "When did I feel the Spirit today? ", "How did I see the Lord's hand in my life today? ", "Is there anything I did today that I will do different next time? ", "Did the Spirit prompt me to do something today? ", "What questions do I have for my scripture study and prayers tomorrow? ", "What was the best part of my day today? " };

//Sunday - quotes
List<string> _sundayPrompts = new List<string>{"Nelson Mandela said, 'Education is the most powerful weapon which you can use to change the world.' ", "Amanda Gorman said, 'There is always light. If only we're brave enough to see it. If only we're brave enough to be it.' ", "Booker T. Washington said, 'If you want to lift yourself up, lift up someone else.' ", "Rosa Parks said, 'We will fail when we fail to try.' ", "President Russell M. Nelson said, 'Each day is a day of decision, and our decisions determine our destiny.' "};


//Monday - Family History Moment
List<string> _mondayPrompts = new List<string>{"Write about an experience you had with your grandma or grandpa. ", "Write about an experience you had with your aunt or uncle. ", "Write about an experience you had with one of your parents. ", "Write about an experience you had with one of your siblings ", "Which of your family members do you most admire and why? ", "Write about one of your early memories. ", "Write about a trip you've taken. "};


//Tuesday - Favorites
 List<string> _tuesdayPrompts = new List<string>{"Describe in detail one of your favorite kinds of foods. ", "Write about a favorite trip that you took. Would you ever go back? ", "Name the song and artist that is at the top of your playlist right now. ", "Name a person that you are following on social media and tell why you follow them. "
 };

 //Wednesday - Glimpse of Today
 List<string> _wednesdayPrompts = new List<string>{"What is the price of gasoline per gallon today? ", "What is the name and cost of your favorite snack food today? ", "What is the top headline today? ", "Which song and artist are at the top of the charts today? ", "What new movie is getting released today? ", "Write your feelings about a recent General Conference talk. Include the author and title. "};


 //Thursday - Future- dreams and goals
 List<string> _thursdayPrompts = new List<string>{"Where do you see yourself in 5 years? ", "What goals are you currently working on? ", "Is this where you imagined yourself 5 years ago? Is it better or worse and why? ", "What one goal could you set for today that could help you? ", "Name a place on your bucket list that you want to travel to. Make a plan to get there. ", "If this was your last decade on Earth, what would you do differently? Make a goal about that. ", "What is your greatest dream? " };

 //Friday -silly 
 List<string> _fridayPrompts = new List<string>{
  "Do plants have souls? ", "Describe a weird dream you've had and then try to give the interpretation. ", "Pretend you can time travel. Write a pretend journal entry from the year 3001. ", "If you could invent anything, what would it be? ","What do you look for in the perfect imaginary friend. Why do you choose those attributes? " 
 };


//Saturday is just freestyle writing







 public PromptGenerator()
 {
    _prompt = RandomPrompt();
    _bonusPrompt = GetBonusPrompt();
 }


 public string RandomPrompt()
 {
 //return a string that has the prompt choice.
 //I got help from this website: 
 // https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
  var random = new Random();
  int index = random.Next(_prompts.Count);
  return (_prompts[index]);
 }

 public string GetBonusPrompt()
{
   JournalDate newDate = new JournalDate();
   int journalDate = newDate._theDay;
   var randomBonus = new Random(); 
   int index;  
   
   if (journalDate == 0)
   {
    index = randomBonus.Next(_sundayPrompts.Count);
    return ($"Write your thoughts about this quote:{_sundayPrompts[index]}");
   }
   else if(journalDate == 1)
   {
    index = randomBonus.Next(_mondayPrompts.Count);
    return (_mondayPrompts[index]);
   }   
   else if (journalDate == 2)
   {
    index = randomBonus.Next(_tuesdayPrompts.Count);
    return (_tuesdayPrompts[index]);
   }
   else if (journalDate ==3)
   {
    index = randomBonus.Next(_wednesdayPrompts.Count);
    return (_wednesdayPrompts[index]);
   }
   else if (journalDate == 4)
   {
    index = randomBonus.Next(_thursdayPrompts.Count);
    return (_thursdayPrompts[index]);
   }
   else if (journalDate == 5)
   {
    index = randomBonus.Next(_fridayPrompts.Count);
    return (_fridayPrompts[index]);
   }
   else
   //Saturday:
   return ("Write about whatever you want: ");
}

}