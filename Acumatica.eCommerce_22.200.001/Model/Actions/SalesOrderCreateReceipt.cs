using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateReceipt : EntityActionWithParameters<SalesOrder, SalesOrderCreateReceiptParameters>
	{
		public SalesOrderCreateReceipt() : base()
		{ }
		public SalesOrderCreateReceipt(SalesOrder entity, SalesOrderCreateReceiptParameters parameters) : base(entity, parameters)
		{ }

		public DateTimeValue ShipmentDate
		{
			get { return Parameters.ShipmentDate; }
			set { Parameters.ShipmentDate = value; }
		}
		public StringValue WarehouseID
		{
			get { return Parameters.WarehouseID; }
			set { Parameters.WarehouseID = value; }
		}
	}
}