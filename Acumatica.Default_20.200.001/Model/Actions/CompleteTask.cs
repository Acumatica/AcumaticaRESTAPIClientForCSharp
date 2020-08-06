using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompleteTask : EntityAction<Task>
	{
		public CompleteTask(Task entity) : base(entity)
		{ }
		public CompleteTask() : base()
		{ }
	}
}
