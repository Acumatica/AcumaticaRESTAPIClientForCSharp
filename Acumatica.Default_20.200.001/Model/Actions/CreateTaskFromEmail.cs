using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CreateTaskFromEmail : EntityAction<Email>
	{
		public CreateTaskFromEmail(Email entity) : base(entity)
		{ }
		public CreateTaskFromEmail() : base()
		{ }
	}
}
