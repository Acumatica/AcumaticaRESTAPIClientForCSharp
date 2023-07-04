using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class Estimate : Entity, ITopLevelEntity
	{

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue CostCode { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue Engineer { get; set; }

		[DataMember(Name="EstimateClass", EmitDefaultValue=false)]
		public StringValue EstimateClass { get; set; }

		[DataMember(Name="EstimateDescription", EmitDefaultValue=false)]
		public StringValue EstimateDescription { get; set; }

		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue EstimateID { get; set; }

		[DataMember(Name="ExtRefNbr", EmitDefaultValue=false)]
		public StringValue ExtRefNbr { get; set; }

		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue FixedLaborOverride { get; set; }

		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue FixedOverheadOverride { get; set; }

		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue FixLaborCost { get; set; }

		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue FixOverheadCost { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public List<EstimateHistory> History { get; set; }

		[DataMember(Name="ImageURL", EmitDefaultValue=false)]
		public StringValue ImageURL { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue ItemDescription { get; set; }

		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue LeadTimeDays { get; set; }

		[DataMember(Name="LeadTimeOverride", EmitDefaultValue=false)]
		public BooleanValue LeadTimeOverride { get; set; }

		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue MachineCost { get; set; }

		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue MachineOverride { get; set; }

		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue MaterialCost { get; set; }

		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue MaterialOverride { get; set; }

		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue NonInventory { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public List<EstimateOperationDetail> Operation { get; set; }

		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue OpportunityID { get; set; }

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue OrderNbr { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue OrderType { get; set; }

		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue Owner { get; set; }

		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue Primary { get; set; }

		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue Project { get; set; }

		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue ProjectTask { get; set; }

		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue PromiseDate { get; set; }

		[DataMember(Name="QuoteNbrQuoteNbr", EmitDefaultValue=false)]
		public StringValue QuoteNbrQuoteNbr { get; set; }

		[DataMember(Name="QuoteSource", EmitDefaultValue=false)]
		public StringValue QuoteSource { get; set; }

		[DataMember(Name="QuoteType", EmitDefaultValue=false)]
		public StringValue QuoteType { get; set; }

		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue RefMaterialCost { get; set; }

		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue RequestDate { get; set; }

		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue Revision { get; set; }

		[DataMember(Name="RevisionDate", EmitDefaultValue=false)]
		public DateTimeValue RevisionDate { get; set; }

		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue Status { get; set; }

		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue SubcontractCost { get; set; }

		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue SubcontractOverride { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue TaxCategory { get; set; }

		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue ToolCost { get; set; }

		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue ToolOverride { get; set; }

		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue TotalCost { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public EstimateTotal Totals { get; set; }

		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue VariableLaborOverride { get; set; }

		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue VariableOverheadOverride { get; set; }

		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue VarLaborCost { get; set; }

		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue VarOverheadCost { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

		public string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}