using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>EP203000</c> in the Acumatica ERP
	/// <para>Key Fields: EmployeeID</para>
	/// </summary>
	public class Employee : Entity, ITopLevelEntity
	{

		#region Fields
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

		/// <summary>
		/// The status of the employee.
		/// <para>DAC Field Name: VStatus</para>
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// The identifier of the employee class that the employee belongs to.
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Employee Class</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? VendorClassID { get; set; }

		/// <summary>
		/// Identifier of the employee department that the employee belongs to.
		/// <para>DAC: PX.Objects.EP.EPEmployee</para>
		/// <para>Display Name: Department</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? DepartmentID { get; set; }

		/// <summary>
		/// The date and time when the record was created.
		/// <para>DAC: PX.Objects.CR.CRPMTimeActivity</para>
		/// <para>Display Name: Created At</para>
		/// </summary>
		public DateTimeValue? CreatedDateTime { get; set; }

		public StringValue? DisplayName { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public Contact? ContactInfo { get; set; }

		public EmployeeSettings? EmployeeSettings { get; set; }

		public EmployeeFinancialSettings? FinancialSettings { get; set; }

		#endregion

		#region Details
		public List<AttributeValue>? Attributes { get; set; }

		public List<CompanyTree>? CompanyTreeInfo { get; set; }

		public List<EmployeeDelegate>? Delegates { get; set; }

		public List<EmploymentHistoryRecord>? EmploymentHistory { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(Employee)} - \"{EmployeeID}\"";
		}

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string CompanyTreeInfo = "CompanyTreeInfo";
			public const string ContactInfo = "ContactInfo";
			public const string Delegates = "Delegates";
			public const string EmployeeSettings = "EmployeeSettings";
			public const string EmploymentHistory = "EmploymentHistory";
			public const string FinancialSettings = "FinancialSettings";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,CompanyTreeInfo,ContactInfo,Delegates,EmployeeSettings,EmploymentHistory,FinancialSettings";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}