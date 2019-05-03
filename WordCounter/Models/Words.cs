using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Words
  {
    private string _sentence;
    private string _oneWord;
    private string[] _array;


    public Words(string fullSentence, string wordToMatch)
    {
      _sentence = fullSentence.ToUpper();
      _oneWord = wordToMatch.ToUpper();
      _array = _sentence.Split(' ');

    }

    public string GetSentence()
    {
      return _sentence;
    }

    public string GetOneWord()
    {
      return _oneWord;
    }

    public void SetOneWord(string newOneWord)
    {
      _oneWord = newOneWord;
    }

    public string[] GetArray()
    {
      return _array;
    }

    public int Counting()
    {
      int count = 0;
      foreach(string oneWord in _array)
      {
        if(oneWord == _oneWord)
        {
          count++;
        }
      }
      return count;
    }

  }
}
