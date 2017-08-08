using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrams.Models;
using System.Collections.Generic;
using System;

namespace Anagrams.Tests
{
  [TestClass]
  public class AnagramClassTest

  {
      [TestMethod]
      public void CheckAnagram_IsAnAnagram_True()
      {
        AnagramClass myAnagram = new AnagramClass("bread");
        string testString = "beard";

        bool results = myAnagram.CheckAnagram(testString);
        Assert.AreEqual(true, results);

      }
  }
}
