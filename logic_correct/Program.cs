using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_correct


/*
* CS2 – Lab 6.1
* Author: Michaela Clark
* Date: 02/24/2026
* Description: This class applies logic to the classes created in the final product. 
*/
{
    public class Logic
         {
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
    class Program  ///Causes the program to run
    {
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
