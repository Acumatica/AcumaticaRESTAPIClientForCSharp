
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CopyFromCompany : EntityAction<Contact>
    {
 public CopyFromCompany(Contact entity) : base(entity)
        { }
 public CopyFromCompany() : base()
        { }
  }
}
