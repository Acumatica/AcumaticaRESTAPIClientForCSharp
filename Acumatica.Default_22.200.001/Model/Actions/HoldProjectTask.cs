using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldProjectTask : EntityAction<ProjectTask>
	{
		public HoldProjectTask(ProjectTask entity) : base(entity)
		{ }
		public HoldProjectTask() : base()
		{ }
	}
}
