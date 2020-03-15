using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class InsuranceCompany
    {
        private int clientId = 0;
        private string companyName = string.Empty;
        private string policyNumber = string.Empty;
        private string clientName = string.Empty;
        private string address = string.Empty;
        private string city = string.Empty;
        private int stateId = 0;
        private long zipCode = 0;
        private string stateName = string.Empty;
        private string contactPerson = string.Empty;
        private string mobileNumber = string.Empty;
        private string emailId = string.Empty;
        private string currency = string.Empty;
        private DateTime createdAt = DateTime.Now;
        private string createdBy = string.Empty;
        private string broker = string.Empty;
        private string reinsurer = string.Empty;

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public int StateId { get => stateId; set => stateId = value; }
        public string ContactPerson { get => contactPerson; set => contactPerson = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string Currency { get => currency; set => currency = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public string StateName { get => stateName; set => stateName = value; }
        public long ZipCode { get => zipCode; set => zipCode = value; }
        public string Reinsurer { get => reinsurer; set => reinsurer = value; }
        public string Broker { get => broker; set => broker = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string PolicyNumber { get => policyNumber; set => policyNumber = value; }
        public int ClientId { get => clientId; set => clientId = value; }
    }
}
