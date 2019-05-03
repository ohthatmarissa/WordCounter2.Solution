using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordsTest
  {
    [TestMethod]
    public void WordsConstructor_CreateInstanceOfWords_Words()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";
      Words newWords = new Words(sentence, oneWord);
      //Asserts that the constructor returns an object with type Words
      Assert.AreEqual(typeof(Words), newWords.GetType());




      //Asserts that the constructor is properly setting the sentence property
      string result = newWords.GetSentence();
      string expectedSentence = sentence.ToUpper();
      Assert.AreEqual(expectedSentence, result);

      //Asserts that the constructor is properly setting the oneWord property
      string resultOneWord = newWords.GetOneWord();
      string expectedOneWord = oneWord.ToUpper();
      Assert.AreEqual(expectedOneWord, resultOneWord);

      //Assert that the constructor is properly computing the array property
      string[] expectedArray = expectedSentence.Split(' ');
      string[] resultArray = newWords.GetArray();
      CollectionAssert.AreEqual(expectedArray, resultArray);
    }

    [TestMethod]
    public void Counting_HowManyTimesWordInSentence_Int()
    {
      string sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      string oneWord = "kitty";

      int result = 1;
      Words newWords = new Words(sentence, oneWord);
      Assert.AreEqual(result, newWords.Counting());

      sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      oneWord = "best";
      result = 2;
      newWords = new Words(sentence, oneWord);
      Assert.AreEqual(result, newWords.Counting());

      sentence = "Kittytopia is the best place to see kitties and find your kitty best friend";
      oneWord = "Best";
      result = 2;
      newWords = new Words(sentence, oneWord);
      Assert.AreEqual(result, newWords.Counting());
    }

  }
}
