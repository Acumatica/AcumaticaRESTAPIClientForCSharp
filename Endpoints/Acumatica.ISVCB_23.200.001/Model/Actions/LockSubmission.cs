using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class LockSubmission : EntityAction<SolutionSubmission>
    {
        public LockSubmission(SolutionSubmission entity)
            : base(entity)
        {
        }
    }
}