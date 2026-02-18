using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM303000</c> in the Acumatica ERP
	/// <para>Key Fields: EstimateID, Revision</para>
	/// </summary>
	public class Estimate : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: BranchID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Branch { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CostCodeID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Cost Code</para>
		/// </summary>
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BAccountID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// </summary>
		public StringValue? Customer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EngineerID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Engineer { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EstimateClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Estimate Class</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? EstimateClass { get; set; }

		/// <summary>
		/// Rich text description of the item/estimate
		/// <para>DAC Field Name: Body</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(MAX)</para>
		/// </summary>
		public StringValue? EstimateDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Estimate ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EstimateID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExternalRefNbr</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Ext. Ref. Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? ExtRefNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Fixed Labor Cost</para>
		/// </summary>
		public BooleanValue? FixedLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Fixed Overhead Cost</para>
		/// </summary>
		public BooleanValue? FixedOverheadOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Fixed Labor Cost</para>
		/// </summary>
		public DecimalValue? FixLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FixedOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Fixed Overhead Cost</para>
		/// </summary>
		public DecimalValue? FixOverheadCost { get; set; }

		public List<EstimateHistory>? History { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ImageUrl</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? ImageURL { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryCD</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemClassID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Item Class</para>
		/// </summary>
		public StringValue? ItemClass { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ItemDesc</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Item Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? ItemDescription { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LeadTime</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Lead Time (Days)</para>
		/// </summary>
		public IntValue? LeadTimeDays { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Lead Time</para>
		/// </summary>
		public BooleanValue? LeadTimeOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Machine Cost</para>
		/// </summary>
		public DecimalValue? MachineCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Machine Cost</para>
		/// </summary>
		public BooleanValue? MachineOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Material Cost</para>
		/// </summary>
		public DecimalValue? MaterialCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Material Cost</para>
		/// </summary>
		public BooleanValue? MaterialOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsNonInventory</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Non-Inventory</para>
		/// </summary>
		public BooleanValue? NonInventory { get; set; }

		public List<EstimateOperationDetail>? Operation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Opportunity ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OpportunityID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Order Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OwnerID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Owner { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPrimary</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public BooleanValue? Primary { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProjectID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// </summary>
		public StringValue? Project { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaskID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Project Task</para>
		/// </summary>
		public StringValue? ProjectTask { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Promise Date</para>
		/// </summary>
		public DateTimeValue? PromiseDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QuoteNbr</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Quote Nbr</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? QuoteNbrQuoteNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Quote Source</para>
		/// </summary>
		public StringValue? QuoteSource { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Quote Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? QuoteType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ReferenceMaterialCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Ref. Material Cost</para>
		/// </summary>
		public DecimalValue? RefMaterialCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Request Date</para>
		/// </summary>
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Revision Date</para>
		/// </summary>
		public DateTimeValue? RevisionDate { get; set; }

		/// <summary>
		/// Overall estimate status
		/// <para>DAC Field Name: EstimateStatus</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Subcontract Cost</para>
		/// </summary>
		public DecimalValue? SubcontractCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Subcontract Cost</para>
		/// </summary>
		public BooleanValue? SubcontractOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxCategoryID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateReference</para>
		/// <para>Display Name: Tax Category</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Tool Cost</para>
		/// </summary>
		public DecimalValue? ToolCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Tool Cost</para>
		/// </summary>
		public BooleanValue? ToolOverride { get; set; }

		/// <summary>
		/// For use in totals display without a currency view impact(hiding from currency toggle)
		/// <para>DAC Field Name: ExtCostDisplay</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Total Cost</para>
		/// </summary>
		public DecimalValue? TotalCost { get; set; }

		public EstimateTotal? Totals { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Var. Labor Cost</para>
		/// </summary>
		public BooleanValue? VariableLaborOverride { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Override Var. Overhead Cost</para>
		/// </summary>
		public BooleanValue? VariableOverheadOverride { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableLaborCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Var. Labor Cost</para>
		/// </summary>
		public DecimalValue? VarLaborCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VariableOverheadCost</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// <para>Display Name: Var. Overhead Cost</para>
		/// </summary>
		public DecimalValue? VarOverheadCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMEstimateItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string History = "History";
			public const string History_Files = "History/Files";
			public const string Operation = "Operation";
			public const string Operation_Files = "Operation/Files";
			public const string Totals = "Totals";

			//Intentionally excluded
			//public const string All = "Files,Translations,History,History/Files,Operation,Operation/Files,Totals";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}