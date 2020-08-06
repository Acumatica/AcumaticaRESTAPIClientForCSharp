using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ValidateLeadAddress : EntityAction<Lead>
	{
		public ValidateLeadAddress(Lead entity) : base(entity)
		{ }
		public ValidateLeadAddress() : base()
		{ }
	}
}
