using Acumatica.RESTClient.Model;

namespace SOAPLikeWrapperForREST
{
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
        public IntSearch(int? value = null) : base(value)
        { }

        public IntCondition Condition { get; set; }

        public int? Value2 { get; set; }
    }
    public partial class IntReturn : IntValue
    {
    }
}
