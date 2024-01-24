using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class StorageDetailByLocation : Entity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="QtyAvailableinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinLocation { get; set; }

		[DataMember(Name="QtyAvailableforIssueinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinLocation { get; set; }

		[DataMember(Name="QtyAvailableforShippinginLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginLocation { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		[DataMember(Name="LastModifiedDateofLocationQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofLocationQty { get; set; }

		[DataMember(Name="QtyOnHandinLocation", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinLocation { get; set; }

		[DataMember(Name="QtyAvailableinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableinWarehouse { get; set; }

		[DataMember(Name="QtyAvailableforIssueinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforIssueinWarehouse { get; set; }

		[DataMember(Name="QtyAvailableforShippinginWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyAvailableforShippinginWarehouse { get; set; }

		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

		[DataMember(Name="LastModifiedDateofWarehouseQty", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateofWarehouseQty { get; set; }

		[DataMember(Name="QtyOnHandinWarehouse", EmitDefaultValue=false)]
		public DecimalValue? QtyOnHandinWarehouse { get; set; }

	}
}