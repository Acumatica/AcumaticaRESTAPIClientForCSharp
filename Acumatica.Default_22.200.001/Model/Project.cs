using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PM301000 in the Acumatica ERP
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
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// The project description.
		/// DAC: PX.Objects.PM.PMProject 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee>? Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment>? Equipments { get; set; }

		/// <summary>
		/// DAC Field Name: CuryExpense 
		/// DAC: PX.Objects.PM.PMTaskTotal 
		/// Display Name: Expense 
		/// </summary>
		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public DecimalValue? Expenses { get; set; }

		/// <summary>
		/// The external reference number (such as an identifier required by the customer or a number from an external system integrated with Acumatica ERP) entered            manually.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// Display Name: External Ref. Nbr. 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount? GLAccounts { get; set; }

		/// <summary>
		/// Specifies (if set to true) that the project is on hold.
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC Field Name: CuryIncome 
		/// DAC: PX.Objects.PM.PMTaskTotal 
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
		/// DAC Field Name: ContractCD 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Project ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties? ProjectProperties { get; set; }

		/// <summary>
		/// The template for the project.
		/// DAC Field Name: TemplateID 
		/// DAC: PX.Objects.PM.PMProject 
		/// Display Name: Template 
		/// </summary>
		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// The status of the project.
		/// DAC: PX.Objects.PM.PMProject 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="UnionLocals", EmitDefaultValue=false)]
		public List<ProjectUnionLocal>? UnionLocals { get; set; }

		[DataMember(Name="VisibilitySettings", EmitDefaultValue=false)]
		public VisibilitySettings? VisibilitySettings { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}