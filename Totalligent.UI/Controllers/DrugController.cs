using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class DrugController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: Drug
        public ActionResult Index()
        {
            return PartialView("_DrugMaster");
        }

        // GET: Drug/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Drug/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drug/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DrugMaster objDrug = new DrugMaster
                {
                    DrugName = collection["DrugName"].ToString(),
                    DrugCode = collection["DrugCode"].ToString(),
                };

                long returnCode = -1;
                if (objDrug != null)
                {
                    returnCode = objMasterBAL.SaveDrug(objDrug);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Drug/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drug/Edit/5
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

        // GET: Drug/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drug/Delete/5
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
