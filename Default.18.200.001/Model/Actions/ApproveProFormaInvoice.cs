
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ApproveProFormaInvoice : EntityAction<ProFormaInvoice>
    {
 public ApproveProFormaInvoice(ProFormaInvoice entity) : base(entity)
        { }
 public ApproveProFormaInvoice() : base()
        { }
  }
}
