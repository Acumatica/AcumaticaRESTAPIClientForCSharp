using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class SetResult : EntityActionWithParameters<SolutionSubmission, SetResultParameters>
    {
        public StringValue? Result
        {
            get
            {
                return base.Parameters.Result;
            }
            set
            {
                base.Parameters.Result = value;
            }
        }

        public SetResult(SolutionSubmission entity, SetResultParameters parameters)
            : base(entity, parameters)
        {
        }
    }
}