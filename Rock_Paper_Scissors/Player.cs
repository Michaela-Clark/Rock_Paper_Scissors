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

                if (Enum.TryParse(input, true, out Choice choice)) // converts text into choice
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid. Please enter 'Rock', 'Paper', or 'Scissors'."); //Tells the user to enter the specified text to type.
                }
                
            }
        }
    }
}
