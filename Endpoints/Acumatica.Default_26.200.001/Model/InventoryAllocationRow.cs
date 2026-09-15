using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
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