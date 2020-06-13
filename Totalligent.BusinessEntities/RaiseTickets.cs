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
        private string status = string.Empty;
        private string emailId = string.Empty;
        private string username = string.Empty;
        private string newpassword   = string.Empty;

        public int TicketId { get => ticketId; set => ticketId = value; }
        public string RaisedBy { get => raisedBy; set => raisedBy = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public string CreatedBy { get => createdBy; set => createdBy = value; }
        public string Status { get => status; set => status = value; }
        public string EmailId { get => emailId; set => emailId = value; }
        public string Username { get => username; set => username = value; }
        public string Newpassword { get => newpassword; set => newpassword = value; }
    }
}
