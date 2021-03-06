﻿using Totalligent.BusinessEntities;
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
        public Quotation QuotationMaster { get; set; }

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
        public long ProducerMaster(ProducerMaster objPM)
        {
            try
            {
                long returnCode = -1;
                returnCode = objBALTot.InsertPM(objPM);
                return returnCode;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}