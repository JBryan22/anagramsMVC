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

      [TestMethod]
      public void CheckAnagram_IsAnAnagram_False()
      {
        AnagramClass myAnagram = new AnagramClass("bread");
        string testString = "butter";

        bool results = myAnagram.CheckAnagram(testString);
        Assert.AreEqual(false, results);
      }

      [TestMethod]
      public void CheckAnagram_IsAPartialAnagram_True()
      {
        AnagramClass myAnagram = new AnagramClass("badder");
        string testString = "baddy";

        bool results = myAnagram.CheckAnagram(testString);
        Assert.AreEqual(true, results);
      }

  }
}
