using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealer.Models;

namespace CarDealer.Controllers
{
  public class CarController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      return View(Car.GetAll());
    }
    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create()
    {
      Car newCar = new Car (Request.Form["new-brand"], Request.Form["new-model"], int.Parse(Request.Form["new-price"]));
      newCar.Save();
      return View("Index", Car.GetAll());
    }
    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
        Car.ClearAll();
        return View();
    }
  }
}
