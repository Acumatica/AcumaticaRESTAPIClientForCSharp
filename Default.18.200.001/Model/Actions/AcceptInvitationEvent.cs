
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class AcceptInvitationEvent : EntityAction<Event>
    {
 public AcceptInvitationEvent(Event entity) : base(entity)
        { }
 public AcceptInvitationEvent() : base()
        { }
  }
}
