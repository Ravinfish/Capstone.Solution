using Microsoft.AspNetCore.Mvc;
using SoakSeeker.Models;
using System.Collections.Generic;
using System.Linq;

namespace SoakSeeker.Controllers;

public class HomeController : Controller
{
  private readonly SoakSeekerContext _db;
  public HomeController(SoakSeekerContext db)
  {
    _db = db;
  }
  [HttpGet("/")]
  public ActionResult Index()
  {
    return View();
  }
}
