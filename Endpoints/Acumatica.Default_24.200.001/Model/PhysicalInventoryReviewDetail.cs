using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	public class PhysicalInventoryReviewDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Book Quantity</para>
		/// </summary>
		public DecimalValue? BookQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Estimated Ext. Variance Cost</para>
		/// </summary>
		public DecimalValue? ExtendedVarianceCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Location</para>
		/// </summary>
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Lot/Serial Number</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Physical Quantity</para>
		/// </summary>
		public DecimalValue? PhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TagNumber</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Tag Nbr.</para>
		/// </summary>
		public IntValue? TagNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Variance Quantity</para>
		/// </summary>
		public DecimalValue? VarianceQty { get; set; }

	}
}