using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class AcceptInvitationEvent : EntityAction<Event>
	{
		public AcceptInvitationEvent(Event entity) : base(entity)
		{ }
		public AcceptInvitationEvent() : base()
		{ }
	}
}
