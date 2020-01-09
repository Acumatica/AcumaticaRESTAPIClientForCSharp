using Acumatica.DefaultEndpoint_18_200_001.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForDeafultEndpoint_18_200_001
{
    public enum StringCondition
    {
        /// <remarks/>
        Equal,

        /// <remarks/>
        NotEqual,

        /// <remarks/>
        IsBetween,

        /// <remarks/>
        IsGreaterThan,

        /// <remarks/>
        IsLessThan,

        /// <remarks/>
        IsGreaterThanOrEqualsTo,

        /// <remarks/>
        IsLessThanOrEqualsTo,

        /// <remarks/>
        Contains,

        /// <remarks/>
        DoesNotContain,

        /// <remarks/>
        StartsWith,

        /// <remarks/>
        EndsWith,

        /// <remarks/>
        IsNull,

        /// <remarks/>
        IsNotNull,
    }
    public partial class StringSearch : StringValue
    {
        private StringCondition conditionField;

        private string value2Field;

        public StringCondition Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        public string Value2
        {
            get
            {
                return this.value2Field;
            }
            set
            {
                this.value2Field = value;
            }
        }
    }
    public partial class StringReturn : StringValue
    {
    }
    public partial class StringSkip : StringValue
    {
    }

}
