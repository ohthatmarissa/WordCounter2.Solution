using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      WordsController controller = new WordsController();
      ActionResult indexView = controller.Index();
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Show_ReturnsCorrectView_True()
    {
      WordsController controller = new WordsController();
      ActionResult showView = controller.Show();
      Assert.IsInstanceOfType(showView, typeof(ViewResult));    }

  }

}
