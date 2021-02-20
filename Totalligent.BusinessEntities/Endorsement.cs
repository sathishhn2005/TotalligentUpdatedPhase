using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class Endorsement
    {
        public long EndorsementId { get; set; }

        public long? TicketNumber { get; set; }

        public string ClientName { get; set; }

        public DateTime? MailReceivedDate { get; set; }

        public string GLPolicyNumber { get; set; }

        public string WCPolicyNumber { get; set; }

        public string PolicyPeriod { get; set; }

        public string ErrorDescription { get; set; }

        public string EndorsementType { get; set; }

        public decimal? GLPremium { get; set; }

        public decimal? WCPremium { get; set; }

        public string MedicalPolicyNo { get; set; }

        public decimal? MedicalPremium { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public long GLEndorsementId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime? DOB { get; set; }

        public decimal? SumAssured { get; set; }

        public DateTime? EffectiveDate { get; set; }
        public long WLEndorsementId { get; set; }

        public decimal? EAWRo { get; set; }

        
    }
}
