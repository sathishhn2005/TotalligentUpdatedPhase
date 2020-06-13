using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class InsuranceCompanyController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: InsuranceCompany
        public ActionResult Index()
        {
            return PartialView("_InsCompanyMaster");
        }

        // GET: InsuranceCompany/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InsuranceCompany/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceCompany/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                InsuranceCompanyMaster ohjInsCompanyMaster = new InsuranceCompanyMaster
                {
                    InsurancecompanyName = collection["InsurancecompanyName"].ToString(),
                    State = collection["State"].ToString(),
                    Address = collection["Address"].ToString(),
                    City = collection["City"].ToString(),
                    Zipcode = Convert.ToInt32(collection["Zipcode"]),
                    ContactPerson = collection["ContactPerson"].ToString(),
                    MobileNumber = collection["MobileNumber"].ToString(),
                    EmailId = collection["EmailId"].ToString(),
                };

                long returnCode = -1;
                if (ohjInsCompanyMaster != null)
                {
                    returnCode = objMasterBAL.SaveInsCom(ohjInsCompanyMaster);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: InsuranceCompany/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InsuranceCompany/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: InsuranceCompany/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InsuranceCompany/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
