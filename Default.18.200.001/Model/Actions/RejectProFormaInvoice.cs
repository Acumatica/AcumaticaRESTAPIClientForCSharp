
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class RejectProFormaInvoice : EntityAction<ProFormaInvoice>
    {
 public RejectProFormaInvoice(ProFormaInvoice entity) : base(entity)
        { }
 public RejectProFormaInvoice() : base()
        { }
  }
}
