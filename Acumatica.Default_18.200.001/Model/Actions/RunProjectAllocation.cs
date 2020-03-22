using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
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
