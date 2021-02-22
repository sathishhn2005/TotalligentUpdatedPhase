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
using Totalligent.Utilities;
using System.Data;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace Totalligent.UI.Controllers
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
        [HttpGet]
        public ActionResult GeneratePDFWLCL(long EndorsementId)
        {
            byte[] pdfBytes;
            using (var stream = new MemoryStream())
            using (var wri = new PdfWriter(stream))
            using (var pdf = new PdfDocument(wri))
            using (var doc = new Document(pdf))
            {
                doc.Add(new Paragraph("Hello World!"));
                doc.Flush();
                pdfBytes = stream.ToArray();
            }
            return new FileContentResult(pdfBytes, "application/pdf");
        }
        /*    public void GeneratePDF()
            {
                string companyName = "ASPSnippets";
                int orderNo = 2303;
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("ProductId", typeof(string)),
                                new DataColumn("Product", typeof(string)),
                                new DataColumn("Price", typeof(int)),
                                new DataColumn("Quantity", typeof(int)),
                                new DataColumn("Total", typeof(int))});
                dt.Rows.Add(101, "Sun Glasses", 200, 5, 1000);
                dt.Rows.Add(102, "Jeans", 400, 2, 800);
                dt.Rows.Add(103, "Trousers", 300, 3, 900);
                dt.Rows.Add(104, "Shirts", 550, 2, 1100);

                using (StringWriter sw = new StringWriter())
                {
                    using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                    {
                        StringBuilder sb = new StringBuilder();

                        //Generate Invoice (Bill) Header.
                        sb.Append("<table width='100%' cellspacing='0' cellpadding='2'>");
                        sb.Append("<tr><td align='center' style='background-color: #18B5F0' colspan = '2'><b>Order Sheet</b></td></tr>");
                        sb.Append("<tr><td colspan = '2'></td></tr>");
                        sb.Append("<tr><td><b>Order No: </b>");
                        sb.Append(orderNo);
                        sb.Append("</td><td align = 'right'><b>Date: </b>");
                        sb.Append(DateTime.Now);
                        sb.Append(" </td></tr>");
                        sb.Append("<tr><td colspan = '2'><b>Company Name: </b>");
                        sb.Append(companyName);
                        sb.Append("</td></tr>");
                        sb.Append("</table>");
                        sb.Append("<br />");

                        //Generate Invoice (Bill) Items Grid.
                        sb.Append("<table border = '1'>");
                        sb.Append("<tr>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            sb.Append("<th style = 'background-color: #D20B0C;color:#ffffff'>");
                            sb.Append(column.ColumnName);
                            sb.Append("</th>");
                        }
                        sb.Append("</tr>");
                        foreach (DataRow row in dt.Rows)
                        {
                            sb.Append("<tr>");
                            foreach (DataColumn column in dt.Columns)
                            {
                                sb.Append("<td>");
                                sb.Append(row[column]);
                                sb.Append("</td>");
                            }
                            sb.Append("</tr>");
                        }
                        sb.Append("<tr><td align = 'right' colspan = '");
                        sb.Append(dt.Columns.Count - 1);
                        sb.Append("'>Total</td>");
                        sb.Append("<td>");
                        sb.Append(dt.Compute("sum(Total)", ""));
                        sb.Append("</td>");
                        sb.Append("</tr></table>");

                        //Export HTML String as PDF.
                        StringReader sr = new StringReader(sb.ToString());
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        HTMLWorker htmlparser = new HTMLWorker(pdfDoc);
                        PdfWriter writer = PdfWriter.(pdfDoc, Response.OutputStream);
                        pdfDoc.Open();
                        htmlparser.Parse(sr);
                        pdfDoc.Close();
                        Response.ContentType = "application/pdf";
                        Response.AddHeader("content-disposition", "attachment;filename=Invoice_" + orderNo + ".pdf");
                        Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        Response.Write(pdfDoc);
                        Response.End();
                    }
                }
            }*/
    }


}