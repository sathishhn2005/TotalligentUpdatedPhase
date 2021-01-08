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
            long returnCode = -1;
            try
            {
                returnCode = objBALTot.SaveEmployee(objEmployeRegistration);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(returnCode);
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
            long returnCode = -1;
            string PolicyNumber = string.Empty;
            try
            {
                returnCode = objBALTot.RegisterTPAInsEmployee(objInsCompany, out PolicyNumber);
                return Json(PolicyNumber);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        [HttpGet]
        public ActionResult GetCompany(string PolicyNumber)
        {
            List<InsuranceCompany> lstGetCompanies = new List<InsuranceCompany>();
            if (!string.IsNullOrEmpty(PolicyNumber))
            {
                try
                {
                    lstGetCompanies = objBALTot.GetCompanies(PolicyNumber);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
            return Json(lstGetCompanies, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult RaiseTickets(FormCollection collection)
        {
            try
            {
                RaiseTickets objRaiseTickets = new RaiseTickets
                {
                    TicketId = Convert.ToInt32(collection["TicketId"]),
                    RaisedBy = collection["RaisedBy"].ToString(),
                    Description = collection["Description"].ToString(),
                    CreatedAt = Convert.ToDateTime(collection["CreatedAt"]),
                    CreatedBy = collection["CreatedBy"].ToString(),
                };

                long returnCode = -1;
                returnCode = objBALTot.RaiseTicket(objRaiseTickets);
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult ViewTickets()
        {
            var Model = new List<RaiseTickets>();
            try
            {
                Model = objBALTot.ViewTickets();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView("_ViewTicket", Model);
        }

        [HttpPost]
        public ActionResult ResetNewPassword(FormCollection collection)
        {
            try
            {

                RaiseTickets objRaiseTickets = new RaiseTickets
                {
                    TicketId = Convert.ToInt32(collection["TicketId"]),
                    RaisedBy = collection["RaisedBy"].ToString(),
                    Newpassword = collection["Newpassword"].ToString(),
                };

                long returnCode = 1;
                returnCode = objBALTot.CloseTicket(objRaiseTickets);
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        public ActionResult Masters()
        {

            return View();

        }
        public ActionResult Quotation()
        {

            return View();

        }
        public ActionResult EmployeeRegister()
        {

            return View();

        }
        [HttpGet]
        public ActionResult Edit(int QuotationId)
        {
            Quotation objQuotation = null;
            string UserName = string.Empty;
            UserName = "sathish";
            try
            {
                objBALTot.EditQutation(UserName, QuotationId,out objQuotation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
                return View("Quotation", objQuotation);
            
        }
        public ActionResult UnderwritingDashboard()
        {
            long returnCode = -1;
            UnderWriter obj = null;
            try
            {
                string UserName = "Sathish";
                returnCode = objBALTot.GetUWDB(UserName, out obj);
                if (obj != null)
                {
                    return View(obj);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View(obj);

        }
        public ActionResult ClientDashboard()
        {

            return View();

        }
        public ActionResult ProducerMaster()
        {
            return View();
        }


    }
}