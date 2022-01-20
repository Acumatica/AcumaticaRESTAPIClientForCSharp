using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeRequestCreateECO : EntityAction<EngineeringChangeRequest>
	{
		public EngineeringChangeRequestCreateECO(EngineeringChangeRequest entity) : base(entity)
		{ }
		public EngineeringChangeRequestCreateECO() : base()
		{ }
	}
}
