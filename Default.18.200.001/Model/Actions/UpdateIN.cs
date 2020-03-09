
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class UpdateIN : EntityAction<Shipment>
    {
 public UpdateIN(Shipment entity) : base(entity)
        { }
 public UpdateIN() : base()
        { }
  }
}
