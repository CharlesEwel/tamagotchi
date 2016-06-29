using System.Collections.Generic;
using Nancy;
using myTamagotchi.Objects;

namespace myTamagotchis
{
  public class HomeModule:NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>View["index.cshtml"];
      Get["/create"]=_=>View["create_a_tamagotchi.cshtml"];
      Post["/birth_form"] = _ => {
        Tamagotchi newTamagotchi = new Tamagotchi (Request.Form["new-name"]);
        return View["tamagotchi.cshtml", newTamagotchi];
      };
    }
  }
}
