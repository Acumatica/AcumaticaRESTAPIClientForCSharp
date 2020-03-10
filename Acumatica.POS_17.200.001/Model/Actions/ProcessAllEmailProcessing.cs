using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ProcessAllEmailProcessing : EntityAction<EmailProcessing>
	{
		public ProcessAllEmailProcessing(EmailProcessing entity) : base(entity)
		{ }
		public ProcessAllEmailProcessing() : base()
		{ }
	}
}
