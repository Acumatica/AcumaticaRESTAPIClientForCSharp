using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CloseOrder : EntityAction<ServiceOrder>
	{
		public CloseOrder(ServiceOrder entity) : base(entity)
		{ }
		public CloseOrder() : base()
		{ }
	}
}
