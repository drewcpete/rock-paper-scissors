namespace Rps
{
public class Game
{

  public static string CheckWinner(string input1, string input2)
  {
    string Winner = "";
    if (input1 == input2)
    {
      Winner = "Draw";
    }
    else if (input1 == "rock")
    {
      if (input2 == "scissors")
      {
        Winner = "Player 1 is victorious";
      }
      else if (input2 == "paper")
      {
        Winner = "Player 2 is victorious";
      }  
    }
    else if (input1 == "scissors")
    {
      if (input2 == "rock")
      {
        Winner = "Player 2 is victorious";
      }
      else if (input2 == "paper")
      {
        Winner = "Player 1 is victorious";
      }
    }
    else if (input1 == "paper")
    {
      if (input2 == "rock")
      {
        Winner = "Player 1 is victorious";
      }
      else if (input2 == "scissors")
      {
        Winner = "Player 2 is victorious";
      }
    }
    else 
    {
      Winner= "Someone entered an invalid input";
    }
    return Winner;
  }
}
}