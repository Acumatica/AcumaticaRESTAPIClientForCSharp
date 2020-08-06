using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreateContactFromEmail : EntityAction<Email>
	{
		public CreateContactFromEmail(Email entity) : base(entity)
		{ }
		public CreateContactFromEmail() : base()
		{ }
	}
}
