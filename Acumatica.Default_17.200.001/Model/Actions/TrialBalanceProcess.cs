using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_17_200_001.Model
{
	[DataContract]
	public partial class TrialBalanceProcess : EntityAction<TrialBalance>
	{
		public TrialBalanceProcess(TrialBalance entity) : base(entity)
		{ }
		public TrialBalanceProcess() : base()
		{ }
	}
}
