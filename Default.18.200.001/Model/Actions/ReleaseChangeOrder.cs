
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseChangeOrder : EntityAction<ChangeOrder>
    {
 public ReleaseChangeOrder(ChangeOrder entity) : base(entity)
        { }
 public ReleaseChangeOrder() : base()
        { }
  }
}
