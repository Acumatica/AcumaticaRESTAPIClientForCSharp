using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class CompleteOrder : EntityAction<ServiceOrder>
	{
		public CompleteOrder(ServiceOrder entity) : base(entity)
		{ }
		public CompleteOrder() : base()
		{ }
	}
}
