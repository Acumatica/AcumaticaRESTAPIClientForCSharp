using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderHold : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderHold(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderHold() : base()
		{ }
	}
}
