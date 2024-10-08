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
	public class CostTransactionDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: AcctID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Account", EmitDefaultValue=false)]
		public StringValue? Account { get; set; }

		/// <summary>
		/// The reference number of the transaction.
		/// DAC Field Name: BatNbr 
		/// DAC: PX.Objects.AM.AMBatch 
		/// Display Name: Batch Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC Field Name: TranAmt 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Ext. Cost 
		/// </summary>
		[DataMember(Name="ExtCost", EmitDefaultValue=false)]
		public DecimalValue? ExtCost { get; set; }

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
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

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
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Quantity", EmitDefaultValue=false)]
		public DecimalValue? Quantity { get; set; }

		/// <summary>
		/// Cost ID value such as Tool ID, Overhead ID, Machine ID, etc.
		/// DAC Field Name: ReferenceCostID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// Display Name: Ref. Cost ID 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="RefCostID", EmitDefaultValue=false)]
		public StringValue? RefCostID { get; set; }

		/// <summary>
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.AM.AMMTran 
		/// </summary>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

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

	}
}