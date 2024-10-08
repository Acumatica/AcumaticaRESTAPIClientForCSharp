using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class WipAdjustmentEntryDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// DAC Field Name: TranAmt 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="CostAdj", EmitDefaultValue=false)]
		public DecimalValue? CostAdj { get; set; }

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
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Qty Scrapped 
		/// </summary>
		[DataMember(Name="QtyScrapped", EmitDefaultValue=false)]
		public DecimalValue? QtyScrapped { get; set; }

		/// <summary>
		/// DAC Field Name: ReasonCodeID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Reason Code 
		/// SQL Type: nvarchar(20) 
		/// </summary>
		[DataMember(Name="ReasonCode", EmitDefaultValue=false)]
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

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

		/// <summary>
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Tran. Type 
		/// SQL Type: nchar(3) 
		/// </summary>
		[DataMember(Name="TranType", EmitDefaultValue=false)]
		public StringValue? TranType { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}