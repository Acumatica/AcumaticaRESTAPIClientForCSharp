using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public enum StringCondition
    {
        Equal,
        NotEqual,
        IsBetween,
        IsGreaterThan,
        IsLessThan,
        IsGreaterThanOrEqualsTo,
        IsLessThanOrEqualsTo,
        Contains,
        DoesNotContain,
        StartsWith,
        EndsWith,
        IsNull,
        IsNotNull,
    }
    
    public partial class StringSearch : StringValue
    {
        public StringCondition Condition { get; set; }

		public string Value2 { get; set; }
	}
    public partial class StringReturn : StringValue
    {
    }
    public partial class StringSkip : StringValue
    {
    }

}
