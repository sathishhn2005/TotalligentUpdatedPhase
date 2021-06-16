using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Totalligent.UI.Areas.MedicalInsurance.Controllers
{
    public class MIUnderWritingController : Controller
    {
        // GET: MedicalInsurance/MIUnderWriting
        public ActionResult MIMasters()
        {
            return View();
        }
        public ActionResult MIQuotation()
        {
            return View();
        }
        public ActionResult MIPolicyIssuance()
        {
            return View();
        }
        public ActionResult MICardIssuance()
        {
            return View();
        }
        public ActionResult MIEndorsement()
        {
            return View();
        }
    }
}