using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class ClientCompanyController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: ClientCompany
        public ActionResult Index()
        {
            return PartialView("_ClientCompanyMaster");
        }

        // GET: ClientCompany/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientCompany/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientCompany/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ClientCompanyMaster objClientComMaster = new ClientCompanyMaster
                {
                    ClientCompanyName = collection["ClientCompanyName"].ToString(),
                    Address = collection["Address"].ToString(),
                    City = collection["City"].ToString(),
                    Zipcode = Convert.ToInt32(collection["Zipcode"]),
                    ContactPerson = collection["ContactPerson"].ToString(),
                    MobileNumber = collection["MobileNumber"].ToString(),
                    EmailId = collection["EmailId"].ToString(),
                    Currency = collection["Currency"].ToString(),
                    Provider = collection["Provider"].ToString(),
                    ProviderCommission = collection["ProviderCommission"].ToString(),
                    ReInsurer = collection["ReInsurer"].ToString(),
                    ReInsurerRate = collection["ReInsurerRate"].ToString()
                };

                long returnCode = -1;
                if (objClientComMaster != null)
                {
                    returnCode = objMasterBAL.SaveClientCom(objClientComMaster);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: ClientCompany/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientCompany/Edit/5
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

        // GET: ClientCompany/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientCompany/Delete/5
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
