using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ActivateProjectTask : EntityAction<ProjectTask>
	{
		public ActivateProjectTask(ProjectTask entity) : base(entity)
		{ }
		public ActivateProjectTask() : base()
		{ }
	}
}
