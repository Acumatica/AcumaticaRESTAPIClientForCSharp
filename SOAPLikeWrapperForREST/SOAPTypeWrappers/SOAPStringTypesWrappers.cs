using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public enum GuidCondition
    {

        /// <remarks/>
        Equal,

        /// <remarks/>
        NotEqual,

        /// <remarks/>
        IsNull,

        /// <remarks/>
        IsNotNull,
    }
    public enum IntCondition
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
        IsNull,

        /// <remarks/>
        IsNotNull,
    }
    public enum DateTimeCondition
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
        Today,

        /// <remarks/>
        Overdue,

        /// <remarks/>
        Tomorrow,

        /// <remarks/>
        ThisWeek,

        /// <remarks/>
        ThisMonth,

        /// <remarks/>
        IsNull,

        /// <remarks/>
        IsNotNull,
    }
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
    public partial class GuidSearch : GuidValue
    {

        private GuidCondition conditionField;

        private System.Guid value2Field;

        public GuidCondition Condition
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

        public System.Guid Value2
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
    public partial class IntSearch : IntValue
    {

        private IntCondition conditionField;

        private System.Nullable<int> value2Field;


        public IntCondition Condition
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

        public System.Nullable<int> Value2
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
