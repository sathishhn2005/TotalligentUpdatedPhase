using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totalligent.DAL;
using Totalligent.BusinessEntities;
using System.Security.Cryptography;
using Totalligent.Utilities;
using System.Transactions;

namespace Totalligent.BAL
{
    public class TotalligentBALayer
    {
        TotalligentDALayer objTotalligentDAL = new TotalligentDALayer();

        public List<Role> GetRoles()
        {
            try
            {
                List<Role> lstRole = objTotalligentDAL.GetRoles();
                return lstRole;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<UserType> GetUserType()
        {
            try
            {
                List<UserType> lstUserType = objTotalligentDAL.GetUserTypeMaster();
                return lstUserType;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public long UpdateNewPassword(string UserName, string OldPswd, string NewPswd)
        {
            long returnCode = -1;
            try
            {
                if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(OldPswd) && !string.IsNullOrEmpty(NewPswd))
                {

                    returnCode = objTotalligentDAL.UpdateNewPassword(UserName, OldPswd, NewPswd);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return returnCode;
        }

        public Employee GetLogin(string Username, string Password, int RoleId, out string IsFirstLogin)
        {
            try
            {

                Employee objEmployee = objTotalligentDAL.GetLoginInfo(Username, Password, RoleId, out IsFirstLogin);
                return objEmployee;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public long SaveUser(Register objRegister)
        {
            try
            {
                long returnCode = objTotalligentDAL.RegisterUser(objRegister);
                if (returnCode > 0)
                {
                    string UserName = "Totlli" + UserNamePasswordGen();

                    byte[] b = ASCIIEncoding.ASCII.GetBytes(UserName.Substring(0, 8));
                    string encryptedPswd = Convert.ToBase64String(b);
                    if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(encryptedPswd))
                    {
                        returnCode = objTotalligentDAL.SaveLogin(UserName, encryptedPswd, 0);
                        MailingServices objMail = new MailingServices();
                        returnCode = objMail.SendMailToAdmin(UserName, encryptedPswd, objRegister.EmailId);
                    }
                }
                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private static string UserNamePasswordGen()
        {
            int randval;
            string n;
            StringBuilder op = new StringBuilder();
            RandomNumberGenerator obj = RandomNumberGenerator.Create();
            byte[] val = new byte[4];
            obj.GetBytes(val);
            randval = BitConverter.ToInt32(val, 0);
            if (randval < 0)
            {
                randval *= -1;
            }
            n = randval.ToString();
            int i = n.Length - 1;
            int c = 1;
            while (c <= 6)
            {
                op.Append(n[i]);
                c += 1;
                i -= 1;
            }
            obj.Dispose();
            return op.ToString();
        }
        public long SaveEmployee(Employee objRegisterEmployee)
        {
            try
            {
                long returnCode = objTotalligentDAL.RegisterEmployee(objRegisterEmployee, out string UserName, out string EmailId);
                if (returnCode > 0)
                {
                    if (UserName.Length < 5)
                    {
                        UserName += "Totalligent";
                    }
                    byte[] b = ASCIIEncoding.ASCII.GetBytes(UserName.Substring(0, 4));
                    string encryptedPswd = Convert.ToBase64String(b);
                    if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(encryptedPswd))
                    {
                        returnCode = objTotalligentDAL.SaveLogin(objRegisterEmployee.UserName, encryptedPswd, objRegisterEmployee.RoleId);
                        MailingServices objMail = new MailingServices();
                        returnCode = objMail.SendMailToAdmin(UserName, encryptedPswd, EmailId);
                    }
                }
                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string InsertClient(Register objClientRegistration)
        {
            string PolicyNumber = string.Empty;
            try
            {
                if (objClientRegistration != null)
                {
                    objClientRegistration.PolicyNumber = "D/01/3101/20/";
                    PolicyNumber = objTotalligentDAL.InsertClient(objClientRegistration);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PolicyNumber;
        }
        public List<Register> GetClients(string PolicyNumber)
        {
            List<Register> lstClients = new List<Register>();
            if (!string.IsNullOrEmpty(PolicyNumber))
            {
                try
                {
                    lstClients = objTotalligentDAL.GetClients(PolicyNumber);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return lstClients;
        }
        //Registering New TPA Insurance company Employee
        public long RegisterTPAInsEmployee(InsuranceCompany objInsCompany, out string PolicyNumber)
        {
            try
            {
                long returnCode = objTotalligentDAL.TPAInsComRegister(objInsCompany, out PolicyNumber);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<InsuranceCompany> GetCompanies(string CompanyDraftNo)
        {
            List<InsuranceCompany> lstClients = new List<InsuranceCompany>();
            if (!string.IsNullOrEmpty(CompanyDraftNo))
            {
                try
                {
                    lstClients = objTotalligentDAL.GetCompanies(CompanyDraftNo);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return lstClients;
        }
        public long RaiseTicket(RaiseTickets objRaiseTickets)
        {
            try
            {
                long returnCode = objTotalligentDAL.SaveRaiseTicket(objRaiseTickets);

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int IsUserExits(string UserId)
        {
            int i = 0;

            try
            {
                i = objTotalligentDAL.IsUserExists(UserId, out List<Employee> lstUsers);

                if (i > 0)
                {
                    MailingServices objMail = new MailingServices();
                    i = objMail.PswdResetMailFromAdmin(lstUsers[0].UserName, lstUsers[0].MobileNumber, lstUsers[0].EmailId, lstUsers[0].TicketId, 0);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return i;

        }
        public List<RaiseTickets> ViewTickets()
        {
            try
            {
                List<RaiseTickets> lstViewTickets = objTotalligentDAL.GetTickets();

                return lstViewTickets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long CloseTicket(RaiseTickets objRaiseTickets)
        {
            try
            {
                long returnCode = objTotalligentDAL.CloseRaisedTicket(objRaiseTickets, out List<Employee> lstMailNewPswd);
                if (returnCode > 0 && lstMailNewPswd.Count > 0)
                {
                    MailingServices objMail = new MailingServices();
                    returnCode = objMail.PswdResetMailFromAdmin(lstMailNewPswd[0].UserName, lstMailNewPswd[0].Newpassword,
                        lstMailNewPswd[0].EmailId, lstMailNewPswd[0].TicketId, 1);

                }

                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public long InsertPM(ProducerMaster objPM)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    byte[] b = ASCIIEncoding.ASCII.GetBytes(objPM.EmailId);
                    string encryptedPswd = Convert.ToBase64String(b);

                    objPM.Password = encryptedPswd;
                    returnCode = objTotalligentDAL.SavePM(objPM, out string UserName, out string EmailId);
                    if (returnCode > 0)
                    {

                        if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(encryptedPswd))
                        {
                            returnCode = objTotalligentDAL.SaveLogin(UserName, encryptedPswd, 1);
                            MailingServices objMail = new MailingServices();
                            returnCode = objMail.SendMailToAdmin(UserName, encryptedPswd, EmailId);
                        }
                        transactionScope.Complete();
                        transactionScope.Dispose();
                    }

                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }
            }
            return returnCode;
        }
        public long CreateQuotation(Quotation objPM,out string draftNo)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    returnCode = objTotalligentDAL.CreateQuotation(objPM, out draftNo);
                    transactionScope.Complete();
                    transactionScope.Dispose();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }
            }
            return returnCode;
        }
        public long GetUWDB(string UserName, out UnderWriter lstInfo)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    returnCode = objTotalligentDAL.GetUWDashBoardDetails(UserName, out lstInfo);
                    transactionScope.Complete();
                    transactionScope.Dispose();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }
            }
            return returnCode;
        }
        public long EditQutation(string UserName,int QuotationId, out Quotation lstInfo)
        {
            long returnCode = -1;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    returnCode = objTotalligentDAL.EditQuotation(UserName, QuotationId, out lstInfo);
                    transactionScope.Complete();
                    transactionScope.Dispose();
                }
                catch (Exception ex)
                {
                    transactionScope.Dispose();
                    throw ex;
                }
            }
            return returnCode;
        }
    }
}
