using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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

    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("words")]
    public ActionResult Create(string sentence, string oneWord)
    {
      Word myWord = new Word(sentence, oneWord);
      return RedirectToAction("Index");
    }

    [HttpGet("/words/{id}")]
    public ActionResult Show(int id)
    {
      Word word = Word.Find(id);
      return View(word);
    }
  }
}


//
//     public void WordsConstructor_CreateInstanceOfWords_Words()
//     {
//       string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
//       string oneWord = "kitty";
//       Words newWords = new Words(sentence, oneWord);
//       //Asserts that the constructor returns an object with type Words
//       Assert.AreEqual(typeof(Words), newWords.GetType());
//
//
//
//
//       //Asserts that the constructor is properly setting the sentence property
//       string result = newWords.GetSentence();
//       string expectedSentence = sentence.ToUpper();
//       Assert.AreEqual(expectedSentence, result);
//
//       //Asserts that the constructor is properly setting the oneWord property
//       string resultOneWord = newWords.GetOneWord();
//       string expectedOneWord = oneWord.ToUpper();
//       Assert.AreEqual(expectedOneWord, resultOneWord);
//
//       //Assert that the constructor is properly computing the array property
//       string[] expectedArray = expectedSentence.Split(' ');
//       string[] resultArray = newWords.GetArray();
//       CollectionAssert.AreEqual(expectedArray, resultArray);
//     }
//
//
//     public void Counting_HowManyTimesWordInSentence_Int()
//     {
//       string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
//       string oneWord = "kitty";
//
//       int result = 1;
//       Words newWords = new Words(sentence, oneWord);
//       Assert.AreEqual(result, newWords.Counting());
//
//       sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
//       oneWord = "best";
//       result = 2;
//       newWords = new Words(sentence, oneWord);
//       Assert.AreEqual(result, newWords.Counting());
//
//       sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
//       oneWord = "Best";
//       result = 2;
//       newWords = new Words(sentence, oneWord);
//       Assert.AreEqual(result, newWords.Counting());
//     }
//
//   }
// }
