using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ConvertLeadToOpportunity : EntityAction<Lead>
	{
		public ConvertLeadToOpportunity(Lead entity) : base(entity)
		{ }
		public ConvertLeadToOpportunity() : base()
		{ }
	}
}
