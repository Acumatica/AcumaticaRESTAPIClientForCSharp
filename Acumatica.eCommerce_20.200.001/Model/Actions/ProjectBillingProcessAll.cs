using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ProjectBillingProcessAll : EntityAction<ProjectBilling>
	{
		public ProjectBillingProcessAll(ProjectBilling entity) : base(entity)
		{ }
		public ProjectBillingProcessAll() : base()
		{ }
	}
}
