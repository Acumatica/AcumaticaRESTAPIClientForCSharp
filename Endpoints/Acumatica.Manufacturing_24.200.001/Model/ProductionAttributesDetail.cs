using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	[DataContract]
	public class ProductionAttributesDetail : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Attribute ID 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Bat Nbr. 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatNbr", EmitDefaultValue=false)]
		public StringValue? BatNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Doc Type 
		/// SQL Type: nchar(1) 
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItemDescr 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Inventory Description 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="InventoryDescription", EmitDefaultValue=false)]
		public StringValue? InventoryDescription { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Qty 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Move Qty 
		/// </summary>
		[DataMember(Name="MoveQty", EmitDefaultValue=false)]
		public DecimalValue? MoveQty { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Order Type 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC Field Name: ProdOrdID 
		/// DAC: PX.Objects.AM.ProductionAttributesFilter 
		/// Display Name: Production Nbr. 
		/// SQL Type: nvarchar(19) 
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Tran. Date 
		/// </summary>
		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Tran Line Nbr. 
		/// </summary>
		[DataMember(Name="TranLineNbr", EmitDefaultValue=false)]
		public IntValue? TranLineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Operation ID 
		/// </summary>
		[DataMember(Name="TranOperationID", EmitDefaultValue=false)]
		public StringValue? TranOperationID { get; set; }

		/// <summary>
		/// DAC Field Name: TransactionRequired 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// Display Name: Trans. Required 
		/// </summary>
		[DataMember(Name="TransRequired", EmitDefaultValue=false)]
		public BooleanValue? TransRequired { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.ProductionAttributeRecords 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}