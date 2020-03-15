using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Totalligent.UI.Models;

namespace Totalligent.UI.Controllers
{
    public class ClientController : Controller
    {
        public ActionResult ClientList([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                List<ClientModel> _emp = new List<ClientModel>();
                _emp.Add(new ClientModel(1, "Bobb", "Ross"));
                _emp.Add(new ClientModel(2, "Pradeep", "Raj"));
                _emp.Add(new ClientModel(3, "Arun", "Kumar"));
                DataSourceResult result = _emp.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
    }
}