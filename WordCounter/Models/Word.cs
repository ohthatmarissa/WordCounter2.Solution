using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Models
{
  public class Word
  {
    private string _sentence;
    private string _oneWord;
    private string[] _array;
    private int _id;
    private static List<Word> _instances = new List<Word> {};


    public Word(string fullSentence, string wordToMatch)
    {
      _sentence = fullSentence.ToUpper();
      _oneWord = wordToMatch.ToUpper();
      _array = _sentence.Split(' ');
      _instances.Add(this);
      _id = _instances.Count;

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

    public int GetId()
    {
      return _id;
    }

    public static Word Find(int searchId)
    {
      return _instances[searchId-1];
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
