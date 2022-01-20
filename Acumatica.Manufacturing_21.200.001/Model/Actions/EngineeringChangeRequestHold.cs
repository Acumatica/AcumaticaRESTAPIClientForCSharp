using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestHold : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestHold(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestHold() : base()
		{ }
	}
}
