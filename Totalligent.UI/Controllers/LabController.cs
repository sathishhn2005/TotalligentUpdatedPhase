using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class LabController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: Lab
        public ActionResult Index()
        {
            return PartialView("_LabMaster");
        }

        // GET: Lab/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lab/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lab/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                LabMaster objLabMaster = new LabMaster
                {
                    LabName = collection["LabName"].ToString(),
                   // LabCode = collection["LabCode"].ToString(),
                    State = collection["State"].ToString(),
                    Address = collection["Address"].ToString(),
                    City = collection["City"].ToString(),
                    Zipcode = Convert.ToInt32(collection["Zipcode"]),
                    ContactPerson = collection["ContactPerson"].ToString(),
                    MobileNumber = collection["MobileNumber"].ToString(),
                    EmailId = collection["EmailId"].ToString(),
                };

                long returnCode = -1;
                if (objLabMaster != null)
                {
                    returnCode = objMasterBAL.SaveLab(objLabMaster);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Lab/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lab/Edit/5
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

        // GET: Lab/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lab/Delete/5
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
