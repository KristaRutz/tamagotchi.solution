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

    [HttpPost("/pets/updateall")]
    public ActionResult UpdateAll()
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
    public ActionResult UpdateFood(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Feed();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{Id}/Sleep")]
    public ActionResult UpdateSleep(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Rest();
      return RedirectToAction("Index");
    }

    [HttpPost("/pets/{Id}/Attention")]
    public ActionResult UpdateAttention(string Id)
    {
      Pet.GetTamagotchi(int.Parse(Id)).Play();
      return RedirectToAction("Index");
    }

  }
}
