using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class RejectProject : EntityAction<Project>
	{
		public RejectProject(Project entity) : base(entity)
		{ }
		public RejectProject() : base()
		{ }
	}
}
