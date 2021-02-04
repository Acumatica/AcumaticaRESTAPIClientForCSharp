using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class CompleteEvent : EntityAction<Event>
	{
		public CompleteEvent(Event entity) : base(entity)
		{ }
		public CompleteEvent() : base()
		{ }
	}
}
