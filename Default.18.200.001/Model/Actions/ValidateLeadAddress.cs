
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ValidateLeadAddress : EntityAction<Lead>
    {
 public ValidateLeadAddress(Lead entity) : base(entity)
        { }
 public ValidateLeadAddress() : base()
        { }
  }
}
