using System;
using System.Collections.Generic;

namespace RockPaperScissorsProject.Objects
{
  public class RockPaperScissors
  {
    private string _player1;
    private string _player2;

    public RockPaperScissors(string userInput1, string userInput2)
    {
      _player1 = userInput1;
      _player2 = userInput2;
    }

    public string GetPlayer1()
    {
      return _player1;
    }
    public string GetPlayer2()
    {
      return _player2;
    }
    public string Compare()
    {
      _player1 = _player1.ToLower();
      _player2 = _player2.ToLower();

      if(_player1 == _player2)
      {
        return "draw";
      }
      else if (_player1 == "scissors" && _player2 == "rock")
        {
          return _player2;
        }
      else if (_player1 == "rock" && _player2 == "scissors")
      {
        return _player1;
      }
      else if (_player1 == "rock" && _player2 == "paper")
      {
        return _player2;
      }
      else if (_player1 == "paper" && _player2 == "rock")
      {
        return _player1;
      }
      else if (_player1 == "scissors" && _player2 == "paper")
      {
        return _player1;
      }
      else if (_player1 == "paper" && _player2 == "scissors")
      {
        return _player2;
      }
      else
      {
        return "error";
      }
    }
  }
}
