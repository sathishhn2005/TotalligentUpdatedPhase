using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Totalligent.DAL;
using Totalligent.BusinessEntities;
using System.Security.Cryptography;
using Totalligent.Utilities;

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
                        returnCode = objTotalligentDAL.SaveLogin(UserName, encryptedPswd, objRegisterEmployee.RoleId);
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
        public long RegisterTPAInsEmployee(InsuranceCompany objInsCompany)
        {
            try
            {
                long returnCode = objTotalligentDAL.TPAInsComRegister(objInsCompany);
                
                return returnCode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
