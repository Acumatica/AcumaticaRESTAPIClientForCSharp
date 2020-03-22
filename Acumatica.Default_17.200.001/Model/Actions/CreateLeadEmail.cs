using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class CreateLeadEmail : EntityAction<Email>
	{
		public CreateLeadEmail(Email entity) : base(entity)
		{ }
		public CreateLeadEmail() : base()
		{ }
	}
}
