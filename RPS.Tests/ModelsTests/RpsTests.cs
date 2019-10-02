using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rps;


namespace Rps.Tests
{
  [TestClass]
  public class GameTests
  {

    [TestMethod]
    public void Game_CheckRockWinner_PlayerOneWinner()
    {
      Game newGame = new Game();
      Player player1 = new Player("rock");
      Player player2 = new Player("scissors");
      string result = Game.CheckWinner("rock", "scissors");
      Assert.AreEqual(result, "Player 1 is victorious");
    }

    [TestMethod]
    public void Game_CheckScissorWinner_PlayerTwoWinner()
    {
      Game newGame = new Game();
      Player player1 = new Player("paper");
      Player player2 = new Player("scissors");
      string result = Game.CheckWinner("paper", "scissors");
      Assert.AreEqual(result, "Player 2 is victorious");
    }

      [TestMethod]
    public void Game_CheckPaperWinner_PlayerOneWinner()
    {
      Game newGame = new Game();
      Player player1 = new Player("paper");
      Player player2 = new Player("rock");
      string result = Game.CheckWinner("paper", "rock");
      Assert.AreEqual(result, "Player 1 is victorious");
    }

      [TestMethod]
        public void Game_CheckDraw_NoWinner()
    {
      Game newGame = new Game();
      Player player1 = new Player("paper");
      Player player2 = new Player("paper");
      string result = Game.CheckWinner("paper", "paper");
      Assert.AreEqual(result, "Draw");
    }

          [TestMethod]
        public void Game_CheckUnknownObject_NoWinner()
    {
      Game newGame = new Game();
      Player player1 = new Player("paper");
      Player player2 = new Player("poop");
      string result = Game.CheckWinner("poop", "paper");
      Assert.AreEqual(result, "unknown object");
    }
  }
}
  