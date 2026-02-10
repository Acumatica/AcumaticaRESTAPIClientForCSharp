using System.Runtime.Serialization;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.ISVCB_23_200_001.Model
{
    [DataContract]
    public class LinkCase : EntityActionWithParameters<SolutionSubmission, LinkCaseParameters>
    {
        public StringValue? RelatedCase
        {
            get
            {
                return base.Parameters.RelatedCase;
            }
            set
            {
                base.Parameters.RelatedCase = value;
            }
        }

        public LinkCase(SolutionSubmission entity, LinkCaseParameters parameters)
            : base(entity, parameters)
        {
        }
    }
}