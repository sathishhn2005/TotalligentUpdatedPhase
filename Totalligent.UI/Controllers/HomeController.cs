using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Totalligent.BusinessEntities;
using Totalligent.BAL;
using System.Web.Mvc;

using Totalligent.UI.Models;
using System.Text.RegularExpressions;
using System.IO;

namespace Totalligent.UI.Controllers
{
    public class HomeController : Controller
    {
        readonly RolesModel objRolesModel = new RolesModel();
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        TotalligentMasterBAL objMasterBAL = new TotalligentMasterBAL();
        static string U_Name = string.Empty;
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
        public ActionResult Userlogin()
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
                    U_Name = objEmployee.UserName;
                    TempData["uname"] = UName;
                    TempData["u"] = U_Name;
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

            return Json(i, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public long InsertProducerMaster(ProducerMaster model)
        {
            long returnCode = -1;
            try
            {
                string UN = string.Empty;

                //TempData["u"] = U_Name;
                if (TempData["u"] == null)
                {
                    UN = U_Name;
                }
                else
                {
                    UN = TempData["u"].ToString() ?? "";

                }
                model.AddedBy = UN;
                returnCode = objBALTot.InsertPM(model);
                //if (model.ID > 0 && returnCode > 0)
                //{
                //    returnCode = 2;
                //    TempData["un"] = u;
                //}
                if (model.Id.Equals(0) && returnCode > 0)
                {
                    returnCode = 1;
                    TempData["u"] = UN;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }
        [HttpPost]
        public ActionResult BulkUpload(HttpPostedFileBase postedFile)
        {
            string filePath = string.Empty;
            string UN = string.Empty;

            //TempData["u"] = U_Name;
            if (TempData["u"] == null)
            {
                UN = U_Name;
            }
            else
            {
                UN = TempData["u"].ToString() ?? "";

            }
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
                long returnCode = objMasterBAL.BulkUpload(extension, filePath,UN);
                if (returnCode > 0)
                {
                    returnCode = 1;
                    TempData["u"] = UN;
                }

            }

            return PartialView("_AgentMaster");
        }
        [HttpPost]
        public ActionResult UploadFiles()
        {
            string filePath = string.Empty;
            string textAlert = string.Empty;
            int reqFrom = Convert.ToInt32(Request.Form["txtMotorMaster"]);
            // Checking no of files injected in Request object  
            if (Request.Files.Count > 0)
            {
                try
                {
                    HttpPostedFileBase file = Request.Files[0];
                    string fname; string alert = string.Empty; ;
                    int rowsCnt = 0;
                    // string fileMismatchErr = string.Empty ;
                    fname = file.FileName;
                    if (fname.Equals("ProducerMaster.xlsx"))
                    {

                        string path = Server.MapPath("~/Uploads/");
                        filePath = path + Path.GetFileName(file.FileName);
                        string extension = Path.GetExtension(file.FileName);
                        file.SaveAs(filePath);
                        // Returns message that successfully uploaded  
                        if (extension.Equals(".xls") || extension.Equals(".xlsx"))
                        {
                            string UN = string.Empty;
                            if (string.IsNullOrEmpty(UN))
                            {
                                UN = U_Name;
                            }
                            long returnCode = objMasterBAL.BulkUploadMotor(extension, filePath, reqFrom, out rowsCnt, out string fileMismatchErr, UN);
                            if (returnCode.Equals(0))
                            {
                                alert = "All the Records already exists. Try uploading new data.";
                                textAlert = "same";
                                
                            }
                            else if (returnCode > 0)
                            {
                                alert = "File Uploaded Successfull & Mail has sent to all the users.!";
                                textAlert = "success";
                                
                            }
                            return Json(textAlert);

                        }
                        else
                        {
                            return Json("Incorrect file.! Please upload the file with the extension (.xls,xlsx)");
                        }
                    }
                    else
                    {
                        reqFrom = -3;
                        return Json(reqFrom);
                    }

                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }

        }
    }

}