using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.MANUFACTURING_25_100_001.Model
{
	public class ProductionAttributesDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Attribute ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? AttributeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Batch Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BatNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Doc. Type</para>
		/// <para>SQL Type: nchar(1)</para>
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		public BooleanValue? Enabled { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItemDescr</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Inventory Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? InventoryDescription { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Label { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		public StringValue? Level { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Qty</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Move Qty.</para>
		/// </summary>
		public DecimalValue? MoveQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? OperationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ProdOrdID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributesFilter</para>
		/// <para>Display Name: Production Nbr.</para>
		/// <para>SQL Type: nvarchar(19)</para>
		/// </summary>
		public StringValue? ProductionNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		public StringValue? Source { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Tran. Date</para>
		/// </summary>
		public DateTimeValue? TranDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Tran Line Nbr.</para>
		/// </summary>
		public IntValue? TranLineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Operation ID</para>
		/// </summary>
		public StringValue? TranOperationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TransactionRequired</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>Display Name: Trans. Required</para>
		/// </summary>
		public BooleanValue? TransRequired { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Value { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.ProductionAttributeRecords</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

	}
}