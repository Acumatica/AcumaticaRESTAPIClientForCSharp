using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	[DataContract]
	public class LaborEntryDetail : Entity
	{

		[DataMember(Name="Allocations", EmitDefaultValue=false)]
		public List<LaborEntryDetailAllocation>? Allocations { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Employee ID 
		/// </summary>
		[DataMember(Name="EmployeeID", EmitDefaultValue=false)]
		public StringValue? EmployeeID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: End Time 
		/// </summary>
		[DataMember(Name="EndTime", EmitDefaultValue=false)]
		public DateTimeValue? EndTime { get; set; }

		/// <summary>
		/// DAC Field Name: ExpireDate 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// DAC Field Name: GLLineNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: GL Batch Line Nbr 
		/// </summary>
		[DataMember(Name="GLBatchLineNbr", EmitDefaultValue=false)]
		public IntValue? GLBatchLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: GLBatNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: GL Batch Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="GLBatchNbr", EmitDefaultValue=false)]
		public StringValue? GLBatchNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Doc Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="INDocType", EmitDefaultValue=false)]
		public StringValue? INDocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Line Nbr 
		/// </summary>
		[DataMember(Name="INLineNbr", EmitDefaultValue=false)]
		public IntValue? INLineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: INBatNbr 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: IN Ref Nbr 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="INRefNbr", EmitDefaultValue=false)]
		public StringValue? INRefNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: ExtCost 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Labor Amount 
		/// </summary>
		[DataMember(Name="LaborAmount", EmitDefaultValue=false)]
		public DecimalValue? LaborAmount { get; set; }

		/// <summary>
		/// DAC Field Name: LaborCodeID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Labor Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="LaborCode", EmitDefaultValue=false)]
		public StringValue? LaborCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Labor Rate 
		/// </summary>
		[DataMember(Name="LaborRate", EmitDefaultValue=false)]
		public DecimalValue? LaborRate { get; set; }

		[DataMember(Name="LaborTime", EmitDefaultValue=false)]
		public IntValue? LaborTime { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Labor Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="LaborType", EmitDefaultValue=false)]
		public StringValue? LaborType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC Field Name: OperationID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationNbr", EmitDefaultValue=false)]
		public StringValue? OperationNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC Field Name: IsScrap 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Qty is Scrap 
		/// </summary>
		[DataMember(Name="QtyisScrap", EmitDefaultValue=false)]
		public BooleanValue? QtyisScrap { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Qty Scrapped 
		/// </summary>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// DAC Field Name: ReasonCodeID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// Record the original receipt number for negative move adjustments
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Receipt Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
		public StringValue? ReceiptNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Scrap Action 
		/// </summary>
		[DataMember(Name="ScrapAction", EmitDefaultValue=false)]
		public StringValue? ScrapAction { get; set; }

		/// <summary>
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.AM.AMMTran 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="Shift", EmitDefaultValue=false)]
		public StringValue? Shift { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Start Time 
		/// </summary>
		[DataMember(Name="StartTime", EmitDefaultValue=false)]
		public DateTimeValue? StartTime { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// A brief description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="TranDescription", EmitDefaultValue=false)]
		public StringValue? TranDescription { get; set; }

		[DataMember(Name="TransactionAttributes", EmitDefaultValue=false)]
		public List<LaborEntryTranAttributes>? TransactionAttributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// SQL Type: nvarchar(6) 
		/// </summary>
		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}