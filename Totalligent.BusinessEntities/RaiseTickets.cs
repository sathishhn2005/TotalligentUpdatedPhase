using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class RaiseTickets
    {

        private int ticketId = 0;
        private string raisedBy = string.Empty;
        private string description = string.Empty;
        private DateTime createdAt = DateTime.Now;
        private string createdBy = string.Empty;

        public int TicketId { get => ticketId; set => ticketId = value; }
        public string RaisedBy { get => raisedBy; set => raisedBy = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
    }
}
