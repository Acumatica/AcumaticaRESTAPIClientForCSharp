using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ProcessAllEmailProcessing : EntityAction<EmailProcessing>
	{
		public ProcessAllEmailProcessing(EmailProcessing entity) : base(entity)
		{ }
		public ProcessAllEmailProcessing() : base()
		{ }
	}
}
