using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateShipment : EntityActionWithParameters<SalesOrder, SalesOrderCreateShipmentParameters>
	{
		public SalesOrderCreateShipment() : base()
		{ }
		public SalesOrderCreateShipment(SalesOrder entity, SalesOrderCreateShipmentParameters parameters) : base(entity, parameters)
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