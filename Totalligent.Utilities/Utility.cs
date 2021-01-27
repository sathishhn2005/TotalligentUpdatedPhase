using System;
using System.Configuration;
using System.Data;
using Totalligent.BusinessEntities;

namespace Totalligent.Utilities
{
    public class Utility
    {
        public string GetConnectionString()
        {
            string conStr = ConfigurationManager.ConnectionStrings["Totalligent"].ConnectionString.ToString();
            return conStr;
        }
        public string GetOLEDBConnectionString(string Extension)
        {
            string OLEDBContstr = string.Empty;
            if (Extension.Equals(".xls"))
            {
                OLEDBContstr = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
            }
            else if (Extension.Equals(".xlsx"))
            {
                OLEDBContstr = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
            }

            return OLEDBContstr;
        }
        public DataTable ConvertToClient(Register _objRegisterClient)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("ClientName", typeof(string));
                _dt.Columns.Add("PolicyNumber", typeof(string));
                _dt.Columns.Add("CompanyAddress", typeof(string));
                _dt.Columns.Add("City", typeof(string));
                _dt.Columns.Add("StateName", typeof(string));
                _dt.Columns.Add("ZipCode", typeof(long));
                _dt.Columns.Add("ContactPerson", typeof(string));
                _dt.Columns.Add("MobileNumber", typeof(string));
                _dt.Columns.Add("EmailId", typeof(string));
                _dt.Columns.Add("Currency", typeof(string));
                _dt.Columns.Add("Broker", typeof(string));
                _dt.Columns.Add("Reinsurer", typeof(string));

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["ClientName"] = _objRegisterClient.ClientName;
                _dr["PolicyNumber"] = _objRegisterClient.PolicyNumber;
                _dr["CompanyAddress"] = _objRegisterClient.Address;
                _dr["City"] = _objRegisterClient.City;
                _dr["StateName"] = _objRegisterClient.StateName;
                _dr["ZipCode"] = _objRegisterClient.ZipCode;
                _dr["ContactPerson"] = _objRegisterClient.ContactPerson;
                _dr["MobileNumber"] = _objRegisterClient.MobileNumber;
                _dr["EmailId"] = _objRegisterClient.EmailId;
                _dr["Currency"] = _objRegisterClient.Currency;
                _dr["Broker"] = _objRegisterClient.Broker;
                _dr["Reinsurer"] = _objRegisterClient.Reinsurer;
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ConvertToQuotationGenerator(Quotation _objQuotation)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("QuotationId", typeof(long));
                _dt.Columns.Add("DraftNo", typeof(string));
                _dt.Columns.Add("CIInsuranceCompanyName", typeof(string));
                _dt.Columns.Add("CIClientCompanyName", typeof(string));
                _dt.Columns.Add("CIProducerType", typeof(string));
                _dt.Columns.Add("CIProducerName", typeof(string));
                _dt.Columns.Add("CISelectCommission", typeof(decimal));
                _dt.Columns.Add("CINoOfPlanCategories", typeof(int));
                _dt.Columns.Add("GBMedicalProviderNetwork", typeof(string));
                _dt.Columns.Add("GBScopeOfCover", typeof(string));
                _dt.Columns.Add("GBAreaOfCoverage", typeof(string));
                _dt.Columns.Add("GBPersonCovered", typeof(string));
                _dt.Columns.Add("GBAnnualBenefitsLimit", typeof(decimal));
                _dt.Columns.Add("GBIsPerClaimLimitIP", typeof(string));
                _dt.Columns.Add("GBPerClaimLimitIP", typeof(decimal));
                _dt.Columns.Add("GBIsPerClaimLimitOP", typeof(string));
                _dt.Columns.Add("GBPerClaimLimitOP", typeof(decimal));
                _dt.Columns.Add("GBPreExisting_ChronicLimit", typeof(decimal));
                _dt.Columns.Add("GBGeoThreateningEmergencyTreatment", typeof(string));
                _dt.Columns.Add("GBGeoElectiveTreatement", typeof(string));
                _dt.Columns.Add("GBGeoOutsideResidentCountry", typeof(string));

                _dt.Columns.Add("GBPremium", typeof(decimal));
                _dt.Columns.Add("GBInsuranceLevy", typeof(decimal));
                _dt.Columns.Add("GBPolicyFee", typeof(decimal));
                _dt.Columns.Add("GBTotalPremium", typeof(decimal));

                _dt.Columns.Add("IPHospitalizationClass", typeof(string));
                _dt.Columns.Add("IPHospitalizationClassLimit", typeof(decimal));
                _dt.Columns.Add("IPICUCoronaryTreatement", typeof(string));
                _dt.Columns.Add("IPICUCoronaryTreatementLimit", typeof(decimal));
                _dt.Columns.Add("IPVariousTherapies", typeof(string));
                _dt.Columns.Add("IPVariousTherapiesLimit", typeof(decimal));
                _dt.Columns.Add("IPOrganTransplantationServices", typeof(string));
                _dt.Columns.Add("IPOrganTransplantationServicesLimit", typeof(decimal));
                _dt.Columns.Add("IPAmbulanceServices", typeof(string));
                _dt.Columns.Add("IPAmbulanceServicesLimit", typeof(decimal));
                _dt.Columns.Add("IPCompanionRoomBoardExpenses", typeof(string));
                _dt.Columns.Add("IPCompanionRoomBoardExpensesLimit", typeof(decimal));
                _dt.Columns.Add("IPHospitalCashBenefitsCashPerDay", typeof(decimal));
                _dt.Columns.Add("IPHospitalCashBenefitsCashTotal", typeof(decimal));
                _dt.Columns.Add("IPRepatriationCostTraansport", typeof(decimal));
                _dt.Columns.Add("IPAddBenefits", typeof(string));
                _dt.Columns.Add("OPPhysicianConsultationDeductible", typeof(string));
                _dt.Columns.Add("OPPhysicianConsultationDeductibleLimit", typeof(decimal));
                _dt.Columns.Add("OPDiagnostics", typeof(string));
                _dt.Columns.Add("OPDiagnosticsLimit", typeof(decimal));
                _dt.Columns.Add("OPPharmaceuticals", typeof(string));
                _dt.Columns.Add("OPPharmaceuticalsLimit", typeof(decimal));
                _dt.Columns.Add("OPPhysiotheraphy", typeof(string));
                _dt.Columns.Add("OPPhysiotheraphyLimit", typeof(decimal));
                _dt.Columns.Add("OPDaycareTreatment", typeof(string));
                _dt.Columns.Add("OPDaycareTreatmentLimit", typeof(decimal));
                _dt.Columns.Add("OPOutPatientSurgery", typeof(string));
                _dt.Columns.Add("OPOutPatientSurgeryLimit", typeof(decimal));
                _dt.Columns.Add("OPWorkRelatedInjuries", typeof(string));
                _dt.Columns.Add("OPWorkRelatedInjuriesLimit", typeof(decimal));
                _dt.Columns.Add("OPAccidentalDamageNaturalTeeth", typeof(string));
                _dt.Columns.Add("OPAccidentalDamageNaturalTeethLimit", typeof(decimal));
                _dt.Columns.Add("OPNewBornBabyCoverage", typeof(string));
                _dt.Columns.Add("OPNewBornBabyCoverageLimit", typeof(decimal));
                _dt.Columns.Add("OPNursingAtHome", typeof(string));
                _dt.Columns.Add("OPNursingAtHomeLimit", typeof(decimal));
                _dt.Columns.Add("OPAlternativeMedicine", typeof(string));
                _dt.Columns.Add("OPAlternativeMedicineCoverage", typeof(string));
                _dt.Columns.Add("OPAlternativeMedicineCoverageLimit", typeof(decimal));
                _dt.Columns.Add("OPAlternativeMedicineDeductible", typeof(string));
                _dt.Columns.Add("OPAlternativeMedicineDeductibleLimit", typeof(decimal));
                _dt.Columns.Add("OPFreeAccessOutsideOMAN", typeof(string));
                _dt.Columns.Add("EBFreeAccessTPANetwork", typeof(string));
                _dt.Columns.Add("EBFreeAccessTPANetworkLimit", typeof(string));
                _dt.Columns.Add("EBReimbursementNonNetworkMedicalProviders", typeof(string));
                _dt.Columns.Add("EBReimbursementNonNetworkMedicalProvidersLimit", typeof(string));
                _dt.Columns.Add("EBEmergencyTreatment", typeof(string));
                _dt.Columns.Add("EBEmergencyTreatmentLimit", typeof(string));
                _dt.Columns.Add("EBEmergencyTreatmentCountry", typeof(string));
                _dt.Columns.Add("ABBenefits", typeof(string));
                _dt.Columns.Add("ABDescription", typeof(string));
                _dt.Columns.Add("ABExclusions", typeof(string));

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["QuotationId"] = _objQuotation.QuotationId.Equals(null) ? 0 : _objQuotation.QuotationId;
                _dr["DraftNo"] = _objQuotation.DraftNo ?? "";
                _dr["CIInsuranceCompanyName"] = _objQuotation.CIInsuranceCompanyName ?? "";
                _dr["CIClientCompanyName"] = _objQuotation.CIClientCompanyName ?? "";
                _dr["CIProducerType"] = _objQuotation.CIProducerType ?? "";
                _dr["CIProducerName"] = _objQuotation.CIProducerName ?? "";
                _dr["CISelectCommission"] = _objQuotation.CISelectCommission.Equals(null) ? 0 : _objQuotation.CISelectCommission;
                _dr["CINoOfPlanCategories"] = _objQuotation.CINoOfPlanCategories.Equals(null) ? 0 : _objQuotation.CINoOfPlanCategories;
                _dr["GBMedicalProviderNetwork"] = _objQuotation.GBMedicalProviderNetwork ?? "";
                _dr["GBScopeOfCover"] = _objQuotation.GBScopeOfCover ?? "";
                _dr["GBAreaOfCoverage"] = _objQuotation.GBAreaOfCoverage ?? "";
                _dr["GBPersonCovered"] = _objQuotation.GBPersonCovered ?? "";
                _dr["GBAnnualBenefitsLimit"] = _objQuotation.GBAnnualBenefitsLimit.Equals(null) ? 0 : _objQuotation.GBAnnualBenefitsLimit;
                _dr["GBIsPerClaimLimitIP"] = _objQuotation.GBIsPerClaimLimitIP ?? "";
                _dr["GBPerClaimLimitIP"] = _objQuotation.GBPerClaimLimitIP.Equals(null) ? 0 : _objQuotation.GBPerClaimLimitIP;
                _dr["GBIsPerClaimLimitOP"] = _objQuotation.GBIsPerClaimLimitOP ?? "";
                _dr["GBPerClaimLimitOP"] = _objQuotation.GBPerClaimLimitOP.Equals(null) ? 0 : _objQuotation.GBPerClaimLimitOP;
                _dr["GBPreExisting_ChronicLimit"] = _objQuotation.GBPreExisting_ChronicLimit.Equals(null) ? 0 : _objQuotation.GBPreExisting_ChronicLimit;
                _dr["GBGeoThreateningEmergencyTreatment"] = _objQuotation.GBGeoThreateningEmergencyTreatment ?? "";
                _dr["GBGeoElectiveTreatement"] = _objQuotation.GBGeoElectiveTreatement ?? "";
                _dr["GBGeoOutsideResidentCountry"] = _objQuotation.GBGeoOutsideResidentCountry ?? "";

                _dr["GBTotalPremium"] = _objQuotation.GBTotalPremium.Equals(null) ? 0 : _objQuotation.GBTotalPremium;
                _dr["GBPolicyFee"] = _objQuotation.GBPolicyFee.Equals(null) ? 0 : _objQuotation.GBPolicyFee;
                _dr["GBInsuranceLevy"] = _objQuotation.GBInsuranceLevy.Equals(null) ? 0 : _objQuotation.GBInsuranceLevy;
                _dr["GBPremium"] = _objQuotation.GBPremium.Equals(null) ? 0 : _objQuotation.GBPremium;

                _dr["IPHospitalizationClass"] = _objQuotation.IPHospitalizationClass ?? "";
                _dr["IPHospitalizationClassLimit"] = _objQuotation.IPHospitalizationClassLimit.Equals(null) ? 0 : _objQuotation.IPHospitalizationClassLimit;
                _dr["IPICUCoronaryTreatement"] = _objQuotation.IPICUCoronaryTreatement ?? "";
                _dr["IPICUCoronaryTreatementLimit"] = _objQuotation.IPICUCoronaryTreatementLimit.Equals(null) ? 0 : _objQuotation.IPICUCoronaryTreatementLimit;
                _dr["IPVariousTherapies"] = _objQuotation.IPVariousTherapies ?? "";
                _dr["IPVariousTherapiesLimit"] = _objQuotation.IPVariousTherapiesLimit.Equals(null) ? 0 : _objQuotation.IPVariousTherapiesLimit;
                _dr["IPOrganTransplantationServices"] = _objQuotation.IPOrganTransplantationServices ?? "";
                _dr["IPOrganTransplantationServicesLimit"] = _objQuotation.IPOrganTransplantationServicesLimit.Equals(null) ? 0 : _objQuotation.IPOrganTransplantationServicesLimit;
                _dr["IPAmbulanceServices"] = _objQuotation.IPAmbulanceServices ?? "";
                _dr["IPAmbulanceServicesLimit"] = _objQuotation.IPAmbulanceServicesLimit.Equals(null) ? 0 : _objQuotation.IPAmbulanceServicesLimit;
                _dr["IPCompanionRoomBoardExpenses"] = _objQuotation.IPCompanionRoomBoardExpenses ?? "";
                _dr["IPCompanionRoomBoardExpensesLimit"] = _objQuotation.IPCompanionRoomBoardExpensesLimit.Equals(null) ? 0 : _objQuotation.IPCompanionRoomBoardExpensesLimit;
                _dr["IPHospitalCashBenefitsCashPerDay"] = _objQuotation.IPHospitalCashBenefitsCashPerDay.Equals(null) ? 0 : _objQuotation.IPHospitalCashBenefitsCashPerDay;
                _dr["IPHospitalCashBenefitsCashTotal"] = _objQuotation.IPHospitalCashBenefitsCashTotal.Equals(null) ? 0 : _objQuotation.IPHospitalCashBenefitsCashTotal;
                _dr["IPRepatriationCostTraansport"] = _objQuotation.IPRepatriationCostTraansport.Equals(null) ? 0 : _objQuotation.IPRepatriationCostTraansport;
                _dr["IPAddBenefits"] = _objQuotation.IPAddBenefits ?? "";
                _dr["OPPhysicianConsultationDeductible"] = _objQuotation.OPPhysicianConsultationDeductible ?? "";
                _dr["OPPhysicianConsultationDeductibleLimit"] = _objQuotation.OPPhysicianConsultationDeductibleLimit.Equals(null) ? 0 : _objQuotation.OPPhysicianConsultationDeductibleLimit;
                _dr["OPDiagnostics"] = _objQuotation.OPDiagnostics ?? "";
                _dr["OPDiagnosticsLimit"] = _objQuotation.OPDiagnosticsLimit.Equals(null) ? 0 : _objQuotation.OPDiagnosticsLimit;
                _dr["OPPharmaceuticals"] = _objQuotation.OPPharmaceuticals ?? "";
                _dr["OPPharmaceuticalsLimit"] = _objQuotation.OPPharmaceuticalsLimit.Equals(null) ? 0 : _objQuotation.OPPharmaceuticalsLimit;
                _dr["OPPhysiotheraphy"] = _objQuotation.OPPhysiotheraphy ?? "";
                _dr["OPPhysiotheraphyLimit"] = _objQuotation.OPPhysiotheraphyLimit.Equals(null) ? 0 : _objQuotation.OPPhysiotheraphyLimit;
                _dr["OPDaycareTreatment"] = _objQuotation.OPDaycareTreatment ?? "";
                _dr["OPDaycareTreatmentLimit"] = _objQuotation.OPDaycareTreatmentLimit.Equals(null) ? 0 : _objQuotation.OPDaycareTreatmentLimit;
                _dr["OPOutPatientSurgery"] = _objQuotation.OPOutPatientSurgery ?? "";
                _dr["OPOutPatientSurgeryLimit"] = _objQuotation.OPOutPatientSurgeryLimit.Equals(null) ? 0 : _objQuotation.OPOutPatientSurgeryLimit;
                _dr["OPWorkRelatedInjuries"] = _objQuotation.OPWorkRelatedInjuries ?? "";
                _dr["OPWorkRelatedInjuriesLimit"] = _objQuotation.OPWorkRelatedInjuriesLimit.Equals(null) ? 0 : _objQuotation.OPWorkRelatedInjuriesLimit;
                _dr["OPAccidentalDamageNaturalTeeth"] = _objQuotation.OPAccidentalDamageNaturalTeeth ?? "";
                _dr["OPAccidentalDamageNaturalTeethLimit"] = _objQuotation.OPAccidentalDamageNaturalTeethLimit.Equals(null) ? 0 : _objQuotation.OPAccidentalDamageNaturalTeethLimit;
                _dr["OPNewBornBabyCoverage"] = _objQuotation.OPNewBornBabyCoverage ?? "";
                _dr["OPNewBornBabyCoverageLimit"] = _objQuotation.OPNewBornBabyCoverageLimit.Equals(null) ? 0 : _objQuotation.OPNewBornBabyCoverageLimit;
                _dr["OPNursingAtHome"] = _objQuotation.OPNursingAtHome ?? "";
                _dr["OPNursingAtHomeLimit"] = _objQuotation.OPNursingAtHomeLimit.Equals(null) ? 0 : _objQuotation.OPNursingAtHomeLimit;
                _dr["OPAlternativeMedicine"] = _objQuotation.OPAlternativeMedicine ?? "";
                _dr["OPAlternativeMedicineCoverage"] = _objQuotation.OPAlternativeMedicineCoverage ?? "";
                _dr["OPAlternativeMedicineCoverageLimit"] = _objQuotation.OPAlternativeMedicineCoverageLimit.Equals(null) ? 0 : _objQuotation.OPAlternativeMedicineCoverageLimit;
                _dr["OPAlternativeMedicineDeductible"] = _objQuotation.OPAlternativeMedicineDeductible ?? "";
                _dr["OPAlternativeMedicineDeductibleLimit"] = _objQuotation.OPAlternativeMedicineDeductibleLimit.Equals(null) ? 0 : _objQuotation.OPAlternativeMedicineDeductibleLimit;
                _dr["OPFreeAccessOutsideOMAN"] = _objQuotation.OPFreeAccessOutsideOMAN ?? "";
                _dr["EBFreeAccessTPANetwork"] = _objQuotation.EBFreeAccessTPANetwork ?? "";
                _dr["EBFreeAccessTPANetworkLimit"] = _objQuotation.EBFreeAccessTPANetworkLimit ?? "";
                _dr["EBReimbursementNonNetworkMedicalProviders"] = _objQuotation.EBReimbursementNonNetworkMedicalProviders ?? "";
                _dr["EBReimbursementNonNetworkMedicalProvidersLimit"] = _objQuotation.EBReimbursementNonNetworkMedicalProvidersLimit ?? "";
                _dr["EBEmergencyTreatment"] = _objQuotation.EBEmergencyTreatment ?? "";
                _dr["EBEmergencyTreatmentLimit"] = _objQuotation.EBEmergencyTreatmentLimit ?? "";
                _dr["EBEmergencyTreatmentCountry"] = _objQuotation.EBEmergencyTreatmentCountry ?? "";
                _dr["ABBenefits"] = _objQuotation.ABBenefits ?? "";
                _dr["ABDescription"] = _objQuotation.ABDescription ?? "";
                _dr["ABExclusions"] = _objQuotation.ABExclusions ?? "";
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ConvertToEmployeeMasterGenerator(EmployeeMaster _obj)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("EmployeeId", typeof(long));
                _dt.Columns.Add("EmployeeName", typeof(string));
                _dt.Columns.Add("EmployeeUniqueNumber", typeof(string));
                _dt.Columns.Add("Relation", typeof(string));
                _dt.Columns.Add("Nationality", typeof(string));

                _dt.Columns.Add("Category", typeof(string));
                _dt.Columns.Add("DOB", typeof(DateTime));
                _dt.Columns.Add("Age", typeof(int));
                _dt.Columns.Add("Salary", typeof(decimal));
                _dt.Columns.Add("EAW", typeof(decimal));

                _dt.Columns.Add("SumAssured", typeof(decimal));
                _dt.Columns.Add("EffectiveDate", typeof(DateTime));
                _dt.Columns.Add("Remarks", typeof(string));
                _dt.Columns.Add("EntryType", typeof(string));
             

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["EmployeeId"] = _obj.EmployeeId.Equals(null) ? 0 : _obj.EmployeeId;
                _dr["EmployeeName"] = _obj.EmployeeName ?? "";
                _dr["EmployeeUniqueNumber"] = _obj.EmployeeUniqueNumber ?? "";
                _dr["Relation"] = _obj.Relation ?? "";
                _dr["Nationality"] = _obj.Nationality ?? "";

                _dr["Category"] = _obj.Category ?? "";
                _dr["DOB"] = _obj.DOB.Equals(null) ? DateTime.Now : _obj.DOB;
                _dr["Age"] = _obj.Age.Equals(null) ? 0 : _obj.Age;
                _dr["Salary"] = _obj.Salary.Equals(null) ? 0 : _obj.Salary;
                _dr["EAW"] = _obj.EAW.Equals(null) ? 0 : _obj.EAW;
              
                _dr["SumAssured"] = _obj.SumAssured.Equals(null) ? 0 : _obj.SumAssured;
                _dr["EffectiveDate"] = _obj.EffectiveDate.Equals(null) ? DateTime.Now : _obj.EffectiveDate;

                _dr["Remarks"] = _obj.Remarks ?? "";
                _dr["EntryType"] = _obj.EntryType ?? "";
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable ConvertToInsCompany(InsuranceCompany _objRegisterClient)
        {
            try
            {
                DataTable _dt = new DataTable();
                _dt.Columns.Add("CompanyName", typeof(string));
                _dt.Columns.Add("PolicyNumber", typeof(string));
                _dt.Columns.Add("CompanyAddress", typeof(string));
                _dt.Columns.Add("City", typeof(string));
                _dt.Columns.Add("StateName", typeof(string));
                _dt.Columns.Add("ZipCode", typeof(long));
                _dt.Columns.Add("ContactPerson", typeof(string));
                _dt.Columns.Add("MobileNumber", typeof(string));
                _dt.Columns.Add("EmailId", typeof(string));
                _dt.Columns.Add("Currency", typeof(string));
                _dt.Columns.Add("Broker", typeof(string));
                _dt.Columns.Add("Reinsurer", typeof(string));

                DataRow _dr;

                _dr = _dt.NewRow();
                _dr["CompanyName"] = _objRegisterClient.ClientName;
                _dr["PolicyNumber"] = _objRegisterClient.PolicyNumber;
                _dr["CompanyAddress"] = _objRegisterClient.Address;
                _dr["City"] = _objRegisterClient.City;
                _dr["StateName"] = _objRegisterClient.StateName;
                _dr["ZipCode"] = _objRegisterClient.ZipCode;
                _dr["ContactPerson"] = _objRegisterClient.ContactPerson;
                _dr["MobileNumber"] = _objRegisterClient.MobileNumber;
                _dr["EmailId"] = _objRegisterClient.EmailId;
                _dr["Currency"] = _objRegisterClient.Currency;
                _dr["Broker"] = _objRegisterClient.Broker;
                _dr["Reinsurer"] = _objRegisterClient.Reinsurer;
                _dt.Rows.Add(_dr);

                return _dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
