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

    [HttpPost("/pets")]
    public ActionResult Create(string name)
    {
      Pet newPet = new Pet(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/pets/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/pets/delete")]
    public ActionResult Delete()
    {
      Pet.ClearPets();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/edit")]
    public ActionResult EditAll()
    {
      Pet.IncreaseTime();
      return RedirectToAction("Index");
    }

    [HttpGet("/pets/{Id}/show")]
    public ActionResult Show(int Id)
    {
      Pet pet = Pet.GetTamagotchi(Id);
      return View(pet);
    }

    [HttpPost("/pets/{Id}/Food")]
    public ActionResult EditFood(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Feed();
      // newPet.Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{Id}/Sleep")]
    public ActionResult EditSleep(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Rest();
      // Pet newPet =

      // newPet.Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{Id}/Attention")]
    public ActionResult EditAttention(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Play();
      return RedirectToAction("Index");
    }

  }
}
