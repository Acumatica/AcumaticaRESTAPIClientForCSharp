using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CreateOpportunityInvoice : EntityAction<Opportunity>
	{
		public CreateOpportunityInvoice(Opportunity entity) : base(entity)
		{ }
		public CreateOpportunityInvoice() : base()
		{ }
	}
}
