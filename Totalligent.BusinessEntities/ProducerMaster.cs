using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class ProducerMaster
    {
        public long Id { get; set; }

        public string MasterType { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailId { get; set; }

        public DateTime? AddedOn { get; set; }

        public string AddedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public string EntryType { get; set; }


    }
}
