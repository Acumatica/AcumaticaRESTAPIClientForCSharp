using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CompleteProjectTask : EntityAction<ProjectTask>
	{
		public CompleteProjectTask(ProjectTask entity) : base(entity)
		{ }
		public CompleteProjectTask() : base()
		{ }
	}
}
