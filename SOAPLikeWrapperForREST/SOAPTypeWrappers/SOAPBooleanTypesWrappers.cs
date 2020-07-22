using Acumatica.RESTClient.Model;

namespace SOAPLikeWrapperForREST
{
    public partial class BooleanReturn : BooleanValue
    {
    }

    public enum BooleanCondition
    {
        Equal,
        NotEqual,
        IsNull,
        IsNotNull,
    }
    public partial class BooleanSearch : BooleanValue
    {
		public BooleanCondition Condition { get; set; }

		public bool? Value2 { get; set; }
	}

}
