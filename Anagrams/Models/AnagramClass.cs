using System.Collections.Generic;
using System;

namespace Anagrams.Models
{
    public class AnagramClass
    {
      private string _inputWord;
      private List<string> _anagrams;
      private List<string> _notAnagrams;
      private List<string> _partial;

      public AnagramClass(string word)
      {
        _inputWord = word;
        _anagrams = new List<string>{};
        _notAnagrams = new List<string>{};
        _partial = new List<string>{};
      }

      public string GetInputWord()
      {
        return _inputWord;
      }

      public List<string> GetAnagrams()
      {
        return _anagrams;
      }

      public List<string> GetNotAnagrams()
      {
        return _notAnagrams;
      }

      public List<string> GetPartial()
      {
        return _partial;
      }


      public bool CheckAnagram(string testString)
      {
          if (testString.Length < _inputWord.Length)
          {
            _partial.Add(testString);
            return CheckPartialAnagram(testString);
          }
          char[] inputWordArray = _inputWord.ToCharArray();
          char[] testWordArray = testString.ToCharArray();
          Array.Sort(inputWordArray);
          Array.Sort(testWordArray);

          for (int i = 0; i < inputWordArray.Length; i++)
          {
            if (inputWordArray[i] != testWordArray[i])
            {
              _notAnagrams.Add(testString);
              return false;
            }
          }
          _anagrams.Add(testString);
          return true;
      }

      public bool CheckPartialAnagram(string testString)
      {
        for (int i = 0; i < testString.Length; i++)
        {
          if ((testString.Split(testString[i]).Length - 1) > (_inputWord.Split(testString[i]).Length - 1))
          {
            return false;
          }
        }
        return true;
      }
    }
}
