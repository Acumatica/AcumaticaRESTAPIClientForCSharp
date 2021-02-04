using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class ReleaseCashSale : EntityAction<CashSale>
	{
		public ReleaseCashSale(CashSale entity) : base(entity)
		{ }
		public ReleaseCashSale() : base()
		{ }
	}
}
