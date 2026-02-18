using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM301000</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectID</para>
	/// </summary>
	public class Project : Entity, ITopLevelEntity
	{

		public List<ProjectActivity>? ActivityHistory { get; set; }

		public List<Approval>? ApprovalDetails { get; set; }

		public DecimalValue? Assets { get; set; }

		public List<AttributeValue>? Attributes { get; set; }

		public List<ProjectBalance>? Balances { get; set; }

		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		public BillToSettings? BillToSettings { get; set; }

		/// <summary>
		/// The identifier of the customer for the project. Projects can be of the internal or external type. Internal projects are those that have the value of this            property equal to NULL and hense are not billable.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The project description.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<ProjectEmployee>? Employees { get; set; }

		public List<ProjectEquipment>? Equipments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExpense</para>
		/// <para>DAC: PX.Objects.PM.PMTaskTotal</para>
		/// <para>Display Name: Expense</para>
		/// </summary>
		public DecimalValue? Expenses { get; set; }

		/// <summary>
		/// The external reference number (such as an identifier required by the customer or a number from an external system integrated with Acumatica ERP) entered            manually.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: External Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? ExternalRefNbr { get; set; }

		public ProjectGLAccount? GLAccounts { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the project is on hold.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// </summary>
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryIncome</para>
		/// <para>DAC: PX.Objects.PM.PMTaskTotal</para>
		/// </summary>
		public DecimalValue? Income { get; set; }

		public List<ProjectProFormaDetails>? Invoices { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public DecimalValue? Liabilities { get; set; }

		/// <summary>
		/// The project CD. This is a segmented key. Its format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: ContractCD</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Project ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		public StringValue? ProjectID { get; set; }

		public ProjectProperties? ProjectProperties { get; set; }

		/// <summary>
		/// The template for the project.
		/// <para>DAC Field Name: TemplateID</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Template</para>
		/// </summary>
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The status of the project.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<ProjectUnionLocal>? UnionLocals { get; set; }

		public VisibilitySettings? VisibilitySettings { get; set; }

		public ProjectRetainage? Retainage { get; set; }

		public ProjectAddress? ProjectAddress { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string ActivityHistory = "ActivityHistory";
			public const string ActivityHistory_Files = "ActivityHistory/Files";
			public const string ApprovalDetails = "ApprovalDetails";
			public const string ApprovalDetails_Files = "ApprovalDetails/Files";
			public const string Attributes = "Attributes";
			public const string Balances = "Balances";
			public const string Balances_Files = "Balances/Files";
			public const string BillingAndAllocationSettings = "BillingAndAllocationSettings";
			public const string BillToSettings = "BillToSettings";
			public const string BillToSettings_BillToAddress = "BillToSettings/BillToAddress";
			public const string BillToSettings_BillToContact = "BillToSettings/BillToContact";
			public const string Employees = "Employees";
			public const string Employees_Files = "Employees/Files";
			public const string Equipments = "Equipments";
			public const string Equipments_Files = "Equipments/Files";
			public const string GLAccounts = "GLAccounts";
			public const string GLAccounts_DefaultTaskForGLAccounts = "GLAccounts/DefaultTaskForGLAccounts";
			public const string GLAccounts_DefaultTaskForGLAccounts_Files = "GLAccounts/DefaultTaskForGLAccounts/Files";
			public const string Invoices = "Invoices";
			public const string Invoices_Files = "Invoices/Files";
			public const string ProjectProperties = "ProjectProperties";
			public const string UnionLocals = "UnionLocals";
			public const string UnionLocals_Files = "UnionLocals/Files";
			public const string VisibilitySettings = "VisibilitySettings";
			public const string Retainage = "Retainage";
			public const string ProjectAddress = "ProjectAddress";

			//Intentionally excluded
			//public const string All = "Files,Translations,ActivityHistory,ActivityHistory/Files,ApprovalDetails,ApprovalDetails/Files,Attributes,Balances,Balances/Files,BillingAndAllocationSettings,BillToSettings,BillToSettings/BillToAddress,BillToSettings/BillToContact,Employees,Employees/Files,Equipments,Equipments/Files,GLAccounts,GLAccounts/DefaultTaskForGLAccounts,GLAccounts/DefaultTaskForGLAccounts/Files,Invoices,Invoices/Files,ProjectProperties,UnionLocals,UnionLocals/Files,VisibilitySettings,Retainage,ProjectAddress";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}