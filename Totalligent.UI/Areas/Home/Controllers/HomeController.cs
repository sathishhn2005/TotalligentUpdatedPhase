using System;
using System.Collections.Generic;
using System.Web;
using Totalligent.BusinessEntities;
using Totalligent.BAL;
using System.Web.Mvc;
using Totalligent.UI.Models;
using System.Text.RegularExpressions;
using System.IO;
using Totalligent.Utilities;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace Totalligent.UI.Areas.Home.Controllers
{
    public class HomeController : Controller
    {
        ExcelSheetToDT objUtility = new ExcelSheetToDT();

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
        public ActionResult HomePage()
        {
            return View();

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
                        return View("HomePage");
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
                long returnCode = objMasterBAL.BulkUpload(extension, filePath, UN);
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
                                alert = "File Uploaded Successfull & Mail has sent to the users.!";
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
        [HttpPost]
        public long InsertEmployeeMaster(EmployeeMaster model)
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
                returnCode = objBALTot.InsertEM(model);
                //if (model.ID > 0 && returnCode > 0)
                //{
                //    returnCode = 2;
                //    TempData["un"] = u;
                //}
                if (model.EmployeeId.Equals(0) && returnCode > 0)
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
        public ActionResult Endorsement()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Endorsement(Endorsement obj, List<HttpPostedFileBase> fileUploadGLEndorsementPage, HttpPostedFileBase GLpostedFileDoc)
        {


            List<Endorsement> lst = null;
            string _filePath = string.Empty;
            string _FileName = string.Empty;

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            try
            {
                foreach (var item in fileUploadGLEndorsementPage)
                {
                    if (fileUploadGLEndorsementPage != null && fileUploadGLEndorsementPage.Count > 0)
                    {
                        string path = Server.MapPath(GetAppSettingsValue.EndorsementPath());

                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        _filePath = path + Path.GetFileName(item.FileName);
                        string extension = Path.GetExtension(item.FileName);
                        item.SaveAs(_filePath);
                        if (extension.Equals(".xlsx") || extension.Equals(".xls"))
                        {
                            if (item.FileName.Equals("GL_ENDORSEMENT_PAGE.xls"))
                            {
                                dt1 = objUtility.BulkUpload(extension, _filePath);
                                // model.GLEndorsement = dt;
                            }
                            else if (item.FileName.Equals("WC_ENDORSEMENT_PAGE.xls"))
                            {
                                dt2 = objUtility.BulkUpload(extension, _filePath);
                            }
                        }
                    }
                }
                string _ConfigureFilePath = GetAppSettingsValue.GLEndorsementDocumentPath();
                if (GLpostedFileDoc.ContentLength > 0)
                {
                    _FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + Path.GetFileName(GLpostedFileDoc.FileName);
                    _filePath = Path.Combine(Server.MapPath(_ConfigureFilePath), Path.GetFileName(_FileName));

                    GLpostedFileDoc.SaveAs(_filePath);
                }

                obj.GlpostedFileDocPath = _filePath;
                objBALTot.InsertEndorsement(obj, obj.EndorsementId, out lst, dt1, dt2);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            //   return returnCode;
            //return Json(lst, JsonRequestBehavior.AllowGet);
            return View(lst);
        }
        [HttpGet]
        public JsonResult GetClientMaster()
        {
            List<ClientCompanyMaster> lst = null;
            try
            {
                objBALTot.GetClientMaster(out lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetGLWLPolicyNos(string CompanyName)
        {
            Endorsement objEndor;
            try
            {
                objBALTot.GetGLWLPolicies(out objEndor, CompanyName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(objEndor, JsonRequestBehavior.AllowGet);

        }

        #region EndorsementPDF

        [HttpPost]
        [ValidateInput(false)]
        public FileResult GenerateGLwLPDF(long EndorsementId, string PdfType)
        {
            long returnCode = -1;
            List<Endorsement> lstEndorsement = null;

            returnCode = objBALTot.GetGL_WL_PDFdata(EndorsementId, PdfType, out lstEndorsement);

            string ExportData = RenderGLWLEndorsementHTML(lstEndorsement);
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader reader = new StringReader(ExportData);
                Document PdfFile = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(PdfFile, stream);
                PdfFile.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, PdfFile, reader);
                PdfFile.Close();

                return File(stream.ToArray(), "application/pdf", PdfType == "GL" ? "GLEndorsement.pdf" : "WLEndorsement.pdf");
            }

        }

        private string RenderGLWLEndorsementHTML(List<Endorsement> lstEndorsement)
        {
            string GenerateHTML = string.Empty;

            GenerateHTML += "<html><head></head><div>";
            if (lstEndorsement != null)
            {
                GenerateHTML += "<div align='center'> GROUP LIFE  – ENDORSEMENT </div>  <br /> ";
                GenerateHTML += "<table style='width: 80 %;'> <tr style='height: 35px;'><td>Class of Insurance</td> <td>:</td><td>" + lstEndorsement[0].ClssOfInsurance + "</td> </tr >";
                GenerateHTML += "<tr style='height: 35px;'><td>Endorsement No</td><td>:</td><td>" + lstEndorsement[0].EndorsementNo + "</td> </tr>";
                GenerateHTML += "<tr style='height: 35px;'><td>Policy No </td><td>:</td><td>" + lstEndorsement[0].PolicyNo + "</td></tr>";
                GenerateHTML += "<tr style='height: 35px;'><td>Insured</td><td>:</td><td>" + lstEndorsement[0].ClientName + "</td></tr>";
                GenerateHTML += "<tr style='height: 35px;'> <td>Policy Period</td> <td>:</td><td>" + lstEndorsement[0].PolicyPeriod + "</td></tr></table> <br /><br />";
                GenerateHTML += "<div style='height: 75px;'><p> At the request of the Insured, it is hereby agreed to delete the following employees of <b>" + lstEndorsement[0].ClientName + "</b>. to the above-mentioned policy. The details are as mentioned below</p> </div>";

                GenerateHTML += "<table style='width:100 %;border-color:darkgray' border='1' cellpadding='0' cellspacing='0'><thead><tr style='height: 30px;background-color:lightsteelblue'><td>S.No</td><td>Name of Employee</td><td>DOB </td><td>Sum Assured</td> <td>Effective Date</td></tr></thead > <tbody>";
                foreach (Endorsement value in lstEndorsement)
                {

                    GenerateHTML += "<tr style='height:30px;'>";
                    GenerateHTML += "<td>" + value.GLEndorsementId + "</td>";
                    GenerateHTML += "<td>" + value.EmployeeName + "</td>";
                    GenerateHTML += "<td>" + Convert.ToDateTime(value.DOB).ToString("dd-MM-yyyy") + "</td>";
                    GenerateHTML += "<td>" + value.SumAssured + "</td>";
                    GenerateHTML += "<td>" + Convert.ToDateTime(value.EffectiveDate).ToString("dd-MM-yyyy") + "</td></tr>";
                }
                GenerateHTML += "</tbody></table><br /><br />";


                GenerateHTML += "<div> <p>In consideration of the foregoing, a premium of <b>RO.31.931</b> is hereby Credited to the Insured.All other terms, conditions and limitations remain unaltered. </p > </div >";
                GenerateHTML += "<br /><br /><div><div> Authorized Signatory </div><div>  Place: Muscat </div><div>  Date: " + DateTime.Now.ToString() + "</div></div>";

            }
            else
            {
                GenerateHTML += "<div>No Records Found</div>";
            }
            GenerateHTML += "</div></html>";
            return GenerateHTML;
        }
        #endregion


    }
}