using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldProjectTemplate : EntityAction<ProjectTemplate>
	{
		public HoldProjectTemplate(ProjectTemplate entity) : base(entity)
		{ }
		public HoldProjectTemplate() : base()
		{ }
	}
}
