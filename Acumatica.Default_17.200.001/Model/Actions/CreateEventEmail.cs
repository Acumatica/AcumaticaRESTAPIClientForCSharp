using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CreateEventEmail : EntityAction<Email>
	{
		public CreateEventEmail(Email entity) : base(entity)
		{ }
		public CreateEventEmail() : base()
		{ }
	}
}
