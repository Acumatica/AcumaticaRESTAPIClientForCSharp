using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class StorageDetail : Entity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="QtyAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailable { get; set; }

		[DataMember(Name="QtyAvailableforIssue", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssue { get; set; }

		[DataMember(Name="QtyHardAvailable", EmitDefaultValue=false)]
		public DecimalValue? QtyHardAvailable { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		[DataMember(Name="LastModifiedDateofWarehouseQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		[DataMember(Name="QtyOnHand", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHand { get; set; }

	}
}