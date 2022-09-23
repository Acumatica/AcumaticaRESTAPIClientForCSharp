using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ActivateProject : EntityAction<Project>
	{
		public ActivateProject(Project entity) : base(entity)
		{ }
		public ActivateProject() : base()
		{ }
	}
}
