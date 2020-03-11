using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class CharacterTests
  {

    [TestMethod]
    public void TamagotchiConstructor_CreatesInstanceOfTamagotchi_Tamagotchi()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      Assert.AreEqual(typeof(Pet), newTamagotchi.GetType());
    }

    [TestMethod]

    public void TamagotchiConstructor_CreatesNameOfTamagotchi_TamagotchiName()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      Assert.AreEqual("Yoyo", newTamagotchi.Name);
      Assert.AreEqual(100, newTamagotchi.Attention);
    }

    [TestMethod]
    public void GetTamagotchis_ProvidesAccesstoTamagotchisList_TamagotchisList()
    {
      Pet.ClearPets();
      Pet Yoyo = new Pet("Yoyo");
      Pet Mametchi = new Pet("Mametchi");
      Pet Gozarutchi = new Pet("Gozarutchi");
      List<Pet> allPets = Pet.GetTamagotchis();

      Assert.AreEqual(3, allPets.Count);
    }

    [TestMethod]
    public void GetTamagotchi_FindTamagothiByProvidedId_Tamagotchi()
    {
      Pet.ClearPets();
      Pet Yoyo = new Pet("Yoyo");
      Pet Mametchi = new Pet("Mametchi");
      Pet Gozarutchi = new Pet("Gozarutchi");
      Pet result = Pet.GetTamagotchi(1);

      Assert.AreEqual(result, Yoyo);
    }

    [TestMethod]

    public void Rest_IncreasesTamagotchiSleepLevel_Sleep()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      newTamagotchi.Sleep = 20;
      newTamagotchi.Rest();
      Assert.AreEqual(40, newTamagotchi.Sleep);
    }

    [TestMethod]

    public void Feed_IncreasesTamagotchiFoodLevel_Food()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      newTamagotchi.Food = 40;
      newTamagotchi.Feed();
      Assert.AreEqual(60, newTamagotchi.Food);
    }

    [TestMethod]

    public void IsTamagotchiDead_ChecksTamagotchiCondition_False()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      newTamagotchi.Attention = 20;
      newTamagotchi.Food = 20;
      newTamagotchi.Sleep = 20;
      bool result = newTamagotchi.IsTamagotchiDead();
      Assert.AreEqual(false, result);
    }

    [TestMethod]

    public void DecreaseRest_DecreasesTamagotchiSleepLevel_Sleep()
    {
      Pet newTamagotchi = new Pet("Yoyo");
      newTamagotchi.Sleep = 20;
      newTamagotchi.DecreaseRest();
      Assert.AreEqual(15, newTamagotchi.Sleep);
    }

  }
}
