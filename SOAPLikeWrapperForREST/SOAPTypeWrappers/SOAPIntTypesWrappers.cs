using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
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
}
