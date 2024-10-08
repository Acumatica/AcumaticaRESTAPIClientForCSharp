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
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Cost Code 
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue? Customer { get; set; }

		/// <summary>
		/// DAC Field Name: EngineerID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Engineer", EmitDefaultValue=false)]
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// DAC Field Name: EstimateClassID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Estimate Class 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="EstimateClass", EmitDefaultValue=false)]
		public StringValue? EstimateClass { get; set; }

		/// <summary>
		/// Rich text description of the item/estimate
		/// DAC Field Name: Body 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Description 
		/// SQL Type: nvarchar(MAX) 
		/// </summary>
		[DataMember(Name="EstimateDescription", EmitDefaultValue=false)]
		public StringValue? EstimateDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Estimate ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EstimateID", EmitDefaultValue=false)]
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// DAC Field Name: ExternalRefNbr 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Ext. Ref. Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ExtRefNbr", EmitDefaultValue=false)]
		public StringValue? ExtRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixedLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixedOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// DAC Field Name: FixedLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Fixed Labor Cost 
		/// </summary>
		[DataMember(Name="FixLaborCost", EmitDefaultValue=false)]
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: FixedOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Fixed Overhead Cost 
		/// </summary>
		[DataMember(Name="FixOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? FixOverheadCost { get; set; }

		[DataMember(Name="History", EmitDefaultValue=false)]
		public List<EstimateHistory>? History { get; set; }

		/// <summary>
		/// DAC Field Name: ImageUrl 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="ImageURL", EmitDefaultValue=false)]
		public StringValue? ImageURL { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryCD 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Inventory ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ItemClassID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Item Class 
		/// </summary>
		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// DAC Field Name: ItemDesc 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Item Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="ItemDescription", EmitDefaultValue=false)]
		public StringValue? ItemDescription { get; set; }

		/// <summary>
		/// DAC Field Name: LeadTime 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Lead Time (Days) 
		/// </summary>
		[DataMember(Name="LeadTimeDays", EmitDefaultValue=false)]
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Lead Time 
		/// </summary>
		[DataMember(Name="LeadTimeOverride", EmitDefaultValue=false)]
		public BooleanValue? LeadTimeOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Machine Cost 
		/// </summary>
		[DataMember(Name="MachineCost", EmitDefaultValue=false)]
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Machine Cost 
		/// </summary>
		[DataMember(Name="MachineOverride", EmitDefaultValue=false)]
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Material Cost 
		/// </summary>
		[DataMember(Name="MaterialCost", EmitDefaultValue=false)]
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Material Cost 
		/// </summary>
		[DataMember(Name="MaterialOverride", EmitDefaultValue=false)]
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// DAC Field Name: IsNonInventory 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Non-Inventory 
		/// </summary>
		[DataMember(Name="NonInventory", EmitDefaultValue=false)]
		public BooleanValue? NonInventory { get; set; }

		[DataMember(Name="Operation", EmitDefaultValue=false)]
		public List<EstimateOperationDetail>? Operation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Opportunity ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="OpportunityID", EmitDefaultValue=false)]
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Order Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: OwnerID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Owner", EmitDefaultValue=false)]
		public StringValue? Owner { get; set; }

		/// <summary>
		/// DAC Field Name: IsPrimary 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Primary", EmitDefaultValue=false)]
		public BooleanValue? Primary { get; set; }

		/// <summary>
		/// DAC Field Name: ProjectID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// </summary>
		[DataMember(Name="Project", EmitDefaultValue=false)]
		public StringValue? Project { get; set; }

		/// <summary>
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTask", EmitDefaultValue=false)]
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Promise Date 
		/// </summary>
		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// DAC Field Name: QuoteNbr 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Quote Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="QuoteNbrQuoteNbr", EmitDefaultValue=false)]
		public StringValue? QuoteNbrQuoteNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Quote Source 
		/// </summary>
		[DataMember(Name="QuoteSource", EmitDefaultValue=false)]
		public StringValue? QuoteSource { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Quote Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="QuoteType", EmitDefaultValue=false)]
		public StringValue? QuoteType { get; set; }

		/// <summary>
		/// DAC Field Name: ReferenceMaterialCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Ref. Material Cost 
		/// </summary>
		[DataMember(Name="RefMaterialCost", EmitDefaultValue=false)]
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Request Date 
		/// </summary>
		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Revision Date 
		/// </summary>
		[DataMember(Name="RevisionDate", EmitDefaultValue=false)]
		public DateTimeValue? RevisionDate { get; set; }

		/// <summary>
		/// Overall estimate status
		/// DAC Field Name: EstimateStatus 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractCost", EmitDefaultValue=false)]
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Subcontract Cost 
		/// </summary>
		[DataMember(Name="SubcontractOverride", EmitDefaultValue=false)]
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.AM.AMEstimateReference 
		/// Display Name: Tax Category 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Tool Cost 
		/// </summary>
		[DataMember(Name="ToolCost", EmitDefaultValue=false)]
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Tool Cost 
		/// </summary>
		[DataMember(Name="ToolOverride", EmitDefaultValue=false)]
		public BooleanValue? ToolOverride { get; set; }

		/// <summary>
		/// For use in totals display without a currency view impact(hiding from currency toggle)
		/// DAC Field Name: ExtCostDisplay 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Total Cost 
		/// </summary>
		[DataMember(Name="TotalCost", EmitDefaultValue=false)]
		public DecimalValue? TotalCost { get; set; }

		[DataMember(Name="Totals", EmitDefaultValue=false)]
		public EstimateTotal? Totals { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VariableLaborOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Override Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VariableOverheadOverride", EmitDefaultValue=false)]
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// DAC Field Name: VariableLaborCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Var. Labor Cost 
		/// </summary>
		[DataMember(Name="VarLaborCost", EmitDefaultValue=false)]
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// DAC Field Name: VariableOverheadCost 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// Display Name: Var. Overhead Cost 
		/// </summary>
		[DataMember(Name="VarOverheadCost", EmitDefaultValue=false)]
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMEstimateItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}