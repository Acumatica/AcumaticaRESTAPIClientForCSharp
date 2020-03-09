
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class OpenTimeEntry : EntityAction<TimeEntry>
    {
 public OpenTimeEntry(TimeEntry entity) : base(entity)
        { }
 public OpenTimeEntry() : base()
        { }
  }
}
