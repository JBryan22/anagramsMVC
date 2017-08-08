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

      public bool CheckAnagram(string testString)
      {
        if (testString.Length != _inputWord.Length)
        {
          return false;
        }
        else
        {
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

      }
    }
}
