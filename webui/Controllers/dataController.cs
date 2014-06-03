using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Polymermvc.Models;
using Polymermvc.Classes;

namespace Polymermvc.Controllers
{
  public class DataController : Controller
  {
    public ActionResult Names()
    {
      List<MinimalPersonViewModel> myPeople = PeopleDatabase.GetAllPeople();

      return Json(myPeople, JsonRequestBehavior.AllowGet);
    }

    public ActionResult Graph()
    {
      Random rand = new Random();
      var numberToGenerate = rand.Next(5, 50);

      List<GraphViewModel> myGraph = new List<GraphViewModel>();
      for(int counter = 0; counter < numberToGenerate; counter++)
      {
        var valueToSend = rand.Next(200);
        var tagToSend = string.Format("Value {0}", valueToSend);
        myGraph.Add(new GraphViewModel {Tag = tagToSend, Value = valueToSend});
      }

      return Json(myGraph, JsonRequestBehavior.AllowGet);
    }

  }
}
