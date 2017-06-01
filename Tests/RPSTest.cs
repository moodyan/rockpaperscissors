using Xunit;
using System;
using System.Collections.Generic;

namespace RockPaperScissorsProject.Objects
{
  public class RockPaperScissorsProjectTest
  {

    [Fact]
    public void Compare_TurnLettersLowerCase_True()
    {
      RockPaperScissors newRPS = new RockPaperScissors("ROCK", "Scissors");

      Assert.Equal("rock", newRPS.Compare());
    }
    [Fact]
    public void Compare_CompareIfInputsAreTheSame_Draw()
    {
      RockPaperScissors newRPS = new RockPaperScissors("rock", "rock");

      Assert.Equal("draw", newRPS.Compare());
    }
    [Fact]
    public void Compare_IfRockWins_Rock()
    {
      RockPaperScissors newRPS = new RockPaperScissors("rock", "scissors");

      Assert.Equal("rock", newRPS.Compare());
    }
    [Fact]
    public void Compare_IfScissorsWin_Scissors()
    {
      RockPaperScissors newRPS = new RockPaperScissors("scissors", "paper");

      Assert.Equal("scissors", newRPS.Compare());
    }
    [Fact]
    public void Compare_IfPaperWins_Paper()
    {
      RockPaperScissors newRPS = new RockPaperScissors("paper", "rock");

      Assert.Equal("paper", newRPS.Compare());
    }
  }
}
