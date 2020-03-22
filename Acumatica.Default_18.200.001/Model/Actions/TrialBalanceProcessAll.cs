using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class TrialBalanceProcessAll : EntityAction<TrialBalance>
	{
		public TrialBalanceProcessAll(TrialBalance entity) : base(entity)
		{ }
		public TrialBalanceProcessAll() : base()
		{ }
	}
}
