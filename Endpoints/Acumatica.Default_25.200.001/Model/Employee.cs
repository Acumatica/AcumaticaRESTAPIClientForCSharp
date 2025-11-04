using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen EP203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Employee : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="CompanyTreeInfo", EmitDefaultValue=false)]
		public List<CompanyTree>? CompanyTreeInfo { get; set; }

		[DataMember(Name="ContactInfo", EmitDefaultValue=false)]
		public Contact? ContactInfo { get; set; }

		[DataMember(Name="Delegates", EmitDefaultValue=false)]
		public List<EmployeeDelegate>? Delegates { get; set; }

		/// <summary>
		/// The human-readable identifier of the employee that isspecified by the user or defined by the EMPLOYEE auto-numbering sequence during thecreation of the employee. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// DAC Field Name: AcctCD 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The employee name, which is usually a concatenation of thefirst and last nameof the appropriate contact.
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// Display Name: Employee Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue? EmployeeName { get; set; }

		[DataMember(Name="EmployeeSettings", EmitDefaultValue=false)]
		public EmployeeSettings? EmployeeSettings { get; set; }

		[DataMember(Name="EmploymentHistory", EmitDefaultValue=false)]
		public List<EmploymentHistoryRecord>? EmploymentHistory { get; set; }

		[DataMember(Name="FinancialSettings", EmitDefaultValue=false)]
		public EmployeeFinancialSettings? FinancialSettings { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The status of the employee.
		/// DAC Field Name: VStatus 
		/// DAC: PX.Objects.EP.EPEmployee 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";
			public const string CompanyTreeInfo = "CompanyTreeInfo";
			public const string CompanyTreeInfo_Files = "CompanyTreeInfo/Files";
			public const string ContactInfo = "ContactInfo";
			public const string ContactInfo_Activities = "ContactInfo/Activities";
			public const string ContactInfo_Activities_Files = "ContactInfo/Activities/Files";
			public const string ContactInfo_Address = "ContactInfo/Address";
			public const string ContactInfo_Attributes = "ContactInfo/Attributes";
			public const string ContactInfo_Campaigns = "ContactInfo/Campaigns";
			public const string ContactInfo_Campaigns_Files = "ContactInfo/Campaigns/Files";
			public const string ContactInfo_Cases = "ContactInfo/Cases";
			public const string ContactInfo_Cases_Files = "ContactInfo/Cases/Files";
			public const string ContactInfo_Duplicates = "ContactInfo/Duplicates";
			public const string ContactInfo_Duplicates_Files = "ContactInfo/Duplicates/Files";
			public const string ContactInfo_MarketingLists = "ContactInfo/MarketingLists";
			public const string ContactInfo_MarketingLists_Files = "ContactInfo/MarketingLists/Files";
			public const string ContactInfo_Notifications = "ContactInfo/Notifications";
			public const string ContactInfo_Notifications_Files = "ContactInfo/Notifications/Files";
			public const string ContactInfo_Opportunities = "ContactInfo/Opportunities";
			public const string ContactInfo_Opportunities_Files = "ContactInfo/Opportunities/Files";
			public const string ContactInfo_Relations = "ContactInfo/Relations";
			public const string ContactInfo_Relations_Files = "ContactInfo/Relations/Files";
			public const string ContactInfo_RoleAssignments = "ContactInfo/RoleAssignments";
			public const string ContactInfo_RoleAssignments_Files = "ContactInfo/RoleAssignments/Files";
			public const string ContactInfo_UserInfo = "ContactInfo/UserInfo";
			public const string ContactInfo_UserInfo_Roles = "ContactInfo/UserInfo/Roles";
			public const string ContactInfo_UserInfo_Roles_Files = "ContactInfo/UserInfo/Roles/Files";
			public const string Delegates = "Delegates";
			public const string Delegates_Files = "Delegates/Files";
			public const string EmployeeSettings = "EmployeeSettings";
			public const string EmploymentHistory = "EmploymentHistory";
			public const string EmploymentHistory_Files = "EmploymentHistory/Files";
			public const string FinancialSettings = "FinancialSettings";
			public const string FinancialSettings_PaymentInstructions = "FinancialSettings/PaymentInstructions";
			public const string FinancialSettings_PaymentInstructions_Files = "FinancialSettings/PaymentInstructions/Files";

			//Intentionally excluded
			//public const string All = "Files,Attributes,CompanyTreeInfo,CompanyTreeInfo/Files,ContactInfo,ContactInfo/Activities,ContactInfo/Activities/Files,ContactInfo/Address,ContactInfo/Attributes,ContactInfo/Campaigns,ContactInfo/Campaigns/Files,ContactInfo/Cases,ContactInfo/Cases/Files,ContactInfo/Duplicates,ContactInfo/Duplicates/Files,ContactInfo/MarketingLists,ContactInfo/MarketingLists/Files,ContactInfo/Notifications,ContactInfo/Notifications/Files,ContactInfo/Opportunities,ContactInfo/Opportunities/Files,ContactInfo/Relations,ContactInfo/Relations/Files,ContactInfo/RoleAssignments,ContactInfo/RoleAssignments/Files,ContactInfo/UserInfo,ContactInfo/UserInfo/Roles,ContactInfo/UserInfo/Roles/Files,Delegates,Delegates/Files,EmployeeSettings,EmploymentHistory,EmploymentHistory/Files,FinancialSettings,FinancialSettings/PaymentInstructions,FinancialSettings/PaymentInstructions/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}