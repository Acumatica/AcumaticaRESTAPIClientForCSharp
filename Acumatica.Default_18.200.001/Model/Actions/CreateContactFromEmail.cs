using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CreateContactFromEmail : EntityAction<Email>
	{
		public CreateContactFromEmail(Email entity) : base(entity)
		{ }
		public CreateContactFromEmail() : base()
		{ }
	}
}
