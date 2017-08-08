using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongApp.Models;
using System.Collections.Generic;

namespace PingPongApp.Tests
{
  [TestClass]
  public class PingPongTest
  {
      [TestMethod]
      public void CountToNumber_IsAnArrayofNumbers_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");

          List<string> actualList = PingPong.CountToNumber(2);

          CollectionAssert.AreEqual(expectedList, actualList);
      }

      [TestMethod]
      public void CountToNumber_MultiplesOfThreePing_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");
          expectedList.Add("ping");

          List<string> actualList = PingPong.CountToNumber(3);

          CollectionAssert.AreEqual(expectedList, actualList);
      }

      [TestMethod]
      public void CountToNumber_MultiplesOfFivePong_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");
          expectedList.Add("ping");
          expectedList.Add("4");
          expectedList.Add("pong");

          List<string> actualList = PingPong.CountToNumber(5);

          CollectionAssert.AreEqual(expectedList, actualList);
      }

      [TestMethod]
      public void CountToNumber_MultiplesOfFifteenPingPong_True()
      {
          List<string> expectedList = new List<string> {};
          expectedList.Add("1");
          expectedList.Add("2");
          expectedList.Add("ping");
          expectedList.Add("4");
          expectedList.Add("pong");
          expectedList.Add("ping");
          expectedList.Add("7");
          expectedList.Add("8");
          expectedList.Add("ping");
          expectedList.Add("pong");
          expectedList.Add("11");
          expectedList.Add("ping");
          expectedList.Add("13");
          expectedList.Add("14");
          expectedList.Add("pingpong");

          List<string> actualList = PingPong.CountToNumber(15);

          CollectionAssert.AreEqual(expectedList, actualList);
      }
  }
}
