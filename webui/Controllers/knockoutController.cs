using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using webui.Models;

namespace webui.Controllers
{
  public class knockoutController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult GetData()
    {
      List<KoDataViewModel> dataToReturn = new List<KoDataViewModel>
      {
        new KoDataViewModel{ Id = 1, Name = "Peter", NickName = "Shawty"},
        new KoDataViewModel{ Id = 2, Name = "Samantha", NickName = "Sam"},
        new KoDataViewModel{ Id = 3, Name = "Rufus", NickName = "Buggerlugs"}
      };

      return Json(dataToReturn, JsonRequestBehavior.AllowGet);
    }

  }
}
