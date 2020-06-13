using System;

namespace Totalligent.BusinessEntities
{

    public class AgentMaster
    {
        public long AgentId { get; set; }

        public string AgentName { get; set; }

        public string AgentCode { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Zipcode { get; set; }

        public string ContactPerson { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public DateTime? AddedOn { get; set; }

        public string AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

    }


}