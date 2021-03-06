using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class Pet
  {
    public int Id { get; }
    private static List<Pet> _tamagotchis = new List<Pet>();
    public string Name { get; }
    public int Attention { get; set; }
    public int Food { get; set; }
    public int Sleep { get; set; }
    public static int TamagotchiId { get; set; } = 0;

    public Pet(string name)
    {
      Name = name;
      Attention = 100;
      Food = 100;
      Sleep = 100;
      Id = TamagotchiId++;
      _tamagotchis.Add(this);
    }

    public void Rest()
    {
      int currentSleepLevel = Sleep;
      if ((currentSleepLevel += 20) >= 100)
      {
        Sleep = 100;
      }
      else
      {
        Sleep += 20;
      }
    }

    public void Feed()
    {
      int currentFoodLevel = Food;
      if ((currentFoodLevel += 20) >= 100)
      {
        Food = 100;
      }
      else
      {
        Food += 20;
      }
    }

    public void Play()
    {
      int currentAttentionLevel = Attention;
      if ((currentAttentionLevel += 20) >= 100)
      {
        Attention = 100;
      }
      else
      {
        Attention += 20;
      }
    }

    public bool IsTamagotchiDead()
    {
      if ((Sleep <= 0) || (Attention <= 0) || (Food <= 0))
      {
        return true;
      }
      return false;
    }

    public void DecreaseRest()
    {
      Sleep -= 5;
    }
    public void DecreaseAttention()
    {
      Attention -= 5;
    }

    public void DecreaseFood()
    {
      Food -= 5;
    }

    public static void IncreaseTime()
    {
      foreach (Pet tamagotchi in _tamagotchis)
      {
        tamagotchi.DecreaseFood();
        tamagotchi.DecreaseRest();
        tamagotchi.DecreaseAttention();
      }
    }

    public static Pet GetTamagotchi(int id)
    {
      return _tamagotchis.Find(x => x.Id == id);
    }

    // public static Pet Find(int searchId)
    // {
    //   return _tamagotchis[searchId - 1];
    // }

    public static void DeletePet(int searchId)
    {
      _tamagotchis.Remove(Pet.GetTamagotchi(searchId));
    }

    public static List<Pet> GetTamagotchis()
    {
      return _tamagotchis;
    }

    public static void ClearPets()
    {
      _tamagotchis.Clear();
    }
  }
}