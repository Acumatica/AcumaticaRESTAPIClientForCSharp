using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class CreateTaskEmail : EntityAction<Email>
	{
		public CreateTaskEmail(Email entity) : base(entity)
		{ }
		public CreateTaskEmail() : base()
		{ }
	}
}
