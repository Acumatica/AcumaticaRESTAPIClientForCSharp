using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CreateEventFromEmail : EntityAction<Email>
	{
		public CreateEventFromEmail(Email entity) : base(entity)
		{ }
		public CreateEventFromEmail() : base()
		{ }
	}
}
