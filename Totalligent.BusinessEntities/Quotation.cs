using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class Quotation
    {
        private long quotationId = 0;
        private long annualbenefitLimit = 0;
        private string geographicalscope = string.Empty;
        private string geoScopeEmergencytreat = string.Empty;

        private string covCriteriaforTreat = string.Empty;
        private string networkApplicable = string.Empty;
        private string uWterms = string.Empty;
        private string hospitalClass = string.Empty;
        private string hospitalaccomdation = string.Empty;
        private string iCUTreat = string.Empty;
        private string consultantsFees = string.Empty;
        private string variousTherapies = string.Empty;
        private string organtransplant = string.Empty;
        private string medicalEquipments = string.Empty;
        private string ambulanceServices = string.Empty;
        private string beneficiaryexpences = string.Empty;
        private string iPtreatmentinGOVhospita = string.Empty;
        private string repatriationCosts = string.Empty;
        private string physicianConsultation = string.Empty;
        private string diagnostics = string.Empty;
        private string pharmaceuticals = string.Empty;
        private string physiotheraphy = string.Empty;
        private string daycareTreatment = string.Empty;
        private string outPatientSurgery = string.Empty;
        private string workRelatedInjuries = string.Empty;
        private string dentalTreatment = string.Empty;
        private string newBornBabyCoverage = string.Empty;
        private string nursingatHome = string.Empty;
        private string alternativeMedicineBenefits = string.Empty;
        private string outsideOmanfreeaccess = string.Empty;
        private DateTime addedOn = DateTime.Now;
        private DateTime updatedOn = DateTime.Now;
        private string addedBy = string.Empty;
        private string updatedBy = string.Empty;

        public long QuotationId { get => quotationId; set => quotationId = value; }
        public long AnnualbenefitLimit { get => annualbenefitLimit; set => annualbenefitLimit = value; }
        public string Geographicalscope { get => geographicalscope; set => geographicalscope = value; }
        public string GeoScopeEmergencytreat { get => geoScopeEmergencytreat; set => geoScopeEmergencytreat = value; }
        public string CovCriteriaforTreat { get => covCriteriaforTreat; set => covCriteriaforTreat = value; }
        public string NetworkApplicable { get => networkApplicable; set => networkApplicable = value; }
        public string UWterms { get => uWterms; set => uWterms = value; }
        public string HospitalClass { get => hospitalClass; set => hospitalClass = value; }
        public string Hospitalaccomdation { get => hospitalaccomdation; set => hospitalaccomdation = value; }
        public string ICUTreat { get => iCUTreat; set => iCUTreat = value; }
        public string ConsultantsFees { get => consultantsFees; set => consultantsFees = value; }
        public string VariousTherapies { get => variousTherapies; set => variousTherapies = value; }
        public string Organtransplant { get => organtransplant; set => organtransplant = value; }
        public string MedicalEquipments { get => medicalEquipments; set => medicalEquipments = value; }
        public string AmbulanceServices { get => ambulanceServices; set => ambulanceServices = value; }
        public string Beneficiaryexpences { get => beneficiaryexpences; set => beneficiaryexpences = value; }
        public string IPtreatmentinGOVhospita { get => iPtreatmentinGOVhospita; set => iPtreatmentinGOVhospita = value; }
        public string RepatriationCosts { get => repatriationCosts; set => repatriationCosts = value; }
        public string PhysicianConsultation { get => physicianConsultation; set => physicianConsultation = value; }
        public string Diagnostics { get => diagnostics; set => diagnostics = value; }
        public string Pharmaceuticals { get => pharmaceuticals; set => pharmaceuticals = value; }
        public string Physiotheraphy { get => physiotheraphy; set => physiotheraphy = value; }
        public string DaycareTreatment { get => daycareTreatment; set => daycareTreatment = value; }
        public string OutPatientSurgery { get => outPatientSurgery; set => outPatientSurgery = value; }
        public string WorkRelatedInjuries { get => workRelatedInjuries; set => workRelatedInjuries = value; }
        public string DentalTreatment { get => dentalTreatment; set => dentalTreatment = value; }
        public string NewBornBabyCoverage { get => newBornBabyCoverage; set => newBornBabyCoverage = value; }
        public string NursingatHome { get => nursingatHome; set => nursingatHome = value; }
        public string AlternativeMedicineBenefits { get => alternativeMedicineBenefits; set => alternativeMedicineBenefits = value; }
        public string OutsideOmanfreeaccess { get => outsideOmanfreeaccess; set => outsideOmanfreeaccess = value; }
        public DateTime AddedOn { get => addedOn; set => addedOn = value; }
        public DateTime UpdatedOn { get => updatedOn; set => updatedOn = value; }
        public string AddedBy { get => addedBy; set => addedBy = value; }
        public string UpdatedBy { get => updatedBy; set => updatedBy = value; }
    }
}
