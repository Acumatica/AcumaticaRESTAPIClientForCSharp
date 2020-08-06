using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CancelActivityTask : EntityAction<Task>
	{
		public CancelActivityTask(Task entity) : base(entity)
		{ }
		public CancelActivityTask() : base()
		{ }
	}
}
