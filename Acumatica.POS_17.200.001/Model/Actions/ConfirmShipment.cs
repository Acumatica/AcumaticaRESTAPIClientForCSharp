using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ConfirmShipment : EntityAction<Shipment>
	{
		public ConfirmShipment(Shipment entity) : base(entity)
		{ }
		public ConfirmShipment() : base()
		{ }
	}
}
