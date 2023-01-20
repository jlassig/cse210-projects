public class PromptGenerator
{
 public string prompt;


 List<string> prompts = new List<string> { "What was I most grateful for today and why? ", "When did I feel the Spirit today? ", "How did I see the Lord's hand in my life today? ", "Is there anything I did today that I will do different next time? ", "Did the Spirit prompt me to do something today? ", "What questions do I have for my scripture study and prayers tomorrow? ", "What was the best part of my day today? " };

 public PromptGenerator()
 {
    prompt = RandomPrompt();
 }


 public string RandomPrompt()
 {
 //return a string that has the prompt choice.
 //I got help from this website: 
 // https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
  var random = new Random();
  int index = random.Next(prompts.Count);
  return (prompts[index]);
 }
}