using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class HoldProject : EntityAction<Project>
	{
		public HoldProject(Project entity) : base(entity)
		{ }
		public HoldProject() : base()
		{ }
	}
}
