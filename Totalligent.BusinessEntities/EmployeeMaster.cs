using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class EmployeeMaster
    {

        public long EmployeeId { get; set; }
        public decimal ClientRate { get; set; }
        public decimal RIRate { get; set; }
        
        public string EmployeeName { get; set; }

        public string EmployeeUniqueNumber { get; set; }

        public string Relation { get; set; }

        public string Nationality { get; set; }

        public string Category { get; set; }

        public DateTime? DOB { get; set; }

        public int? Age { get; set; }

        public decimal? Salary { get; set; }

        public decimal? EAW { get; set; }

        public decimal? SumAssured { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public string Remarks { get; set; }

        public string EntryType { get; set; }

        public string AddedBy { get; set; }

        public DateTime? AddedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

    }
}