using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public class InviteEvent : EntityAction<Event>
	{
		public InviteEvent(Event entity) : base(entity)
		{ }
		public InviteEvent() : base()
		{ }
	}
}
