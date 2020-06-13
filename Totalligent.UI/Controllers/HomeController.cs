using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Totalligent.BusinessEntities;
using Totalligent.BAL;
using System.Web.Mvc;

using Totalligent.UI.Models;
using System.Text.RegularExpressions;

namespace Totalligent.UI.Controllers
{
    public class HomeController : Controller
    {
        readonly RolesModel objRolesModel = new RolesModel();
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Index()
        {
            if (TempData["Data"] != null)
            {
                return View(TempData["Data"]);
            }
            else
            {
                return View();
            }

        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult NewPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewPassword(RolesModel objModelNewPassword)
        {
            long returnCode = -1;
            string Username = (string)TempData["uname"];
            if (!Regex.IsMatch(objModelNewPassword.NewPassword, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])"))
            {
                ViewBag.ConfirmPasswordMessage = "Password should be Alphanumeric with a Capital letter and character.";
                return View();
            }
            else
            {
                if (objModelNewPassword != null && !string.IsNullOrEmpty(objModelNewPassword.NewPassword)
                    && !string.IsNullOrEmpty(objModelNewPassword.OldPassword)
                    && !string.IsNullOrEmpty(objModelNewPassword.ConfirmPassword))
                {
                    if (!objModelNewPassword.NewPassword.Equals(objModelNewPassword.ConfirmPassword))
                    {
                        ViewBag.ConfirmPasswordMessage = "New Password and Confirmation Password must match.";
                        return View();
                    }
                    else
                        returnCode = objBALTot.UpdateNewPassword(Username, objModelNewPassword.OldPassword, objModelNewPassword.ConfirmPassword);
                }
            }
            if (returnCode > 0)

                return View("Login");
            else
                return View("Error");

        }
        [HttpGet]
        public ActionResult Login(RolesModel objModels)
        {
            string UName = string.Empty;
            if (objModels.LoginUser != null)
            {
                Employee objEmployee = objBALTot.GetLogin(objModels.LoginUser.UserName, objModels.LoginUser.Password, objModels.Role, out string IsFirstLogin);
                if (!string.IsNullOrEmpty(objEmployee.UserName))
                {
                    UName = objEmployee.UserName;
                    TempData["uname"] = UName;
                    if (IsFirstLogin.Equals("N"))
                        return View("NewPassword");
                    else
                    {
                        ViewBag.UserName = "Welcome " + UName;
                        //
                        ViewBag.Data = objEmployee;
                        ViewBag.RoleId = objEmployee.RoleId;
                        TempData["Data"] = objEmployee;
                        return View("Index");
                    }
                }
                else
                {
                    ViewBag.Message = "Username or Password not found.!";
                    return View();
                }
            }

            else
                return View();
        }
        public ActionResult Registration()
        {
            //RolesModel objRolesModels = new RolesModel();
            // var result = objRolesModels.GetRoles();
            //ViewBag.lstRoles = new SelectList(result, "RoleId", "Description");
            return View();
        }
        [HttpPost]
        public ActionResult Register(Register objRegister)
        {
            long returnCode = -1;
            returnCode = objRolesModel.RegisterUser(objRegister);
            if (returnCode > 0)
            {
                return View("Login");
            }
            else
            {
                return View("Login");
            }
        }
        [HttpGet]
        public JsonResult ResetPassword(string UserId)
        {
            int i = 0;
            try
            {
                if (!string.IsNullOrEmpty(UserId))
                {
                    i = objRolesModel.IsUserExits(UserId);
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(i,JsonRequestBehavior.AllowGet);

        }




    }
}