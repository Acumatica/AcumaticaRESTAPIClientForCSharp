
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class ReleaseTrialBalance : EntityAction<TrialBalance>
    {
 public ReleaseTrialBalance(TrialBalance entity) : base(entity)
        { }
 public ReleaseTrialBalance() : base()
        { }
  }
}
