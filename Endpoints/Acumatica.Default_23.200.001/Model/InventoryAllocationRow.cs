using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class InventoryAllocationRow : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: PlanDate</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Allocation Date</para>
		/// </summary>
		[DataMember(Name="AllocationDate", EmitDefaultValue=false)]
		public DateTimeValue? AllocationDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Allocation Type</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="AllocationType", EmitDefaultValue=false)]
		public StringValue? AllocationType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: QADocType</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Document Type</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// </summary>
		[DataMember(Name="Expired", EmitDefaultValue=false)]
		public BooleanValue? Expired { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqFilter</para>
		/// <para>Display Name: Lot/Serial Nbr.</para>
		/// <para>SQL Type: nvarchar(100)</para>
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>SQL Type: nvarchar(2)</para>
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PlanQty</para>
		/// <para>DAC: PX.Objects.IN.InventoryAllocDetEnqResult</para>
		/// <para>Display Name: Qty.</para>
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

	}
}