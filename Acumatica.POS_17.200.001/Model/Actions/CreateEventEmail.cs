using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class CreateEventEmail : EntityAction<Email>
	{
		public CreateEventEmail(Email entity) : base(entity)
		{ }
		public CreateEventEmail() : base()
		{ }
	}
}
