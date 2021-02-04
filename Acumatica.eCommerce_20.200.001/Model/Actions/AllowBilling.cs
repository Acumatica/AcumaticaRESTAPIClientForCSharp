using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class AllowBilling : EntityAction<ServiceOrder>
	{
		public AllowBilling(ServiceOrder entity) : base(entity)
		{ }
		public AllowBilling() : base()
		{ }
	}
}
