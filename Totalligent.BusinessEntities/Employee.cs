using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class Employee
    {

        private int employeeId = 0;

        private int roleId = 0;
        private string userName = string.Empty;
        private string userEmployeeNo = string.Empty;
        private int userTypeId = 0;
        private string reportingManager = string.Empty;
        private string designation = string.Empty;
        private string emailId = string.Empty;
        private string mobileNumber = string.Empty;
        private DateTime addedOn = DateTime.Now;
        private string addedBy = string.Empty;
        private DateTime updatedOn = DateTime.Now;
        private string updatedBy = string.Empty;
        private string newpassword = string.Empty;
        private int ticketId = 0;
        
        
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        
        public string UserName { get => userName; set => userName = value; }
        public string UserEmployeeNo { get => userEmployeeNo; set => userEmployeeNo = value; }
        public int UserTypeId { get => userTypeId; set => userTypeId = value; }
        public string ReportingManager { get => reportingManager; set => reportingManager = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public DateTime AddedOn { get => addedOn; set => addedOn = value; }
        public string AddedBy { get => addedBy; set => addedBy = value; }
        public DateTime UpdatedOn { get => updatedOn; set => updatedOn = value; }
        public string UpdatedBy { get => updatedBy; set => updatedBy = value; }
        public string Designation { get => designation; set => designation = value; }
        public int RoleId { get => roleId; set => roleId = value; }
        public int TicketId { get => ticketId; set => ticketId = value; }
        public string Newpassword { get => newpassword; set => newpassword = value; }
    }
}
