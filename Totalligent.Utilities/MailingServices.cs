using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Totalligent.Utilities
{
    public class MailingServices
    {
        readonly string smtpAddress = ConfigurationManager.AppSettings["smtpAddress"];
        readonly int portNumber = Convert.ToInt32(ConfigurationManager.AppSettings["portNumber"]);
        readonly bool enableSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["enableSSL"]);
        readonly string emailFromAddress = ConfigurationManager.AppSettings["emailFromAddress"];
        readonly string password = ConfigurationManager.AppSettings["password"];
        readonly string subject = ConfigurationManager.AppSettings["TotalligentSubject"];
        readonly string TotalligentBody = ConfigurationManager.AppSettings["MailBody"];
        readonly string EmailId = ConfigurationManager.AppSettings["emailAddressTo"];

        public long SendMailToAdmin(string UserName, string encryptedPswd, string ToAddress)
        {
            long returnCode = -1;
            try
            {
                string emailToAddress = EmailId;
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromAddress);
                    if (!string.IsNullOrEmpty(ToAddress))
                    {
                        mail.To.Add(ToAddress);
                        mail.Subject = "Registration Successfull.!";
                    }
                    else
                    {
                        mail.To.Add(emailToAddress);
                        mail.Subject = subject;
                    }
                    mail.Body = TotalligentBody + UserName + " and your password is " + encryptedPswd;
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
                returnCode = 1;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnCode;
        }

    }
}
