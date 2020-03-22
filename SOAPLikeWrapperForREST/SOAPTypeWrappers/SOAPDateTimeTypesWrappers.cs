using Acumatica.RESTClient.Model;
using System;

namespace SOAPLikeWrapperForREST
{
    public partial class DateTimeReturn : DateTimeValue
    {
    }
    public partial class DateTimeSearch : DateTimeValue
    {
		public DateTimeCondition Condition { get; set; }

		public DateTime? Value2 { get; set; }
	}

    public enum DateTimeCondition
    {
        Equal,
        NotEqual,
        IsBetween,
        IsGreaterThan,
        IsLessThan,
        IsGreaterThanOrEqualsTo,
        IsLessThanOrEqualsTo,
        Today,
        Overdue,
        Tomorrow,
        ThisWeek,
        ThisMonth,
        IsNull,
        IsNotNull,
    }

}
