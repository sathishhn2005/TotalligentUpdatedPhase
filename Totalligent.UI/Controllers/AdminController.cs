using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.UI.Models;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        readonly AdminModel objAdminModel = new AdminModel();
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();

        [HttpPost]
        public JsonResult EmployeeRegister(Employee objEmployeRegistration)
        {
            try
            {
                long returnCode = -1;
                returnCode = objBALTot.SaveEmployee(objEmployeRegistration);
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public JsonResult Register(Register objRegister)
        {
            try
            {

                string PolicyNumber = string.Empty;
                PolicyNumber = objBALTot.InsertClient(objRegister);
                if (!string.IsNullOrEmpty(PolicyNumber))
                {
                    ViewBag.PolicyNumber = PolicyNumber;
                    return Json(PolicyNumber);
                    // return Json(PolicyNumber);
                }
                else
                {
                    // return Json(PolicyNumber);
                    return Json(PolicyNumber);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpGet]
        public ActionResult GetClients(string PolicyNumber)
        {
            List<Register> lstGetClients = new List<Register>();
            var model = new List<Register>();
            if (!string.IsNullOrEmpty(PolicyNumber))
            {
                try
                {
                    lstGetClients = objBALTot.GetClients(PolicyNumber);
                    ViewBag.lstGetClients = lstGetClients;
                    model = lstGetClients;

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
             return Json(lstGetClients, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult TPAInsCompany(InsuranceCompany objInsCompany)
        {
            try
            {
                long returnCode = -1;
                returnCode = objBALTot.RegisterTPAInsEmployee(objInsCompany);
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}