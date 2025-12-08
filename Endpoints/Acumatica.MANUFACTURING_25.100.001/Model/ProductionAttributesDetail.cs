using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	[DataContract]
	public class ProductionAttributesDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="AttributeID", EmitDefaultValue=false)]
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Bat Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BatNbr", EmitDefaultValue=false)]
		public StringValue? BatNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Doc Type</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		[DataMember(Name="Enabled", EmitDefaultValue=false)]
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItemDescr</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Inventory Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="InventoryDescription", EmitDefaultValue=false)]
		public StringValue? InventoryDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Label", EmitDefaultValue=false)]
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		[DataMember(Name="Level", EmitDefaultValue=false)]
		public StringValue? Level { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Move Qty</para>
		/// </summary>
		[DataMember(Name="MoveQty", EmitDefaultValue=false)]
		public DecimalValue? MoveQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		[DataMember(Name="OperationID", EmitDefaultValue=false)]
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		[DataMember(Name="ProductionNbr", EmitDefaultValue=false)]
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Tran. Date</para>
		/// </summary>
		[DataMember(Name="TranDate", EmitDefaultValue=false)]
		public DateTimeValue? TranDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Tran Line Nbr.</para>
		/// </summary>
		[DataMember(Name="TranLineNbr", EmitDefaultValue=false)]
		public IntValue? TranLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		[DataMember(Name="TranOperationID", EmitDefaultValue=false)]
		public StringValue? TranOperationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TransactionRequired</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Trans. Required</para>
		/// </summary>
		[DataMember(Name="TransRequired", EmitDefaultValue=false)]
		public BooleanValue? TransRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

	}
}