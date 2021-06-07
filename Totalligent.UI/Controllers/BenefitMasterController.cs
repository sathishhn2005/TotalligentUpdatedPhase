using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Totalligent.UI.Controllers
{
    public class BenefitMasterController : Controller
    {
        // GET: BenefitMaster
        public ActionResult Index()
        {
            return View();
        }

        // GET: BenefitMaster/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BenefitMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BenefitMaster/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BenefitMaster/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BenefitMaster/Edit/5
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

        // GET: BenefitMaster/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BenefitMaster/Delete/5
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
