using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM301000</c> in the Acumatica ERP
	/// <para>Key Fields: ProjectID</para>
	/// </summary>
	[DataContract]
	public class Project : Entity, ITopLevelEntity
	{

		[DataMember(Name="ActivityHistory", EmitDefaultValue=false)]
		public List<ProjectActivity>? ActivityHistory { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval>? ApprovalDetails { get; set; }

		[DataMember(Name="Assets", EmitDefaultValue=false)]
		public DecimalValue? Assets { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue>? Attributes { get; set; }

		[DataMember(Name="Balances", EmitDefaultValue=false)]
		public List<ProjectBalance>? Balances { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectBillingAndAllocationSettings? BillingAndAllocationSettings { get; set; }

		[DataMember(Name="BillToSettings", EmitDefaultValue=false)]
		public BillToSettings? BillToSettings { get; set; }

		/// <summary>
		/// The identifier of the customer for the project. Projects can be of the internal or external type. Internal projects are those that have the value of this            property equal to NULL and hense are not billable.
		/// <para>DAC Field Name: CustomerID</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The project description.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee>? Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment>? Equipments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryExpense</para>
		/// <para>DAC: PX.Objects.PM.PMTaskTotal</para>
		/// <para>Display Name: Expense</para>
		/// </summary>
		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public DecimalValue? Expenses { get; set; }

		/// <summary>
		/// The external reference number (such as an identifier required by the customer or a number from an external system integrated with Acumatica ERP) entered            manually.
		/// <para>DAC Field Name: ExtRefNbr</para>
		/// <para>DAC: PX.Objects.PM.PMChangeOrder</para>
		/// <para>Display Name: External Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount? GLAccounts { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the project is on hold.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CuryIncome</para>
		/// <para>DAC: PX.Objects.PM.PMTaskTotal</para>
		/// </summary>
		[DataMember(Name="Income", EmitDefaultValue=false)]
		public DecimalValue? Income { get; set; }

		[DataMember(Name="Invoices", EmitDefaultValue=false)]
		public List<ProjectProFormaDetails>? Invoices { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Liabilities", EmitDefaultValue=false)]
		public DecimalValue? Liabilities { get; set; }

		/// <summary>
		/// The project CD. This is a segmented key. Its format is configured on the Segmented Keys (CS202000) form.
		/// <para>DAC Field Name: ContractCD</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Project ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties? ProjectProperties { get; set; }

		/// <summary>
		/// The template for the project.
		/// <para>DAC Field Name: TemplateID</para>
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>Display Name: Template</para>
		/// </summary>
		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The status of the project.
		/// <para>DAC: PX.Objects.PM.PMProject</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnionLocals", EmitDefaultValue=false)]
		public List<ProjectUnionLocal>? UnionLocals { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		[DataMember(Name="Retainage", EmitDefaultValue=false)]
		public ProjectRetainage? Retainage { get; set; }

		[DataMember(Name="ProjectAddress", EmitDefaultValue=false)]
		public ProjectAddress? ProjectAddress { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
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
			//public const string All = "Files,ActivityHistory,ActivityHistory/Files,ApprovalDetails,ApprovalDetails/Files,Attributes,Balances,Balances/Files,BillingAndAllocationSettings,BillToSettings,BillToSettings/BillToAddress,BillToSettings/BillToContact,Employees,Employees/Files,Equipments,Equipments/Files,GLAccounts,GLAccounts/DefaultTaskForGLAccounts,GLAccounts/DefaultTaskForGLAccounts/Files,Invoices,Invoices/Files,ProjectProperties,UnionLocals,UnionLocals/Files,VisibilitySettings,Retainage,ProjectAddress";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}