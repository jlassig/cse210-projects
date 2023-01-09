using System;
class Program
{
    static void Main(string[] args)
    {
        //to add some lines to break up the monotony of programming in the terminal: 
       string prettyDashes = new string('-', 36);
       //to add a loop so the user can play as much as they want: 
       string playAgain = "yes";
       //the aforementioned loop: 
       while (playAgain.ToLower() == "yes")
       {

        Console.WriteLine();
        Console.WriteLine(prettyDashes);

        ////this is for the user to create a magic number:
        // Console.Write("What is the magic number? ");
        // string numberEntry = Console.ReadLine();
        // int magicNumber = int.Parse(numberEntry);

        //get a random number: 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.WriteLine("       Guess the magic number!");
        Console.WriteLine("--the number is between 1 and 100--");

        Console.WriteLine(prettyDashes);
        Console.WriteLine();

        int guess;
        int guessCounter = 0;

        do{
            //ask the user for their guess: 
            Console.Write("What is your guess? ");
            string guessEntry = Console.ReadLine();
            //turn the string guess into a number:
            guess = int.Parse(guessEntry);
            //add a counter for each time they guess
            guessCounter += 1;

            //give the user hints if their number is higher or lower or equal
            if (guess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else
            {   
                //if equal, reset the guess counter and ask if they want to play again? 
                Console.WriteLine();
                Console.WriteLine(prettyDashes);
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It only took you {guessCounter} tries!");
                guessCounter = 0;
                Console.Write("Do you want to play again? ");
                playAgain = Console.ReadLine();
                Console.WriteLine(prettyDashes);

            }

        } while (guess != magicNumber && guessCounter != 0);

      }





    }
}