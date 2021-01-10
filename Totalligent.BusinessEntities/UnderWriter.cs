using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class UnderWriter
    {

        public int TotPoltoBeRenewed { get; set; }

        public int TotPolforRenewal { get; set; }

        public int NoOfPoRenewed { get; set; }

        public int PolicyLost { get; set; }

        public int TotPoltoBeRenewedCM { get; set; }

        public int TotPolforRenewalCM { get; set; }

        public int NoOfPoRenewedCM { get; set; }
        public decimal TotalPremiumEarned { get; set; }
        public decimal TotalPremiumRejected { get; set; }
        public decimal TotalPremiumPending { get; set; }

        public int PolicyLostCM { get; set; }
        public long RoleId { get; set; }
        public string UserName { get; set; }
        //public List<ProducerCodeMaster> lstProducerMaster { get; set; }
        public List<Quotation> lstQuotation { get; set; }
        public long TNPYear { get; set; }
        public long TNPUnderProcessYear { get; set; }
        public long TNPLostYear { get; set; }
        public long TNPRenewedYear { get; set; }
        public decimal PercentageRenewedYear { get; set; }
        public long TNPMonth { get; set; }
        public long TNPLostMonth { get; set; }
        public long TNPUnderProcessMonth { get; set; }
        public long TNPRenewedMonth { get; set; }
        public decimal PercentageRenewedMonth { get; set; }
        public long TNPYearPremium { get; set; }
        public long TNPUPYearPremium { get; set; }
        public long TNPLostYearPremium { get; set; }
        public long TNPRenewedYearPremium { get; set; }
        public decimal PercentPremiumRenewedYear { get; set; }
        public long TNPMonthPremium { get; set; }
        public long TNPLostMonthPremium { get; set; }
        public long TNPUPMonthPremium { get; set; }
        public long TNPRenewedMonthPremium { get; set; }
        public decimal PercentPremiumRenewedMonth { get; set; }

        public long TotalNoPolQuotationDrafted { get; set; }
        public long TotNoPolIssued { get; set; }
        public decimal TotalNoPolRejected { get; set; }
    }
}
