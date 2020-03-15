using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Totalligent.BusinessEntities;
using Totalligent.BAL;
using Totalligent.Utilities;

namespace Totalligent.UI.Models
{
    public class RolesModel
    {
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        readonly MailingServices objUtilityMailSer = new MailingServices();
        public int Role { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }

        public long RegisterUser(Register objRegister)
        {
            try
            {
                long returnCode = -1;
                returnCode = objBALTot.SaveUser(objRegister);
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Login LoginUser { get; set; }
    }
    public enum Gender
    {
        Male,
        Female
    }
}