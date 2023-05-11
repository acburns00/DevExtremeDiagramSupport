using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiagramTesting.Models;
using DiagramTesting.SampleData;

namespace DiagramTesting.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View(new OrgData { Nodes = SampleData.SampleData.OrgItemsRestrictions });
        }

        public ActionResult Index_2()
        {
            return View(new OrgData { Nodes = SampleData.SampleData.OrgItemsRestrictions });
        }
    }
}