using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class GeneratePeriods : EntityAction<FinancialPeriod>
	{
		public GeneratePeriods(FinancialPeriod entity) : base(entity)
		{ }
		public GeneratePeriods() : base()
		{ }
	}
}
