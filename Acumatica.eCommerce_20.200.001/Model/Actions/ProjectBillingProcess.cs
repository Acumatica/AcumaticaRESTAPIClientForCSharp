using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
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
