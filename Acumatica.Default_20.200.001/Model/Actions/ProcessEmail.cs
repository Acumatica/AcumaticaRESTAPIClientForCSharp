using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProcessEmail : EntityAction<Email>
	{
		public ProcessEmail(Email entity) : base(entity)
		{ }
		public ProcessEmail() : base()
		{ }
	}
}
