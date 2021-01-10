using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Totalligent.BusinessEntities
{
    public class Quotation
    {
        public long QuotationId { get; set; }

        public string DraftNo { get; set; }
        public string PolicyNo { get; set; }
        public string Status { get; set; }

        public string CIInsuranceCompanyName { get; set; }

        public string CIClientCompanyName { get; set; }

        public string CIProducerType { get; set; }

        public string CIProducerName { get; set; }

        public decimal? CISelectCommission { get; set; }

        public int? CINoOfPlanCategories { get; set; }

        public string GBMedicalProviderNetwork { get; set; }

        public string GBScopeOfCover { get; set; }

        public string GBAreaOfCoverage { get; set; }

        public string GBPersonCovered { get; set; }

        public decimal? GBAnnualBenefitsLimit { get; set; }

        public string GBIsPerClaimLimitIP { get; set; }

        public decimal? GBPerClaimLimitIP { get; set; }
        

        public decimal? GBTotalPremium { get; set; }
        public decimal? GBPolicyFee { get; set; }
        public decimal? GBInsuranceLevy { get; set; }
        public decimal? GBPremium { get; set; }

        public string GBIsPerClaimLimitOP { get; set; }

        public decimal? GBPerClaimLimitOP { get; set; }

        public decimal? GBPreExisting_ChronicLimit { get; set; }

        public string GBGeoThreateningEmergencyTreatment { get; set; }

        public string GBGeoElectiveTreatement { get; set; }

        public string GBGeoOutsideResidentCountry { get; set; }

        public string IPHospitalizationClass { get; set; }

        public decimal? IPHospitalizationClassLimit { get; set; }

        public string IPICUCoronaryTreatement { get; set; }

        public decimal? IPICUCoronaryTreatementLimit { get; set; }

        public string IPVariousTherapies { get; set; }

        public decimal? IPVariousTherapiesLimit { get; set; }

        public string IPOrganTransplantationServices { get; set; }

        public decimal? IPOrganTransplantationServicesLimit { get; set; }

        public string IPAmbulanceServices { get; set; }

        public decimal? IPAmbulanceServicesLimit { get; set; }

        public string IPCompanionRoomBoardExpenses { get; set; }

        public decimal? IPCompanionRoomBoardExpensesLimit { get; set; }

        public decimal? IPHospitalCashBenefitsCashPerDay { get; set; }

        public decimal? IPHospitalCashBenefitsCashTotal { get; set; }

        public decimal? IPRepatriationCostTraansport { get; set; }

        public string IPAddBenefits { get; set; }

        public string OPPhysicianConsultationDeductible { get; set; }

        public decimal? OPPhysicianConsultationDeductibleLimit { get; set; }

        public string OPDiagnostics { get; set; }

        public decimal? OPDiagnosticsLimit { get; set; }

        public string OPPharmaceuticals { get; set; }

        public decimal? OPPharmaceuticalsLimit { get; set; }

        public string OPPhysiotheraphy { get; set; }

        public decimal? OPPhysiotheraphyLimit { get; set; }

        public string OPDaycareTreatment { get; set; }

        public decimal? OPDaycareTreatmentLimit { get; set; }

        public string OPOutPatientSurgery { get; set; }

        public decimal? OPOutPatientSurgeryLimit { get; set; }

        public string OPWorkRelatedInjuries { get; set; }

        public decimal? OPWorkRelatedInjuriesLimit { get; set; }

        public string OPAccidentalDamageNaturalTeeth { get; set; }

        public decimal? OPAccidentalDamageNaturalTeethLimit { get; set; }

        public string OPNewBornBabyCoverage { get; set; }

        public decimal? OPNewBornBabyCoverageLimit { get; set; }

        public string OPNursingAtHome { get; set; }

        public decimal? OPNursingAtHomeLimit { get; set; }

        public string OPAlternativeMedicine { get; set; }

        public string OPAlternativeMedicineCoverage { get; set; }

        public decimal? OPAlternativeMedicineCoverageLimit { get; set; }

        public string OPAlternativeMedicineDeductible { get; set; }

        public decimal? OPAlternativeMedicineDeductibleLimit { get; set; }

        public string OPFreeAccessOutsideOMAN { get; set; }

        public string EBFreeAccessTPANetwork { get; set; }

        public string EBFreeAccessTPANetworkLimit { get; set; }

        public string EBReimbursementNonNetworkMedicalProviders { get; set; }

        public string EBReimbursementNonNetworkMedicalProvidersLimit { get; set; }

        public string EBEmergencyTreatment { get; set; }

        public string EBEmergencyTreatmentLimit { get; set; }

        public string EBEmergencyTreatmentCountry { get; set; }

        public string ABBenefits { get; set; }

        public string ABDescription { get; set; }

        public string ABExclusions { get; set; }

        public string AddedBy { get; set; }

        public DateTime? AddedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

    }


    public class Q
    {
        [Display(Name = "custom Percentage")]
        public string custom_Percentage { get; set; }
        [Display(Name = "Scope Of Cover IP ")]
        public string ScopeOfCoverIP { get; set; }
        [Display(Name = "Scope Of Cover OP ")]
        public string ScopeOfCoverOP { get; set; }
        [Display(Name = " Chronic Limit Input")]
        public string ChronicLimitInput { get; set; }
        [Display(Name = "Reasonable Charges ")]
        public string ReasonableCharges { get; set; }
        [Display(Name = "Actual Cost Incurred ")]
        public string ActualCostIncurred { get; set; }
        [Display(Name = "AC Incurred ")]
        public string ACIncurred { get; set; }
        [Display(Name = "Criteria Input ")]
        public string CriteriaInput { get; set; }
        [Display(Name = " Limit Per Day")]
        public string LimitPerDay { get; set; }
        [Display(Name = "Intensive Care Limit")]
        public string IntensiveCareLimit { get; set; }
        [Display(Name = "Various Therapies Limit")]
        public string VariousTherapiesLimit { get; set; }
        [Display(Name = "Recepient Organ Limit")]
        public string RecepientOrganLimit { get; set; }
        [Display(Name = "Ambulance Services Limit")]
        public string AmbulanceServicesLimit { get; set; }
        [Display(Name = "Companion Room Limit")]
        public string CompanionRoomLimit { get; set; }
        [Display(Name = "Hospital Cash Per Day")]
        public string HospitalCashPerDay { get; set; }
        [Display(Name = "Hospital Cash Total")]
        public string HospitalCashTotal { get; set; }
        [Display(Name = "Repatriation Costs Limit Per Person")]
        public string RepatriationCostsLimitPerPerson { get; set; }
        [Display(Name = "Day care Treatment Limit")]
        public string DaycareTreatmentLimit { get; set; }
        [Display(Name = "Out Patient Surgery Limit")]
        public string OutPatientSurgeryLimit { get; set; }
        [Display(Name = "Work Related Limit")]
        public string WorkRelatedLimit { get; set; }
        [Display(Name = "Emergency Dental Limit")]
        public string EmergencyDentalLimit { get; set; }
        [Display(Name = "New Born Baby Limit")]
        public string NewBornBabyLimit { get; set; }
        [Display(Name = "Nursing at Home Limit")]
        public string NursingatHomeLimit { get; set; }
        [Display(Name = "Benefits")]
        public string Benefits { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

    }
}
