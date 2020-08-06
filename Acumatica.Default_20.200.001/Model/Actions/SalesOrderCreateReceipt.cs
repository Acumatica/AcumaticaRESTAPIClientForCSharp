using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
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