using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public partial class IntReturn : IntValue
    {
    }

    public enum IntCondition
    {
        Equal,
        NotEqual,
        IsBetween,
        IsGreaterThan,
        IsLessThan,
        IsGreaterThanOrEqualsTo,
        IsLessThanOrEqualsTo,
        IsNull,
        IsNotNull,
    }

    public partial class IntSearch : IntValue
    {
        public IntCondition Condition { get; set; }

		public int? Value2 { get; set; }
	}
}
