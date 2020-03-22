using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class ReleaseTrialBalance : EntityAction<TrialBalance>
	{
		public ReleaseTrialBalance(TrialBalance entity) : base(entity)
		{ }
		public ReleaseTrialBalance() : base()
		{ }
	}
}
