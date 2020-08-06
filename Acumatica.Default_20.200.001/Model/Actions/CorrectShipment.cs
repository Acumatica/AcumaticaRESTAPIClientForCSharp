using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CorrectShipment : EntityAction<Shipment>
	{
		public CorrectShipment(Shipment entity) : base(entity)
		{ }
		public CorrectShipment() : base()
		{ }
	}
}
