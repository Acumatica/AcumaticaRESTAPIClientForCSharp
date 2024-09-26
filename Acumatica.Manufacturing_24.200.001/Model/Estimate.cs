using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM303000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Estimate : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EngineerID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateClass", EmitDefaultValue=false)]
		public StringValue? EstimateClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateDescription", EmitDefaultValue=false)]
		public StringValue? EstimateDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExternalRefNbr 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExtRefNbr", EmitDefaultValue=false)]
		public StringValue? ExtRefNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedLaborOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FixedOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? FixOverheadCost { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public List<EstimateHistory>? History { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ImageUrl 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ImageURL", EmitDefaultValue=false)]
		public StringValue? ImageURL { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ItemDesc 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue? ItemDescription { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LeadTime 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LeadTimeOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LeadTimeOverride", EmitDefaultValue=false)]
		public BooleanValue? LeadTimeOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MachineOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MaterialOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsNonInventory 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue? NonInventory { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public List<EstimateOperationDetail>? Operation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OpportunityID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderNbr 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrderType 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPrimary 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue? Primary { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PromiseDate 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QuoteNbr 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QuoteNbrQuoteNbr", EmitDefaultValue=false)]
		public StringValue? QuoteNbrQuoteNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QuoteSource 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QuoteSource", EmitDefaultValue=false)]
		public StringValue? QuoteSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: QuoteType 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="QuoteType", EmitDefaultValue=false)]
		public StringValue? QuoteType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequestDate 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RevisionDate 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RevisionDate", EmitDefaultValue=false)]
		public DateTimeValue? RevisionDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EstimateStatus 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubcontractOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToolOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue? ToolOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtCostDisplay 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public EstimateTotal? Totals { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableLaborOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableOverheadOverride 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VariableOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}