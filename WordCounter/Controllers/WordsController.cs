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

    [HttpPost("/words/show")]
    public ActionResult Create(string sentence, string oneWord)
    {
      Word myWord = new Word(sentence, oneWord);
      return View("Show", myWord);
    }

  }
}
