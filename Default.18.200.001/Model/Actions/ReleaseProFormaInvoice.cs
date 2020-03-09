
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseProFormaInvoice : EntityAction<ProFormaInvoice>
    {
 public ReleaseProFormaInvoice(ProFormaInvoice entity) : base(entity)
        { }
 public ReleaseProFormaInvoice() : base()
        { }
  }
}
