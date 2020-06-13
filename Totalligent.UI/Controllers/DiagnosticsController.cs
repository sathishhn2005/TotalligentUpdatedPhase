using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class DiagnosticsController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: Diagnostics
        public ActionResult Index()
        {
            return PartialView("_DiagnosticsMaster");
        }

        // GET: Diagnostics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Diagnostics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diagnostics/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                DiagnosticsMaster objDiag = new DiagnosticsMaster
                {
                    DiagnosticsName = collection["DiagnosticsName"].ToString(),
                    DiagnosticsCode = collection["DiagnosticsCode"].ToString(),
                };

                long returnCode = -1;
                if (objDiag != null)
                {
                    returnCode = objMasterBAL.InsertDiagnostics(objDiag);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Diagnostics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Diagnostics/Edit/5
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

        // GET: Diagnostics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Diagnostics/Delete/5
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
