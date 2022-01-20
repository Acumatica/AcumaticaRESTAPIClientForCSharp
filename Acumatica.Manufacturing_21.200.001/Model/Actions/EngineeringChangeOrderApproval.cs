using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderApproval : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderApproval(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderApproval() : base()
		{ }
	}
}
