using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.POS_17_200_001.Model
{
	[DataContract]
	public class RejectInvitationEvent : EntityAction<Event>
	{
		public RejectInvitationEvent(Event entity) : base(entity)
		{ }
		public RejectInvitationEvent() : base()
		{ }
	}
}
