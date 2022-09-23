using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class RecalcExternalTax : EntityAction<ServiceOrder>
	{
		public RecalcExternalTax(ServiceOrder entity) : base(entity)
		{ }
		public RecalcExternalTax() : base()
		{ }
	}
}
