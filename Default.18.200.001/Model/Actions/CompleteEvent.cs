
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CompleteEvent : EntityAction<Event>
    {
 public CompleteEvent(Event entity) : base(entity)
        { }
 public CompleteEvent() : base()
        { }
  }
}
