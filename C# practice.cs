using System;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[]args)
        {
         Random random =new Random();
         int targetNum = random.Next(1, 21);
         int answer = 0;
         int attempts =0;

         Console.WriteLine("WELCOME TO THE NUMBER GUESSING GAME");
         Console.WriteLine("Guess a number between 1-20");
         //while loop for the game
         while(answer != targetNum)
         {
            Console.WriteLine("Choose your number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out answer))
            {
                attempts++;
                if(answer < targetNum)
                {
                    Console.WriteLine("Incorrect to low");
                }
                 else if(answer > targetNum)
                {
                    Console.WriteLine("incorrect try again to high");
                }
                else{
                    Console.WriteLine($"You did it! the correct number was {targetNum}.");
                    Console.WriteLine($"it took {attempts} to get it right!");
                }
            }
            else
            {
                Console.WriteLine("please enter a valid number");
            }
         }
         Console.WriteLine("Thanks for playing");
        }
    }
}