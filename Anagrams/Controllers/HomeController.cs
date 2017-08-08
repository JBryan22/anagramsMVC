using Microsoft.AspNetCore.Mvc;
using Anagrams.Models;
using System.Collections.Generic;
using System;

namespace Anagrams.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/anagram/result")]
    public ActionResult Results()
    {
      AnagramClass newAnagram = new AnagramClass (Request.Form["origin-word"]);

    newAnagram.CheckAnagram(Request.Form["anagram-1"]);
    newAnagram.CheckAnagram(Request.Form["anagram-2"]);
    newAnagram.CheckAnagram(Request.Form["anagram-3"]);

     newAnagram.GetInputWord();

     List<List<string>> anagramLists = new List<List<string>>
     {
       newAnagram.GetAnagrams(),
       newAnagram.GetNotAnagrams(),
       newAnagram.GetPartial()
     };

     return View(anagramLists);
    }
  }
}
