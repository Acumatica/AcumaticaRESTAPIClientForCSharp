using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	public class InventoryAllocationRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PlanDate</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Allocation Date</para>
		/// </summary>
		public DateTimeValue? AllocationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Allocation Type</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		public StringValue? AllocationType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QADocType</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Document Type</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// </summary>
		public BooleanValue? Expired { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanQty</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Qty.</para>
		/// </summary>
		public DecimalValue? Qty { get; set; }

	}
}