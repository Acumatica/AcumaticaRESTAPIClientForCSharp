using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseJournalVoucher : EntityAction<JournalVoucher>
	{
		public ReleaseJournalVoucher(JournalVoucher entity) : base(entity)
		{ }
		public ReleaseJournalVoucher() : base()
		{ }
	}
}
