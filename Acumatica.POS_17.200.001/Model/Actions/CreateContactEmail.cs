using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CreateContactEmail : EntityAction<Email>
	{
		public CreateContactEmail(Email entity) : base(entity)
		{ }
		public CreateContactEmail() : base()
		{ }
	}
}
