using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AutoRecalculateDiscounts : EntityAction<SalesOrder>
	{
		public AutoRecalculateDiscounts(SalesOrder entity) : base(entity)
		{ }
		public AutoRecalculateDiscounts() : base()
		{ }
	}
}
