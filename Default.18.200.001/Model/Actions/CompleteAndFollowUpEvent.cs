
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CompleteAndFollowUpEvent : EntityAction<Event>
    {
 public CompleteAndFollowUpEvent(Event entity) : base(entity)
        { }
 public CompleteAndFollowUpEvent() : base()
        { }
  }
}
