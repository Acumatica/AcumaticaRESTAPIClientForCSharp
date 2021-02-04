using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ConvertLeadToContact : EntityAction<Lead>
	{
		public ConvertLeadToContact(Lead entity) : base(entity)
		{ }
		public ConvertLeadToContact() : base()
		{ }
	}
}
