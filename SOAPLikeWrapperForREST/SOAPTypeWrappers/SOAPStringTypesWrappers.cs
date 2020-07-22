using Acumatica.RESTClient.Model;

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
        public StringSearch(string value = null) : base(value)
        { }

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
