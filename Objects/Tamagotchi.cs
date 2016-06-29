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

    public Tamagotchi (string Name)
    {
      _name = Name;
      _age = 0;
      _food = 4;
      _sleep = 4;
      _fun = 4;
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
    public void Feed()
    {
      _food+=1;
    }
    public void Sleep()
    {
      _sleep+=1;
    }
    public void Play()
    {
      _fun+=1;
    }
    public void PassageOfTime()
    {
      _food-=1;
      _sleep-=1;
      _fun-=1;
    }
  }
}
