using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
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
