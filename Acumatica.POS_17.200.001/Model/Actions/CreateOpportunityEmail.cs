using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CreateOpportunityEmail : EntityAction<Email>
	{
		public CreateOpportunityEmail(Email entity) : base(entity)
		{ }
		public CreateOpportunityEmail() : base()
		{ }
	}
}
