using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Totalligent.UI.Areas.MedicalInsurance.Controllers
{
    public class MIClaimsController : Controller
    {
        // GET: MedicalInsurance/Claims

        public ActionResult MIDashBoard()
        {
            return View();
        }
        public ActionResult MIOPIPTreatment()
        {
            return View();
        }
        public ActionResult MIReimbursement()
        {
            return View();
        }
        public ActionResult MITPADataManagement()
        {
            return View();
        }
        public ActionResult MIClaimsRegistration()
        {
            return View();

        }
        public ActionResult MIPreApprovals()
        {
            return View();
        }
        //ClaimsAdminMedicalInsurance
        public ActionResult MIOPApprovals()
        {
            return View();
        }
        public ActionResult MIIPApprovals()
        {
            return View();
        }
    }
}