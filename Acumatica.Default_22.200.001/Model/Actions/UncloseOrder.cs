using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class UncloseOrder : EntityAction<ServiceOrder>
	{
		public UncloseOrder(ServiceOrder entity) : base(entity)
		{ }
		public UncloseOrder() : base()
		{ }
	}
}
