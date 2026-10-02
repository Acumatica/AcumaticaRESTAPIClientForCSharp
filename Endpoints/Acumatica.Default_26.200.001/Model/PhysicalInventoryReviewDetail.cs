using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class PhysicalInventoryReviewDetail : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TagNumber</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Tag Nbr.</para>
		/// </summary>
		public IntValue? TagNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryID_InventoryItem_descr</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// </summary>
		public StringValue? Description { get; set; }

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
		/// <para>DAC Field Name: ExpireDate</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Book Quantity</para>
		/// </summary>
		public DecimalValue? BookQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Physical Quantity</para>
		/// </summary>
		public DecimalValue? PhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: VarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Variance Quantity</para>
		/// </summary>
		public DecimalValue? VarianceQty { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Unit Cost</para>
		/// </summary>
		public DecimalValue? UnitCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ExtVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Estimated Ext. Variance Cost</para>
		/// </summary>
		public DecimalValue? ExtendedVarianceCost { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIDetail</para>
		/// <para>Display Name: Reason Code</para>
		/// <para>SQL Type: nvarchar(20)</para>
		/// </summary>
		public StringValue? ReasonCode { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}