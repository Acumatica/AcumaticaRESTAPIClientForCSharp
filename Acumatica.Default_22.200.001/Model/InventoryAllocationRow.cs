using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryAllocationRow : Entity
	{

		/// <summary>
		/// DAC Field Name: PlanDate 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// Display Name: Allocation Date 
		/// </summary>
		[DataMember(Name="AllocationDate", EmitDefaultValue=false)]
		public DateTimeValue? AllocationDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// Display Name: Allocation Type 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AllocationType", EmitDefaultValue=false)]
		public StringValue? AllocationType { get; set; }

		/// <summary>
		/// DAC Field Name: QADocType 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// Display Name: Document Type 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// </summary>
		[DataMember(Name="Expired", EmitDefaultValue=false)]
		public BooleanValue? Expired { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqFilter 
		/// Display Name: Lot/Serial Nbr. 
		/// SQL Type: nvarchar(100) 
		/// </summary>
		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		/// <summary>
		/// DAC Field Name: PlanQty 
		/// DAC: PX.Objects.IN.InventoryAllocDetEnqResult 
		/// Display Name: Qty. 
		/// </summary>
		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

	}
}