
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReverseChangeOrder : EntityAction<ChangeOrder>
    {
 public ReverseChangeOrder(ChangeOrder entity) : base(entity)
        { }
 public ReverseChangeOrder() : base()
        { }
  }
}
