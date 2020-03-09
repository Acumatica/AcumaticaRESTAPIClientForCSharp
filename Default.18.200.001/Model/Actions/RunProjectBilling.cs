
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class RunProjectBilling : EntityAction<Project>
    {
 public RunProjectBilling(Project entity) : base(entity)
        { }
 public RunProjectBilling() : base()
        { }
  }
}
