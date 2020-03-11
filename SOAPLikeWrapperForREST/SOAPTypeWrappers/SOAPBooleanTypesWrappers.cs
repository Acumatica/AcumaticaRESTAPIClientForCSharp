using Acumatica.RESTClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAPLikeWrapperForREST
{
    public partial class BooleanReturn : BooleanValue
    {
    }

    public enum BooleanCondition
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
    public partial class BooleanSearch : BooleanValue
    {

        private BooleanCondition conditionField;

        private System.Nullable<bool> value2Field;

        public BooleanCondition Condition
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

        public System.Nullable<bool> Value2
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
