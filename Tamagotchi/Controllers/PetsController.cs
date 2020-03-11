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
      Dictionary<string, object> model = new Dictionary<string, object>();
      Pet newPet = new Pet(name);
      List<Pet> pets = Pet.GetTamagotchis();
      model.Add("pet", newPet);
      model.Add("pets", pets);
      return View("Index", model);
    }

    [HttpGet("/pets/{petId}/show")]
    public ActionResult Show(int petId)
    {
      Pet pet = Pet.GetTamagotchi(petId);
      return View("Show", pet);
    }

  }
}
