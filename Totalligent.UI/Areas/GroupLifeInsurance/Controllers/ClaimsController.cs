using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Totalligent.UI.Areas.GroupLifeInsurance.Controllers
{
    public class ClaimsController : Controller
    {
        // GET: GroupLifeInsurance/Claims
        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult OPIPTreatment()
        {
            return View();
        }
        public ActionResult Reimbursement()
        {
            return View();
        }
        public ActionResult TPADataManagement()
        {
            return View();
        }
        public ActionResult ClaimsRegistration()
        {
            return View();

        }
        public ActionResult PreApprovals()
        {
            return View();
        }
        //ClaimsAdmin
        public ActionResult OPApprovals()
        {
            return View();
        }
        public ActionResult IPApprovals()
        {
            return View();
        }
    }
}