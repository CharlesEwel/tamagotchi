using System.Collections.Generic;

namespace myTamagotchi.Objects
{
  public class Tamagotchi
  {
    private string _name;
    private int _age;
    private int _food;
    private int _sleep;
    private int _fun;
    public static List<Tamagotchi> _stable = new List<Tamagotchi> {};
    public Tamagotchi (string Name)
    {
      _name = Name;
      _age = 0;
      _food = 4;
      _sleep = 4;
      _fun = 4;
      _stable.Add(this);
    }
    public string GetName()
    {
      return _name;
    }
    public int GetAge()
    {
      return _age;
    }
    public int GetHunger()
    {
      return _food;
    }
    public int GetSleepiness()
    {
      return _sleep;
    }
    public int GetHappiness()
    {
      return _fun;
    }
    public void ActOnTamgagotchi(string action)
    {
      if(action=="feed")
      {
        _food+=1;
      }
      if(action=="sleep")
      {
        _sleep+=1;
      }
      if(action=="play")
      {
        _fun+=1;
      }
      if(action=="passtime")
      {
        _food-=1;
        _sleep-=1;
        _fun-=1;
        _age+=1;
      }
    }
    public static Tamagotchi Find(string searchTamagotchiName)
    {
      int counter=0;
      int searchIndex=0;
      foreach(var tamagotchi in _stable)
      {
        if(tamagotchi.GetName()==searchTamagotchiName)
        {
          searchIndex=counter;
        }
        counter++;
      }
      return _stable[searchIndex];
    }
  }
}
