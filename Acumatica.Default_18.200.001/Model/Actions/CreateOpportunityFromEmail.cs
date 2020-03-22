using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CreateOpportunityFromEmail : EntityAction<Email>
	{
		public CreateOpportunityFromEmail(Email entity) : base(entity)
		{ }
		public CreateOpportunityFromEmail() : base()
		{ }
	}
}
