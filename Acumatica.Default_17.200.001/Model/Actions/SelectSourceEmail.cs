using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public class SelectSourceEmail : EntityAction<Email>
	{
		public SelectSourceEmail(Email entity) : base(entity)
		{ }
		public SelectSourceEmail() : base()
		{ }
	}
}
