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
	public class SalesOrderCreateReceiptParameters
	{
		public SalesOrderCreateReceiptParameters() { }

		[DataMember(Name="ShipmentDate", EmitDefaultValue=false)]
		public DateTimeValue? ShipmentDate { get; set; }
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }
	}
}