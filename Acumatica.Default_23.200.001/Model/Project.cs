using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
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
		/// 
		/// Display Name:
		/// DAC Field Name: CustomerID 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Employees", EmitDefaultValue=false)]
		public List<ProjectEmployee>? Employees { get; set; }

		[DataMember(Name="Equipments", EmitDefaultValue=false)]
		public List<ProjectEquipment>? Equipments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryExpense 
		/// DAC: PX.Objects.PM.PMTaskTotal 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public DecimalValue? Expenses { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalRefNbr", EmitDefaultValue=false)]
		public StringValue? ExternalRefNbr { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public ProjectGLAccount? GLAccounts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Hold 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryIncome 
		/// DAC: PX.Objects.PM.PMTaskTotal 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Income", EmitDefaultValue=false)]
		public DecimalValue? Income { get; set; }

		[DataMember(Name="Invoices", EmitDefaultValue=false)]
		public List<ProjectProFormaDetails>? Invoices { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Liabilities", EmitDefaultValue=false)]
		public DecimalValue? Liabilities { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContractCD 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="ProjectProperties", EmitDefaultValue=false)]
		public ProjectProperties? ProjectProperties { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TemplateID 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTemplateID", EmitDefaultValue=false)]
		public StringValue? ProjectTemplateID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.PM.PMProject 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}