using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class CreateCaseEmail : EntityAction<Email>
	{
		public CreateCaseEmail(Email entity) : base(entity)
		{ }
		public CreateCaseEmail() : base()
		{ }
	}
}
