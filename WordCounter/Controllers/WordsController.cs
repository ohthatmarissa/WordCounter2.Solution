using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/words")]
    public ActionResult Index()
    {
      return new ViewResult();
    }

    // [HttpGet("/words/new")]
    // public ActionResult New()
    // {
    //   return View();
    // }

    [HttpPost("/words")]
    public ActionResult Create(string sentence, string oneWord)
    {
      Word myWord = new Word(sentence, oneWord);
      return RedirectToAction("Show");
    }

    [HttpGet("/words/show")]
    public ActionResult Show()
    {
      return View();
    }

  }
}
