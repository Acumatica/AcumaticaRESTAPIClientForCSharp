
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class RejectChangeOrder : EntityAction<ChangeOrder>
    {
 public RejectChangeOrder(ChangeOrder entity) : base(entity)
        { }
 public RejectChangeOrder() : base()
        { }
  }
}
