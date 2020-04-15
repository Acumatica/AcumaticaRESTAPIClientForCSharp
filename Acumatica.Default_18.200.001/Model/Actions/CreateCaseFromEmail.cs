using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class CreateCaseFromEmail : EntityAction<Email>
	{
		public CreateCaseFromEmail(Email entity) : base(entity)
		{ }
		public CreateCaseFromEmail() : base()
		{ }
	}
}
