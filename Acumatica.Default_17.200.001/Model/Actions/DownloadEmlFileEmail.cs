using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class DownloadEmlFileEmail : EntityAction<Email>
	{
		public DownloadEmlFileEmail(Email entity) : base(entity)
		{ }
		public DownloadEmlFileEmail() : base()
		{ }
	}
}
