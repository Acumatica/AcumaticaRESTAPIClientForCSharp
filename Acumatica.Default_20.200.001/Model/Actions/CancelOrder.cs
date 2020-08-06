using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CancelOrder : EntityAction<ServiceOrder>
	{
		public CancelOrder(ServiceOrder entity) : base(entity)
		{ }
		public CancelOrder() : base()
		{ }
	}
}
