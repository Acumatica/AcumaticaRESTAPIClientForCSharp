using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class RejectInvitationEvent : EntityAction<Event>
	{
		public RejectInvitationEvent(Event entity) : base(entity)
		{ }
		public RejectInvitationEvent() : base()
		{ }
	}
}
