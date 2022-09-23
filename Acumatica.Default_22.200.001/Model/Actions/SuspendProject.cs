using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class SuspendProject : EntityAction<Project>
	{
		public SuspendProject(Project entity) : base(entity)
		{ }
		public SuspendProject() : base()
		{ }
	}
}
