using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class ProcessManageFinancialPeriods : EntityAction<ManageFinancialPeriods>
	{
		public ProcessManageFinancialPeriods(ManageFinancialPeriods entity) : base(entity)
		{ }
		public ProcessManageFinancialPeriods() : base()
		{ }
	}
}
