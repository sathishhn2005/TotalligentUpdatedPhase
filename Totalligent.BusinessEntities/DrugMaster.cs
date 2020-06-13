using System;

namespace Totalligent.BusinessEntities
{

    public class DrugMaster
    {
        public int DrugId { get; set; }

        public string DrugCode { get; set; }

        public string DrugName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }

}