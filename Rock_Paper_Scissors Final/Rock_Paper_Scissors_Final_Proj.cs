using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    public enum Choice
    {
        Rock,
        Paper,
        Scissors
    }

    public class Player
    {
        public string Name { get; private set; }

        public Player()
        {
            //Asks the user enters their name.
            Console.WriteLine("Enter your name: ");
            Name = Console.ReadLine();
        }

        public Choice GetChoice()
        {
            while (true)
            {
                // Tells the user to type "Rock", "Paper", or "Scissors".
                Console.WriteLine($"{Name}, enter Rock, Paper, or Scissors:");
                string input = Console.ReadLine();

                if (Enum.TryParse(input, true, out Choice choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid. Please enter 'Rock', 'Paper', or 'Scissors'.");
                }
            }
        }
    }

    /** CS2 - Lab 6.1
    * Author: Abby Allen
    * Date: 02/24/26
    * Description: This class generates a random turn for the computer
    */
    public class ComputerPlayer
    {
        Random random = new Random();

        /// <summary>
        /// This method takes the output of the randomizer and returns a turn
        /// </summary>
        /// <returns>Rock, Paper, or Scissors</returns>
        public Choice GenerateChoice()
        {
            int turn = random.Next(1, 4);

            if (turn == 1)
                return Choice.Rock;
            else if (turn == 2)
                return Choice.Paper;
            else
                return Choice.Scissors;
        }
    }


    /*
* CS2 – Lab 6.1
* Author: Michaela Clark
* Date: 02/24/2026
* Description: This class applies logic to the classes created in the final product. 
*/
    public class Logic
    {
        /// <summary>
        /// Displays if the player or computer lost, won, or got a tie. .
        /// </summary>
        public string DetermineWinner(Choice player, Choice computer)
        {
            if (player == computer)
                return "Tie!";

            if ((player == Choice.Rock && computer == Choice.Scissors) ||
                (player == Choice.Paper && computer == Choice.Rock) ||
                (player == Choice.Scissors && computer == Choice.Paper))
            {
                return "Player Wins!";
            }

            return "Computer Wins!";
        }
    }
    class Program ///Allows program to run

    {
        /// <summary>
        /// Main program prints computer choices and creates working player objects
        /// </summary>
        static void Main(string[] args)
        {
            Player player = new Player();
            ComputerPlayer computer = new ComputerPlayer();
            Logic logic = new Logic();

            Choice playerChoice = player.GetChoice();
            Choice computerChoice = computer.GenerateChoice();

            Console.WriteLine($"Computer chose: {computerChoice}");
            Console.WriteLine(logic.DetermineWinner(playerChoice, computerChoice));

            Console.ReadLine();
        }
    }
}

