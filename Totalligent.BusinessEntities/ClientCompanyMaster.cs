using System;

namespace Totalligent.BusinessEntities
{

    public class ClientCompanyMaster
    {
        public int ClientComId { get; set; }

        public string ClientCompanyName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public long? Zipcode { get; set; }

        public string ContactPerson { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string Currency { get; set; }

        public string Provider { get; set; }

        public string ProviderCommission { get; set; }

        public string ReInsurer { get; set; }

        public string ReInsurerRate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }

    


}