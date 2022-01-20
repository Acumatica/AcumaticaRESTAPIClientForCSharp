using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ConfirmShipment : EntityAction<VendorShipment>
	{
		public ConfirmShipment(VendorShipment entity) : base(entity)
		{ }
		public ConfirmShipment() : base()
		{ }
	}
}
