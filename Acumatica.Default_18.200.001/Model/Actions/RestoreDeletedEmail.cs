using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class RestoreDeletedEmail : EntityAction<Email>
	{
		public RestoreDeletedEmail(Email entity) : base(entity)
		{ }
		public RestoreDeletedEmail() : base()
		{ }
	}
}
