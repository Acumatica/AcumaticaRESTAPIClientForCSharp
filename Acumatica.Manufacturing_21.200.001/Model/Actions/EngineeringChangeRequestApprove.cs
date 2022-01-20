using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestApprove : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestApprove(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestApprove() : base()
		{ }
	}
}
