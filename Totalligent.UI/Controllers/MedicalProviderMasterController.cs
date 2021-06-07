using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Totalligent.UI.Controllers
{
    public class MedicalProviderMasterController : Controller
    {
        // GET: MedicalProviderMaster
        public ActionResult Index()
        {
            return View();
        }

        // GET: MedicalProviderMaster/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MedicalProviderMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalProviderMaster/Create
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

        // GET: MedicalProviderMaster/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalProviderMaster/Edit/5
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

        // GET: MedicalProviderMaster/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalProviderMaster/Delete/5
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
