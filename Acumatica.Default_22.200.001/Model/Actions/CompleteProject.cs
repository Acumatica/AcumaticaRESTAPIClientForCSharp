using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CompleteProject : EntityAction<Project>
	{
		public CompleteProject(Project entity) : base(entity)
		{ }
		public CompleteProject() : base()
		{ }
	}
}
