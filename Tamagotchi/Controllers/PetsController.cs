using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
  public class PetsController : Controller
  {
    [HttpGet("/pets")]
    public ActionResult Index()
    {
      List<Pet> pets = Pet.GetTamagotchis();
      return View(pets);
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/delete")]
    public ActionResult Delete()
    {
      Pet.ClearPets();
      return RedirectToAction("Index");
    }


    [HttpGet("/pets/{petId}/show")]
    public ActionResult Show(int petId)
    {
      Pet pet = Pet.GetTamagotchi(petId);
      return View("Show", pet);
    }

    [HttpPost("/pets/{petId}/editfood")]
    public ActionResult EditFood(string petId)
    {
      Pet newPet = Pet.GetTamagotchi(int.Parse(petId));
      newPet.Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{petId}/editsleep")]
    public ActionResult EditSleep(string petId)
    {
      Pet newPet = Pet.GetTamagotchi(int.Parse(petId));
      newPet.Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{petId}/editattention")]
    public ActionResult EditAttention(string petId)
    {
      Pet newPet = Pet.GetTamagotchi(int.Parse(petId));
      newPet.Play();
      return RedirectToAction("Index");
    }

  }
}
