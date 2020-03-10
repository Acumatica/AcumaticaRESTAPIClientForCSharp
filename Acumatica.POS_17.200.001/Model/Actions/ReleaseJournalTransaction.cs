using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseJournalTransaction : EntityAction<JournalTransaction>
	{
		public ReleaseJournalTransaction(JournalTransaction entity) : base(entity)
		{ }
		public ReleaseJournalTransaction() : base()
		{ }
	}
}
