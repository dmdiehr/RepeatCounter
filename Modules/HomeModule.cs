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

        return View["output.cshtml"];
      };
    }
  }
}
