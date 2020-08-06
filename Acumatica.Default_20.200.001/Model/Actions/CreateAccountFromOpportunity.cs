using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreateAccountFromOpportunity : EntityActionWithParameters<Opportunity, CreateAccountFromOpportunityParameters>
	{
		public CreateAccountFromOpportunity() : base()
		{ }
		public CreateAccountFromOpportunity(Opportunity entity, CreateAccountFromOpportunityParameters parameters) : base(entity, parameters)
		{ }

		public StringValue AccountClass
		{
			get { return Parameters.AccountClass; }
			set { Parameters.AccountClass = value; }
		}
		public StringValue AccountName
		{
			get { return Parameters.AccountName; }
			set { Parameters.AccountName = value; }
		}
		public StringValue BAccountID
		{
			get { return Parameters.BAccountID; }
			set { Parameters.BAccountID = value; }
		}
	}
}