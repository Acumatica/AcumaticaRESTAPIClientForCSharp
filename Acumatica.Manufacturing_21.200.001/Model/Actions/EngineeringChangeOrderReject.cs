using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderReject : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderReject(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderReject() : base()
		{ }
	}
}
