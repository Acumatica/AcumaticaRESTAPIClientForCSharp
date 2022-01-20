using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestReject : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestReject(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestReject() : base()
		{ }
	}
}
