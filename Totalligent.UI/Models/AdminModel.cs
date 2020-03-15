using Totalligent.BusinessEntities;
using Totalligent.BAL;
using Totalligent.Utilities;
using System;

namespace Totalligent.UI.Models
{
    public class AdminModel
    {
        readonly TotalligentBALayer objBALTot = new TotalligentBALayer();
        readonly MailingServices objUtilityMailSer = new MailingServices();
        public Employee EmployeeRegistration { get; set; }
        
        public long RegisterUser(Employee objEmployee)
        {
            try
            {
                long returnCode = -1;
                returnCode = objBALTot.SaveEmployee(objEmployee);
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}