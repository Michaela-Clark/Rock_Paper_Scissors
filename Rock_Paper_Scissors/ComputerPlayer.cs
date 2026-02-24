/*
* CS2 - Lab 6.1
* Author: Abby Allen
* Date: 02/24/26
* Description: This class generates a random turn for the computer
*/

/// <summary>
/// This class creates the randmoizer
/// </summary>

public class ComputerPlayer
{
    Random random = new Random();

    /// <summary>
    /// This method takes the output of the randomizer and returns a turn
    /// </summary>
    /// <returns>Rock, Paper, or Scissors</return>
    
    public string GenerateChoice()
    {
        int turn = random.Next(1,4);
        if (turn == 1)
            return "Rock";
        else if (turn == 2)
            return "Paper";
        else
            return "Scissors";
    }
}