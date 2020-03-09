
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ConvertBusinessAccountToCustomer : EntityAction<BusinessAccount>
    {
 public ConvertBusinessAccountToCustomer(BusinessAccount entity) : base(entity)
        { }
 public ConvertBusinessAccountToCustomer() : base()
        { }
  }
}
