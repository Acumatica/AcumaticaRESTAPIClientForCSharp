using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CreateAccountFromOpportunity : EntityActionWithParameters<Opportunity, CreateAccountFromOpportunityParameters>
	{
		public CreateAccountFromOpportunity() : base()
		{ }
		public CreateAccountFromOpportunity(Opportunity entity, CreateAccountFromOpportunityParameters parameters) : base(entity, parameters)
		{ }
	}
}