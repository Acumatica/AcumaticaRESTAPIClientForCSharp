using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>EP203000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeeID</para>
	/// </summary>
	public class Employee : Entity, ITopLevelEntity
	{

		public List<AttributeValue>? Attributes { get; set; }

		public Contact? ContactInfo { get; set; }

		public List<EmployeeDelegate>? Delegates { get; set; }

		/// <summary>
		/// The human-readable identifier of the employee that isspecified by the user or defined by the EMPLOYEE auto-numbering sequence during thecreation of the employee. This field is a natural key, as opposedto the surrogate key BAccountID.
		/// <para>DAC Field Name: AcctCD</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Employee ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// The employee name, which is usually a concatenation of thefirst and last nameof the appropriate contact.
		/// <para>DAC Field Name: AcctName</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Employee Name</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? EmployeeName { get; set; }

		public EmployeeSettings? EmployeeSettings { get; set; }

		public List<EmploymentHistoryRecord>? EmploymentHistory { get; set; }

		public EmployeeFinancialSettings? FinancialSettings { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The status of the employee.
		/// <para>DAC Field Name: VStatus</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
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
			//public const string All = "Files,Translations,Attributes,ContactInfo,ContactInfo/Activities,ContactInfo/Activities/Files,ContactInfo/Address,ContactInfo/Attributes,ContactInfo/Campaigns,ContactInfo/Campaigns/Files,ContactInfo/Cases,ContactInfo/Cases/Files,ContactInfo/Duplicates,ContactInfo/Duplicates/Files,ContactInfo/MarketingLists,ContactInfo/MarketingLists/Files,ContactInfo/Notifications,ContactInfo/Notifications/Files,ContactInfo/Opportunities,ContactInfo/Opportunities/Files,ContactInfo/Relations,ContactInfo/Relations/Files,ContactInfo/RoleAssignments,ContactInfo/RoleAssignments/Files,ContactInfo/UserInfo,ContactInfo/UserInfo/Roles,ContactInfo/UserInfo/Roles/Files,Delegates,Delegates/Files,EmployeeSettings,EmploymentHistory,EmploymentHistory/Files,FinancialSettings,FinancialSettings/PaymentInstructions,FinancialSettings/PaymentInstructions/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}