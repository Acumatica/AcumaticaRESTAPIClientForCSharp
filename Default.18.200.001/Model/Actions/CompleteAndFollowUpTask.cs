
using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
[DataContract]
 public partial class CompleteAndFollowUpTask : EntityAction<Task>
    {
 public CompleteAndFollowUpTask(Task entity) : base(entity)
        { }
 public CompleteAndFollowUpTask() : base()
        { }
  }
}
