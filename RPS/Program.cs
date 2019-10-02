using System;
using Rps;

namespace Rps
{
  public class Program
  {
    public static void Main()
    {
      Game newGame = new Game();
      Console.WriteLine("Welcome to  ⊘ ▤ ✂ !");
      Console.WriteLine("Player 1, make your move. rock/paper/scissors");
      
      string input1 = Console.ReadLine();
      DeletePrevConsoleLine();
      Player player1 = new Player(input1);
      Console.WriteLine("\n");

      Console.WriteLine("Player 2, make your move. rock/paper/scissors");
      
      string input2 = Console.ReadLine();
      DeletePrevConsoleLine();
      Player player2 = new Player(input2);
      Console.WriteLine("\n");
      Console.WriteLine(Game.CheckWinner(player1.Input, player2.Input));

      Console.WriteLine("play again?");
      string playagain = Console.ReadLine();
      if (playagain == "y" || playagain == "Y")
      {
          Main();
      }
      
    }
    public static void DeletePrevConsoleLine()
    {
      if (Console.CursorTop == 0) return;
      Console.SetCursorPosition(0, Console.CursorTop - 1);
      Console.Write(new string(' ', Console.WindowWidth));
      Console.SetCursorPosition(0, Console.CursorTop - 1);
    }
  }
}
