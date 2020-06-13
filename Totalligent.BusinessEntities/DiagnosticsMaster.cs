using System;

namespace Totalligent.BusinessEntities
{

    public class DiagnosticsMaster
    {
        public int DiagnosticsId { get; set; }

        public string DiagnosticsCode { get; set; }

        public string DiagnosticsName { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }

}