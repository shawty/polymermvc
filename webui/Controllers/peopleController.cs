using System.Web.Mvc;
using webui.Models;
using webui.classes;

namespace webui.Controllers
{
  public class PeopleController : Controller
  {
    [HttpGet]
    public ActionResult Edit(int recordId)
    {
      ViewBag.recordId = recordId;
      return View();
    }

    [HttpPost]
    public ActionResult Edit(FullPersonViewModel fullPerson)
    {
      if (ModelState.IsValid)
      {
        PeopleDatabase.UpdateFullPerson(fullPerson);
        return RedirectToAction("Index", "Home");
      }

      //TODO: figure out how to send full model to web component, not just ID for it to load from.
      ViewBag.recordId = fullPerson.RecordId;
      return View();
    }

    [HttpGet]
    public ActionResult Info(int recordId)
    {
      ViewBag.recordId = recordId;
      return View();
    }

    [HttpGet]
    public ActionResult JsonInfo(int recordId)
    {
      FullPersonViewModel myPerson = PeopleDatabase.GetOneFullPersonByRecordId(recordId) ?? new FullPersonViewModel
                                                                                              {
                                                                                                RecordId = 0,
                                                                                                Name = "Not Found",
                                                                                                Age = 0,
                                                                                                ContactPic = string.Empty,
                                                                                                Role = string.Empty,
                                                                                                BlogPage = string.Empty
                                                                                              };

      return Json(myPerson, JsonRequestBehavior.AllowGet);
    }

  }
}
