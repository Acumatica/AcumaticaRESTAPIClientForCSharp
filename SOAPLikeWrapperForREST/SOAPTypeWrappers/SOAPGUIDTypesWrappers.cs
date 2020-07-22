using Acumatica.RESTClient.Model;
using System;

namespace SOAPLikeWrapperForREST
{
    public enum GuidCondition
    {
        Equal,
        NotEqual,
        IsNull,
        IsNotNull,
    }

    public partial class GuidSearch : GuidValue
    {
        public GuidSearch(Guid? value = null) : base(value)
        { }

        public GuidCondition Condition { get; set; }

        public Guid Value2
        {
            get;
            set;
        }
    }
}
