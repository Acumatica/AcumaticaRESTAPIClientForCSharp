using Acumatica.RESTClient.Model;

namespace SOAPLikeWrapperForREST
{
    public partial class LongReturn : LongValue
    {
    }
    public enum LongCondition
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

    public partial class LongSearch : LongValue
    {
        public LongCondition Condition { get; set; }

        public long? Value2 { get; set; }
    }
}
