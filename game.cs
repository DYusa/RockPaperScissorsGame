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
            Console.WriteLine("Enter your choice (Rock, Paper, or Scissors): ");
            
            string playerChoice = Console.ReadLine()?.Trim().ToLower();
            if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine("Invalid input. Please choose Rock, Paper, or Scissors.");
                return;
            }

            int computerChoiceIndex = random.Next(choices.Length);
            string computerChoice = choices[computerChoiceIndex];
            
            Console.WriteLine($"You chose: {playerChoice}");
            Console.WriteLine($"The computer chose: {computerChoice}");

            string result = DetermineWinner(playerChoice, computerChoice.ToLower());
            Console.WriteLine(result);
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
