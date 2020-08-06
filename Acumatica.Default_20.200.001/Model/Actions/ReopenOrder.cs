using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReopenOrder : EntityAction<ServiceOrder>
	{
		public ReopenOrder(ServiceOrder entity) : base(entity)
		{ }
		public ReopenOrder() : base()
		{ }
	}
}
