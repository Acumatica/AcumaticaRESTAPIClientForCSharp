using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestSubmit : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestSubmit(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestSubmit() : base()
		{ }
	}
}
