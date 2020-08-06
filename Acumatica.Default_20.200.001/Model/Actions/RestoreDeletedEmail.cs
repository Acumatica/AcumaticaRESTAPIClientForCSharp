using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class RestoreDeletedEmail : EntityAction<Email>
	{
		public RestoreDeletedEmail(Email entity) : base(entity)
		{ }
		public RestoreDeletedEmail() : base()
		{ }
	}
}
