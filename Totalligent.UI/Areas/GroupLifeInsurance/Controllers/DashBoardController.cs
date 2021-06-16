using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.BAL;
using Totalligent.UI.Models;
using Totalligent.BusinessEntities;
using Newtonsoft.Json;

namespace Totalligent.UI.Areas.GroupLifeInsurance.Controllers
{
    public class DashBoardController : Controller
    {
        readonly AdminModel objAdminModel = new AdminModel();
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        // GET: GroupLifeInsurance/DashBoard
        public ActionResult UnderWriterDashBoard()
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
        public ActionResult MISDashBoard()
        {
            return View();
        }
        public ActionResult BIDashBoard()
        {
            return View();
        }
    }
}