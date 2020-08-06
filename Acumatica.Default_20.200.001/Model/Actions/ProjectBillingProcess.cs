using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProjectBillingProcess : EntityAction<ProjectBilling>
	{
		public ProjectBillingProcess(ProjectBilling entity) : base(entity)
		{ }
		public ProjectBillingProcess() : base()
		{ }
	}
}
