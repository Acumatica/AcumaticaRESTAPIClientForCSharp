using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class SalesOrderCreateShipment : EntityActionWithParameters<SalesOrder, SalesOrderCreateShipmentParameters>
	{
		public SalesOrderCreateShipment() : base()
		{ }
		public SalesOrderCreateShipment(SalesOrder entity, SalesOrderCreateShipmentParameters parameters) : base(entity, parameters)
		{ }
	}
}