USE [Totalligent]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_InsCompanyRegister]    Script Date: 08-01-2021 17:49:01 ******/
CREATE TYPE [dbo].[UDT_InsCompanyRegister] AS TABLE(
	[CompanyName] [nvarchar](150) NULL,
	[PolicyNumber] [nvarchar](50) NOT NULL,
	[CompanyAddress] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[StateName] [nvarchar](100) NULL,
	[ZipCode] [bigint] NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[MobileNumber] [bigint] NULL,
	[EmailId] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[Broker] [nvarchar](75) NULL,
	[Reinsurer] [nvarchar](150) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_ProducerMaster]    Script Date: 08-01-2021 17:49:01 ******/
CREATE TYPE [dbo].[UDT_ProducerMaster] AS TABLE(
	[MasterType] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[EmailId] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_Quotation]    Script Date: 08-01-2021 17:49:01 ******/
CREATE TYPE [dbo].[UDT_Quotation] AS TABLE(
	[QuotationId] [bigint] NULL,
	[DraftNo] [nvarchar](100) NULL,
	[CIInsuranceCompanyName] [nvarchar](100) NULL,
	[CIClientCompanyName] [nvarchar](100) NULL,
	[CIProducerType] [nvarchar](100) NULL,
	[CIProducerName] [nvarchar](100) NULL,
	[CISelectCommission] [decimal](18, 2) NULL,
	[CINoOfPlanCategories] [int] NULL,
	[GBMedicalProviderNetwork] [nvarchar](100) NULL,
	[GBScopeOfCover] [nvarchar](100) NULL,
	[GBAreaOfCoverage] [nvarchar](100) NULL,
	[GBPersonCovered] [nvarchar](100) NULL,
	[GBAnnualBenefitsLimit] [decimal](18, 2) NULL,
	[GBIsPerClaimLimitIP] [nvarchar](10) NULL,
	[GBPerClaimLimitIP] [decimal](18, 2) NULL,
	[GBIsPerClaimLimitOP] [nvarchar](10) NULL,
	[GBPerClaimLimitOP] [decimal](18, 2) NULL,
	[GBPreExisting_ChronicLimit] [decimal](18, 2) NULL,
	[GBGeoThreateningEmergencyTreatment] [nvarchar](100) NULL,
	[GBGeoElectiveTreatement] [nvarchar](100) NULL,
	[GBGeoOutsideResidentCountry] [nvarchar](100) NULL,
	[IPHospitalizationClass] [nvarchar](100) NULL,
	[IPHospitalizationClassLimit] [decimal](18, 2) NULL,
	[IPICUCoronaryTreatement] [nvarchar](50) NULL,
	[IPICUCoronaryTreatementLimit] [decimal](18, 2) NULL,
	[IPVariousTherapies] [nvarchar](50) NULL,
	[IPVariousTherapiesLimit] [decimal](18, 2) NULL,
	[IPOrganTransplantationServices] [nvarchar](50) NULL,
	[IPOrganTransplantationServicesLimit] [decimal](18, 2) NULL,
	[IPAmbulanceServices] [nvarchar](50) NULL,
	[IPAmbulanceServicesLimit] [decimal](18, 2) NULL,
	[IPCompanionRoomBoardExpenses] [nvarchar](50) NULL,
	[IPCompanionRoomBoardExpensesLimit] [decimal](18, 2) NULL,
	[IPHospitalCashBenefitsCashPerDay] [decimal](18, 2) NULL,
	[IPHospitalCashBenefitsCashTotal] [decimal](18, 2) NULL,
	[IPRepatriationCostTraansport] [decimal](18, 2) NULL,
	[IPAddBenefits] [nvarchar](100) NULL,
	[OPPhysicianConsultationDeductible] [nvarchar](50) NULL,
	[OPPhysicianConsultationDeductibleLimit] [decimal](18, 2) NULL,
	[OPDiagnostics] [nvarchar](50) NULL,
	[OPDiagnosticsLimit] [decimal](18, 2) NULL,
	[OPPharmaceuticals] [nvarchar](50) NULL,
	[OPPharmaceuticalsLimit] [decimal](18, 2) NULL,
	[OPPhysiotheraphy] [nvarchar](50) NULL,
	[OPPhysiotheraphyLimit] [decimal](18, 2) NULL,
	[OPDaycareTreatment] [nvarchar](50) NULL,
	[OPDaycareTreatmentLimit] [decimal](18, 2) NULL,
	[OPOutPatientSurgery] [nvarchar](50) NULL,
	[OPOutPatientSurgeryLimit] [decimal](18, 2) NULL,
	[OPWorkRelatedInjuries] [nvarchar](50) NULL,
	[OPWorkRelatedInjuriesLimit] [decimal](18, 2) NULL,
	[OPAccidentalDamageNaturalTeeth] [nvarchar](50) NULL,
	[OPAccidentalDamageNaturalTeethLimit] [decimal](18, 2) NULL,
	[OPNewBornBabyCoverage] [nvarchar](50) NULL,
	[OPNewBornBabyCoverageLimit] [decimal](18, 2) NULL,
	[OPNursingAtHome] [nvarchar](50) NULL,
	[OPNursingAtHomeLimit] [decimal](18, 2) NULL,
	[OPAlternativeMedicine] [nvarchar](80) NULL,
	[OPAlternativeMedicineCoverage] [nvarchar](50) NULL,
	[OPAlternativeMedicineCoverageLimit] [decimal](18, 2) NULL,
	[OPAlternativeMedicineDeductible] [nvarchar](50) NULL,
	[OPAlternativeMedicineDeductibleLimit] [decimal](18, 2) NULL,
	[OPFreeAccessOutsideOMAN] [nvarchar](100) NULL,
	[EBFreeAccessTPANetwork] [nvarchar](100) NULL,
	[EBFreeAccessTPANetworkLimit] [nvarchar](100) NULL,
	[EBReimbursementNonNetworkMedicalProviders] [nvarchar](100) NULL,
	[EBReimbursementNonNetworkMedicalProvidersLimit] [nvarchar](100) NULL,
	[EBEmergencyTreatment] [nvarchar](100) NULL,
	[EBEmergencyTreatmentLimit] [nvarchar](100) NULL,
	[EBEmergencyTreatmentCountry] [nvarchar](100) NULL,
	[ABBenefits] [nvarchar](500) NULL,
	[ABDescription] [nvarchar](500) NULL,
	[ABExclusions] [nvarchar](max) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_RegisterClient]    Script Date: 08-01-2021 17:49:01 ******/
CREATE TYPE [dbo].[UDT_RegisterClient] AS TABLE(
	[ClientName] [nvarchar](150) NULL,
	[PolicyNumber] [nvarchar](50) NOT NULL,
	[CompanyAddress] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[StateName] [nvarchar](100) NULL,
	[ZipCode] [bigint] NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[MobileNumber] [bigint] NULL,
	[EmailId] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[Broker] [nvarchar](75) NULL,
	[Reinsurer] [nvarchar](150) NULL
)
GO
/****** Object:  Table [dbo].[TB_AgentMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_AgentMaster](
	[AgentId] [bigint] IDENTITY(1,1) NOT NULL,
	[AgentName] [nvarchar](40) NULL,
	[AgentCode]  AS ('AG'+right('0000'+CONVERT([varchar](8),[AgentId]),(8))) PERSISTED,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](20) NULL,
	[Zipcode] [nvarchar](10) NULL,
	[ContactPerson] [nvarchar](40) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](40) NULL,
	[UpdatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_BrokerMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_BrokerMaster](
	[BrokerId] [bigint] IDENTITY(1,1) NOT NULL,
	[BrokerCode]  AS ('BR'+right('0000'+CONVERT([varchar](8),[BrokerId]),(8))) PERSISTED,
	[BrokerName] [nvarchar](40) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](20) NULL,
	[Zipcode] [nvarchar](10) NULL,
	[ContactPerson] [nvarchar](40) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](40) NULL,
	[UpdatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_CategoryMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_CategoryMaster](
	[CategoryId] [bigint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](40) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](20) NULL,
	[Zipcode] [nvarchar](10) NULL,
	[ContactPerson] [nvarchar](40) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](50) NULL,
	[AddedOn] [datetime] NULL,
	[AddedBy] [nvarchar](40) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ClientCompanyMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ClientCompanyMaster](
	[ClientComId] [int] IDENTITY(1,1) NOT NULL,
	[ClientCompCode]  AS ('CL'+right('0000'+CONVERT([varchar](8),[ClientComId]),(8))) PERSISTED,
	[ClientCompanyName] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Zipcode] [bigint] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](30) NULL,
	[Currency] [nvarchar](10) NULL,
	[Provider] [nvarchar](50) NULL,
	[ProviderCommission] [nvarchar](10) NULL,
	[ReInsurer] [nvarchar](50) NULL,
	[ReInsurerRate] [nvarchar](30) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_DiagnosticsMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DiagnosticsMaster](
	[DiagnosticsId] [int] IDENTITY(1,1) NOT NULL,
	[DiagnosticsCode] [nvarchar](50) NOT NULL,
	[DiagnosticsName] [nvarchar](100) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_DrugMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_DrugMaster](
	[DrugId] [int] IDENTITY(1,1) NOT NULL,
	[DrugCode] [nvarchar](50) NOT NULL,
	[DrugName] [nvarchar](100) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Employee]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](75) NULL,
	[UserEmployeeNo] [nvarchar](50) NULL,
	[UserTypeId] [int] NULL,
	[RoleId] [int] NULL,
	[ReportingManager] [nvarchar](50) NULL,
	[EmailId] [nvarchar](70) NULL,
	[MobileNumber] [nvarchar](25) NULL,
	[AddedOn] [datetime] NULL,
	[AddedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_HospitalMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_HospitalMaster](
	[HospitalId] [int] IDENTITY(1,1) NOT NULL,
	[HospitalName] [nvarchar](100) NULL,
	[HospitalCode]  AS ('HO'+right('0000'+CONVERT([varchar](8),[HospitalId]),(8))) PERSISTED,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Zipcode] [bigint] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](30) NULL,
	[Band] [nvarchar](15) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_InsuranceCompanyMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_InsuranceCompanyMaster](
	[ICMId] [int] IDENTITY(1,1) NOT NULL,
	[InsurancecompanyName] [nvarchar](100) NULL,
	[InsCompCode]  AS ('IN'+right('0000'+CONVERT([varchar](8),[ICMId]),(8))) PERSISTED,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Zipcode] [bigint] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](30) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ICMId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_LabMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_LabMaster](
	[LabId] [int] IDENTITY(1,1) NOT NULL,
	[LabCode]  AS ('LB'+right('0000'+CONVERT([varchar](8),[LabId]),(8))) PERSISTED,
	[LabName] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](20) NULL,
	[State] [nvarchar](20) NULL,
	[Zipcode] [bigint] NULL,
	[ContactPerson] [nvarchar](50) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](30) NULL,
	[CreatedBy] [nvarchar](20) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedBy] [nvarchar](20) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Login]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Login](
	[LoginId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserName] [nvarchar](25) NULL,
	[Password] [nvarchar](25) NULL,
	[CreatedAt] [datetime] NULL,
	[IsPasswordChanged] [nvarchar](5) NULL,
	[AddedBy] [nvarchar](50) NULL,
	[UpdatedBy] [nvarchar](25) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ProducerMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ProducerMaster](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[MasterType] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[UserName] [nvarchar](100) NULL,
	[Password] [nvarchar](100) NULL,
	[EmailId] [nvarchar](100) NULL,
	[AddedOn] [datetime] NULL,
	[AddedBy] [nvarchar](100) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[EntryType] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Quotation]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Quotation](
	[QuotationId] [bigint] IDENTITY(1,1) NOT NULL,
	[DraftNo] [nvarchar](100) NULL,
	[Status] [nvarchar](20) NULL,
	[CIInsuranceCompanyName] [nvarchar](100) NULL,
	[CIClientCompanyName] [nvarchar](100) NULL,
	[CIProducerType] [nvarchar](100) NULL,
	[CIProducerName] [nvarchar](100) NULL,
	[CISelectCommission] [decimal](18, 2) NULL,
	[CINoOfPlanCategories] [int] NULL,
	[GBMedicalProviderNetwork] [nvarchar](100) NULL,
	[GBScopeOfCover] [nvarchar](100) NULL,
	[GBAreaOfCoverage] [nvarchar](100) NULL,
	[GBPersonCovered] [nvarchar](100) NULL,
	[GBAnnualBenefitsLimit] [decimal](18, 2) NULL,
	[GBIsPerClaimLimitIP] [nvarchar](10) NULL,
	[GBPerClaimLimitIP] [decimal](18, 2) NULL,
	[GBIsPerClaimLimitOP] [nvarchar](10) NULL,
	[GBPerClaimLimitOP] [decimal](18, 2) NULL,
	[GBPreExisting_ChronicLimit] [decimal](18, 2) NULL,
	[GBGeoThreateningEmergencyTreatment] [nvarchar](100) NULL,
	[GBGeoElectiveTreatement] [nvarchar](100) NULL,
	[GBGeoOutsideResidentCountry] [nvarchar](100) NULL,
	[IPHospitalizationClass] [nvarchar](100) NULL,
	[IPHospitalizationClassLimit] [decimal](18, 2) NULL,
	[IPICUCoronaryTreatement] [nvarchar](50) NULL,
	[IPICUCoronaryTreatementLimit] [decimal](18, 2) NULL,
	[IPVariousTherapies] [nvarchar](50) NULL,
	[IPVariousTherapiesLimit] [decimal](18, 2) NULL,
	[IPOrganTransplantationServices] [nvarchar](50) NULL,
	[IPOrganTransplantationServicesLimit] [decimal](18, 2) NULL,
	[IPAmbulanceServices] [nvarchar](50) NULL,
	[IPAmbulanceServicesLimit] [decimal](18, 2) NULL,
	[IPCompanionRoomBoardExpenses] [nvarchar](50) NULL,
	[IPCompanionRoomBoardExpensesLimit] [decimal](18, 2) NULL,
	[IPHospitalCashBenefitsCashPerDay] [decimal](18, 2) NULL,
	[IPHospitalCashBenefitsCashTotal] [decimal](18, 2) NULL,
	[IPRepatriationCostTraansport] [decimal](18, 2) NULL,
	[IPAddBenefits] [nvarchar](100) NULL,
	[OPPhysicianConsultationDeductible] [nvarchar](50) NULL,
	[OPPhysicianConsultationDeductibleLimit] [decimal](18, 2) NULL,
	[OPDiagnostics] [nvarchar](50) NULL,
	[OPDiagnosticsLimit] [decimal](18, 2) NULL,
	[OPPharmaceuticals] [nvarchar](50) NULL,
	[OPPharmaceuticalsLimit] [decimal](18, 2) NULL,
	[OPPhysiotheraphy] [nvarchar](50) NULL,
	[OPPhysiotheraphyLimit] [decimal](18, 2) NULL,
	[OPDaycareTreatment] [nvarchar](50) NULL,
	[OPDaycareTreatmentLimit] [decimal](18, 2) NULL,
	[OPOutPatientSurgery] [nvarchar](50) NULL,
	[OPOutPatientSurgeryLimit] [decimal](18, 2) NULL,
	[OPWorkRelatedInjuries] [nvarchar](50) NULL,
	[OPWorkRelatedInjuriesLimit] [decimal](18, 2) NULL,
	[OPAccidentalDamageNaturalTeeth] [nvarchar](50) NULL,
	[OPAccidentalDamageNaturalTeethLimit] [decimal](18, 2) NULL,
	[OPNewBornBabyCoverage] [nvarchar](50) NULL,
	[OPNewBornBabyCoverageLimit] [decimal](18, 2) NULL,
	[OPNursingAtHome] [nvarchar](50) NULL,
	[OPNursingAtHomeLimit] [decimal](18, 2) NULL,
	[OPAlternativeMedicine] [nvarchar](80) NULL,
	[OPAlternativeMedicineCoverage] [nvarchar](50) NULL,
	[OPAlternativeMedicineCoverageLimit] [decimal](18, 2) NULL,
	[OPAlternativeMedicineDeductible] [nvarchar](50) NULL,
	[OPAlternativeMedicineDeductibleLimit] [decimal](18, 2) NULL,
	[OPFreeAccessOutsideOMAN] [nvarchar](100) NULL,
	[EBFreeAccessTPANetwork] [nvarchar](100) NULL,
	[EBFreeAccessTPANetworkLimit] [nvarchar](100) NULL,
	[EBReimbursementNonNetworkMedicalProviders] [nvarchar](100) NULL,
	[EBReimbursementNonNetworkMedicalProvidersLimit] [nvarchar](100) NULL,
	[EBEmergencyTreatment] [nvarchar](100) NULL,
	[EBEmergencyTreatmentLimit] [nvarchar](100) NULL,
	[EBEmergencyTreatmentCountry] [nvarchar](100) NULL,
	[ABBenefits] [nvarchar](500) NULL,
	[ABDescription] [nvarchar](500) NULL,
	[ABExclusions] [nvarchar](max) NULL,
	[AddedBy] [nvarchar](100) NULL,
	[AddedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](100) NULL,
	[UpdatedAt] [datetime] NULL,
	[PolicyNo] [nvarchar](80) NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RegisterClient]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RegisterClient](
	[ClientId] [int] IDENTITY(1,1) NOT NULL,
	[PolicyNumber] [nvarchar](50) NOT NULL,
	[ClientName] [nvarchar](150) NULL,
	[CompanyName] [nvarchar](100) NULL,
	[CompanyAddress] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[StateName] [nvarchar](100) NULL,
	[ZipCode] [bigint] NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[MobileNumber] [bigint] NULL,
	[EmailId] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[Broker] [nvarchar](75) NULL,
	[Reinsurer] [nvarchar](150) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RegisterCompany]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RegisterCompany](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[StateName] [nvarchar](100) NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[MobileNumber] [bigint] NULL,
	[EmailId] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RegisterInsCompany]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_RegisterInsCompany](
	[InsCompanyId] [int] IDENTITY(1,1) NOT NULL,
	[PolicyNumber] [nvarchar](50) NOT NULL,
	[CompanyName] [nvarchar](100) NULL,
	[CompanyAddress] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[StateName] [nvarchar](100) NULL,
	[ZipCode] [bigint] NULL,
	[ContactPerson] [nvarchar](100) NULL,
	[MobileNumber] [bigint] NULL,
	[EmailId] [nvarchar](100) NULL,
	[Currency] [nvarchar](10) NULL,
	[Broker] [nvarchar](75) NULL,
	[Reinsurer] [nvarchar](150) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_ReInsurerMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_ReInsurerMaster](
	[ReInsurerId] [bigint] IDENTITY(1,1) NOT NULL,
	[ReInsurerName] [nvarchar](40) NULL,
	[ReInsurerCode] [nvarchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[City] [nvarchar](20) NULL,
	[Zipcode] [nvarchar](10) NULL,
	[ContactPerson] [nvarchar](40) NULL,
	[MobileNumber] [nvarchar](20) NULL,
	[EmailId] [nvarchar](50) NULL,
	[AddedOn] [datetime] NULL,
	[AddedBy] [nvarchar](40) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Role]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Tickets]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Tickets](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[RaisedBy] [nvarchar](75) NULL,
	[Description] [nvarchar](500) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[Flag] [int] NULL,
	[UpdatedBy] [nvarchar](25) NULL,
	[UpdatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_UserTypeMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_UserTypeMaster](
	[UserTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Designation] [nvarchar](70) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TB_AgentMaster] ON 
GO
INSERT [dbo].[TB_AgentMaster] ([AgentId], [AgentName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (1, N'AON Majan', N'Siruseri', N'Chennai', N'600021', N'Mr.Sharma', N'9578544470', N'prasadkec@yahoo.com', CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL, CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL)
GO
INSERT [dbo].[TB_AgentMaster] ([AgentId], [AgentName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (2, N'Modern Gulf Insurance Services', N'Taramani', N'Chennai', N'600021', N'Mr.Arun', N'9578544471', N'arun@yahoo.com', CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL, CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL)
GO
INSERT [dbo].[TB_AgentMaster] ([AgentId], [AgentName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (3, N'Nizwa Window', N'Anna Salai', N'Chennai', N'600214', N'Mr.Tharun', N'9574455471', N'tharun@yahoo.com', CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL, CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL)
GO
INSERT [dbo].[TB_AgentMaster] ([AgentId], [AgentName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (4, N'United Finance Company', N'Guindy', N'Chennai', N'602214', N'Mr.nithin', N'9574454455', N'Nithi@yahoo.com', CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL, CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL)
GO
INSERT [dbo].[TB_AgentMaster] ([AgentId], [AgentName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (5, N'FASTERZ', N'Anna Salai', N'Chennai', N'602215', N'Mr.Aadhithya', N'9574454457', N'Aathi@yahooo.com', CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL, CAST(N'2020-06-23T11:15:42.293' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_AgentMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_BrokerMaster] ON 
GO
INSERT [dbo].[TB_BrokerMaster] ([BrokerId], [BrokerName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (1, N'Risk Management Serives', N'Siruseri', N'India', N'600021', N'Mr.Sharma', N'9578544470', N'prasadkec@yahoo.com', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_BrokerMaster] ([BrokerId], [BrokerName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (2, N'Howden Insurance', N'Taramani', N'India', N'600021', N'Mr.Arun', N'9578544471', N'arun@yahoo.com', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_BrokerMaster] ([BrokerId], [BrokerName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (3, N'ACE Broker', N'Anna Salai', N'India', N'600214', N'Mr.Tharun', N'9574455471', N'tharun@yahoo.com', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_BrokerMaster] ([BrokerId], [BrokerName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (4, N'DOT International', N'Guindy', N'India', N'602214', N'Mr.nithin', N'9574454455', N'Nithi@yahoo.com', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_BrokerMaster] ([BrokerId], [BrokerName], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (5, N'Oman Insurance Service Bureau', N'Anna Salai', N'India', N'602215', N'Mr.Aadhithya', N'9574454457', N'Aathi@yahooo.com', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin', CAST(N'2020-06-22T17:01:46.547' AS DateTime), N'Admin')
GO
SET IDENTITY_INSERT [dbo].[TB_BrokerMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_CategoryMaster] ON 
GO
INSERT [dbo].[TB_CategoryMaster] ([CategoryId], [Description], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1, N'Band A', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_CategoryMaster] ([CategoryId], [Description], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (2, N'Band B', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.307' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.307' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_CategoryMaster] ([CategoryId], [Description], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (3, N'Band C', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.307' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.307' AS DateTime), N'Admin')
GO
SET IDENTITY_INSERT [dbo].[TB_CategoryMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_ClientCompanyMaster] ON 
GO
INSERT [dbo].[TB_ClientCompanyMaster] ([ClientComId], [ClientCompanyName], [Address], [City], [State], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Provider], [ProviderCommission], [ReInsurer], [ReInsurerRate], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (3, N'ADHIOMAN', N'OMAN', NULL, NULL, NULL, N'Jeeva', N'9094317112', N'jeeva_sph@gmail.com', N'OMAN', NULL, NULL, NULL, NULL, NULL, CAST(N'2021-01-08T16:04:07.870' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[TB_ClientCompanyMaster] ([ClientComId], [ClientCompanyName], [Address], [City], [State], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Provider], [ProviderCommission], [ReInsurer], [ReInsurerRate], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (4, N'Cognizant', N'chennai', NULL, NULL, NULL, N'sathish', N'9840359280', N'sathishhn2005@yahoo.co.in', N'OMAN', NULL, NULL, NULL, NULL, NULL, CAST(N'2021-01-08T16:48:17.233' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_ClientCompanyMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Employee] ON 
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1, N'arunTotalligent', N'arun', 2, 2, N'Ranganathan', N'murali@totalligent.com', N'9840359280', CAST(N'2020-03-15T12:27:55.913' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (2, N'Jeevarathanam', N'jEEVA', 3, 3, N'Ranganathan', N'sathishhn2005@gmail.com', N'9840359280', CAST(N'2020-03-15T12:44:56.133' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (3, N'MathuKumar K', N'120', 2, 2, N'Abitha Velu', N'satishjpr89@gmail.com', N'9748547585', CAST(N'2020-03-16T08:28:32.020' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (4, N'Raja', N'124', 3, 2, N'MuraliSwami', N'muraliii@gmail.com', N'9748547585', CAST(N'2020-03-16T08:49:37.870' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1004, N'Aniruth', N'102', 2, 2, N'Jeeva', N'murali@totalligent.com', N'9578577705', CAST(N'2020-06-16T17:21:54.430' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1005, N'Ilaiyaraja', N'1222', 3, 3, N'Ranga', N'ilayaraja@totalligent.com', N'97745585542', CAST(N'2020-06-16T17:38:54.523' AS DateTime), N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Employee] ([EmployeeId], [UserName], [UserEmployeeNo], [UserTypeId], [RoleId], [ReportingManager], [EmailId], [MobileNumber], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1006, N'sathish', N'152', 1, 2, N'Muralidharan M', N'mathishun33@gmail.com', N'98403592804', CAST(N'2020-06-20T18:40:20.803' AS DateTime), N'Admin', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_InsuranceCompanyMaster] ON 
GO
INSERT [dbo].[TB_InsuranceCompanyMaster] ([ICMId], [InsurancecompanyName], [Address], [City], [State], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (1, N'ICICI Lambard', NULL, NULL, NULL, NULL, N'Sathish', N'9840359280', N'sathishhn2005@gmail.com', NULL, CAST(N'2021-01-05T21:37:25.550' AS DateTime), NULL, CAST(N'2021-01-05T21:37:25.550' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[TB_InsuranceCompanyMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Login] ON 
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1, 1, N'sa', N's', CAST(N'2020-03-15T12:18:07.723' AS DateTime), N'Y', NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (2, 2, N'arunTotalligent', N'sathish', CAST(N'2020-03-15T12:27:55.920' AS DateTime), N'Y', NULL, N'Admin', CAST(N'2020-06-15T14:21:21.640' AS DateTime))
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (3, 3, N'Jeevarathanam', N'satishmca', CAST(N'2020-03-15T12:44:56.140' AS DateTime), N'Y', NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (4, 2, N'MathuKumar K', N'TWF0aA==', CAST(N'2020-03-16T08:28:32.020' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (5, 2, N'Raja', N'UmFqYQ==', CAST(N'2020-03-16T08:49:37.877' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1004, 1, N'Totlli287049', N'VG90bGxpMjg=', CAST(N'2020-04-17T11:39:38.587' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1005, 1, N'Admin', N'Satishmca@1', NULL, N'Y', NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1007, 2, N'Aniruth', N'QW5pcg==', CAST(N'2020-06-16T17:21:54.440' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1008, 3, N'Ilaiyaraja', N'Satishmca@1', CAST(N'2020-06-16T17:38:54.530' AS DateTime), N'Y', NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1009, 2, N'sathish', N'c2F0aA==', CAST(N'2020-06-20T18:40:20.813' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1010, 1, N'Ba85585', N'QmE4NTU4NQ==', CAST(N'2020-12-28T15:01:28.630' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1011, 1, N'A00125', N'QTAwMTI1', CAST(N'2020-12-28T15:49:36.033' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1020, 1, N'AG00001', N'c2F0aGlza', CAST(N'2021-01-08T12:34:42.300' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1022, 0, N'CL00001', N'amVldmFfc', CAST(N'2021-01-08T16:04:07.870' AS DateTime), NULL, N'Admin', NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1021, 1, N'BA00001', N'aWxheWFyY', CAST(N'2021-01-08T12:52:28.770' AS DateTime), NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Login] ([LoginId], [RoleId], [UserName], [Password], [CreatedAt], [IsPasswordChanged], [AddedBy], [UpdatedBy], [UpdatedAt]) VALUES (1023, 0, N'CL00003', N'c2F0aGlza', CAST(N'2021-01-08T16:48:17.233' AS DateTime), NULL, N'Admin', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_Login] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_ProducerMaster] ON 
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (1, N'Broker', N'Modern Gulf Insurance Services', N'BA00001', N'bXVyYWxpQ', N'murali@totalligent.com', CAST(N'2021-01-08T16:40:56.827' AS DateTime), N'sa', NULL, NULL, N'Data Entry')
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (2, N'Agent', N'AON Majan', N'AG00001', N'aWxheWFyY', N'ilayaraja@totalligent.com', CAST(N'2021-01-08T16:41:28.877' AS DateTime), N'sa', NULL, NULL, N'Data Entry')
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (3, N'Agent', N'AON Majan', N'AG00003', N'sa', N'ilayaraja@totalligent.com', CAST(N'2021-01-08T16:42:24.140' AS DateTime), N'sa', NULL, NULL, N'Bulk Upload')
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (4, N'Agent', N'FASTERZ', N'AG00004', N'sa', N'jeeva_sph@gmail.com', CAST(N'2021-01-08T16:42:24.140' AS DateTime), N'sa', NULL, NULL, N'Bulk Upload')
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (5, N'Branches', N'Nizwa Window', N'BR00001', N'sa', N'sathishhn2005@gmail.com', CAST(N'2021-01-08T16:42:24.140' AS DateTime), N'sa', NULL, NULL, N'Bulk Upload')
GO
INSERT [dbo].[TB_ProducerMaster] ([Id], [MasterType], [Name], [UserName], [Password], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy], [EntryType]) VALUES (6, N'DirectSales', N'United Finance Company', N'SA00001', N'sa', N'satishjpr89@gmail.com', CAST(N'2021-01-08T16:42:24.140' AS DateTime), N'sa', NULL, NULL, N'Bulk Upload')
GO
SET IDENTITY_INSERT [dbo].[TB_ProducerMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Quotation] ON 
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (1, N'004/01/21/3101/4', N'Pending', N'ICICI Lombard', N'CTS', N'2', N'1', CAST(0.00 AS Decimal(18, 2)), 1, N'BAND - A', N'on', N'England', N'on', CAST(10000.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'>> Select Region', N'>> Select Region', N'', N'Limit Per Day', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(101.00 AS Decimal(18, 2)), N'Covered in Full', CAST(103.00 AS Decimal(18, 2)), N'Covered in Full', CAST(104.00 AS Decimal(18, 2)), N'Limit Per Trip', CAST(105.00 AS Decimal(18, 2)), N'Covered in Full', CAST(105.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(252.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'benefits', N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(201.00 AS Decimal(18, 2)), N'Covered in Full', CAST(202.00 AS Decimal(18, 2)), N'Covered in Full', CAST(203.00 AS Decimal(18, 2)), N'Limit', CAST(204.00 AS Decimal(18, 2)), N'Limit', CAST(205.00 AS Decimal(18, 2)), N'Limit Per Baby', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(207.00 AS Decimal(18, 2)), N'Chiropractic', N'Pool Limit Per Policy', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2.00 AS Decimal(18, 2)), N'kuwait', N'Covered in Full', N'Hospital', N'Within the Resident Country', N'kuwait', N'Worldwide', N'Free Access', N'kuwait', N'benefits', N'Description', N'Exclusions ', NULL, CAST(N'2021-01-05T20:45:40.230' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (2, N'004/01/21/3101/4', N'Pending', N'HDFC', N'TCS', N'2', N'1', CAST(0.00 AS Decimal(18, 2)), 1, N'BAND - A', N'on', N'England', N'on', CAST(10000.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'>> Select Region', N'>> Select Region', N'', N'Limit Per Day', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(101.00 AS Decimal(18, 2)), N'Covered in Full', CAST(103.00 AS Decimal(18, 2)), N'Covered in Full', CAST(104.00 AS Decimal(18, 2)), N'Limit Per Trip', CAST(105.00 AS Decimal(18, 2)), N'Covered in Full', CAST(105.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), CAST(252.00 AS Decimal(18, 2)), CAST(100.00 AS Decimal(18, 2)), N'benefits', N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(201.00 AS Decimal(18, 2)), N'Covered in Full', CAST(202.00 AS Decimal(18, 2)), N'Covered in Full', CAST(203.00 AS Decimal(18, 2)), N'Limit', CAST(204.00 AS Decimal(18, 2)), N'Limit', CAST(205.00 AS Decimal(18, 2)), N'Limit Per Baby', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(207.00 AS Decimal(18, 2)), N'Chiropractic', N'Pool Limit Per Policy', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2.00 AS Decimal(18, 2)), N'kuwait', N'Covered in Full', N'Hospital', N'Within the Resident Country', N'kuwait', N'Worldwide', N'Free Access', N'kuwait', N'benefits', N'Description', N'Exclusions ', NULL, CAST(N'2021-01-05T20:45:40.230' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (3, N'004/01/21/3101/4', N'Pending', N'Bajaj Allianz Life Insurance Company', N'TCS', N'1', N'2', CAST(0.00 AS Decimal(18, 2)), 3, N'BAND - B', N'on', N'kuwait', N'on', CAST(10000.00 AS Decimal(18, 2)), N'', CAST(10000.00 AS Decimal(18, 2)), N'', CAST(2500.00 AS Decimal(18, 2)), CAST(4500.00 AS Decimal(18, 2)), N'Worldwide', N'Worldwide', N'on', N'Covered in Full', CAST(1500.00 AS Decimal(18, 2)), N'Limit Per Day', CAST(1000.00 AS Decimal(18, 2)), N'Number of Sessions', CAST(2.00 AS Decimal(18, 2)), N'Pool Limit', CAST(250.00 AS Decimal(18, 2)), N'Limit Per Trip', CAST(363.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2500.00 AS Decimal(18, 2)), CAST(1000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), N'Benefits', N'Limit Per Person', CAST(3.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Per Claim Limit', CAST(0.00 AS Decimal(18, 2)), N'No of Sessions Per Ailment', CAST(200.00 AS Decimal(18, 2)), N'Limit', CAST(250.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Covered in Full', CAST(300.00 AS Decimal(18, 2)), N'Limit', CAST(350.00 AS Decimal(18, 2)), N'Limit Per Baby', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(3500.00 AS Decimal(18, 2)), N'Ayurveda', N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2.00 AS Decimal(18, 2)), N'Australia', N'Covered in Full', N'Pharmacy', N'Outside Resident Country', N'England', N'Within Territorial Limit', N'Free Access', N'England', N'Benefits ', N'Description', N'Exclusions', NULL, CAST(N'2021-01-08T16:19:43.510' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (4, N'004/01/21/3101/4', N'Pending', N'ICICI Lombard', N'CTS', N'2', N'2', CAST(0.00 AS Decimal(18, 2)), 2, N'BAND - A', N'on', N'Dubai', N'on', CAST(20000.00 AS Decimal(18, 2)), N'', CAST(100.00 AS Decimal(18, 2)), N'', CAST(5222.00 AS Decimal(18, 2)), CAST(452.00 AS Decimal(18, 2)), N'Specific Country', N'Worldwide', N'on', N'Covered in Full', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Pool Limit', CAST(250.00 AS Decimal(18, 2)), N'Limit Per Trip', CAST(22.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(352.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(352.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), N'458', N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'Co-Pay', CAST(0.00 AS Decimal(18, 2)), N'Per Claim Limit', CAST(0.00 AS Decimal(18, 2)), N'No of Sessions Per Ailment', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Limit', CAST(300.00 AS Decimal(18, 2)), N'Covered in Full', CAST(350.00 AS Decimal(18, 2)), N'Limit', CAST(360.00 AS Decimal(18, 2)), N'Limit Per Baby', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(400.00 AS Decimal(18, 2)), N'Homeopathy', N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2.00 AS Decimal(18, 2)), N'Dubai', N'Limited Access', N'Hospital', N'Outside Resident Country', N'India', N'Worldwide', N'Reimbursment', N'England', N'Benefits', N'Description', N'Exclusions', NULL, CAST(N'2021-01-08T17:34:26.797' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (5, N'004/01/21/3101/5', N'Pending', N'ICICI Lombard', N'CTS', N'2', N'2', CAST(0.00 AS Decimal(18, 2)), 2, N'BAND - A', N'on', N'Dubai', N'on', CAST(20000.00 AS Decimal(18, 2)), N'', CAST(100.00 AS Decimal(18, 2)), N'', CAST(5222.00 AS Decimal(18, 2)), CAST(452.00 AS Decimal(18, 2)), N'Specific Country', N'Worldwide', N'on', N'Covered in Full', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Pool Limit', CAST(250.00 AS Decimal(18, 2)), N'Limit Per Trip', CAST(22.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(352.00 AS Decimal(18, 2)), CAST(250.00 AS Decimal(18, 2)), CAST(352.00 AS Decimal(18, 2)), CAST(350.00 AS Decimal(18, 2)), N'458', N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'Co-Pay', CAST(0.00 AS Decimal(18, 2)), N'Per Claim Limit', CAST(0.00 AS Decimal(18, 2)), N'No of Sessions Per Ailment', CAST(100.00 AS Decimal(18, 2)), N'Covered in Full', CAST(200.00 AS Decimal(18, 2)), N'Limit', CAST(300.00 AS Decimal(18, 2)), N'Covered in Full', CAST(350.00 AS Decimal(18, 2)), N'Limit', CAST(360.00 AS Decimal(18, 2)), N'Limit Per Baby', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(400.00 AS Decimal(18, 2)), N'Homeopathy', N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(2.00 AS Decimal(18, 2)), N'Dubai', N'Limited Access', N'Hospital', N'Outside Resident Country', N'India', N'Worldwide', N'Reimbursment', N'England', N'Benefits', N'Description', N'Exclusions', NULL, CAST(N'2021-01-08T17:35:15.557' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[TB_Quotation] ([QuotationId], [DraftNo], [Status], [CIInsuranceCompanyName], [CIClientCompanyName], [CIProducerType], [CIProducerName], [CISelectCommission], [CINoOfPlanCategories], [GBMedicalProviderNetwork], [GBScopeOfCover], [GBAreaOfCoverage], [GBPersonCovered], [GBAnnualBenefitsLimit], [GBIsPerClaimLimitIP], [GBPerClaimLimitIP], [GBIsPerClaimLimitOP], [GBPerClaimLimitOP], [GBPreExisting_ChronicLimit], [GBGeoThreateningEmergencyTreatment], [GBGeoElectiveTreatement], [GBGeoOutsideResidentCountry], [IPHospitalizationClass], [IPHospitalizationClassLimit], [IPICUCoronaryTreatement], [IPICUCoronaryTreatementLimit], [IPVariousTherapies], [IPVariousTherapiesLimit], [IPOrganTransplantationServices], [IPOrganTransplantationServicesLimit], [IPAmbulanceServices], [IPAmbulanceServicesLimit], [IPCompanionRoomBoardExpenses], [IPCompanionRoomBoardExpensesLimit], [IPHospitalCashBenefitsCashPerDay], [IPHospitalCashBenefitsCashTotal], [IPRepatriationCostTraansport], [IPAddBenefits], [OPPhysicianConsultationDeductible], [OPPhysicianConsultationDeductibleLimit], [OPDiagnostics], [OPDiagnosticsLimit], [OPPharmaceuticals], [OPPharmaceuticalsLimit], [OPPhysiotheraphy], [OPPhysiotheraphyLimit], [OPDaycareTreatment], [OPDaycareTreatmentLimit], [OPOutPatientSurgery], [OPOutPatientSurgeryLimit], [OPWorkRelatedInjuries], [OPWorkRelatedInjuriesLimit], [OPAccidentalDamageNaturalTeeth], [OPAccidentalDamageNaturalTeethLimit], [OPNewBornBabyCoverage], [OPNewBornBabyCoverageLimit], [OPNursingAtHome], [OPNursingAtHomeLimit], [OPAlternativeMedicine], [OPAlternativeMedicineCoverage], [OPAlternativeMedicineCoverageLimit], [OPAlternativeMedicineDeductible], [OPAlternativeMedicineDeductibleLimit], [OPFreeAccessOutsideOMAN], [EBFreeAccessTPANetwork], [EBFreeAccessTPANetworkLimit], [EBReimbursementNonNetworkMedicalProviders], [EBReimbursementNonNetworkMedicalProvidersLimit], [EBEmergencyTreatment], [EBEmergencyTreatmentLimit], [EBEmergencyTreatmentCountry], [ABBenefits], [ABDescription], [ABExclusions], [AddedBy], [AddedOn], [UpdatedBy], [UpdatedAt], [PolicyNo]) VALUES (6, N'004/01/21/3101/6', N'Pending', N'HDFC Prudential', N'CTS', N'2', N'2', CAST(0.00 AS Decimal(18, 2)), 3, N'BAND - A', N'on', N'Australia', N'on', CAST(20000.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), N'', CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'Specific Country', N'Worldwide', N'on', N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Number of Sessions', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)), CAST(355.00 AS Decimal(18, 2)), N'555', N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'Per Claim Limit', CAST(0.00 AS Decimal(18, 2)), N'Per Claim Limit', CAST(0.00 AS Decimal(18, 2)), N'No of Sessions Per Ailment', CAST(200.00 AS Decimal(18, 2)), N'Covered in Full', CAST(300.00 AS Decimal(18, 2)), N'Covered in Full', CAST(350.00 AS Decimal(18, 2)), N'Limit', CAST(350.00 AS Decimal(18, 2)), N'Covered in Full', CAST(350.00 AS Decimal(18, 2)), N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Pool Limit', CAST(500.00 AS Decimal(18, 2)), N'Ayurveda', N'Covered in Full', CAST(0.00 AS Decimal(18, 2)), N'Limit Per Person', CAST(1.00 AS Decimal(18, 2)), N'kuwait', N'Limited Access', N'Clinic', N'Outside Resident Country', N'kuwait', N'Worldwide', N'Reimbursment', N'America', N'benefits', N'description', N'test', NULL, CAST(N'2021-01-08T17:41:34.387' AS DateTime), NULL, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_Quotation] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterClient] ON 
GO
INSERT [dbo].[TB_RegisterClient] ([ClientId], [PolicyNumber], [ClientName], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (1, N'D/01/3101/20/D/01/3101/20/00001', N'Totalligent Pvt Ltd', NULL, N'Chennai', N'chennai', N'tamilnadu', 603103, N'jeevarathanam', 9840359280, N'sathishhn2005@gmail.com', N'INR', N'BrokerTest', N'ReInsurer', CAST(N'2020-03-15T13:14:35.107' AS DateTime), NULL)
GO
INSERT [dbo].[TB_RegisterClient] ([ClientId], [PolicyNumber], [ClientName], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (2, N'D/01/3101/20/D/01/3101/20/00002', N'Totalligent Pvt Ltd', NULL, N'Chennai', N'chennai', N'tamilnadu', 603103, N'jeevarathanam', 9840359280, N'sathishhn2005@gmail.com', N'INR', N'Broker Test 1', N'Re Insurer TEST 1', CAST(N'2020-04-17T21:04:48.370' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterClient] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterCompany] ON 
GO
INSERT [dbo].[TB_RegisterCompany] ([CompanyId], [CompanyName], [Address], [City], [StateName], [ContactPerson], [MobileNumber], [EmailId], [Currency], [CreatedAt], [CreatedBy]) VALUES (1, N'TPAAudit', N'TPA Address', N'chennai', N'TN', N'9578577701', 9578577701, N'sathishhn2005@gmail.com', N'DHR', CAST(N'2020-03-15T12:18:07.663' AS DateTime), N'Developer')
GO
INSERT [dbo].[TB_RegisterCompany] ([CompanyId], [CompanyName], [Address], [City], [StateName], [ContactPerson], [MobileNumber], [EmailId], [Currency], [CreatedAt], [CreatedBy]) VALUES (2, N'Totalligent Pvt Ltd', N'Chennai', N'chennai', N'tamilnadu', N'Sundhar', 9840359280, N'sathishhn2005@gmail.com', N'OMR', CAST(N'2020-04-17T11:39:38.527' AS DateTime), N'Developer')
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterCompany] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterInsCompany] ON 
GO
INSERT [dbo].[TB_RegisterInsCompany] ([InsCompanyId], [PolicyNumber], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (1, N'00001', N'Cognizant Technology Solutions', N'Siruseri', N'Chennai', N'TamilNadu', 603103, N'Murali Prasad S', 9578577701, N'murali@gmail.com', N'DHR', N'Broker Test 1', N'Re Insurer TEST 1', CAST(N'2020-03-15T12:23:03.883' AS DateTime), NULL)
GO
INSERT [dbo].[TB_RegisterInsCompany] ([InsCompanyId], [PolicyNumber], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (2, N'00002', N'Cognizant Technology Solutions', N'Siruseri', N'Chennai', N'TamilNadu', 603103, N'Murali Prasad S', 9578577701, N'murali@gmail.com', N'DHR', N'Broker Test 1', N'Re Insurer TEST 1', CAST(N'2020-03-15T12:23:13.810' AS DateTime), NULL)
GO
INSERT [dbo].[TB_RegisterInsCompany] ([InsCompanyId], [PolicyNumber], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (3, N'00003', N'Cognizant Technology Solutions', N'Siruseri', N'Chennai', N'TamilNadu', 603103, N'Murali Prasad S', 9578577701, N'murali@gmail.com', N'DHR', N'Broker Test 1', N'Re Insurer TEST 1', CAST(N'2020-03-15T12:23:39.467' AS DateTime), NULL)
GO
INSERT [dbo].[TB_RegisterInsCompany] ([InsCompanyId], [PolicyNumber], [CompanyName], [CompanyAddress], [City], [StateName], [ZipCode], [ContactPerson], [MobileNumber], [EmailId], [Currency], [Broker], [Reinsurer], [CreatedAt], [CreatedBy]) VALUES (4, N'00004', N'Cognizant Technology Solutions', N'Siruseri', N'Chennai', N'TamilNadu', 603103, N'Murali Prasad S', 9578577701, N'murali@gmail.com', N'DHR', N'Broker Test 1', N'Re Insurer TEST 1', CAST(N'2020-03-15T12:23:48.220' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_RegisterInsCompany] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_ReInsurerMaster] ON 
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (1, N'Hannover RE', N'RE002', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.287' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.287' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (2, N'Axis RE', N'RE003', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.287' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.287' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (3, N'Swiss RE', N'RE004', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (4, N'GEN Re', N'RE005', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (5, N'Munich RE', N'RE006', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin')
GO
INSERT [dbo].[TB_ReInsurerMaster] ([ReInsurerId], [ReInsurerName], [ReInsurerCode], [Address], [City], [Zipcode], [ContactPerson], [MobileNumber], [EmailId], [AddedOn], [AddedBy], [UpdatedOn], [UpdatedBy]) VALUES (6, N'RGA RE', N'', NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin', CAST(N'2020-04-09T02:40:55.290' AS DateTime), N'Admin')
GO
SET IDENTITY_INSERT [dbo].[TB_ReInsurerMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Role] ON 
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (1, N'Admin')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (2, N'Agent')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (3, N'Broker')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (4, N'Branches')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (5, N'DirectSales')
GO
SET IDENTITY_INSERT [dbo].[TB_Role] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_Tickets] ON 
GO
INSERT [dbo].[TB_Tickets] ([TicketId], [RaisedBy], [Description], [CreatedAt], [CreatedBy], [Flag], [UpdatedBy], [UpdatedAt]) VALUES (1, N'arunTotalligent', N'Request raised for Reset the password', CAST(N'2020-06-15T12:49:44.030' AS DateTime), N'arunTotalligent', 1, N'Admin', CAST(N'2020-06-15T14:21:21.640' AS DateTime))
GO
INSERT [dbo].[TB_Tickets] ([TicketId], [RaisedBy], [Description], [CreatedAt], [CreatedBy], [Flag], [UpdatedBy], [UpdatedAt]) VALUES (2, N'arunTotalligent', N'Request raised for Reset the password', CAST(N'2020-06-16T17:03:01.353' AS DateTime), N'arunTotalligent', 0, NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[TB_Tickets] OFF
GO
SET IDENTITY_INSERT [dbo].[TB_UserTypeMaster] ON 
GO
INSERT [dbo].[TB_UserTypeMaster] ([UserTypeId], [Designation]) VALUES (1, N'Line Manager')
GO
INSERT [dbo].[TB_UserTypeMaster] ([UserTypeId], [Designation]) VALUES (2, N'Sr.Executive')
GO
INSERT [dbo].[TB_UserTypeMaster] ([UserTypeId], [Designation]) VALUES (3, N'Executive')
GO
SET IDENTITY_INSERT [dbo].[TB_UserTypeMaster] OFF
GO
ALTER TABLE [dbo].[TB_AgentMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_AgentMaster] ADD  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[TB_BrokerMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_BrokerMaster] ADD  DEFAULT ('Admin') FOR [CreatedBy]
GO
ALTER TABLE [dbo].[TB_BrokerMaster] ADD  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[TB_BrokerMaster] ADD  DEFAULT ('Admin') FOR [UpdatedBy]
GO
ALTER TABLE [dbo].[TB_CategoryMaster] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[TB_CategoryMaster] ADD  DEFAULT ('Admin') FOR [AddedBy]
GO
ALTER TABLE [dbo].[TB_CategoryMaster] ADD  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[TB_CategoryMaster] ADD  DEFAULT ('Admin') FOR [UpdatedBy]
GO
ALTER TABLE [dbo].[TB_ClientCompanyMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_DiagnosticsMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_DrugMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_Employee] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[TB_HospitalMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_InsuranceCompanyMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_InsuranceCompanyMaster] ADD  DEFAULT (getdate()) FOR [UpdatedAt]
GO
ALTER TABLE [dbo].[TB_LabMaster] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_ProducerMaster] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[TB_Quotation] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[TB_RegisterInsCompany] ADD  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[TB_ReInsurerMaster] ADD  DEFAULT (getdate()) FOR [AddedOn]
GO
ALTER TABLE [dbo].[TB_ReInsurerMaster] ADD  DEFAULT ('Admin') FOR [AddedBy]
GO
ALTER TABLE [dbo].[TB_ReInsurerMaster] ADD  DEFAULT (getdate()) FOR [UpdatedOn]
GO
ALTER TABLE [dbo].[TB_ReInsurerMaster] ADD  DEFAULT ('Admin') FOR [UpdatedBy]
GO
/****** Object:  StoredProcedure [dbo].[SP_Clients]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Clients]  
(
@PolicyNumber nvarchar(75)
)
as Begin  
declare @sql nvarchar(max)

set @sql='select ClientId,PolicyNumber,ClientName,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer

 from TB_RegisterClient '
 if(@PolicyNumber<>'')

set @sql+='where PolicyNumber='''+@PolicyNumber+''''
print @sql
exec sp_executesql @sql;

end

GO
/****** Object:  StoredProcedure [dbo].[SP_CloseTicket]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CloseTicket]
(
@TicketId int,
@RaisedBy nvarchar(50),
@Newpassword nvarchar(50)
)
as
begin
update TB_Login set Password=@Newpassword ,UpdatedBy='Admin',UpdatedAt=getdate() where UserName=@RaisedBy
update TB_Tickets set Flag=1,UpdatedBy='Admin',UpdatedAt=getdate() where TicketId=@TicketId and RaisedBy=@RaisedBy
Select @TicketId as TicketId, UserName,@Newpassword as Newpassword,EmailId from TB_Employee where UserName=@RaisedBy
end
GO
/****** Object:  StoredProcedure [dbo].[SP_CompanyRegistration]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[SP_CompanyRegistration]
(
@CompanyName nvarchar(100),
@Address nvarchar(100),
@City nvarchar(50),
@StateName NVARCHAR(100),
@ContactPerson nvarchar(100),
@MobileNumber bigint,
@EmailId nvarchar(100),
@Currency nvarchar(10),

@CreatedBy nvarchar(50)

)
as
Begin
if not exists(Select 1 from TB_RegisterCompany where CompanyName=@CompanyName)
Insert into TB_RegisterCompany(CompanyName,Address,City,StateName,ContactPerson,MobileNumber,EmailId,Currency,CreatedAt,CreatedBy)
select @CompanyName ,@Address ,@City ,@StateName ,@ContactPerson ,@MobileNumber ,@EmailId ,@Currency,GETDATE(),@CreatedBy 
--set @Return=SCOPE_IDENTITY()
End
GO
/****** Object:  StoredProcedure [dbo].[SP_CreateQuotation]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_CreateQuotation]
(
@UDT_QuotationGenerator dbo.UDT_Quotation readonly

)
as
begin

declare @Result bigint
Insert into TB_Quotation(CIInsuranceCompanyName,CIClientCompanyName,CIProducerType,CIProducerName,CISelectCommission,CINoOfPlanCategories,

GBMedicalProviderNetwork,GBScopeOfCover,GBAreaOfCoverage,GBPersonCovered,GBAnnualBenefitsLimit,GBIsPerClaimLimitIP,GBPerClaimLimitIP,GBIsPerClaimLimitOP,GBPerClaimLimitOP,
GBPreExisting_ChronicLimit,GBGeoThreateningEmergencyTreatment,GBGeoElectiveTreatement,GBGeoOutsideResidentCountry,

IPHospitalizationClass,IPHospitalizationClassLimit,IPICUCoronaryTreatement,IPICUCoronaryTreatementLimit,IPVariousTherapies,IPVariousTherapiesLimit,IPOrganTransplantationServices,
IPOrganTransplantationServicesLimit,IPAmbulanceServices,IPAmbulanceServicesLimit,IPCompanionRoomBoardExpenses,IPCompanionRoomBoardExpensesLimit,IPHospitalCashBenefitsCashPerDay,
IPHospitalCashBenefitsCashTotal,IPRepatriationCostTraansport,IPAddBenefits,

OPPhysicianConsultationDeductible,OPPhysicianConsultationDeductibleLimit,OPDiagnostics,OPDiagnosticsLimit,OPPharmaceuticals,OPPharmaceuticalsLimit,OPPhysiotheraphy,OPPhysiotheraphyLimit,
OPDaycareTreatment,OPDaycareTreatmentLimit,OPOutPatientSurgery,OPOutPatientSurgeryLimit,OPWorkRelatedInjuries,OPWorkRelatedInjuriesLimit,OPAccidentalDamageNaturalTeeth,
OPAccidentalDamageNaturalTeethLimit,OPNewBornBabyCoverage,OPNewBornBabyCoverageLimit,OPNursingAtHome,OPNursingAtHomeLimit,OPAlternativeMedicine,OPAlternativeMedicineCoverage,
OPAlternativeMedicineCoverageLimit,OPAlternativeMedicineDeductible,OPAlternativeMedicineDeductibleLimit,OPFreeAccessOutsideOMAN,

EBFreeAccessTPANetwork,EBFreeAccessTPANetworkLimit,EBReimbursementNonNetworkMedicalProviders,EBReimbursementNonNetworkMedicalProvidersLimit,EBEmergencyTreatment,EBEmergencyTreatmentLimit,
EBEmergencyTreatmentCountry,

ABBenefits,ABDescription,ABExclusions,Status)
select CIInsuranceCompanyName,CIClientCompanyName,CIProducerType,CIProducerName,CISelectCommission,CINoOfPlanCategories,

GBMedicalProviderNetwork,GBScopeOfCover,GBAreaOfCoverage,GBPersonCovered,GBAnnualBenefitsLimit,GBIsPerClaimLimitIP,GBPerClaimLimitIP,GBIsPerClaimLimitOP,GBPerClaimLimitOP,
GBPreExisting_ChronicLimit,GBGeoThreateningEmergencyTreatment,GBGeoElectiveTreatement,GBGeoOutsideResidentCountry,

IPHospitalizationClass,IPHospitalizationClassLimit,IPICUCoronaryTreatement,IPICUCoronaryTreatementLimit,IPVariousTherapies,IPVariousTherapiesLimit,IPOrganTransplantationServices,
IPOrganTransplantationServicesLimit,IPAmbulanceServices,IPAmbulanceServicesLimit,IPCompanionRoomBoardExpenses,IPCompanionRoomBoardExpensesLimit,IPHospitalCashBenefitsCashPerDay,
IPHospitalCashBenefitsCashTotal,IPRepatriationCostTraansport,IPAddBenefits,

OPPhysicianConsultationDeductible,OPPhysicianConsultationDeductibleLimit,OPDiagnostics,OPDiagnosticsLimit,OPPharmaceuticals,OPPharmaceuticalsLimit,OPPhysiotheraphy,OPPhysiotheraphyLimit,
OPDaycareTreatment,OPDaycareTreatmentLimit,OPOutPatientSurgery,OPOutPatientSurgeryLimit,OPWorkRelatedInjuries,OPWorkRelatedInjuriesLimit,OPAccidentalDamageNaturalTeeth,
OPAccidentalDamageNaturalTeethLimit,OPNewBornBabyCoverage,OPNewBornBabyCoverageLimit,OPNursingAtHome,OPNursingAtHomeLimit,OPAlternativeMedicine,OPAlternativeMedicineCoverage,
OPAlternativeMedicineCoverageLimit,OPAlternativeMedicineDeductible,OPAlternativeMedicineDeductibleLimit,OPFreeAccessOutsideOMAN,

EBFreeAccessTPANetwork,EBFreeAccessTPANetworkLimit,EBReimbursementNonNetworkMedicalProviders,EBReimbursementNonNetworkMedicalProvidersLimit,EBEmergencyTreatment,EBEmergencyTreatmentLimit,
EBEmergencyTreatmentCountry,

ABBenefits,ABDescription,ABExclusions,'Pending'
from @UDT_QuotationGenerator
set @Result=scope_identity()
if(@Result>0)
begin
--004 = Company code
--	    01 =   Branch
--                 20 =   YEAR
--                3101 = Product code
--                00001 = Sequence number   
update TB_Quotation set DraftNo='004/01/21/3101/'+CONVERT(nvarchar,@Result) where QuotationId=@Result
select ISNULL(DraftNo,'004/01/21/3101/'+CONVERT(nvarchar,@Result) ) as DraftNo from TB_Quotation where QuotationId=@Result

end
else
begin
select '' as DraftNo
end

end
GO
/****** Object:  StoredProcedure [dbo].[SP_EmployeeRegistration]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[SP_EmployeeRegistration]
(
@UserName nvarchar(100),
@UserEmployeeNo nvarchar(100),
@UserTypeId int,
@ReportingManager NVARCHAR(100),
@EmailId nvarchar(100),
@MobileNumber nvarchar(15),
@CreatedBy nvarchar(50),
@RoleId int

)
as
Begin
declare @EmpId int
if not exists(Select 1 from TB_Employee where UserEmployeeNo=@UserEmployeeNo)
Insert into TB_Employee(UserName,UserEmployeeNo,UserTypeId,ReportingManager,EmailId,MobileNumber,AddedBy,AddedOn,RoleId)
select @UserName ,@UserEmployeeNo,@UserTypeId,@ReportingManager,@EmailId,@MobileNumber ,@CreatedBy,GETDATE() ,@RoleId
set @EmpId=SCOPE_IDENTITY()
if(@EmpId>0)
begin
Select UserName,EmailId from TB_Employee where EmployeeId=@EmpId
end
End
GO
/****** Object:  StoredProcedure [dbo].[SP_GetCompanies]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GetCompanies]  
(
@CompanyDraftNo nvarchar(75)
)
as Begin  
declare @sql nvarchar(max)

set @sql='select InsCompanyId ,PolicyNumber,CompanyName,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer

 from TB_RegisterInsCompany '
 if(@CompanyDraftNo<>'')

set @sql+='where PolicyNumber='''+@CompanyDraftNo+''''
print @sql
exec sp_executesql @sql;

end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetLoginInfo]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GetLoginInfo]
(
@UserName nvarchar(25),
@Password nvarchar(25),
@IsFirstLogin nvarchar out,
@RoleId int
)
as
begin
if(@RoleId!=1)
begin
select E.EmployeeId, L.UserName,UserEmployeeNo,Designation,ReportingManager,EmailId,MobileNumber,L.RoleId from TB_Login L 
left join TB_Employee E on e.UserName=l.UserName
Inner join TB_UserTypeMaster UTM on UTM.UserTypeId=E.UserTypeId
 where L.UserName=@UserName and L.Password=@Password and L.RoleId=@RoleId
end
else
begin
select 0 as EmployeeId, L.UserName,''as UserEmployeeNo,'' as Designation,''as ReportingManager,''as EmailId,'' as MobileNumber,L.RoleId from TB_Login L 
where L.UserName=@UserName and L.Password=@Password and L.RoleId=@RoleId
end
set @IsFirstLogin=(select IsPasswordChanged from TB_Login where UserName=@UserName and Password=@Password and RoleId=@RoleId)

end


GO
/****** Object:  StoredProcedure [dbo].[SP_GetQuotation]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GetQuotation](
@QuotationId bigint)
as begin
select 

QuotationId,DraftNo,Status,CIInsuranceCompanyName,CIClientCompanyName,CIProducerType,CIProducerName,CISelectCommission,CINoOfPlanCategories,GBMedicalProviderNetwork,
GBScopeOfCover,GBAreaOfCoverage,GBPersonCovered,GBAnnualBenefitsLimit,GBIsPerClaimLimitIP,GBPerClaimLimitIP,GBIsPerClaimLimitOP,GBPerClaimLimitOP,GBPreExisting_ChronicLimit,
GBGeoThreateningEmergencyTreatment,GBGeoElectiveTreatement,GBGeoOutsideResidentCountry,IPHospitalizationClass,IPHospitalizationClassLimit,IPICUCoronaryTreatement,IPICUCoronaryTreatementLimit,
IPVariousTherapies,IPVariousTherapiesLimit,IPOrganTransplantationServices,IPOrganTransplantationServicesLimit,IPAmbulanceServices,IPAmbulanceServicesLimit,IPCompanionRoomBoardExpenses,
IPCompanionRoomBoardExpensesLimit,IPHospitalCashBenefitsCashPerDay,IPHospitalCashBenefitsCashTotal,IPRepatriationCostTraansport,IPAddBenefits,OPPhysicianConsultationDeductible,
OPPhysicianConsultationDeductibleLimit,OPDiagnostics,OPDiagnosticsLimit,OPPharmaceuticals,OPPharmaceuticalsLimit,OPPhysiotheraphy,OPPhysiotheraphyLimit,OPDaycareTreatment,OPDaycareTreatmentLimit,
OPOutPatientSurgery,OPOutPatientSurgeryLimit,OPWorkRelatedInjuries,OPWorkRelatedInjuriesLimit,OPAccidentalDamageNaturalTeeth,OPAccidentalDamageNaturalTeethLimit,OPNewBornBabyCoverage,
OPNewBornBabyCoverageLimit,OPNursingAtHome,OPNursingAtHomeLimit,OPAlternativeMedicine,OPAlternativeMedicineCoverage,OPAlternativeMedicineCoverageLimit,OPAlternativeMedicineDeductible,
OPAlternativeMedicineDeductibleLimit,OPFreeAccessOutsideOMAN,EBFreeAccessTPANetwork,EBFreeAccessTPANetworkLimit,EBReimbursementNonNetworkMedicalProviders,
EBReimbursementNonNetworkMedicalProvidersLimit,EBEmergencyTreatment,EBEmergencyTreatmentLimit,EBEmergencyTreatmentCountry,ABBenefits,ABDescription,ABExclusions,PolicyNo
 from tb_quotation where QuotationId=@QuotationId
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetRoles]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_GetRoles]

as
begin
Select * from tb_role
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUserType]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_GetUserType]
as

begin
Select UserTypeId,Designation from TB_UserTypeMaster
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GetUWDashboard]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_GetUWDashboard](
@UserName nvarchar(20)
)
as begin
declare @TotalNoPoliciesYear bigint,@TotalNoPolUnderProcessYear bigint,@TotNoPolLostYear bigint,@TotalNoPolRenewedYear bigint,
@TotalNoPoliciesMonth bigint ,@TotalNoPoliciesLostMonth bigint,@TotalNoPoliciesUPMonth bigint,@TotalNoPoliciesRenewedMonth bigint
,@TotalNoPoliciesYearPremium bigint,@TotalNoPolUnderProcessYearPremium bigint,@TotNoPolLostYearPremium bigint,@TotalNoPolRenewedYearPremium bigint
,@TotalNoPoliciesMonthPremium bigint,@TotalNoPoliciesLostMonthPremium bigint,@TotalNoPoliciesUPMonthPremium bigint,@TotalNoPoliciesRenewedMonthPremium bigint,
@TotalNPYearPercent decimal(18,2),@TotalNPMonthPercent decimal(18,2),@TotalNPYearPercentPremium decimal(18,2),@TotalNPMonthPercentPremium decimal(18,2),@TotalNoPolQuotationDrafted bigint,
@TotNoPolIssued bigint,@TotalNoPolRejected bigint

set @TotalNoPoliciesYear =(SELECT count(*) as TotalNoPoliciesYear from TB_Quotation )--where PolicyToDate between getdate() and DATEADD(dd, -1, DATEADD(yy, DATEDIFF(yy, 0, GETDATE())+1, 0)))
set @TotalNoPolQuotationDrafted =(select count(*) as TotalUnderProcessYear from TB_Quotation where Status='Pending')
set @TotNoPolIssued =(select count(*) as TotalLostYear from TB_Quotation where Status='Issued')
set @TotalNoPolRejected =(select count(*) as TotalRenewedYear from TB_Quotation where Status='Rejected')
--set @TotalNPYearPercent= (@TotalNoPolRenewedYear *100/ @TotalNoPoliciesYear)
select isnull(@TotalNoPoliciesYear,0)                as TNPYear, 
       isnull(@TotalNoPolQuotationDrafted,0)         as TotalNoPolQuotationDrafted, 
       isnull(@TotNoPolIssued,0)         as TotNoPolIssued, 
       isnull(@TotalNoPolRejected,0)         as TotalNoPolRejected, 
       @UserName as UserName

select QuotationId, DraftNo,ISNULL(PolicyNo,'Yet to Generate') as PolicyNo,CIInsuranceCompanyName,CIClientCompanyName,Status from TB_Quotation order by AddedOn desc

--Alter table TB_Quotation add PolicyNo nvarchar(80)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertAgentMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertAgentMaster](
@AgentName	nvarchar	(80),
--@AgentCode	nvarchar	(40),
@Address	nvarchar	(400),
@City	nvarchar	(40),
@Zipcode	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_AgentMaster WHERE AgentName=@AgentName)
BEGIN
Insert into TB_AgentMaster(AgentName,Address,City,Zipcode,ContactPerson,MobileNumber,EmailId)
select @AgentName,@Address,@City,@Zipcode,@ContactPerson,@MobileNumber,@EmailId
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertBrokerMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertBrokerMaster](
@BrokerName	nvarchar	(80),
--@BrokerCode	nvarchar	(40),
@Address	nvarchar	(400),
@City	nvarchar	(40),
@Zipcode	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_BrokerMaster WHERE BrokerName=@BrokerName)
BEGIN
Insert into TB_BrokerMaster(BrokerName,Address,City,Zipcode,ContactPerson,MobileNumber,EmailId)
select @BrokerName,@Address,@City,@Zipcode,@ContactPerson,@MobileNumber,@EmailId
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertClientCompanyMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertClientCompanyMaster](
@ClientCompanyName	nvarchar	(200),
@Address	nvarchar	(400),
@Password	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100),
@Currency	nvarchar	(20)
)
AS 
BEGIN
declare @Id int,@MaxId bigint,@UserName nvarchar(100)
set @MaxId=(Select max(ClientComId) from TB_ClientCompanyMaster)
IF(@MaxId IS NULL)
SET @MaxId=1


set @UserName=(SELECT 'CL'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8))) 

IF NOT EXISTS(SELECT 1 FROM TB_ClientCompanyMaster WHERE ClientCompanyName=@ClientCompanyName)
BEGIN
Insert into TB_ClientCompanyMaster(ClientCompanyName,Address,ContactPerson,MobileNumber,EmailId,Currency)
select @ClientCompanyName,@Address,@ContactPerson,@MobileNumber,@EmailId,@Currency

Insert into TB_Login(UserName,Password,RoleId,CreatedAt,AddedBy)
select @UserName,SUBSTRING(@Password,0,10),0,GETDATE(),'Admin'
set @Id=SCOPE_IDENTITY()

if(@Id>0)
begin
Select UserName,Password from TB_Login where LoginId=@Id
end
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDiagnosticsMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertDiagnosticsMaster](
@DiagnosticsName nvarchar(50),
@DiagnosticsCode nvarchar(40)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_DiagnosticsMaster WHERE DiagnosticsName=@DiagnosticsName)
BEGIN
Insert into TB_DiagnosticsMaster(DiagnosticsName,DiagnosticsCode)
select @DiagnosticsName,@DiagnosticsCode
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDrugMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[SP_InsertDrugMaster](
@DrugName	nvarchar	(40),
@DrugCode	nvarchar	(40)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_DrugMaster WHERE DrugName=@DrugName)
BEGIN
Insert into TB_DrugMaster(DrugName,DrugCode)
select @DrugName,@DrugCode
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertHospitalMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertHospitalMaster](
@HospitalName	nvarchar	(80),
@Address	nvarchar	(200),
@State	nvarchar	(40),
@City	nvarchar	(40),
@Zipcode	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100),
@Band nvarchar	(15)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_HospitalMaster WHERE HospitalName=@HospitalName and Band=@Band)
BEGIN
Insert into TB_HospitalMaster(HospitalName,State, Address,City,Zipcode,ContactPerson,MobileNumber,EmailId,Band)
select @HospitalName,@state,@Address,@City,@Zipcode,@ContactPerson,@MobileNumber,@EmailId,@Band
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertInsCompanyMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_InsertInsCompanyMaster](
@InsurancecompanyName	nvarchar	(80),
@Address	nvarchar	(50),
@State	nvarchar	(40),
@City	nvarchar	(40),
@Zipcode	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_InsuranceCompanyMaster WHERE InsurancecompanyName=@InsurancecompanyName)
BEGIN
Insert into TB_InsuranceCompanyMaster(InsurancecompanyName,State,Address,City,Zipcode,ContactPerson,MobileNumber,EmailId)
select @InsurancecompanyName,@State,@Address,@City,@Zipcode,@ContactPerson,@MobileNumber,@EmailId
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertLabMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_InsertLabMaster](
@LabName	nvarchar	(80),
--@LabCode	nvarchar	(30),
@Address	nvarchar	(50),
@State	nvarchar	(40),
@City	nvarchar	(40),
@Zipcode	nvarchar	(20),
@ContactPerson	nvarchar	(80),
@MobileNumber	nvarchar	(40),
@EmailId	nvarchar	(100)
)
AS 
BEGIN
IF NOT EXISTS(SELECT 1 FROM TB_LabMaster WHERE LabName=@LabName)
BEGIN
Insert into TB_LabMaster(LabName,State,Address,City,Zipcode,ContactPerson,MobileNumber,EmailId)
select @LabName,@State,@Address,@City,@Zipcode,@ContactPerson,@MobileNumber,@EmailId
END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertProducerMaster]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE Proc [dbo].[SP_InsertProducerMaster]
(
  @MasterType nvarchar(50),
  @Name nvarchar(50),
  --@UserName nvarchar(50), 
  @Password nvarchar(50),
  @EmailId nvarchar(50),
  @AddedBy nvarchar(50)
 )
as
Begin
declare @Id int,@MaxId bigint,@UserName nvarchar(100)
set @MaxId=(Select max(Id) from TB_ProducerMaster where MasterType=@MasterType)
IF(@MaxId IS NULL)
SET @MaxId=1

if(@MasterType='Agent')
begin
set @UserName=(SELECT 'AG'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8))) 
end
if(@MasterType='Broker')
begin
set @UserName=(SELECT 'BA'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8))) 
end
if(@MasterType='Branches')
begin
set @UserName=(SELECT 'BR'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8))) 
end
if(@MasterType='DirectSales')
begin
set @UserName=(SELECT 'SA'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8))) 
end
IF not exists(select 1 from TB_ProducerMaster where EmailId=@EmailId)
begin
insert into tb_producermaster(MasterType,Name,UserName,EmailId,AddedBy,EntryType,Password)
select @MasterType,@Name,@UserName, @EmailId,@AddedBy,'Data Entry',SUBSTRING(@Password,0,10)
set @Id=SCOPE_IDENTITY()
end
if(@Id>0)
begin
Select UserName,EmailId,Password from TB_ProducerMaster where Id=@Id
end
End
GO
/****** Object:  StoredProcedure [dbo].[SP_ProducerMasterUpload]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ProducerMasterUpload] (@UDT_ProducerMaster dbo.UDT_ProducerMaster 
readonly,
@UserName nvarchar(100)) 
AS 
  BEGIN 
     declare @Id int,@MaxId bigint,@Cnt bigint
	 set @MaxId=1
	 declare @tt table(
Id int,
Role nvarchar(50)
	 )
	 insert into @tt(Id,Role)
	 select ISNULL(MAX(Id),0) as Id,R.Description from TB_ProducerMaster PM 
	 right join TB_Role R on R.Description=pm.MasterType
	 
	 group by R.Description
	 
	insert into tb_producermaster(UserName,MasterType,Name,AddedBy,EntryType,EmailId,Password)
	 select
	 Case  
	 when 
	 UDT.MasterType='Agent' then 
	 'AG'+right('0000'+CONVERT([Nvarchar](8), tt.Id+ROW_NUMBER() over (partition by tt.Role ORDER BY NAME)),(8))
	 when 
	 UDT.MasterType='Broker' then 
	 'BA'+right('0000'+CONVERT([Nvarchar](8), tt.Id+ROW_NUMBER() over (partition by tt.Role ORDER BY NAME)),(8))
	 
	 when 
	 UDT.MasterType='Branches' then 
	 'BR'+right('0000'+CONVERT([Nvarchar](8), tt.Id+ROW_NUMBER() over (partition by tt.Role ORDER BY NAME)),(8))
	 
	 when 
	 UDT.MasterType='DirectSales' then 
	 'SA'+right('0000'+CONVERT([Nvarchar](8), tt.Id+ROW_NUMBER() over (partition by tt.Role ORDER BY NAME)),(8))
	 
	 end as UserName,UDT.MasterType,UDT.Name,@UserName,'Bulk Upload',EmailId,@UserName
	  from @tt tt 

	 inner join @UDT_ProducerMaster UDT on UDT.MasterType=tt.Role
--set @Cnt=(select count(*) from @UDT_ProducerMaster)
		
--		insert into tb_producermaster(MasterType,Name,AddedBy,EntryType,UserName)
--select MasterType,Name,@UserName,'Bulk Upload',


--CASE
--    WHEN UDT.MasterType='Agent' THEN (SELECT 'AG'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8)))
--    WHEN UDT.MasterType='Broker' THEN (SELECT 'BA'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8)))
--    WHEN UDT.MasterType='Branches' THEN (SELECT 'BR'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8)))
--    WHEN UDT.MasterType='DirectSales' THEN (SELECT 'SA'+right('0000'+CONVERT([Nvarchar](8),@MaxId),(8)))
    
--    ELSE 'NA'
--END AS UserName
--from  @UDT_ProducerMaster UDT

			
        
		select distinct PM.EmailId,PM.UserName,PM.Password from TB_ProducerMaster PM
		inner join @UDT_ProducerMaster UDT on UDT.EmailId=PM.EmailId

  END 
GO
/****** Object:  StoredProcedure [dbo].[SP_RaiseTicket]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RaiseTicket]
(
@TicketId int,@RaisedBy nvarchar(50),@Description nvarchar(500),@CreatedAt datetime,@CreatedBy nvarchar(50)
) 
AS
BEGIN
Insert into TB_Tickets(RaisedBy,Description,CreatedAt,CreatedBy)
select @RaisedBy,@Description,GETDATE(),@CreatedBy
END
GO
/****** Object:  StoredProcedure [dbo].[SP_RegisterClient]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RegisterClient]
(
@UDT_ClientRegistration dbo.UDT_RegisterClient readonly

)
as
begin
declare @Result int,@Cnt int
set @Cnt=(select count(*) from TB_RegisterClient)
declare @PolicyNumber nvarchar(100)
set @PolicyNumber=(select PolicyNumber from @UDT_ClientRegistration)
if(@Cnt>0)

begin
print 1
set @PolicyNumber+=(SELECT top 1 @PolicyNumber+RIGHT('0000' + CAST([ClientId]+1 AS varchar(15)) , 5)
FROM TB_RegisterClient order by ClientId desc)
end
else
begin
print 2
set @PolicyNumber+=(SELECT @PolicyNumber+RIGHT('0000' + CAST(1 AS varchar(15)) , 5))
end

if not exists(select 1 from TB_RegisterClient C Inner join @UDT_ClientRegistration UDTC on UDTC.PolicyNumber=C.PolicyNumber)
begin

Insert into TB_RegisterClient(ClientName,PolicyNumber,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer,CreatedAt)
select distinct ClientName,@PolicyNumber,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer,GETDATE() from @UDT_ClientRegistration
end

set @Result=scope_identity()
if(@Result>0)
begin

select PolicyNumber from TB_RegisterClient where ClientId=@Result

end
else
begin
select '' as PolicyNumber
end

end
GO
/****** Object:  StoredProcedure [dbo].[SP_RegisterInsCompany]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_RegisterInsCompany]
(
@UDT_InsCompanyRegistration dbo.UDT_InsCompanyRegister readonly

)
as
begin
declare @Result int,@Cnt int
set @Cnt=(select count(*) from TB_RegisterInsCompany)
declare @PolicyNumber nvarchar(100)
set @PolicyNumber=(select PolicyNumber from @UDT_InsCompanyRegistration)
if(@Cnt>0)

begin
print 1
set @PolicyNumber+=(SELECT top 1 @PolicyNumber+RIGHT('0000' + CAST([InsCompanyId]+1 AS varchar(15)) , 5)
FROM TB_RegisterInsCompany order by InsCompanyId desc)
end
else
begin
print 2
set @PolicyNumber+=(SELECT @PolicyNumber+RIGHT('0000' + CAST(1 AS varchar(15)) , 5))
end

if not exists(select 1 from TB_RegisterInsCompany C Inner join @UDT_InsCompanyRegistration UDTC on UDTC.PolicyNumber=C.PolicyNumber)
begin

Insert into TB_RegisterInsCompany(CompanyName,PolicyNumber,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer)
select distinct CompanyName,@PolicyNumber,CompanyAddress,City,StateName,ZipCode,ContactPerson,MobileNumber,EmailId,Currency,Broker,Reinsurer from @UDT_InsCompanyRegistration
end

set @Result=scope_identity()
if(@Result>0)
begin

select PolicyNumber from TB_RegisterInsCompany where InsCompanyId=@Result

end
else
begin
select '' as PolicyNumber
end

end
GO
/****** Object:  StoredProcedure [dbo].[SP_ResetPassword]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ResetPassword]
(
@UserName nvarchar(50)
)
as
begin
declare @Result int
if exists(select 1 from TB_Employee where UserName=@UserName and UserTypeId<>1)
begin
if not exists(select 1 from TB_Tickets where RaisedBy=@UserName and flag=0)
begin
Insert into TB_Tickets(RaisedBy,Description,CreatedAt,CreatedBy,Flag)
select @UserName,'Request raised for Reset the password',GETDATE(),@UserName,0
set @Result=SCOPE_IDENTITY()
end
if(@Result>0)
begin
Select @Result as TicketId, UserName,MobileNumber,EmailId from TB_Employee where UserName=@UserName
end
end
end

GO
/****** Object:  StoredProcedure [dbo].[SP_SaveLogin]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SaveLogin]
(
@UserName nvarchar(30),
@Password nvarchar(200),
@RoleId int
)
as 
begin
if not exists(select 1 from TB_Login where UserName=@UserName)
begin
If(@RoleId=0)
SET @RoleId=1
Insert into TB_Login(UserName,Password,RoleId,CreatedAt)
select @UserName,SUBSTRING(@Password,0,10),@RoleId,GETDATE()
end
end
GO
/****** Object:  StoredProcedure [dbo].[SP_TPAInsEmployeeRegistration]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create Proc [dbo].[SP_TPAInsEmployeeRegistration]
(
@UserName nvarchar(100),
@UserEmployeeNo nvarchar(100),
@UserTypeId int,
@ReportingManager NVARCHAR(100),
@EmailId nvarchar(100),
@MobileNumber nvarchar(15),
@CreatedBy nvarchar(50)

)
as
Begin
declare @EmpId int
if not exists(Select 1 from TB_Employee where UserEmployeeNo=@UserEmployeeNo)
Insert into TB_Employee(UserName,UserEmployeeNo,UserTypeId,ReportingManager,EmailId,MobileNumber,AddedBy,AddedOn)
select @UserName ,@UserEmployeeNo,@UserTypeId,@ReportingManager,@EmailId,@MobileNumber ,@CreatedBy,GETDATE() 
set @EmpId=SCOPE_IDENTITY()
if(@EmpId>0)
begin
Select UserName,EmailId from TB_Employee where EmployeeId=@EmpId
end
End
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdatePassword]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_UpdatePassword]
(
@UserName nvarchar(25),
@OldPassword nvarchar(25),
@NewPassword nvarchar(25)
)
as 
begin
Update TB_Login set Password=@NewPassword,IsPasswordChanged='Y' where Password=@OldPassword and UserName=@UserName 
end
GO
/****** Object:  StoredProcedure [dbo].[SP_ViewTickets]    Script Date: 08-01-2021 17:49:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ViewTickets]
as
begin
select TicketId,RaisedBy,Description,CreatedAt,case when Flag=0 then 'Pending' when Flag=1 then 'Completed' end as Status,EmailId from TB_Tickets t
inner join TB_Employee E on e.UserName=t.RaisedBy
end
GO
