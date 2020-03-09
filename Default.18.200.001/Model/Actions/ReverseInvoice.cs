
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReverseInvoice : EntityAction<Invoice>
    {
 public ReverseInvoice(Invoice entity) : base(entity)
        { }
 public ReverseInvoice() : base()
        { }
  }
}
