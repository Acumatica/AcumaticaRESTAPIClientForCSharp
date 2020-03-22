using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CloseLeadAsDuplicate : EntityAction<Lead>
	{
		public CloseLeadAsDuplicate(Lead entity) : base(entity)
		{ }
		public CloseLeadAsDuplicate() : base()
		{ }
	}
}
