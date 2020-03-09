
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class EmailProFormaInvoice : EntityAction<ProFormaInvoice>
    {
 public EmailProFormaInvoice(ProFormaInvoice entity) : base(entity)
        { }
 public EmailProFormaInvoice() : base()
        { }
  }
}
