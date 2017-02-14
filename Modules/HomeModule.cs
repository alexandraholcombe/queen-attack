using Nancy;
using QueenAttack.Objects;
using System.Collections.Generic;

namespace QueenAttack
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        var newQueen = new Queen(Request.Form["qXCoord"], Request.Form["qYCoord"], Request.Form["pXCoord"],  Request.Form["pYCoord"]);
        return View["results.cshtml", newQueen];
      };
    }
  }
}
