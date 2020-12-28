USE [Totalligent]
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_InsCompanyRegister]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  UserDefinedTableType [dbo].[UDT_ProducerMaster]    Script Date: 29-12-2020 01:07:14 ******/
CREATE TYPE [dbo].[UDT_ProducerMaster] AS TABLE(
	[MasterType] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[EmailId] [nvarchar](100) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[UDT_RegisterClient]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_AgentMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_BrokerMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_CategoryMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_ClientCompanyMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_DiagnosticsMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_DrugMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_Employee]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_HospitalMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_InsuranceCompanyMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_LabMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_Login]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_ProducerMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
	[EntryType] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Quotation]    Script Date: 29-12-2020 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Quotation](
	[QuotationId] [bigint] IDENTITY(1,1) NOT NULL,
	[AnnualbenefitLimit] [bigint] NULL,
	[Geographicalscope] [nvarchar](200) NULL,
	[GeoScopeEmergencytreat] [nvarchar](200) NULL,
	[CovCriteriaforTreat] [nvarchar](200) NULL,
	[NetworkApplicable] [nvarchar](200) NULL,
	[UWterms] [nvarchar](200) NULL,
	[HospitalClass] [nvarchar](200) NULL,
	[Hospitalaccomdation] [nvarchar](200) NULL,
	[ICUTreat] [nvarchar](200) NULL,
	[ConsultantsFees] [nvarchar](200) NULL,
	[VariousTherapies] [nvarchar](200) NULL,
	[Organtransplant] [nvarchar](200) NULL,
	[MedicalEquipments] [nvarchar](200) NULL,
	[AmbulanceServices] [nvarchar](200) NULL,
	[Beneficiaryexpences] [nvarchar](200) NULL,
	[IPtreatmentinGOVhospita] [nvarchar](200) NULL,
	[RepatriationCosts] [nvarchar](200) NULL,
	[PhysicianConsultation] [nvarchar](200) NULL,
	[Diagnostics] [nvarchar](200) NULL,
	[Pharmaceuticals] [nvarchar](200) NULL,
	[Physiotheraphy] [nvarchar](200) NULL,
	[DaycareTreatment] [nvarchar](200) NULL,
	[OutPatientSurgery] [nvarchar](200) NULL,
	[WorkRelatedInjuries] [nvarchar](200) NULL,
	[DentalTreatment] [nvarchar](200) NULL,
	[NewBornBabyCoverage] [nvarchar](200) NULL,
	[NursingatHome] [nvarchar](200) NULL,
	[AlternativeMedicineBenefits] [nvarchar](200) NULL,
	[OutsideOmanfreeaccess] [nvarchar](200) NULL,
	[AddedOn] [datetime] NULL,
	[AddedBy] [nvarchar](50) NULL,
	[UpdatedOn] [datetime] NULL,
	[UpdatedBy] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[QuotationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_RegisterClient]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_RegisterCompany]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_RegisterInsCompany]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_ReInsurerMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_Role]    Script Date: 29-12-2020 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TB_Tickets]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  Table [dbo].[TB_UserTypeMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
SET IDENTITY_INSERT [dbo].[TB_Login] OFF
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
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (1, N'ADMIN')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (2, N'EMPLOYEE')
GO
INSERT [dbo].[TB_Role] ([RoleId], [Description]) VALUES (3, N'INSURANCE COMPANY EMPLOYEE / TPA EMPLOYEE')
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TB_Produ__C9F28456238B9459]    Script Date: 29-12-2020 01:07:14 ******/
ALTER TABLE [dbo].[TB_ProducerMaster] ADD UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
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
ALTER TABLE [dbo].[TB_Quotation] ADD  DEFAULT (getdate()) FOR [UpdatedOn]
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
/****** Object:  StoredProcedure [dbo].[SP_Clients]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CloseTicket]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_CompanyRegistration]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_EmployeeRegistration]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_GetCompanies]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_GetLoginInfo]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_GetRoles]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_GetUserType]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertAgentMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertBrokerMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertClientCompanyMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertDiagnosticsMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertDrugMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertHospitalMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertInsCompanyMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertLabMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_InsertProducerMaster]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ProducerMasterUpload]    Script Date: 29-12-2020 01:07:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_ProducerMasterUpload] (@UDT_ProducerMaster dbo.UDT_ProducerMaster 
readonly,
@UserName nvarchar(100)) 
AS 
  BEGIN 
     
		
		insert into tb_producermaster(MasterType,Name,EmailId,AddedBy,EntryType)
select MasterType,Name,EmailId,@UserName,'Bulk Upload'  from  @UDT_ProducerMaster 
			
        
		select distinct PM.EmailId,PM.UserName,PM.Password from TB_ProducerMaster PM
		inner join @UDT_ProducerMaster UDT on UDT.EmailId=PM.EmailId

  END 
GO
/****** Object:  StoredProcedure [dbo].[SP_RaiseTicket]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_RegisterClient]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_RegisterInsCompany]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ResetPassword]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_SaveLogin]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_TPAInsEmployeeRegistration]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_UpdatePassword]    Script Date: 29-12-2020 01:07:14 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ViewTickets]    Script Date: 29-12-2020 01:07:14 ******/
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
