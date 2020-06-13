using System;

namespace Totalligent.BusinessEntities
{

    public class BrokerMaster
    {
        public long BrokerId { get; set; }

        public string BrokerName { get; set; }

        public string BrokerCode { get; set; }

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