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

//I took this out because it was my orignial "show" but since I added the return view to Create() I no longer needed this Show() but that broke the test that I had written for it:(
    [HttpGet("/words/show")]
    public ActionResult Show()
    {
      return View();
    }
  }
}
