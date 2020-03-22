using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SelectRelatedEntityTask : EntityActionWithParameters<Task, SelectRelatedEntityTaskParameters>
	{
		public SelectRelatedEntityTask() : base()
		{ }
		public SelectRelatedEntityTask(Task entity, SelectRelatedEntityTaskParameters parameters) : base(entity, parameters)
		{ }
	}
}