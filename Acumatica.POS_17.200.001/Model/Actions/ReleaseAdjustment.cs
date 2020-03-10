using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public partial class ReleaseAdjustment : EntityAction<Adjustment>
	{
		public ReleaseAdjustment(Adjustment entity) : base(entity)
		{ }
		public ReleaseAdjustment() : base()
		{ }
	}
}
