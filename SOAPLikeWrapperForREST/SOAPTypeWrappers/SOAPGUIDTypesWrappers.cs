using Acumatica.RESTClient.Model;
using System;

namespace SOAPLikeWrapperForREST
{
    public partial class GuidReturn : GuidValue
    {
    }

    public enum GuidCondition
    {
        Equal,
        NotEqual,
        IsNull,
        IsNotNull,
    }
  
    public partial class GuidSearch : GuidValue
    {
		public GuidCondition Condition { get; set; }

		public Guid Value2
        {
            get;
            set;
        }
    }
}
