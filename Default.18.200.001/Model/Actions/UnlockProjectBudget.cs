
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class UnlockProjectBudget : EntityAction<Project>
    {
 public UnlockProjectBudget(Project entity) : base(entity)
        { }
 public UnlockProjectBudget() : base()
        { }
  }
}
