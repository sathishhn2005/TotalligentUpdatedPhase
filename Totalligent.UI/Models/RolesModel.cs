using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Totalligent.BusinessEntities;
using Totalligent.BAL;
using Totalligent.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Web.Security;

namespace Totalligent.UI.Models
{
    public class RolesModel
    {
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        readonly MailingServices objUtilityMailSer = new MailingServices();
        public int Role { get; set; }
        public string OldPassword { get; set; }
    //    [Required]
    //    [MembershipPassword(
    //MinRequiredNonAlphanumericCharacters = 1,
    //MinNonAlphanumericCharactersError = "Your password needs to contain at least one symbol (!, @, #, etc).",
    //ErrorMessage = "Your password must be 6 characters long and contain at least one symbol (!, @, #, etc).",
    //MinRequiredPasswordLength = 6)]
    //    [DataType(DataType.Password)]
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
        public int IsUserExits(string UserId)
        {
            int i = 0;
            try
            {
                i = objBALTot.IsUserExits(UserId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return i;
        }
    }
    public enum Gender
    {
        Male,
        Female
    }
    
}