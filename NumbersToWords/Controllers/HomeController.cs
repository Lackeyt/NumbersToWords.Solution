using Microsoft.AspNetCore.Mvc;
using NumbersToWords.Models;

namespace NumbersToWords.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}