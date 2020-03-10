using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class ConvertLeadToContact : EntityAction<Lead>
	{
		public ConvertLeadToContact(Lead entity) : base(entity)
		{ }
		public ConvertLeadToContact() : base()
		{ }
	}
}
