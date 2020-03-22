using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
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
