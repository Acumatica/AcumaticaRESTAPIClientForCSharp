using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_18_200_001.Model
{
	[DataContract]
	public class ReleaseWipAdjustmentEntry : EntityAction<WipAdjustmentEntry>
	{
		public ReleaseWipAdjustmentEntry(WipAdjustmentEntry entity) : base(entity)
		{ }
		public ReleaseWipAdjustmentEntry() : base()
		{ }
	}
}
