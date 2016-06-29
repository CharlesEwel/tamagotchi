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
        Tamagotchi newTamagotchi = new Tamagotchi(Request.Form["new-name"]);
        return View["tamagotchi.cshtml", newTamagotchi];
      };
      Get["{tamagotchiName}passtime"] = parameters => {
        Tamagotchi tamagotchi = Tamagotchi.Find(parameters.tamagotchiName);
        tamagotchi.ActOnTamgagotchi("passtime");
        if(tamagotchi.GetHunger()<=0 || tamagotchi.GetHappiness()<=0 || tamagotchi.GetSleepiness()<=0)
        {
          return View["/dead_tamagotchi.cshtml"];
        }
        else
        {
          return View["/tamagotchi.cshtml", tamagotchi];
        }
      };

      Get["{tamagotchiName}sleep"] = parameters => {
        Tamagotchi tamagotchi = Tamagotchi.Find(parameters.tamagotchiName);
        tamagotchi.ActOnTamgagotchi("sleep");
        return View["/tamagotchi.cshtml", tamagotchi];
      };
      Get["{tamagotchiName}feed"] = parameters => {
        Tamagotchi tamagotchi = Tamagotchi.Find(parameters.tamagotchiName);
        tamagotchi.ActOnTamgagotchi("feed");
        return View["/tamagotchi.cshtml", tamagotchi];
      };
      Get["{tamagotchiName}play"] = parameters => {
        Tamagotchi tamagotchi = Tamagotchi.Find(parameters.tamagotchiName);
        tamagotchi.ActOnTamgagotchi("play");
        return View["/tamagotchi.cshtml", tamagotchi];
      };
    }
  }
}
