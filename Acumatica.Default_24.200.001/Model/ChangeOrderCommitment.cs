using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class ChangeOrderCommitment : Entity
	{

		/// <summary>
		/// The expense account associated with the commitment.
		/// DAC Field Name: AccountID 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The amount of the change order line in the base currency. The value can be manually modified.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// </summary>
		[DataMember(Name="Amount", EmitDefaultValue=false)]
		public DecimalValue? Amount { get; set; }

		/// <summary>
		/// The amount of the commitment in the project currency.
		/// DAC Field Name: AmountInProjectCury 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: Amount in Project Currency 
		/// </summary>
		[DataMember(Name="AmountinBaseCurrency", EmitDefaultValue=false)]
		public DecimalValue? AmountinBaseCurrency { get; set; }

		/// <summary>
		/// The identifier of the cost code associated with the change order line.
		/// DAC Field Name: CostCodeID 
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Cost Code 
		/// Key Field
		/// </summary>
		[DataMember(Name="CostCode", EmitDefaultValue=false)]
		public StringValue? CostCode { get; set; }

		/// <summary>
		/// The identifier of the commitment currency.
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: Currency 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// The description of the change order.
		/// DAC: PX.Objects.PM.PMChangeOrder 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Inventory ID 
		/// Key Field
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: POLinePM__CuryLineAmt 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="LineAmount", EmitDefaultValue=false)]
		public DecimalValue? LineAmount { get; set; }

		/// <summary>
		/// DAC Field Name: POLinePM__TranDesc 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="LineDescription", EmitDefaultValue=false)]
		public StringValue? LineDescription { get; set; }

		/// <summary>
		/// DAC Field Name: POLinePM__CalcOpenQty 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="OpenQty", EmitDefaultValue=false)]
		public DecimalValue? OpenQty { get; set; }

		/// <summary>
		/// DAC Field Name: POLinePM__OrderDate 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="OrderDate", EmitDefaultValue=false)]
		public DateTimeValue? OrderDate { get; set; }

		/// <summary>
		/// DAC Field Name: POLinePM__OrderQty 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="OrderQty", EmitDefaultValue=false)]
		public DecimalValue? OrderQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: PO Line Nbr. 
		/// </summary>
		[DataMember(Name="POLineNbr", EmitDefaultValue=false)]
		public IntValue? POLineNbr { get; set; }

		/// <summary>
		/// The reference number of the purchase order associated with the commitment.
		/// DAC Field Name: POOrderNbr 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: PO Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="PONbr", EmitDefaultValue=false)]
		public StringValue? PONbr { get; set; }

		/// <summary>
		/// The sum of the amount and the original amount of the purchase order line associated with the commitment.
		/// DAC Field Name: PotentialRevisedAmount 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="PotentiallyRevisedAmount", EmitDefaultValue=false)]
		public DecimalValue? PotentiallyRevisedAmount { get; set; }

		/// <summary>
		/// The sum of the quantity and original quantity of the purchase order line associated with the commitment.
		/// DAC Field Name: PotentialRevisedQty 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="PotentiallyRevisedQty", EmitDefaultValue=false)]
		public DecimalValue? PotentiallyRevisedQty { get; set; }

		/// <summary>
		/// The identifier of the Task associated with the commitment.
		/// DAC Field Name: TaskID 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: Project Task 
		/// </summary>
		[DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
		public StringValue? ProjectTaskID { get; set; }

		/// <summary>
		/// The quantity of the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// Display Name: Quantity 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

		/// <summary>
		/// The status of the commitment line of the change order.
		/// DAC Field Name: LineType 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The cost of the specified unit of the commitment. The value can be manually modified.
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: Unit Cost 
		/// </summary>
		[DataMember(Name="UnitCost", EmitDefaultValue=false)]
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// The unit of measure of the change order line.
		/// DAC: PX.Objects.PM.PMChangeOrderCostBudget 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: VendorID 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// </summary>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// The type of the purchase order associated with the commitment.
		/// DAC Field Name: POOrderType 
		/// DAC: PX.Objects.PM.PMChangeOrderLine 
		/// Display Name: PO Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="POType", EmitDefaultValue=false)]
		public StringValue? POType { get; set; }

	}
}