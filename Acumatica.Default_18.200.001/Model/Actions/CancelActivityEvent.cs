using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class CancelActivityEvent : EntityAction<Event>
	{
		public CancelActivityEvent(Event entity) : base(entity)
		{ }
		public CancelActivityEvent() : base()
		{ }
	}
}
