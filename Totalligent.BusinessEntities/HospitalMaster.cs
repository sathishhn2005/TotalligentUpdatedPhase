using System;

namespace Totalligent.BusinessEntities
{

    public class HospitalMaster
    {
        public int HospitalId { get; set; }

        public string HospitalName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public long? Zipcode { get; set; }

        public string ContactPerson { get; set; }

        public string MobileNumber { get; set; }

        public string EmailId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }


}