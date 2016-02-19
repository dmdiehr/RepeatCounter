using Nancy;
using RepeatCounterProject.Objects;
using System.Collections.Generic;

namespace RepeatCounterProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["searchTerm"], Request.Form["textBlock"]);
        int result = newRepeatCounter.CountRepeats();
        return View["output.cshtml", result];
      };
    }
  }
}
