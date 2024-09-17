using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class InventoryAllocationRow : Entity
	{

		[DataMember(Name="AllocationDate", EmitDefaultValue=false)]
		public DateTimeValue? AllocationDate { get; set; }

		[DataMember(Name="AllocationType", EmitDefaultValue=false)]
		public StringValue? AllocationType { get; set; }

		[DataMember(Name="DocType", EmitDefaultValue=false)]
		public StringValue? DocType { get; set; }

		[DataMember(Name="Expired", EmitDefaultValue=false)]
		public BooleanValue? Expired { get; set; }

		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		[DataMember(Name="LotSerialNbr", EmitDefaultValue=false)]
		public StringValue? LotSerialNbr { get; set; }

		[DataMember(Name="Module", EmitDefaultValue=false)]
		public StringValue? Module { get; set; }

		[DataMember(Name="Qty", EmitDefaultValue=false)]
		public DecimalValue? Qty { get; set; }

	}
}