using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class TrialBalanceProcess : EntityAction<TrialBalance>
	{
		public TrialBalanceProcess(TrialBalance entity) : base(entity)
		{ }
		public TrialBalanceProcess() : base()
		{ }
	}
}
