using System;
using Totalligent.BAL;
using Totalligent.UI.Models;
using Totalligent.BusinessEntities;
using System.Web.Mvc;
using System.Web;
using System.IO;

namespace Totalligent.UI.Controllers
{
    public class AgentController : Controller
    {
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        // GET: Agent
        public ActionResult Index()
        {
            //return View();
            return PartialView("_AgentMaster");
        }

        // GET: Agent/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Agent/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agent/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                AgentMaster objAgentMaster = new AgentMaster
                {
                    AgentName = collection["AgentName"].ToString(),
                    //AgentCode = collection["AgentCode"].ToString(),
                    Address = collection["Address"].ToString(),
                    City = collection["City"].ToString(),
                    Zipcode = collection["Zipcode"].ToString(),
                    ContactPerson = collection["ContactPerson"].ToString(),
                    MobileNumber = collection["MobileNumber"].ToString(),
                    EmailId = collection["EmailId"].ToString(),
                };

                long returnCode = -1;
                if (objAgentMaster != null)
                {
                    returnCode = objMasterBAL.SaveAgent(objAgentMaster);
                }
                return Json(returnCode);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Agent/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agent/Edit/5
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

        // GET: Agent/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agent/Delete/5
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
        [HttpPost]
        public ActionResult BulkUpload(HttpPostedFileBase postedFile)
        {
            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                long returnCode = objMasterBAL.BulkUpload(extension, filePath);
                if (returnCode > 0)
                {
                    ViewBag.BulkUpload = "Data has been uploaded Successfully.!";
                }

            }

            return PartialView("_AgentMaster");
        }
    }
}

