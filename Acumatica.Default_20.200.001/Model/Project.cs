using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class Project : Entity_v4
	{

		[DataMember(Name="ActivityHistory", EmitDefaultValue=false)]
		public List<ProjectActivity> ActivityHistory { get; set; }

		[DataMember(Name="ApprovalDetails", EmitDefaultValue=false)]
		public List<Approval> ApprovalDetails { get; set; }

		[DataMember(Name="Assets", EmitDefaultValue=false)]
		public DecimalValue Assets { get; set; }

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<AttributeValue> Attributes { get; set; }

		[DataMember(Name="Balances", EmitDefaultValue=false)]
		public List<ProjectBalance> Balances { get; set; }

		[DataMember(Name="BillingAndAllocationSettings", EmitDefaultValue=false)]
		public ProjectBillingAndAllocationSettings BillingAndAllocationSettings { get; set; }

		[DataMember(Name="BillToSettings", EmitDefaultValue=false)]
		public BillToSettings BillToSettings { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee> Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment> Equipments { get; set; }

		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public DecimalValue Expenses { get; set; }

		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue ExternalRefNbr { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount GLAccounts { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue Hold { get; set; }

		[DataMember(Name="Income", EmitDefaultValue=false)]
		public DecimalValue Income { get; set; }

		[DataMember(Name="Invoices", EmitDefaultValue=false)]
		public List<ProjectProFormaDetails> Invoices { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue LastModifiedDateTime { get; set; }

		[DataMember(Name="Liabilities", EmitDefaultValue=false)]
		public DecimalValue Liabilities { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue ProjectID { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties ProjectProperties { get; set; }

		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue ProjectTemplateID { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="UnionLocals", EmitDefaultValue=false)]
		public List<ProjectUnionLocal> UnionLocals { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings VisibilitySettings { get; set; }

	}
}