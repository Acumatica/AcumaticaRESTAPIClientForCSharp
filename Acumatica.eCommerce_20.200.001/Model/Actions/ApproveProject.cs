using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ApproveProject : EntityAction<Project>
	{
		public ApproveProject(Project entity) : base(entity)
		{ }
		public ApproveProject() : base()
		{ }
	}
}
