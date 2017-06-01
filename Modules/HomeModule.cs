using Nancy;
using System.Collections.Generic;
using RockPaperScissorsProject.Objects;

namespace RockPaperScissorsProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        RockPaperScissors newRPS = new RockPaperScissors(Request.Form["player1"], Request.Form["player2"]);
        return View["result.cshtml", newRPS];
      };
    }
  }
}
