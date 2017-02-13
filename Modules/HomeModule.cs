using Nancy;
using QueenAttack.Objects;
using System.Collections.Generic;

namespace QueenAttack
{
  public class HomeModule : Nancy Module
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      
    }
  }
}
