using Microsoft.AspNetCore.Mvc;
using NumbersToWords.Models;

namespace NumbersToWords.Controllers
{
  public class NumbersToWordsController : Controller
  {
    [HttpGet("/convert")]
    public ActionResult NumberConvert()
    {
      return View();
    }

    [HttpPost("/convert")]
    public ActionResult ConvertTheNumber(string numberToConvert)
    {
      long num = long.Parse(numberToConvert);
      NumberToConvert userNum = new NumberToConvert(num);
      userNum.ConvertNumber();
      return RedirectToAction("/convert", userNum);
    }

  }
}
