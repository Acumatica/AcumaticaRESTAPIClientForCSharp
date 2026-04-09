using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
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

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee>? Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment>? Equipments { get; set; }

		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public DecimalValue? Expenses { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount? GLAccounts { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="Income", EmitDefaultValue=false)]
		public DecimalValue? Income { get; set; }

		[DataMember(Name="Invoices", EmitDefaultValue=false)]
		public List<ProjectProFormaDetails>? Invoices { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Liabilities", EmitDefaultValue=false)]
		public DecimalValue? Liabilities { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties? ProjectProperties { get; set; }

		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

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
			return "entity/Default/26.200.001";
		}
	}
}