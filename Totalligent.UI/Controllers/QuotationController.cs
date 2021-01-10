using System;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.UI.Models;
using Totalligent.BusinessEntities;

namespace Totalligent.UI.Controllers
{
    public class QuotationController : Controller
    {
        readonly AdminModel objAdminModel = new AdminModel();
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        // GET: Quotation
        public ActionResult Index()
        {
            return View();
        }


        // GET: Quotation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Quotation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quotation/Create
        [HttpPost]
        public ActionResult SalientBenefits(FormCollection collection)
        {
            try
            {
                string str = collection["annualbenefit"].ToString();
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Quotation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Quotation/Edit/5
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

        // GET: Quotation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Quotation/Delete/5
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
        // POST: Quotation/Create
        [HttpPost]
        public JsonResult QuotationMaster(Quotation collection)
        {
            long returnCode = -1;
            string draftNo = string.Empty;
            long QuotationId = collection.QuotationId;
            
            try
            {
               // string str = collection["annualbenefit"].ToString();
                returnCode = objBALTot.CreateQuotation(collection,QuotationId, out draftNo);
                // TODO: Add insert logic here

            }
            catch(Exception e)
            {
                throw e;
            }
            return Json(draftNo);
        }
    }
}
