using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "Rock", "Paper", "Scissors" };
            Random random = new Random();

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            while (true)
            {
                Console.WriteLine("\nEnter your choice (Rock, Paper, or Scissors) or type 'quit' to exit:");
                string playerChoice = Console.ReadLine()?.Trim().ToLower();

                if (playerChoice == "quit")
                {
                    Console.WriteLine("Thanks for playing! Goodbye!");
                    break;
                }

                if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                {
                    Console.WriteLine("Invalid input. Please choose Rock, Paper, or Scissors.");
                    continue;
                }

                int computerChoiceIndex = random.Next(choices.Length);
                string computerChoice = choices[computerChoiceIndex];

                Console.WriteLine($"You chose: {playerChoice}");
                Console.WriteLine($"The computer chose: {computerChoice}");

                string result = DetermineWinner(playerChoice, computerChoice.ToLower());
                Console.WriteLine(result);
            }
        }

        static string DetermineWinner(string player, string computer)
        {
            if (player == computer)
            {
                return "It's a tie!";
            }
            if ((player == "rock" && computer == "scissors") ||
                (player == "paper" && computer == "rock") ||
                (player == "scissors" && computer == "paper"))
            {
                return "You win!";
            }
            return "Computer wins!";
        }
    }
}
