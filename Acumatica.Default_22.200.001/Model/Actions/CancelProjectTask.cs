using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CancelProjectTask : EntityAction<ProjectTask>
	{
		public CancelProjectTask(ProjectTask entity) : base(entity)
		{ }
		public CancelProjectTask() : base()
		{ }
	}
}
