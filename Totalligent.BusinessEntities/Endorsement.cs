using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class Endorsement
    {
        private string glpostedFileDocPath = string.Empty;

        public long EndorsementId { get; set; }

        public long? TicketNumber { get; set; }

        public string ClientName { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
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

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? CreatedAt { get; set; }

        public string CreatedBy { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? UpdatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public long GLEndorsementId { get; set; }

        public string EmployeeName { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }

        public decimal? SumAssured { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? EffectiveDate { get; set; }
        public long WLEndorsementId { get; set; }

        public decimal? EAWRo { get; set; }
      //  public string GLpostedFileDocPath { get; set; }
        
        public string GlpostedFileDocPath { get => glpostedFileDocPath; set => glpostedFileDocPath = value; }

        public string ClssOfInsurance { get; set; }
        public string EndorsementNo { get; set; }
        public string PolicyNo { get; set; }

        



    }
}
