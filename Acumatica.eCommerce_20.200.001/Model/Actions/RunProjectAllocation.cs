using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class RunProjectAllocation : EntityAction<Project>
	{
		public RunProjectAllocation(Project entity) : base(entity)
		{ }
		public RunProjectAllocation() : base()
		{ }
	}
}
