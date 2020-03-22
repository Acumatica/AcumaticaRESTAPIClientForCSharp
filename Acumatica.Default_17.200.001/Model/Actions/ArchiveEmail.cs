using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class ArchiveEmail : EntityAction<Email>
	{
		public ArchiveEmail(Email entity) : base(entity)
		{ }
		public ArchiveEmail() : base()
		{ }
	}
}
