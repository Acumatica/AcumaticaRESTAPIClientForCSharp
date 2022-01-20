using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class EngineeringChangeOrderCommitChanges : EntityAction<EngineeringChangeOrder>
	{
		public EngineeringChangeOrderCommitChanges(EngineeringChangeOrder entity) : base(entity)
		{ }
		public EngineeringChangeOrderCommitChanges() : base()
		{ }
	}
}
